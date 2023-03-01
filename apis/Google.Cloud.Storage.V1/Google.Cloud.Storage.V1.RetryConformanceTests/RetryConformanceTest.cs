// Copyright 2022 Google LLC
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     https://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Gax;
using Google.Apis.Storage.v1.Data;
using Google.Cloud.ClientTesting;
using Google.Cloud.Storage.V1.Tests.Conformance;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;
using Object = Google.Apis.Storage.v1.Data.Object;

namespace Google.Cloud.Storage.V1.RetryConformanceTests;

[Collection(nameof(RetryConformanceTestFixture))]
public class RetryConformanceTest
{
    private const string RetryIdHeader = "x-retry-test-id";
    public static TheoryData<RetryTest> RetryTestData { get; } = StorageConformanceTestData.TestData.GetTheoryData(f => f.RetryTests);

    private readonly RetryConformanceTestFixture _fixture;
    private readonly string retryIdPrefix = IdGenerator.FromGuid(prefix: "test-id-", suffix: "-", maxLength: 20);
    private readonly ITestOutputHelper _output;

    public RetryConformanceTest(RetryConformanceTestFixture fixture, ITestOutputHelper output)
    {
        _fixture = fixture;
        _output = output;
    }

    private StorageClient Client => _fixture.Client;


    /// <summary>
    /// Runs a single <see cref="RetryTest"/>,
    /// which itself can contain multiple instruction lists and methods.
    /// </summary>
    [SkippableTheory]
    [MemberData(nameof(RetryTestData))]
    public async Task RetryTest(RetryTest test)
    {
        Console.WriteLine("************************************************");
        Skip.IfNot(ShouldRunTest(test));

        foreach (InstructionList instructionList in test.Cases)
        {
            if (instructionList.Instructions.Contains("return-reset-connection"))
                continue;

            Console.WriteLine("#########################################################################");
            Console.WriteLine("Test ID: " + test.Id + "  with instruction: " + instructionList.Instructions.ToString());
            Console.WriteLine("#########################################################################");
            foreach (Method method in test.Methods)
            {
                if (ShouldRunMethod(method.Name))
                {
                    Console.WriteLine(method.Name + " is executing");
                    await RunTestCaseAsync(instructionList, method, test.ExpectSuccess, test.PreconditionProvided);
                    Console.WriteLine(method.Name + " is passed");
                }
            }
        }

        // bucket_acl, default_object_acl, object_acl functions do not exist in our handwritten library.
        // object.compose does not exist in our handwritten library and hence does not have retry implemented
        // object.insert is covered under resumable upload
        // objects.copy is not used directly but only as objects.rewrite which is a seperate test case
        bool ShouldRunMethod(string methodName) =>
            !methodName.Contains("_acl") && methodName != "storage.objects.compose" && methodName != "storage.objects.insert" && methodName != "storage.objects.copy";

        // Ids with description "handle_complex_retries" are to test resumable uploads and downloads
        // This section will be implemented in the next phase
        bool ShouldRunTest(RetryTest test) => !test.Description.Contains("handle_complex_retries");
    }

    /// <summary>
    /// Handle full flow of each individual test case from resource creation to running the testing, verify if it passed or failed and delete resource post usage.
    /// </summary>
    private async Task RunTestCaseAsync(InstructionList instructionList, Method method, bool expectSuccess, bool specifyPreconditions)
    {
        var context = CreateTestContext(method);
        var response = await CreateRetryTestResourceAsync(instructionList, method);

        try
        {
            if (expectSuccess)
            {
                RunRetryTest(response, context, method.Group, specifyPreconditions);
                var postTestResponse = await GetRetryTestAsync(response.Id);
                Assert.True(postTestResponse.Completed, "Expected retry test completed to be true, but was false.");
            }
            else
            {
                try
                {
                    RunRetryTest(response, context, method.Group, specifyPreconditions);

                    // storage.buckets.setIamPolicy has no preconditions implemented in .NET and hence will retry successfully
                    // Created an issue https://github.com/googleapis/google-cloud-dotnet/issues/9362 for this.
                    if (!method.Name.Contains("buckets.setIamPolicy"))
                    {
                        Assert.False(response.Completed);
                    }
                }
                catch (GoogleApiException ex) when (InstructionContainsErrorCode(ex.HttpStatusCode))
                {
                    // The instructions specified that the given status code would be returned.
                    // We just need to check that we weren't expecting this specific call to succeed.
                }                
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(method.Name + " threw EXCEPTION!! WHILE RUNNING TEST with MESSAGE: " + ex.Message + " INNER EXCEPTION: " + ex.InnerException);
        }
        finally
        {
            try
            {
                DeleteStorageResources(context);
                RemoveRetryIdHeader();
                await DeleteRetryTest(response.Id);
            }
            catch (Exception ex) // To catch and ignore exceptions occured, if any, while doing clean up of test.
            {
                Console.WriteLine(method.Name + " threw EXCEPTION!!  WHILE DELETING RESOURCES with MESSAGE: " + ex.Message + " INNER EXCEPTION: " + ex.InnerException );
            }
        }

        bool InstructionContainsErrorCode(HttpStatusCode statusCode)
        => instructionList.Instructions.Contains($"return-{(int) statusCode}");
    }

    /// <summary>
    /// Create individual test resource on the storage test bench for each of API to be tested.
    /// </summary>
    private async Task<TestResponse> CreateRetryTestResourceAsync(InstructionList instructionList, Method method)
    {
        var stringContent = GetBodyContent(method.Name, instructionList);
        Console.WriteLine("Creating the resource for method: " + method.Name + " for instructions: " + instructionList.Instructions.ToString() + " URI: " + _fixture.HttpClient.BaseAddress.ToString());
        HttpResponseMessage response = await _fixture.HttpClient.PostAsync("retry_test", stringContent);
        Console.WriteLine($"retry_test status: {response.StatusCode}");
        response.EnsureSuccessStatusCode();
        var responseMessage = await response.Content.ReadAsStringAsync();
        Console.WriteLine($"retry_test message: {responseMessage}");
        return JsonConvert.DeserializeObject<TestResponse>(responseMessage);
    }

    /// <summary>
    /// Add retry header for each request and make a call to retry and test each API.
    /// </summary>
    private void RunRetryTest(TestResponse response, TestContext context, string group, bool specifyPreconditions)
    {
        AddRetryIdHeader(response.Id);

        // For resumable uploads and downloads, pick the group name instead of method name 
        string rpc = (group == null || group == "") ? response.GetMethodName() : group;
        var result = ExecuteRpc(rpc, context, specifyPreconditions);

        // For list methods, we need to fetch a page in order to actually perform requests.
        // Dont need to do this for notifications as those are getting consumed immidiately
        if (rpc.Contains("list") && !rpc.Contains("notification"))
        {
            ConsumeListOutput((dynamic) result);
        }
    }

    // Note: not a local function as that cannot handle dynamic binding with generics.
    private static void ConsumeListOutput<TRequest, TResource>(PagedEnumerable<TRequest, TResource> pagedEnumerable) =>
        pagedEnumerable.ReadPage(10000);

    private object ExecuteRpc(string rpc, TestContext ctx, bool specifyPreconditions)
    {
        var client = _fixture.Client;
        return rpc switch
        {
            "storage.buckets.delete" => InvokeVoid(() => client.DeleteBucket(ctx.BucketName)),
            "storage.buckets.get" => client.GetBucket(ctx.BucketName),
            "storage.buckets.getIamPolicy" => client.GetBucketIamPolicy(ctx.BucketName),
            "storage.buckets.insert" => client.CreateBucket(ctx.ProjectId, IdGenerator.FromDateTime(prefix: retryIdPrefix + "insert-bucket-")),
            "storage.buckets.update" => client.UpdateBucket(new Bucket { Name = ctx.BucketName }, IfPreconditions(new UpdateBucketOptions { IfMetagenerationMatch = 1 })),
            "storage.buckets.list" => client.ListBuckets(ctx.ProjectId),
            "storage.buckets.testIamPermissions" => client.TestBucketIamPermissions(ctx.BucketName, new[] { "bucket.get" }),
            "storage.buckets.lockRetentionPolicy" => InvokeVoid(() => client.LockBucketRetentionPolicy(ctx.BucketName, 1L)),
            "storage.buckets.patch" => client.PatchBucket(new Bucket { Name = ctx.BucketName }, IfPreconditions(new PatchBucketOptions { IfMetagenerationMatch = 1 })),
            "storage.buckets.setIamPolicy" => client.SetBucketIamPolicy(ctx.BucketName, GetIamPolicyAndAddPublicViewer()),
            "storage.objects.get" => client.GetObject(ctx.BucketName, ctx.ObjectName),
            "storage.objects.list" => client.ListObjects(ctx.BucketName),
            "storage.objects.delete" => InvokeVoid(() => client.DeleteObject(ctx.BucketName, ctx.ObjectName, IfPreconditions(new DeleteObjectOptions { IfGenerationMatch = ctx.ObjectGeneration }))),
            "storage.objects.patch" => client.PatchObject(new Object { Name = ctx.ObjectName, Bucket = ctx.BucketName }, IfPreconditions(new PatchObjectOptions { IfMetagenerationMatch = 1 })),
            "storage.objects.rewrite" => client.CopyObject(ctx.BucketName, ctx.ObjectName, ctx.DestinationBucketName, ctx.DestinationObjectName, IfPreconditions(new CopyObjectOptions { IfGenerationMatch = ctx.ObjectGeneration })),
            "storage.objects.update" => client.UpdateObject(new Object { Name = ctx.ObjectName, Bucket = ctx.BucketName }, IfPreconditions(new UpdateObjectOptions { IfMetagenerationMatch = 1 })),
            "storage.hmacKey.get" => client.GetHmacKey(ctx.ProjectId, ctx.HmacAccessId),
            "storage.hmacKey.delete" => InvokeVoid(() => client.DeleteHmacKey(ctx.ProjectId, ctx.HmacAccessId)),
            "storage.hmacKey.list" => client.ListHmacKeys(ctx.ProjectId, ctx.ServiceAccountEmail),
            "storage.hmacKey.update" => client.UpdateHmacKey(new HmacKeyMetadata
            {
                ProjectId = ctx.ProjectId,
                AccessId = ctx.HmacAccessId,
                State = HmacKeyStates.Inactive,
                ETag = specifyPreconditions ? "MQ==" : null
            }),
            "storage.hmacKey.create" => client.CreateHmacKey(ctx.ProjectId, ctx.ServiceAccountEmail),
            "storage.notifications.list" => client.ListNotifications(ctx.BucketName),
            "storage.notifications.get" => client.GetNotification(ctx.BucketName, ctx.NotificationId),
            "storage.notifications.delete" => InvokeVoid(() => client.DeleteNotification(ctx.BucketName, ctx.NotificationId)),
            "storage.notifications.insert" => client.CreateNotification(ctx.BucketName, new Notification { Topic = "Test-topic", PayloadFormat = "NONE" }),
            "storage.serviceaccount.get" => client.GetStorageServiceAccountEmail(ctx.ProjectId),
            "storage.resumable.upload" => client.UploadObject(new Object { Name = ctx.ObjectName, Bucket = ctx.BucketName }, File.OpenRead(_fixture.SampleObjectContentPath)),
            "storage.objects.download" => client.DownloadObject(ctx.BucketName, ctx.ObjectName, new MemoryStream()),
            _ => throw new ArgumentException($"Unknown RPC: {rpc}")
        };

        // Workaround for the switch expression not being able to just call void methods - we need to return something.
        object InvokeVoid(Action action)
        {
            action();
            return null;
        }

        T IfPreconditions<T>(T value) where T : class =>
            specifyPreconditions ? value : null;

        Policy GetIamPolicyAndAddPublicViewer()
        {
            var policy = client.GetBucketIamPolicy(ctx.BucketName);
            Policy.BindingsData AllUsersViewer = new Policy.BindingsData
            {
                Members = new[] { "allUsers" },
                Role = "roles/storage.objectViewer"
            };
            policy.Bindings.Add(AllUsersViewer);
            policy.ETag = specifyPreconditions ? policy.ETag ?? "MQ==" : null;
            return policy;
        }
    }

    /// <summary>
    /// Checks if the retry resource has been created successfully.
    /// </summary>
    private async Task<TestResponse> GetRetryTestAsync(string id)
    {
        HttpResponseMessage response = await _fixture.HttpClient.GetAsync($"retry_test/{id}");
        response.EnsureSuccessStatusCode();
        var responseMessage = await response.Content.ReadAsStringAsync();
        return JsonConvert.DeserializeObject<TestResponse>(responseMessage);
    }

    /// <summary>
    /// Create the basic storage resources on storage test bench to enable running of the test cases
    /// </summary>
    private TestContext CreateTestContext(Method method)
    {
        var context = new TestContext(_fixture.ProjectId, _fixture.ServiceAccountEmail);
        string bucketName = IdGenerator.FromDateTime(prefix: retryIdPrefix + "bucket-");
        string objectName = retryIdPrefix + "TestFile.json";
        foreach (var resource in method.Resources)
        {
            switch (resource)
            {
                case Resource.Bucket:
                    context.BucketName = CreateBucket(bucketName);
                    break;
                case Resource.Object:
                    (context.ObjectName, context.ObjectGeneration) = CreateObject(bucketName, objectName);
                    break;
                case Resource.HmacKey:
                    (context.HmacSecret, context.HmacAccessId) = CreateHmacKey(deactivate: method.Name == "storage.hmacKey.delete");
                    break;
                case Resource.Notification:
                    context.NotificationId = CreateNotification(bucketName);
                    break;
            }
        }
        // Handling for 'storage.buckets.insert' because library's CreateBucket requires bucket's name as mandatory parameter,
        // but retry_tests.json doesn't specify it as required resource in test ID 1 & 6

        if (method.Name == "storage.buckets.insert" && method.Resources.Count == 0)
        {
            context.BucketName = CreateBucket(bucketName);
        }

        // For copying objects, need to create destination bucket and object as well
        if (method.Name == "storage.objects.rewrite")
        {
            string destBucketName = IdGenerator.FromDateTime(prefix: retryIdPrefix + "dest-bucket-");
            context.DestinationBucketName = CreateBucket(destBucketName);
            (context.DestinationObjectName, context.ObjectGeneration) = CreateObject(destBucketName, retryIdPrefix + "DestinationTestFile.json");
        }
        return context;

        // Local methods used to perform the actual resource creation.
        string CreateBucket(string bucketName)
        {
            Client.CreateBucket(_fixture.ProjectId, new Bucket { Name = bucketName });
            _fixture.SleepAfterBucketCreateDelete();
            return bucketName;
        }

        (string secret, string accessId) CreateHmacKey(bool deactivate)
        {
            var serviceAccountEmail = Client.GetStorageServiceAccountEmail(_fixture.ProjectId);
            var hmacKey = Client.CreateHmacKey(_fixture.ProjectId, serviceAccountEmail);

            // If we are testing hmacKey.delete functionality then we have to
            // also deactivate the hmacKey for deletion to be successful.
            if (deactivate)
            {
                hmacKey.Metadata.State = HmacKeyStates.Inactive;
                Client.UpdateHmacKey(hmacKey.Metadata);
            }
            return (hmacKey.Secret, hmacKey.Metadata.AccessId);
        }

        string CreateNotification(string bucketName)
        {
            var notificationConfig = new Notification { Topic = _fixture.TestTopic, PayloadFormat = "NONE" };
            var notification = Client.CreateNotification(bucketName, notificationConfig);
            return notification.Id;
        }

        (string name, long generation) CreateObject(string bucketName, string objectName)
        {
            using var stream = File.OpenRead(_fixture.SampleObjectContentPath);
            var objectCreated = Client.UploadObject(bucketName, objectName, "application/json", stream);
            return (objectCreated.Name, objectCreated.Generation.Value);
        }
    }

    /// <summary>
    /// Create header specific to this request. Remove all previous headers
    /// </summary>
    private void AddHeader(string header, string value)
    {
        bool contains = Client.Service.HttpClient.DefaultRequestHeaders.Contains(header);
        if (contains)
        {
            Client.Service.HttpClient.DefaultRequestHeaders.Remove(header);
        }

        Client.Service.HttpClient.DefaultRequestHeaders.TryAddWithoutValidation(header, value);
    }

    /// <summary>
    /// Create the payload header to be sent for running test cases
    /// </summary>
    private void AddRetryIdHeader(string id) => AddHeader(RetryIdHeader, id);

    /// <summary>
    /// Create the payload body to be sent for running test cases
    /// </summary>
    private static StringContent GetBodyContent(string methodName, InstructionList instructionList)
    {
        if (string.IsNullOrWhiteSpace(methodName) || instructionList == null)
        {
            return null;
        }

        var body = new JObject
        {
            ["instructions"] = new JObject { [methodName] = new JArray(instructionList.Instructions) }
        };

        return new StringContent(body.ToString(), Encoding.UTF8, "application/json");
    }

    /// <summary>
    /// Clears test resource once the test case is complete
    /// </summary>
    private async Task DeleteRetryTest(string id)
    {
        if (!string.IsNullOrWhiteSpace(id))
        {
            HttpResponseMessage response = await _fixture.HttpClient.DeleteAsync($"retry_test/{id}");
            response.EnsureSuccessStatusCode();
        }
    }

    /// <summary>
    /// Cleans up any storage resources created for the retry test.
    /// </summary>
    private void DeleteStorageResources(TestContext context)
    {
        if (context.NotificationId is string notificationId)
        {
            Client.DeleteNotification(context.BucketName, notificationId);
        }
        if (context.HmacSecret is string)
        {
            var hmacKeyMetadata = Client.GetHmacKey(context.ProjectId, context.HmacAccessId);
            hmacKeyMetadata.State = HmacKeyStates.Inactive;
            Client.UpdateHmacKey(hmacKeyMetadata);
            Client.DeleteHmacKey(context.ProjectId, context.HmacAccessId);
        }
        MaybeDeleteBucket(context.BucketName);
        MaybeDeleteBucket(context.DestinationBucketName);

        void MaybeDeleteBucket(string bucketName)
        {
            if (bucketName is null)
            {
                return;
            }
            try
            {
                Client.DeleteBucket(bucketName, new DeleteBucketOptions { UserProject = null, DeleteObjects = true });
            }
            catch (GoogleApiException)
            {
                // Some tests fail to delete buckets due to object retention locks etc. They can be cleaned up later.
            }
            _fixture.SleepAfterBucketCreateDelete();
        }
    }

    /// <summary>
    /// Removes the existing payload header. Should be called once retry test with added header is completed.
    /// </summary>
    private void RemoveRetryIdHeader()
    {
        if (Client.Service.HttpClient.DefaultRequestHeaders.Contains(RetryIdHeader))
        {
            Client.Service.HttpClient.DefaultRequestHeaders.Remove(RetryIdHeader);
        }
    }
}

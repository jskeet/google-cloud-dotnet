// Copyright 2023 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License").
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at 
//
// https://www.apache.org/licenses/LICENSE-2.0 
//
// Unless required by applicable law or agreed to in writing, software 
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and 
// limitations under the License.

using Google.Api.Gax.ResourceNames;
using Google.Cloud.ClientTesting;
using System.Collections.Generic;
using System.Threading;
using Xunit;

namespace Google.Cloud.Storage.V2.IntegrationTests;

[CollectionDefinition(nameof(StorageFixture))]
public class StorageFixture : CloudProjectFixtureBase, ICollectionFixture<StorageFixture>
{
    private readonly List<string> _bucketsToDelete = new List<string>();

    public string BucketPrefix { get; }
    public StorageClient Client { get; }

    public StorageFixture()
    {
        Client = StorageClient.Create();
        //BucketPrefix = IdGenerator.FromDateTime(prefix: "test-jonskeet-integration-tests-", suffix: "-");
        BucketPrefix = IdGenerator.FromDateTime(prefix: "gcs-grpc-team-jonskeet-", suffix: "-");
    }

    internal string GenerateBucketName() => IdGenerator.FromGuid(prefix: BucketPrefix, separator: "", maxLength: 63);

    internal Bucket CreateBucket(string name)
    {
        var bucket = Client.CreateBucket(new ProjectName(ProjectId), new Bucket(), name);
        SleepAfterBucketCreateDelete();
        RegisterBucketToDelete(name);
        return bucket;
    }

    internal void RegisterBucketToDelete(string bucket) => _bucketsToDelete.Add(bucket);

    /// <summary>
    /// Bucket creation/deletion is rate-limited. To avoid making the tests flaky, we sleep after each operation.
    /// </summary>
    internal static void SleepAfterBucketCreateDelete() => Thread.Sleep(2000);

    public override void Dispose()
    {
        var client = StorageClient.Create();
        foreach (var bucket in _bucketsToDelete)
        {
            DeleteBucket(client, bucket);
        }
    }

    private void DeleteBucket(StorageClient client, string bucket)
    {
        try
        {
            var bucketName = new BucketName(ProjectId, bucket);
            foreach (var obj in client.ListObjects(bucketName))
            {
                client.DeleteObject(bucketName.ToString(), obj.Name);
            }
            client.DeleteBucket(bucketName);
        }
        catch (GoogleApiException)
        {
            // Some tests fail to delete buckets due to object retention locks etc.
            // They can be cleaned up later.
        }
        SleepAfterBucketCreateDelete();
    }
}

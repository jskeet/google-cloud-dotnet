// Copyright 2022 Google LLC
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

using Google.Api;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Logging;
using Google.Cloud.Storage.V1.Tests.Conformance;
using System;
using System.IO;
using System.Net.Http;
using System.Threading;
using Xunit;
using static Google.Apis.Http.ConfigurableMessageHandler;

namespace Google.Cloud.Storage.V1.RetryConformanceTests;

[CollectionDefinition(nameof(RetryConformanceTestFixture))]
public class RetryConformanceTestFixture : ICollectionFixture<RetryConformanceTestFixture>
{
    internal StorageClient Client { get; }
    internal string ServiceAccountEmail { get; }
    internal string TestTopic { get; } = GetEnvironmentVariableOrDefault("TOPIC", "test-topic");
    internal string SampleObjectContentPath => Path.Combine(StorageConformanceTestData.TestData.DataPath, "test_service_account.not-a-test.json");
    internal string ProjectId { get; } = "test";
    internal HttpClient HttpClient { get; }
    internal static string TestBenchUrl { get; } = GetEnvironmentVariableOrDefault("TEST_BENCH_URL", "http://localhost:9000/");

    public RetryConformanceTestFixture()
    {
        ApplicationContext.RegisterLogger(new ConsoleLogger(LogLevel.All));
        var clientBuilder = new StorageClientBuilder
        {
            BaseUri = TestBenchUrl + "storage/v1/",
            GZipEnabled = false,
            GoogleCredential = GoogleCredential.FromAccessToken("not--a-token")
        };
        HttpClient = new HttpClient
        {
            BaseAddress = new Uri(TestBenchUrl),
            DefaultRequestHeaders = { ConnectionClose = true }
        };

        Client = clientBuilder.Build();
        Client.Service.HttpClient.DefaultRequestHeaders.ConnectionClose = true;
        
        //Client.Service.HttpClient.MessageHandler.LogEvents =
        //    LogEventType.RequestHeaders | LogEventType.RequestUri | LogEventType.RequestBody | LogEventType.ResponseBody;
        ServiceAccountEmail = Client.GetStorageServiceAccountEmail(ProjectId);
    }

    /// <summary>
    /// Function created to be used for getting environment variables
    /// </summary>
    private static string GetEnvironmentVariableOrDefault(string name, string defaultValue)
    {
        string value = Environment.GetEnvironmentVariable(name);
        return string.IsNullOrEmpty(value) ? defaultValue : value;
    }

    public void SleepAfterBucketCreateDelete() => Thread.Sleep(2000);
}

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

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Api.Gax.ResourceNames;
using Google.Apis.Auth.OAuth2;
using Google.Cloud.Storage.V1;
using Google.Cloud.Storage.V2;
using Google.Cloud.Storage.V2.Workload1;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Globalization;
using StorageClientBuilder = Google.Cloud.Storage.V2.StorageClientBuilder;
using V1Client = Google.Cloud.Storage.V1.StorageClient;

var startTime = DateTime.UtcNow;
var startString = startTime.ToString("yyyyMMdd'T'HHmmss", CultureInfo.InvariantCulture);
var random = new Random();

if (args.Length != 2)
{
    Console.WriteLine("Expected argument: <configuration-file> <client-type>");
    return 1;
}

string clientType = args[1];

var projectName = GoogleCredential.GetApplicationDefault().UnderlyingCredential switch
{
    ServiceAccountCredential serviceAccount => new ProjectName(serviceAccount.ProjectId),
    ComputeCredential x => new ProjectName(Platform.Instance().ProjectId),
    _ => throw new InvalidOperationException("Can't determine the project")
};

var configJson = File.ReadAllText(args[0]);
var configuration = JsonConvert.DeserializeObject<Configuration>(configJson);
var samples = configuration.GetSamples();

var settings = new StorageSettings
{
    WriteObjectSettings = CallSettings.FromExpiration(Expiration.FromTimeout(TimeSpan.FromMinutes(30))),
    ReadObjectSettings = CallSettings.FromExpiration(Expiration.FromTimeout(TimeSpan.FromMinutes(30)))
};
var client = new StorageClientBuilder { Settings = settings }.Build();
var v1Client = V1Client.Create();

var bucketName = await CreateBucket();
Log($"Created bucket: {bucketName}");

Func<string, Stream, Task> uploader = clientType switch
{
    "V1" => (objName, stream) => v1Client.UploadObjectAsync(bucketName.BucketId, objName, null, stream, new UploadObjectOptions { UploadValidationMode = UploadValidationMode.None }),
    "V2" => (objName, stream) => new StorageUploader(client).UploadObject(bucketName, objName, stream),
    _ => throw new ArgumentException($"Client type '{clientType} unknown")
};
Func<string, Task> downloader = clientType switch
{
    "V1" => objName => v1Client.DownloadObjectAsync(bucketName.BucketId, objName, new NullStream(), new DownloadObjectOptions { DownloadValidationMode = DownloadValidationMode.Never }),
    "V2" => objName => new StorageDownloader(client).DownloadAsync(bucketName, objName, new NullStream()),
    _ => throw new ArgumentException($"Client type '{clientType} unknown")
};

string resultFile = $"{configuration.ResultsPrefix}-{startString}-{clientType}.csv";
using (var resultWriter = File.CreateText(resultFile))
{
    await resultWriter.WriteLineAsync($"{args[0]},{bucketName},{clientType}");

    int runNumber = 0;
    while (DateTime.UtcNow < startTime.AddMinutes(configuration.DurationMinutes))
    {
        Log($"Starting run {++runNumber}");
        await RunTest();
    }
    Log($"Finished after {runNumber} runs");

    async Task RunTest()
    {
        foreach (var sample in samples)
        {
            for (int i = 0; i < sample.Iterations; i++)
            {
                var (upload, download) = await RunIteration(sample.Size);
                await resultWriter.WriteLineAsync($"{DateTime.UtcNow:yyyy-MM-dd'T'HH:mm:ss.fff},{sample.Description},{upload},{download}");
            }
        }
    }
}
// Upload the results file to the bucket.
using (var resultReader = File.OpenRead(resultFile))
{
    await v1Client.UploadObjectAsync(configuration.ResultBucket, $"results-{startString}-{clientType}.csv", "text/csv", resultReader);
}

return 0;

void Log(string message) =>
    Console.WriteLine($"{DateTime.UtcNow:HH:mm:ss}: {message}");

async Task<(long, long)> RunIteration(long size)
{
    var objectName = Guid.NewGuid().ToString();
    var bytes = new byte[size];
    random.NextBytes(bytes);

    var stopwatch = Stopwatch.StartNew();
    await uploader(objectName, new MemoryStream(bytes));
    stopwatch.Stop();
    long uploadMillis = stopwatch.ElapsedMilliseconds;

    stopwatch.Restart();
    await downloader(objectName);
    stopwatch.Stop();
    long downloadMillis = stopwatch.ElapsedMilliseconds;

    return (uploadMillis, downloadMillis);
}

async Task<BucketName> CreateBucket()
{
    var globalProjectName = new ProjectName("_");
    string bucketId = $"{configuration.BucketPrefix}-{startString}".ToLowerInvariant();
    var bucket = new Bucket
    {
        ProjectAsProjectName = projectName,
        Location = configuration.Location
    };
    bucket = await client.CreateBucketAsync(globalProjectName, bucket, bucketId);
    return bucket.BucketName;
}

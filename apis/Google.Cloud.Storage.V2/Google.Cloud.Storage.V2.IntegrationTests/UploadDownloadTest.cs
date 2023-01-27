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

using Google.Api.Gax.Grpc;
using Google.Cloud.ClientTesting;
using Google.Protobuf;
using System;
using System.IO;
using System.Threading.Tasks;
using Xunit;

namespace Google.Cloud.Storage.V2.IntegrationTests;

[Collection(nameof(StorageFixture))]
public class UploadDownloadTest 
{
    private readonly StorageFixture _fixture;

    public UploadDownloadTest(StorageFixture fixture) => _fixture = fixture;

    [Fact]
    public async Task UploadDownload()
    {
        // Disable retries for streaming calls.
        var settings = StorageSettings.GetDefault();
        var client = new StorageClientBuilder
        {
            Settings = new StorageSettings
            {
                WriteObjectSettings = settings.WriteObjectSettings.WithRetry(null),
                ReadObjectSettings = settings.ReadObjectSettings.WithRetry(null),
            }
        }.Build();

        var bucketId = _fixture.GenerateBucketName();
        _fixture.CreateBucket(bucketId);

        string objectName = IdGenerator.FromGuid();
        var fullBucketName = new BucketName(_fixture.ProjectId, bucketId);

        var data = new byte[100_000];
        new Random().NextBytes(data);

        await UploadObject();
        await DownloadObject();

        async Task UploadObject()
        {
            var request = new WriteObjectRequest
            {
                WriteObjectSpec = new WriteObjectSpec
                {
                    Resource = new Object
                    {
                        BucketAsBucketName = fullBucketName,
                        Name = objectName
                    }
                },
                ChecksummedData = new ChecksummedData { Content = ByteString.CopyFrom(data) },
                FinishWrite = true
            };

            var stream = client.WriteObject();
            await stream.WriteAsync(request);
            await stream.WriteCompleteAsync();

            var response = await stream.ResponseAsync;
            var writtenResource = response.Resource;
            Assert.Equal(objectName, writtenResource.Name);

            // We don't get the project ID back in the bucket name for the written object.
            var expectedReturnedBucketName = new BucketName("_", bucketId);
            Assert.Equal(expectedReturnedBucketName, writtenResource.BucketAsBucketName);
        }

        async Task DownloadObject()
        {
            var localStream = new MemoryStream();
            var request = new ReadObjectRequest { Bucket = fullBucketName.ToString(), Object = objectName };
            var readStream = client.ReadObject(request);

            await foreach (var response in readStream.GetResponseStream())
            {
                response.ChecksummedData.Content.WriteTo(localStream);
            }

            Assert.Equal(localStream.ToArray(), data);
        }
    }
}

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
using Google.Apis.Upload;
using Google.Protobuf;
using System;
using System.IO;
using System.Threading.Tasks;

namespace Google.Cloud.Storage.V2;

/// <summary>
/// Helper class to manage uploads. Eventually we'd probably use a partial class to put
/// this code directly in StorageClient, but that can come later after a lot of design work.
/// The use of IProgress{T} is only for the sake of performance testing.
/// </summary>
public class StorageUploader
{
    private const int ChunkSize = 1 << 21;
    private readonly StorageClient _client;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="client"></param>
    public StorageUploader(StorageClient client)
    {
        this._client = client;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="bucket"></param>
    /// <param name="objectName"></param>
    /// <param name="stream"></param>
    /// <param name="progressReporter"></param>
    /// <returns></returns>
    public async Task<Object> UploadObject(BucketName bucket, string objectName, Stream stream, IProgress<IUploadProgress> progressReporter = null)
    {
        var headerCallSettings = CallSettings.FromHeader("x-goog-request-params", $"bucket={Uri.EscapeDataString(bucket.ToString())}");
        using var requestStream = _client.WriteObject(headerCallSettings);

        // TODO: Ouch!
        byte[] buffer = new byte[ChunkSize];

        progressReporter?.Report(new ResumableUploadProgress(UploadStatus.Starting, 0));

        long bytesWritten = 0;
        bool firstRequest = true;
        bool finished = false;
        while (!finished)
        {
            int bytesRead = await FillBufferAsync().ConfigureAwait(false);
            // TODO: This ends up with an unnecessary request at the end, if we've read precisely as far as the
            // buffer. The simplicity is appealing though.
            finished = bytesRead != ChunkSize;
            var request = new WriteObjectRequest
            {
                ChecksummedData = new ChecksummedData { Content = ByteString.CopyFrom(buffer, 0, bytesRead) },
                FinishWrite = finished,
                WriteOffset = bytesWritten
            };
            if (firstRequest)
            {
                request.WriteObjectSpec = new WriteObjectSpec
                {
                    Resource = new Object
                    {
                        BucketAsBucketName = bucket,
                        Name = objectName
                    }
                };
                firstRequest = false;
            }
            await requestStream.WriteAsync(request).ConfigureAwait(false);
            bytesWritten += bytesRead;
            progressReporter?.Report(new ResumableUploadProgress(UploadStatus.Uploading, bytesWritten));
        }

        await requestStream.WriteCompleteAsync().ConfigureAwait(false);
        progressReporter?.Report(new ResumableUploadProgress(UploadStatus.Completed, bytesWritten));

        var response = await requestStream.ResponseAsync.ConfigureAwait(false);
        return response.Resource;

        async Task<int> FillBufferAsync()
        {
            int position = 0;
            while (position < buffer.Length)
            {
                int bytesRead = await stream.ReadAsync(buffer, position, buffer.Length - position).ConfigureAwait(false);
                if (bytesRead == 0)
                {
                    break;
                }
                position += bytesRead;
            }
            return position;
        }
    }
}

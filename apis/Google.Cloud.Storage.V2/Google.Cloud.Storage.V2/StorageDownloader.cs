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

using Google.Apis.Download;
using Google.Apis.Upload;
using Google.Type;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Google.Cloud.Storage.V2;

/// <summary>
/// Helper class to manage downloads. Eventually we'd probably use a partial class to put
/// this code directly in StorageClient, but that can come later after a lot of design work.
/// The use of IProgress{T} is only for the sake of performance testing.
/// </summary>
public class StorageDownloader
{
    private readonly StorageClient _client;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="client"></param>
    public StorageDownloader(StorageClient client)
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
    public async Task DownloadAsync(BucketName bucket, string objectName, Stream stream, IProgress<IDownloadProgress> progressReporter = null)
    {
        var request = new ReadObjectRequest { BucketAsBucketName = bucket, Object = objectName };
        using var readStream = _client.ReadObject(request);
        long bytesReceived = 0;

        IAsyncEnumerable<ReadObjectResponse> responseStream = readStream.GetResponseStream();
        await foreach (var response in responseStream.ConfigureAwait(false))
        {
            bytesReceived += response.ChecksummedData.Content.Length;
            // TODO: See if we can add a ByteString.WriteAsync(Stream) method to avoid the copying
            // in .NET 4.6.2.
#if NETSTANDARD2_1_OR_GREATER
            await stream.WriteAsync(response.ChecksummedData.Content.Memory).ConfigureAwait(false);
#else
            byte[] bytes = response.ChecksummedData.Content.ToByteArray();
            await stream.WriteAsync(bytes, 0, bytes.Length).ConfigureAwait(false);
#endif
            progressReporter?.Report(new DownloadProgress(DownloadStatus.Downloading, bytesReceived));
        }
        progressReporter?.Report(new DownloadProgress(DownloadStatus.Completed, bytesReceived));
    }
}

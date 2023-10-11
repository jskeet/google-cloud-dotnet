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
using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Text;

namespace Google.Cloud.Storage.V2;

internal class ResumableUploadProgress : IUploadProgress
{
    /// <summary>
    /// Create a ResumableUploadProgress instance.
    /// </summary>
    /// <param name="status">The status of the upload.</param>
    /// <param name="bytesSent">The number of bytes sent so far.</param>
    public ResumableUploadProgress(UploadStatus status, long bytesSent)
    {
        Status = status;
        BytesSent = bytesSent;
    }

    /// <summary>
    /// Create a ResumableUploadProgress instance.
    /// </summary>
    /// <param name="exception">An exception that occurred during the upload.</param>
    /// <param name="bytesSent">The number of bytes sent before this exception occurred.</param>
    public ResumableUploadProgress(Exception exception, long bytesSent)
    {
        Status = UploadStatus.Failed;
        BytesSent = bytesSent;
        Exception = exception;
        ExceptionDispatchInfo = ExceptionDispatchInfo.Capture(exception);
    }

    public UploadStatus Status { get; }
    public long BytesSent { get; }
    public Exception Exception { get; }

    /// <summary>
    /// The original dispatch information for <see cref="Exception"/>. This is null
    /// if and only if <see cref="Exception"/> is null.
    /// </summary>
    public ExceptionDispatchInfo ExceptionDispatchInfo { get; }
}

internal class DownloadProgress : IDownloadProgress
{
    /// <summary>Constructs a new progress instance.</summary>
    /// <param name="status">The status of the download.</param>
    /// <param name="bytes">The number of bytes received so far.</param>
    public DownloadProgress(DownloadStatus status, long bytes)
    {
        Status = status;
        BytesDownloaded = bytes;
    }

    /// <summary>Constructs a new progress instance.</summary>
    /// <param name="exception">An exception which occurred during the download.</param>
    /// <param name="bytes">The number of bytes received before the exception occurred.</param>
    public DownloadProgress(Exception exception, long bytes)
    {
        Status = DownloadStatus.Failed;
        BytesDownloaded = bytes;
        Exception = exception;
        ExceptionDispatchInfo = ExceptionDispatchInfo.Capture(exception);
    }

    /// <summary>Gets or sets the status of the download.</summary>
    public DownloadStatus Status { get; private set; }

    /// <summary>Gets or sets the amount of bytes that have been downloaded so far.</summary>
    public long BytesDownloaded { get; private set; }

    /// <summary>Gets or sets the exception which occurred during the download or <c>null</c>.</summary>
    public Exception Exception { get; private set; }

    /// <summary>
    /// The original dispatch information for <see cref="Exception"/>. This is null
    /// if and only if <see cref="Exception"/> is null.
    /// </summary>
    public ExceptionDispatchInfo ExceptionDispatchInfo { get; }
}

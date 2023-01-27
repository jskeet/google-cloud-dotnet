// Copyright 2023 Google LLC
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

// Generated code. DO NOT EDIT!

#pragma warning disable CS8981
using gax = Google.Api.Gax;
using gagr = Google.Api.Gax.ResourceNames;
using gcsv = Google.Cloud.Storage.V2;
using sys = System;

namespace Google.Cloud.Storage.V2
{
    /// <summary>Resource name for the <c>Bucket</c> resource.</summary>
    public sealed partial class BucketName : gax::IResourceName, sys::IEquatable<BucketName>
    {
        /// <summary>The possible contents of <see cref="BucketName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/buckets/{bucket}</c>.</summary>
            ProjectBucket = 1,
        }

        private static gax::PathTemplate s_projectBucket = new gax::PathTemplate("projects/{project}/buckets/{bucket}");

        /// <summary>Creates a <see cref="BucketName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="BucketName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static BucketName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new BucketName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="BucketName"/> with the pattern <c>projects/{project}/buckets/{bucket}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="BucketName"/> constructed from the provided ids.</returns>
        public static BucketName FromProjectBucket(string projectId, string bucketId) =>
            new BucketName(ResourceNameType.ProjectBucket, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), bucketId: gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BucketName"/> with pattern
        /// <c>projects/{project}/buckets/{bucket}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BucketName"/> with pattern
        /// <c>projects/{project}/buckets/{bucket}</c>.
        /// </returns>
        public static string Format(string projectId, string bucketId) => FormatProjectBucket(projectId, bucketId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BucketName"/> with pattern
        /// <c>projects/{project}/buckets/{bucket}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BucketName"/> with pattern
        /// <c>projects/{project}/buckets/{bucket}</c>.
        /// </returns>
        public static string FormatProjectBucket(string projectId, string bucketId) =>
            s_projectBucket.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)));

        /// <summary>Parses the given resource name string into a new <see cref="BucketName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/buckets/{bucket}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="bucketName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="BucketName"/> if successful.</returns>
        public static BucketName Parse(string bucketName) => Parse(bucketName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="BucketName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/buckets/{bucket}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="bucketName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="BucketName"/> if successful.</returns>
        public static BucketName Parse(string bucketName, bool allowUnparsed) =>
            TryParse(bucketName, allowUnparsed, out BucketName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BucketName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/buckets/{bucket}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="bucketName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BucketName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string bucketName, out BucketName result) => TryParse(bucketName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BucketName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/buckets/{bucket}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="bucketName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BucketName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string bucketName, bool allowUnparsed, out BucketName result)
        {
            gax::GaxPreconditions.CheckNotNull(bucketName, nameof(bucketName));
            gax::TemplatedResourceName resourceName;
            if (s_projectBucket.TryParseName(bucketName, out resourceName))
            {
                result = FromProjectBucket(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(bucketName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private BucketName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string bucketId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            BucketId = bucketId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="BucketName"/> class from the component parts of pattern
        /// <c>projects/{project}/buckets/{bucket}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        public BucketName(string projectId, string bucketId) : this(ResourceNameType.ProjectBucket, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), bucketId: gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)))
        {
        }

        /// <summary>The <see cref="ResourceNameType"/> of the contained resource name.</summary>
        public ResourceNameType Type { get; }

        /// <summary>
        /// The contained <see cref="gax::UnparsedResourceName"/>. Only non-<c>null</c> if this instance contains an
        /// unparsed resource name.
        /// </summary>
        public gax::UnparsedResourceName UnparsedResource { get; }

        /// <summary>
        /// The <c>Bucket</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string BucketId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectBucket: return s_projectBucket.Expand(ProjectId, BucketId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as BucketName);

        /// <inheritdoc/>
        public bool Equals(BucketName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(BucketName a, BucketName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(BucketName a, BucketName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Notification</c> resource.</summary>
    public sealed partial class NotificationName : gax::IResourceName, sys::IEquatable<NotificationName>
    {
        /// <summary>The possible contents of <see cref="NotificationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/buckets/{bucket}/notificationConfigs/{notification}</c>
            /// .
            /// </summary>
            ProjectBucketNotification = 1,
        }

        private static gax::PathTemplate s_projectBucketNotification = new gax::PathTemplate("projects/{project}/buckets/{bucket}/notificationConfigs/{notification}");

        /// <summary>Creates a <see cref="NotificationName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="NotificationName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static NotificationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new NotificationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="NotificationName"/> with the pattern
        /// <c>projects/{project}/buckets/{bucket}/notificationConfigs/{notification}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="notificationId">The <c>Notification</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="NotificationName"/> constructed from the provided ids.</returns>
        public static NotificationName FromProjectBucketNotification(string projectId, string bucketId, string notificationId) =>
            new NotificationName(ResourceNameType.ProjectBucketNotification, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), bucketId: gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)), notificationId: gax::GaxPreconditions.CheckNotNullOrEmpty(notificationId, nameof(notificationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NotificationName"/> with pattern
        /// <c>projects/{project}/buckets/{bucket}/notificationConfigs/{notification}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="notificationId">The <c>Notification</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="NotificationName"/> with pattern
        /// <c>projects/{project}/buckets/{bucket}/notificationConfigs/{notification}</c>.
        /// </returns>
        public static string Format(string projectId, string bucketId, string notificationId) =>
            FormatProjectBucketNotification(projectId, bucketId, notificationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NotificationName"/> with pattern
        /// <c>projects/{project}/buckets/{bucket}/notificationConfigs/{notification}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="notificationId">The <c>Notification</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="NotificationName"/> with pattern
        /// <c>projects/{project}/buckets/{bucket}/notificationConfigs/{notification}</c>.
        /// </returns>
        public static string FormatProjectBucketNotification(string projectId, string bucketId, string notificationId) =>
            s_projectBucketNotification.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)), gax::GaxPreconditions.CheckNotNullOrEmpty(notificationId, nameof(notificationId)));

        /// <summary>Parses the given resource name string into a new <see cref="NotificationName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/buckets/{bucket}/notificationConfigs/{notification}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="notificationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="NotificationName"/> if successful.</returns>
        public static NotificationName Parse(string notificationName) => Parse(notificationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="NotificationName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/buckets/{bucket}/notificationConfigs/{notification}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="notificationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="NotificationName"/> if successful.</returns>
        public static NotificationName Parse(string notificationName, bool allowUnparsed) =>
            TryParse(notificationName, allowUnparsed, out NotificationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="NotificationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/buckets/{bucket}/notificationConfigs/{notification}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="notificationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NotificationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string notificationName, out NotificationName result) =>
            TryParse(notificationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="NotificationName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/buckets/{bucket}/notificationConfigs/{notification}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="notificationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NotificationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string notificationName, bool allowUnparsed, out NotificationName result)
        {
            gax::GaxPreconditions.CheckNotNull(notificationName, nameof(notificationName));
            gax::TemplatedResourceName resourceName;
            if (s_projectBucketNotification.TryParseName(notificationName, out resourceName))
            {
                result = FromProjectBucketNotification(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(notificationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private NotificationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string bucketId = null, string notificationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            BucketId = bucketId;
            NotificationId = notificationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="NotificationName"/> class from the component parts of pattern
        /// <c>projects/{project}/buckets/{bucket}/notificationConfigs/{notification}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="bucketId">The <c>Bucket</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="notificationId">The <c>Notification</c> ID. Must not be <c>null</c> or empty.</param>
        public NotificationName(string projectId, string bucketId, string notificationId) : this(ResourceNameType.ProjectBucketNotification, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), bucketId: gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)), notificationId: gax::GaxPreconditions.CheckNotNullOrEmpty(notificationId, nameof(notificationId)))
        {
        }

        /// <summary>The <see cref="ResourceNameType"/> of the contained resource name.</summary>
        public ResourceNameType Type { get; }

        /// <summary>
        /// The contained <see cref="gax::UnparsedResourceName"/>. Only non-<c>null</c> if this instance contains an
        /// unparsed resource name.
        /// </summary>
        public gax::UnparsedResourceName UnparsedResource { get; }

        /// <summary>
        /// The <c>Bucket</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string BucketId { get; }

        /// <summary>
        /// The <c>Notification</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string NotificationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectBucketNotification: return s_projectBucketNotification.Expand(ProjectId, BucketId, NotificationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as NotificationName);

        /// <inheritdoc/>
        public bool Equals(NotificationName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(NotificationName a, NotificationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(NotificationName a, NotificationName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>CryptoKey</c> resource.</summary>
    public sealed partial class CryptoKeyName : gax::IResourceName, sys::IEquatable<CryptoKeyName>
    {
        /// <summary>The possible contents of <see cref="CryptoKeyName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}</c>.
            /// </summary>
            ProjectLocationKeyRingCryptoKey = 1,
        }

        private static gax::PathTemplate s_projectLocationKeyRingCryptoKey = new gax::PathTemplate("projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}");

        /// <summary>Creates a <see cref="CryptoKeyName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CryptoKeyName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CryptoKeyName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CryptoKeyName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CryptoKeyName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keyRingId">The <c>KeyRing</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cryptoKeyId">The <c>CryptoKey</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CryptoKeyName"/> constructed from the provided ids.</returns>
        public static CryptoKeyName FromProjectLocationKeyRingCryptoKey(string projectId, string locationId, string keyRingId, string cryptoKeyId) =>
            new CryptoKeyName(ResourceNameType.ProjectLocationKeyRingCryptoKey, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), keyRingId: gax::GaxPreconditions.CheckNotNullOrEmpty(keyRingId, nameof(keyRingId)), cryptoKeyId: gax::GaxPreconditions.CheckNotNullOrEmpty(cryptoKeyId, nameof(cryptoKeyId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CryptoKeyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keyRingId">The <c>KeyRing</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cryptoKeyId">The <c>CryptoKey</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CryptoKeyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string keyRingId, string cryptoKeyId) =>
            FormatProjectLocationKeyRingCryptoKey(projectId, locationId, keyRingId, cryptoKeyId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CryptoKeyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keyRingId">The <c>KeyRing</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cryptoKeyId">The <c>CryptoKey</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CryptoKeyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}</c>.
        /// </returns>
        public static string FormatProjectLocationKeyRingCryptoKey(string projectId, string locationId, string keyRingId, string cryptoKeyId) =>
            s_projectLocationKeyRingCryptoKey.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(keyRingId, nameof(keyRingId)), gax::GaxPreconditions.CheckNotNullOrEmpty(cryptoKeyId, nameof(cryptoKeyId)));

        /// <summary>Parses the given resource name string into a new <see cref="CryptoKeyName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="cryptoKeyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CryptoKeyName"/> if successful.</returns>
        public static CryptoKeyName Parse(string cryptoKeyName) => Parse(cryptoKeyName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CryptoKeyName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="cryptoKeyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CryptoKeyName"/> if successful.</returns>
        public static CryptoKeyName Parse(string cryptoKeyName, bool allowUnparsed) =>
            TryParse(cryptoKeyName, allowUnparsed, out CryptoKeyName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CryptoKeyName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="cryptoKeyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CryptoKeyName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string cryptoKeyName, out CryptoKeyName result) => TryParse(cryptoKeyName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CryptoKeyName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="cryptoKeyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CryptoKeyName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string cryptoKeyName, bool allowUnparsed, out CryptoKeyName result)
        {
            gax::GaxPreconditions.CheckNotNull(cryptoKeyName, nameof(cryptoKeyName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationKeyRingCryptoKey.TryParseName(cryptoKeyName, out resourceName))
            {
                result = FromProjectLocationKeyRingCryptoKey(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(cryptoKeyName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CryptoKeyName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string cryptoKeyId = null, string keyRingId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CryptoKeyId = cryptoKeyId;
            KeyRingId = keyRingId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CryptoKeyName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keyRingId">The <c>KeyRing</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cryptoKeyId">The <c>CryptoKey</c> ID. Must not be <c>null</c> or empty.</param>
        public CryptoKeyName(string projectId, string locationId, string keyRingId, string cryptoKeyId) : this(ResourceNameType.ProjectLocationKeyRingCryptoKey, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), keyRingId: gax::GaxPreconditions.CheckNotNullOrEmpty(keyRingId, nameof(keyRingId)), cryptoKeyId: gax::GaxPreconditions.CheckNotNullOrEmpty(cryptoKeyId, nameof(cryptoKeyId)))
        {
        }

        /// <summary>The <see cref="ResourceNameType"/> of the contained resource name.</summary>
        public ResourceNameType Type { get; }

        /// <summary>
        /// The contained <see cref="gax::UnparsedResourceName"/>. Only non-<c>null</c> if this instance contains an
        /// unparsed resource name.
        /// </summary>
        public gax::UnparsedResourceName UnparsedResource { get; }

        /// <summary>
        /// The <c>CryptoKey</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CryptoKeyId { get; }

        /// <summary>
        /// The <c>KeyRing</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string KeyRingId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationKeyRingCryptoKey: return s_projectLocationKeyRingCryptoKey.Expand(ProjectId, LocationId, KeyRingId, CryptoKeyId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CryptoKeyName);

        /// <inheritdoc/>
        public bool Equals(CryptoKeyName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(CryptoKeyName a, CryptoKeyName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(CryptoKeyName a, CryptoKeyName b) => !(a == b);
    }

    public partial class DeleteBucketRequest
    {
        /// <summary>
        /// <see cref="gcsv::BucketName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::BucketName BucketName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::BucketName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetBucketRequest
    {
        /// <summary>
        /// <see cref="gcsv::BucketName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::BucketName BucketName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::BucketName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateBucketRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListBucketsRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class LockBucketRetentionPolicyRequest
    {
        /// <summary><see cref="BucketName"/>-typed view over the <see cref="Bucket"/> resource name property.</summary>
        public BucketName BucketAsBucketName
        {
            get => string.IsNullOrEmpty(Bucket) ? null : BucketName.Parse(Bucket, allowUnparsed: true);
            set => Bucket = value?.ToString() ?? "";
        }
    }

    public partial class DeleteNotificationRequest
    {
        /// <summary>
        /// <see cref="gcsv::NotificationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::NotificationName NotificationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::NotificationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetNotificationRequest
    {
        /// <summary>
        /// <see cref="gcsv::NotificationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::NotificationName NotificationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::NotificationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateNotificationRequest
    {
        /// <summary><see cref="BucketName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public BucketName ParentAsBucketName
        {
            get => string.IsNullOrEmpty(Parent) ? null : BucketName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListNotificationsRequest
    {
        /// <summary><see cref="BucketName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public BucketName ParentAsBucketName
        {
            get => string.IsNullOrEmpty(Parent) ? null : BucketName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ComposeObjectRequest
    {
        /// <summary>
        /// <see cref="CryptoKeyName"/>-typed view over the <see cref="KmsKey"/> resource name property.
        /// </summary>
        public CryptoKeyName KmsKeyAsCryptoKeyName
        {
            get => string.IsNullOrEmpty(KmsKey) ? null : CryptoKeyName.Parse(KmsKey, allowUnparsed: true);
            set => KmsKey = value?.ToString() ?? "";
        }
    }

    public partial class ListObjectsRequest
    {
        /// <summary><see cref="BucketName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public BucketName ParentAsBucketName
        {
            get => string.IsNullOrEmpty(Parent) ? null : BucketName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class RewriteObjectRequest
    {
        /// <summary>
        /// <see cref="BucketName"/>-typed view over the <see cref="DestinationBucket"/> resource name property.
        /// </summary>
        public BucketName DestinationBucketAsBucketName
        {
            get => string.IsNullOrEmpty(DestinationBucket) ? null : BucketName.Parse(DestinationBucket, allowUnparsed: true);
            set => DestinationBucket = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CryptoKeyName"/>-typed view over the <see cref="DestinationKmsKey"/> resource name property.
        /// </summary>
        public CryptoKeyName DestinationKmsKeyAsCryptoKeyName
        {
            get => string.IsNullOrEmpty(DestinationKmsKey) ? null : CryptoKeyName.Parse(DestinationKmsKey, allowUnparsed: true);
            set => DestinationKmsKey = value?.ToString() ?? "";
        }
    }

    public partial class GetServiceAccountRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Project"/> resource name property.
        /// </summary>
        public gagr::ProjectName ProjectAsProjectName
        {
            get => string.IsNullOrEmpty(Project) ? null : gagr::ProjectName.Parse(Project, allowUnparsed: true);
            set => Project = value?.ToString() ?? "";
        }
    }

    public partial class CreateHmacKeyRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Project"/> resource name property.
        /// </summary>
        public gagr::ProjectName ProjectAsProjectName
        {
            get => string.IsNullOrEmpty(Project) ? null : gagr::ProjectName.Parse(Project, allowUnparsed: true);
            set => Project = value?.ToString() ?? "";
        }
    }

    public partial class DeleteHmacKeyRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Project"/> resource name property.
        /// </summary>
        public gagr::ProjectName ProjectAsProjectName
        {
            get => string.IsNullOrEmpty(Project) ? null : gagr::ProjectName.Parse(Project, allowUnparsed: true);
            set => Project = value?.ToString() ?? "";
        }
    }

    public partial class GetHmacKeyRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Project"/> resource name property.
        /// </summary>
        public gagr::ProjectName ProjectAsProjectName
        {
            get => string.IsNullOrEmpty(Project) ? null : gagr::ProjectName.Parse(Project, allowUnparsed: true);
            set => Project = value?.ToString() ?? "";
        }
    }

    public partial class ListHmacKeysRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Project"/> resource name property.
        /// </summary>
        public gagr::ProjectName ProjectAsProjectName
        {
            get => string.IsNullOrEmpty(Project) ? null : gagr::ProjectName.Parse(Project, allowUnparsed: true);
            set => Project = value?.ToString() ?? "";
        }
    }

    public partial class Bucket
    {
        /// <summary>
        /// <see cref="gcsv::BucketName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::BucketName BucketName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::BucketName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Project"/> resource name property.
        /// </summary>
        public gagr::ProjectName ProjectAsProjectName
        {
            get => string.IsNullOrEmpty(Project) ? null : gagr::ProjectName.Parse(Project, allowUnparsed: true);
            set => Project = value?.ToString() ?? "";
        }
    }

    public partial class HmacKeyMetadata
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Project"/> resource name property.
        /// </summary>
        public gagr::ProjectName ProjectAsProjectName
        {
            get => string.IsNullOrEmpty(Project) ? null : gagr::ProjectName.Parse(Project, allowUnparsed: true);
            set => Project = value?.ToString() ?? "";
        }
    }

    public partial class Notification
    {
        /// <summary>
        /// <see cref="gcsv::NotificationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::NotificationName NotificationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::NotificationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Object
    {
        /// <summary><see cref="BucketName"/>-typed view over the <see cref="Bucket"/> resource name property.</summary>
        public BucketName BucketAsBucketName
        {
            get => string.IsNullOrEmpty(Bucket) ? null : BucketName.Parse(Bucket, allowUnparsed: true);
            set => Bucket = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CryptoKeyName"/>-typed view over the <see cref="KmsKey"/> resource name property.
        /// </summary>
        public CryptoKeyName KmsKeyAsCryptoKeyName
        {
            get => string.IsNullOrEmpty(KmsKey) ? null : CryptoKeyName.Parse(KmsKey, allowUnparsed: true);
            set => KmsKey = value?.ToString() ?? "";
        }
    }
}

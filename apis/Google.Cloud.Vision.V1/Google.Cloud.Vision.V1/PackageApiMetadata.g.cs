// Copyright 2025 Google LLC
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
using gaxgrpc = Google.Api.Gax.Grpc;
using gpr = Google.Protobuf.Reflection;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;

namespace Google.Cloud.Vision.V1
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Cloud.Vision.V1", GetFileDescriptors)
            .WithRequestNumericEnumJsonEncoding(true)
            .WithHttpRuleOverrides(new scg::Dictionary<string, proto::ByteString>
            {
                {
                    "google.longrunning.Operations.GetOperation",
                    // { "get": "/v1/{name=projects/*/operations/*}", "additionalBindings": [ { "get": "/v1/{name=projects/*/locations/*/operations/*}" }, { "get": "/v1/{name=operations/*}" }, { "get": "/v1/{name=locations/*/operations/*}" } ] }
                    proto::ByteString.FromBase64("EiIvdjEve25hbWU9cHJvamVjdHMvKi9vcGVyYXRpb25zLyp9WjASLi92MS97bmFtZT1wcm9qZWN0cy8qL2xvY2F0aW9ucy8qL29wZXJhdGlvbnMvKn1aGRIXL3YxL3tuYW1lPW9wZXJhdGlvbnMvKn1aJRIjL3YxL3tuYW1lPWxvY2F0aW9ucy8qL29wZXJhdGlvbnMvKn0=")
                },
            });

        private static scg::IEnumerable<gpr::FileDescriptor> GetFileDescriptors()
        {
            yield return GeometryReflection.Descriptor;
            yield return ImageAnnotatorReflection.Descriptor;
            yield return ProductSearchReflection.Descriptor;
            yield return ProductSearchServiceReflection.Descriptor;
            yield return TextAnnotationReflection.Descriptor;
            yield return WebDetectionReflection.Descriptor;
            yield return lro::OperationsReflection.Descriptor;
        }
    }
}

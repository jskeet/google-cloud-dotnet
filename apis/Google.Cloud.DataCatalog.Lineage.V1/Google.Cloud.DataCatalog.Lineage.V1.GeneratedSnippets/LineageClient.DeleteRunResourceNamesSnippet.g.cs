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

namespace Google.Cloud.DataCatalog.Lineage.V1.Snippets
{
    // [START datalineage_v1_generated_Lineage_DeleteRun_sync_flattened_resourceNames]
    using Google.Cloud.DataCatalog.Lineage.V1;
    using Google.LongRunning;
    using Google.Protobuf.WellKnownTypes;

    public sealed partial class GeneratedLineageClientSnippets
    {
        /// <summary>Snippet for DeleteRun</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void DeleteRunResourceNames()
        {
            // Create client
            LineageClient lineageClient = LineageClient.Create();
            // Initialize request argument(s)
            RunName name = RunName.FromProjectLocationProcessRun("[PROJECT]", "[LOCATION]", "[PROCESS]", "[RUN]");
            // Make the request
            Operation<Empty, OperationMetadata> response = lineageClient.DeleteRun(name);

            // Poll until the returned long-running operation is complete
            Operation<Empty, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            Empty result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<Empty, OperationMetadata> retrievedResponse = lineageClient.PollOnceDeleteRun(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                Empty retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END datalineage_v1_generated_Lineage_DeleteRun_sync_flattened_resourceNames]
}
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

namespace GoogleCSharpSnippets
{
    // [START vmmigration_v1_generated_VmMigration_CreateMigratingVm_sync_flattened_resourceNames]
    using Google.Cloud.VMMigration.V1;
    using Google.LongRunning;

    public sealed partial class GeneratedVmMigrationClientSnippets
    {
        /// <summary>Snippet for CreateMigratingVm</summary>
        /// <remarks>
        /// This snippet has been automatically generated and should be regarded as a code template only.
        /// It will require modifications to work:
        /// - It may require correct/in-range values for request initialization.
        /// - It may require specifying regional endpoints when creating the service client as shown in
        ///   https://cloud.google.com/dotnet/docs/reference/help/client-configuration#endpoint.
        /// </remarks>
        public void CreateMigratingVmResourceNames()
        {
            // Create client
            VmMigrationClient vmMigrationClient = VmMigrationClient.Create();
            // Initialize request argument(s)
            SourceName parent = SourceName.FromProjectLocationSource("[PROJECT]", "[LOCATION]", "[SOURCE]");
            MigratingVm migratingVm = new MigratingVm();
            string migratingVmId = "";
            // Make the request
            Operation<MigratingVm, OperationMetadata> response = vmMigrationClient.CreateMigratingVm(parent, migratingVm, migratingVmId);

            // Poll until the returned long-running operation is complete
            Operation<MigratingVm, OperationMetadata> completedResponse = response.PollUntilCompleted();
            // Retrieve the operation result
            MigratingVm result = completedResponse.Result;

            // Or get the name of the operation
            string operationName = response.Name;
            // This name can be stored, then the long-running operation retrieved later by name
            Operation<MigratingVm, OperationMetadata> retrievedResponse = vmMigrationClient.PollOnceCreateMigratingVm(operationName);
            // Check if the retrieved long-running operation has completed
            if (retrievedResponse.IsCompleted)
            {
                // If it has completed, then access the result
                MigratingVm retrievedResult = retrievedResponse.Result;
            }
        }
    }
    // [END vmmigration_v1_generated_VmMigration_CreateMigratingVm_sync_flattened_resourceNames]
}

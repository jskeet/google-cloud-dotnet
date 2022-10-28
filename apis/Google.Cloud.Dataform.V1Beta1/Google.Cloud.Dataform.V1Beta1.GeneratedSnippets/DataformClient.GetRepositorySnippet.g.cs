// Copyright 2022 Google LLC
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

namespace Google.Cloud.Dataform.V1Beta1.Snippets
{
    // [START dataform_v1beta1_generated_Dataform_GetRepository_sync_flattened]
    using Google.Cloud.Dataform.V1Beta1;

    public sealed partial class GeneratedDataformClientSnippets
    {
        /// <summary>Snippet for GetRepository</summary>
        /// <remarks>
        /// This snippet has been automatically generated for illustrative purposes only.
        /// It may require modifications to work in your environment.
        /// </remarks>
        public void GetRepository()
        {
            // Create client
            DataformClient dataformClient = DataformClient.Create();
            // Initialize request argument(s)
            string name = "projects/[PROJECT]/locations/[LOCATION]/repositories/[REPOSITORY]";
            // Make the request
            Repository response = dataformClient.GetRepository(name);
        }
    }
    // [END dataform_v1beta1_generated_Dataform_GetRepository_sync_flattened]
}
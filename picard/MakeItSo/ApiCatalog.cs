// Copyright 2020 Google LLC
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

namespace MakeItSo;

/// <summary>
/// // A very cut-down version of the code in Google.Cloud.Tools.Common.
/// </summary>
internal class ApiCatalog
{
    /// <summary>
    /// The APIs within the catalog.
    /// </summary>
    public List<ApiMetadata> Apis { get; set; } = null!;

    /// <summary>
    /// Proto paths for APIs we knowingly don't generate. The values are the reasons for not generating.
    /// </summary>
    public Dictionary<string, string> IgnoredPaths { get; set; } = null!;
}

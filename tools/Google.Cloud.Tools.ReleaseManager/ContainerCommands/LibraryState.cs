// Copyright 2025 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License"):
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

using Google.Cloud.Tools.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Google.Cloud.Tools.ReleaseManager.ContainerCommands;

/// <summary>
/// The state for a single library, used in Librarian state files
/// and standalone for the generation command.
/// </summary>
internal class LibraryState
{
    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("version")]
    public string Version { get; set; }

    [JsonProperty("last_generated_commit")]
    public string LastGeneratedCommit { get; set; }

    [JsonProperty("apis")]
    public List<LibraryApi> Apis { get; set; } = [];

    [JsonProperty("preserve_regex")]
    public List<string> PreserveRegex { get; set; } = [];

    [JsonProperty("remove_regex")]
    public List<string> RemoveRegex { get; set; } = [];
}

internal class LibraryApi
{
    [JsonProperty("path")]
    public string Path { get; set; }

    [JsonProperty("service_config")]
    public string ServiceConfig { get; set; }
}

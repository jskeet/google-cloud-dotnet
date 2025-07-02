// Copyright 2024 Google LLC
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
using Octokit;
using System;
using System.IO;
using System.Linq;

namespace Google.Cloud.Tools.ReleaseManager.ContainerCommands;

/// <summary>
/// Configures a new library for a specified API.
/// </summary>
public class ConfigureCommand : IContainerCommand
{
    public int Execute()
    {
        var state = JsonConvert.DeserializeObject<LibraryState>(File.ReadAllText(MountLocations.LibrarianCommandStateFile));
        var rootLayout = RootLayout.ForConfiguration(MountLocations.GeneratorInputDirectory, MountLocations.ApiRootDirectory);

        var catalog = ApiCatalog.Load(rootLayout);
        var apiPath = state.Apis.Single().Path;
        if (catalog.Apis.FirstOrDefault(api => api.ProtoPath == apiPath) is ApiMetadata api)
        {
            Console.WriteLine($"API path {apiPath} is already configured for {api.Id}");
            return 1;
        }
        var protoc = new ProtobufCompiler();

        api = new ApiAnalyzer(protoc, MountLocations.ApiRootDirectory).ConfigureApi(apiPath, catalog);
        catalog.Add(api);
        catalog.Save(rootLayout);

        // Update the Librarian command state file appropriately.

        state.Id = api.Id;
        // These may not all exist, but I'm assuming that's okay.
        state.RemoveRegex =
        [
            // All generated code
            $@"^apis/{api.Id}/.*\.g\.cs$",
            // All projects
            $@"^apis/{api.Id}/.*\.csproj$",
            // The solution file
            $@"^apis/{api.Id}/{api.Id}\.sln$",
            // GAPIC metadata
            $@"^apis/{api.Id}/gapic_metadata\.json$",
            // Generated snippets JSON metadata
            $@"^apis/{api.Id}/{api.Id}\.GeneratedSnippets/.*\.json$",
            // Files generated for all APIs
            @"^README\.md$",
            @"^\.github/renovate\.json$",
        ];
        File.WriteAllText(MountLocations.LibrarianCommandStateFile, JsonConvert.SerializeObject(state, Formatting.Indented));

        return 0;
    }
}

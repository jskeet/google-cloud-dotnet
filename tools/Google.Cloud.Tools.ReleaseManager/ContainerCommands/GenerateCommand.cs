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
using System;
using System.IO;
using System.Linq;

namespace Google.Cloud.Tools.ReleaseManager.ContainerCommands;

/// <summary>
/// Generates files for a single library (which may contain multiple packages).
/// </summary>
internal class GenerateCommand : IContainerCommand
{
    public int Execute()
    {
        var state = JsonConvert.DeserializeObject<LibraryState>(File.ReadAllText(MountLocations.LibrarianCommandStateFile));

        var rootLayout = RootLayout.ForGeneration(MountLocations.LibrarianGeneratorInputDirectory, MountLocations.GeneratorOutputDirectory, MountLocations.ApiRootDirectory);

        // Note: we expect the container to already have environment variables for
        // protoc, protobuf tools root, the gRPC generator, and the GAPIC generator.
        var generatorCommand = new GenerateApisCommand(rootLayout);
        // Set environment variables used by scripts invoked by GenerateApisCommand.
        Environment.SetEnvironmentVariable(GenerateApisCommand.GeneratorInputDirectoryEnvironmentVariable, rootLayout.GeneratorInput);
        Environment.SetEnvironmentVariable(GenerateApisCommand.GeneratorOutputDirectoryEnvironmentVariable, rootLayout.GeneratorOutput);
        Environment.SetEnvironmentVariable(GenerateApisCommand.GoogleApisDirectoryEnvironmentVariable, rootLayout.Googleapis);

        var catalog = ApiCatalog.Load(rootLayout);
        var packages = catalog.GetPackagesForLibraryId(state.Id);
        return generatorCommand.Execute(packages.ToArray());
    }
}

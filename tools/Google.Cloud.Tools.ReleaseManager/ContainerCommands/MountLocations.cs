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

namespace Google.Cloud.Tools.ReleaseManager.ContainerCommands;

/// <summary>
/// Common locations for container commands. (These are always mounted the same way for the container.)
/// </summary>
internal static class MountLocations
{
    /// <summary>
    /// The generator input directory from the repository.
    /// </summary>
    internal const string GeneratorInputDirectory = "/input";

    /// <summary>
    /// The language repository root for building.
    /// </summary>
    internal const string RepoRoot = "/repo";

    /// <summary>
    /// The API root directory.
    /// </summary>
    internal const string ApiRootDirectory = "/source";

    /// <summary>
    /// The output directory in which to generate.
    /// </summary>
    internal const string GeneratorOutputDirectory = "/output";

    /// <summary>
    /// The librarian directory, containing state and generator input.
    /// </summary>
    internal const string LibrarianDirectory = "/librarian";

    /// <summary>
    /// The generator input directory when LibrarianDirectory is mounted.
    /// </summary>
    internal const string LibrarianGeneratorInputDirectory = "/librarian/generator-input";

    /// <summary>
    /// The Librarian state file for a single command.
    /// </summary>
    internal const string LibrarianCommandStateFile = "/librarian/state.json";
}

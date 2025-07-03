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
using System;
using System.Collections.Generic;
using System.Linq;

namespace Google.Cloud.Tools.ReleaseManager.ContainerCommands;

/// <summary>
/// Builds a library, or all configured libraries.
/// </summary>
public class BuildCommand : IContainerCommand
{
    public int Execute()
    {
        using var _ = SourceLinkFixer.Create(MountLocations.RepoRoot);

        var rootLayout = RootLayout.ForRepositoryRoot(MountLocations.RepoRoot);
        var catalog = ApiCatalog.Load(rootLayout);

        var libraryId = Environment.GetEnvironmentVariable("LIBRARIAN_ID");

        var packages = string.IsNullOrEmpty(libraryId)
            ? catalog.Apis.Select(api => api.Id)
            : catalog.GetPackagesForLibraryId(libraryId);

        // TODO: Include unit testing. Maybe get rid of client creation tests,
        // which are awkward for testing and probably don't provide much value these days.
        List<string> args = ["--notests", .. packages];

        Processes.RunBashScript(MountLocations.RepoRoot, "build.sh", args);
        return 0;
    }
}

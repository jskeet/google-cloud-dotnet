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

using Google.Cloud.ClientTesting;
using Google.Cloud.Tools.Common;
using NuGet.Packaging;
using Octokit;
using System;
using System.Diagnostics;
using System.IO;
using Xunit;

namespace Google.Cloud.Tools.ReleaseManager.IntegrationTests.ContainerCommands;

/// <summary>
/// Fixture for tests which run the actual Docker container (including the generator
/// etc).
/// </summary>
[CollectionDefinition(nameof(DockerCommandFixture))]
public sealed class DockerCommandFixture : ICollectionFixture<DockerCommandFixture>
{
    private const string DockerExecutable = "/usr/bin/docker";
    private const string DockerImageEnvironmentVariable = "TEST_LIBRARIAN_DOTNET_DOCKER_IMAGE";

    /// <summary>
    /// The directory in which to create subdirectories for tests.
    /// </summary>
    public string TempTestDirectory { get; }
    private readonly bool _enabled;
    private readonly string _image;

    public DockerCommandFixture()
    {
        string image = Environment.GetEnvironmentVariable(DockerImageEnvironmentVariable);
        if (!TestEnvironment.IsLinux() || string.IsNullOrEmpty(image))
        {
            _enabled = false;
            return;
        }
        TempTestDirectory = Path.Combine(Path.GetTempPath(), $"DockerCommand-{image}");

        _image = image;
    }

    public void MaybeSkip() => Skip.If(!_enabled);

    public void RunDocker(string command, string[] args, string testMount)
    {
        // TODO: Map the user to the current user/group. Finding the UID and GID
        // in .NET is non-trivial...
        // var userArg = $"--user={uid}:{gid}";
        var psi = new ProcessStartInfo
        {
            FileName = DockerExecutable,
            ArgumentList = { "run", "--rm", _image, $"-v{testMount}:/test", command }
        };
        psi.ArgumentList.AddRange(args);
        //Processes.RunAndPropagateOutput(psi, "running Docker");
    }

    public void RunCommand(params string[] args)
    {
    }
}

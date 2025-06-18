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
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;

namespace Google.Cloud.Tools.ReleaseManager.IntegrationTests.ContainerCommands;

[Collection(nameof(DockerCommandFixture))]
public class DockerCommandTest
{
    private static readonly string dataRoot;
    public static IEnumerable<object[]> Tests { get; }

    static DockerCommandTest()
    {
        var root = TestEnvironment.FindRepositoryRootDirectory();
        var dataRoot = Path.Combine(root, "tools", typeof(DockerCommandTest).Assembly.FullName, "ContainerCommands");
        Tests = Directory.GetDirectories(dataRoot).Select(p => new object[] { Path.GetFileName(p) });
    }

    private readonly DockerCommandFixture _fixture;

    public DockerCommandTest(DockerCommandFixture fixture) => _fixture = fixture;

    [SkippableTheory, MemberData(nameof(Tests))]
    public void DockerTest(string directory)
    {
        _fixture.MaybeSkip();
        var fullDirectory = Path.Combine(dataRoot, directory);
        Assert.NotEmpty(fullDirectory);
    }
}

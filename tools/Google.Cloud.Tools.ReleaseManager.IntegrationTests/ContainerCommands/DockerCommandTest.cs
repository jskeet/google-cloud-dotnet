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
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Xunit;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace Google.Cloud.Tools.ReleaseManager.IntegrationTests.ContainerCommands;

[Collection(nameof(DockerCommandFixture))]
public class DockerCommandTest
{
    private static readonly string s_dataRoot;
    public static IEnumerable<object[]> Tests { get; }

    private static readonly IDeserializer s_yamlDeserializer = new DeserializerBuilder()
        .WithNamingConvention(PascalCaseNamingConvention.Instance)
        .Build();

    static DockerCommandTest()
    {
        var root = TestEnvironment.FindRepositoryRootDirectory();
        s_dataRoot = Path.Combine(root, "tools", typeof(DockerCommandTest).Assembly.GetName().Name, "ContainerCommands", "DockerTests");
        Tests = Directory.GetDirectories(s_dataRoot)
            .Select(Path.GetFileName)
            .Except(["CommonFiles"])
            .Select(p => new object[] { p });
    }

    private readonly DockerCommandFixture _fixture;

    public DockerCommandTest(DockerCommandFixture fixture) => _fixture = fixture;

    [SkippableTheory, MemberData(nameof(Tests))]
    public void DockerTest(string directory)
    {
        _fixture.MaybeSkip();
        var fullDirectory = Path.Combine(s_dataRoot, directory);
        Assert.NotEmpty(fullDirectory);
        var metadataYaml = File.ReadAllText(Path.Combine(fullDirectory, "metadata.yaml"));
        var metadata = s_yamlDeserializer.Deserialize<TestMetadata>(metadataYaml);
        string outputDirectory = CopyTestFiles(fullDirectory, metadata);
        _fixture.RunDocker(metadata.Command, metadata.Args, outputDirectory);

        if (metadata.Expectations is not null)
        {
            foreach (var pair in metadata.Expectations)
            {
                var path = Path.Combine(outputDirectory, pair.Key);
                switch (pair.Value)
                {
                    case Expectation.Absent:
                        Assert.False(Path.Exists(path));
                        break;
                    case Expectation.Present:
                        Assert.True(Path.Exists(path));
                        break;
                    default:
                        throw new Exception($"Unhandled expectation: {pair.Value}");
                }
            }
        }
    }

    private string CopyTestFiles(string fullTestDirectory, TestMetadata metadata)
    {
        var outputDirectory = Path.Combine(_fixture.TempTestDirectory, nameof(DockerCommandTest), Path.GetFileName(fullTestDirectory));
        Directory.CreateDirectory(outputDirectory);
        foreach (var subdirectory in Directory.GetDirectories(outputDirectory))
        {
            CopyDirectory(subdirectory, Path.Combine(outputDirectory, Path.GetFileName(subdirectory)));
        }
        if (metadata.CommonFiles is not null)
        {
            foreach (var pair in metadata.CommonFiles)
            {
                var source = Path.Combine(fullTestDirectory, "CommonFiles", pair.Key);

                // Handle global.json separately: always copy it from the repo root.
                if (pair.Key == "global.json")
                {
                    source = Path.Combine(TestEnvironment.FindRepositoryRootDirectory(), "global.json");
                }
                var target = Path.Combine(outputDirectory, pair.Value);
                if (Directory.Exists(source))
                {
                    CopyDirectory(source, target);
                }
                else
                {
                    var targetDirectory = Path.GetDirectoryName(target);
                    Directory.CreateDirectory(targetDirectory);
                    File.Copy(source, target);
                }
            }
        }
        return outputDirectory;

        void CopyDirectory(string source, string target)
        {
            Directory.CreateDirectory(target);
            foreach (var file in Directory.GetFiles(source))
            {
                File.Copy(file, Path.Combine(target, Path.GetFileName(file)));
            }
            foreach (var directory in Directory.GetDirectories(source))
            {
                CopyDirectory(directory, Path.Combine(target, Path.GetFileName(directory)));
            }
        }
    }

    private class TestMetadata
    {
        /// <summary>
        /// The container command to run
        /// </summary>
        public string Command { get; set; }

        /// <summary>
        /// The arguments to the container command
        /// </summary>
        public string[] Args { get; set; }

        /// <summary>
        /// Files/directories to copy from the CommonFiles directory - the source
        /// is specified as the key, and the target is specified as the value.
        /// </summary>
        public Dictionary<string, string> CommonFiles { get; set; }

        /// <summary>
        /// Expectations of the files after the test
        /// </summary>
        public Dictionary<string, Expectation> Expectations { get; set; }
    }

    public enum Expectation
    {
        Absent,
        Present
    }
}

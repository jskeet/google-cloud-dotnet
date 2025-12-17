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
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Google.Cloud.Tools.ReleaseManager;

public class MigrateToLibrarianCommand : CommandBase
{
    public MigrateToLibrarianCommand() : base("migrate-to-librarian", "Migrates packages to librarian.yaml", "(verbose|quiet)")
    {
    }

    protected override int ExecuteImpl(string[] args)
    {
        bool verbose = args[0] == "verbose";

        var catalog = ApiCatalog.Load(RootLayout);

        var yamlFile = Path.Combine(RootLayout.RepositoryRoot, "librarian.yaml");
        var yamlLines = File.ReadAllLines(yamlFile).ToList();
        var existingMigratedPackages = yamlLines
            .Where(line => line.StartsWith("  - name: "))
            .Select(line => line.Split(':')[1].Trim())
            .ToList();
        var candidates = catalog.Apis.Where(CanMigrate).ToList();

        int total = existingMigratedPackages.Count;
        foreach (var candidate in candidates)
        {
            if (existingMigratedPackages.Contains(candidate.Id))
            {
                Console.WriteLine($"{candidate.Id} is already migrated; skipping.");
                continue;
            }
            yamlLines.AddRange(CreateMigrationLines(RootLayout, candidate));
            Console.WriteLine($"Migrated {candidate.Id}");
            total++;
        }
        File.WriteAllLines(yamlFile, yamlLines.ToArray());
        Console.WriteLine();
        Console.WriteLine($"Packages migrated before run: {existingMigratedPackages.Count}");
        Console.WriteLine($"Packages migrated after run: {total}");
        return 0;

        bool CanMigrate(ApiMetadata api)
        {
            if (api.Type != ApiType.Grpc || api.Generator != GeneratorType.Micro)
            {
                LogReason("Not grpc/micro");
                return false;
            }
            if (api.Projects is not null || api.PackageGroup is not null)
            {
                LogReason("Has projects");
                return false;
            }
            if (api.TestDependencies.Any())
            {
                LogReason("Has test dependencies");
                return false;
            }
            if (api.ProtoPath is null || api.ServiceConfigFile is null)
            {
                LogReason("Has no path or no service config file");
                return false;
            }
            if (Directory.Exists(RootLayout.CreateGeneratorApiLayout(api).TweaksDirectory))
            {
                LogReason("Has tweaks");
                return false;
            }
            if (api.CommonResourcesConfig is not null)
            {
                LogReason("Has custom common resources");
                return false;
            }

            var sourceRoot = RootLayout.CreateRepositoryApiLayout(api);
            var sourceFiles = Directory.EnumerateFiles(sourceRoot.SourceDirectory, "*.cs", SearchOption.AllDirectories);
            if (sourceFiles.Any(file => !file.Contains(".g.cs", StringComparison.Ordinal)))
            {
                LogReason("Has non-generated code");
                return false;
            }
            if (!api.RestNumericEnums || api.Transport != "grpc+rest")
            {
                LogReason("Options are non-default");
                return false;
            }
            return true;

            void LogReason(string reason)
            {
                if (!verbose)
                {
                    return;
                }
                Console.WriteLine($"{api.Id}: {reason}");
            }
        }
    }

    private static IEnumerable<string> CreateMigrationLines(RootLayout rootLayout, ApiMetadata api)
    {
        yield return $"  - name: {api.Id}";
        yield return $"    channels:";
        yield return $"      - path: {api.ProtoPath}";
        yield return $"        service_config: {api.ServiceConfigFile}";
        yield return $"    output: apis/{api.Id}";
        yield return $"    version: {api.Version}";
        if (api.IncludeCommonResourcesProto != true)
        {
            yield return "    dotnet:";
            yield return "      exclude_common_resources_proto: true";
        }
        var sourceLayout = rootLayout.CreateRepositoryApiLayout(api);
        var docsDirectory = sourceLayout.CreateDocsLayout().MarkdownDirectory;

        var keep = new List<string>();
        if (Directory.Exists(docsDirectory))
        {
            var docs = Directory.GetFiles(docsDirectory).Select(file => "docs/" + Path.GetFileName(file));
            keep.AddRange(docs);
        }
        if (File.Exists(Path.Combine(sourceLayout.SourceDirectory, "smoketests.json")))
        {
            keep.Add("smoketests.json");
        }
        if (keep.Any())
        {
            yield return "    keep:";
            foreach (var entry in keep)
            {
                yield return $"    - {entry}";
            }
        }

    }
}

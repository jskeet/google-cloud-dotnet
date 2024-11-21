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

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace MakeItSo;

internal class UpdateCommand : ICommand
{
    private readonly string _apiRoot;
    private readonly string _api;
    private readonly string _outputRoot;

    public UpdateCommand(string apiRoot, string api, string outputRoot)
    {
        _apiRoot = apiRoot;
        _api = api;
        _outputRoot = outputRoot;
    }

    public void Execute()
    {
        var apiCatalogJson = File.ReadAllText(Path.Combine(_outputRoot, "apis", "apis.json"));
        var apiCatalog = JsonConvert.DeserializeObject<ApiCatalog>(apiCatalogJson)!;
        var api = apiCatalog.Apis.FirstOrDefault(api => api.ProtoPath == _api);
        if (api is null)
        {
            throw new Exception($"No API configured with proto path {_api}");
        }

        var psi = new ProcessStartInfo
        {
            FileName = "/bin/bash",
            ArgumentList = { "./generateapis.sh", api.Id },
            WorkingDirectory = _outputRoot,
            EnvironmentVariables = { { "GOOGLEAPIS_DIR", _apiRoot } }
        };
        var process = Process.Start(psi)!;
        process.WaitForExit();
        if (process.ExitCode != 0)
        {
            throw new Exception($"Generation ended with exit code {process.ExitCode}");
        }
    }
}

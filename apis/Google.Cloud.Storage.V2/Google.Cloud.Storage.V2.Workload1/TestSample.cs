// Copyright 2023 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License").
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at 
//
// https://www.apache.org/licenses/LICENSE-2.0 
//
// Unless required by applicable law or agreed to in writing, software 
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and 
// limitations under the License.

namespace Google.Cloud.Storage.V2.Workload1;

/// <summary>
/// A size of object to upload/download, along with the original
/// description and the number of iterations to perform.
/// </summary>
public class TestSample
{
    /// <summary>
    /// Size of the iteration in bytes.
    /// </summary>
    public long Size { get; }

    /// <summary>
    /// Original description (e.g. "8K" or "1G")
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// The number of iterations to execute for this sample.
    /// </summary>
    public int Iterations { get; }

    private TestSample(string description, long size, int iterations) =>
        (Description, Size, Iterations) = (description, size, iterations);

    public static TestSample Create(KeyValuePair<string, int> dictionaryEntry)
    {
        var (description, iterations) = dictionaryEntry;

        var trimmedDescription = description[..^1];
        var size = description.Last() switch
        {
            char d when d >= '0' && d <= '1' => long.Parse(description),
            'B' => long.Parse(trimmedDescription),
            'K' => 1024 * long.Parse(trimmedDescription),
            'M' => 1024 * 1024 * long.Parse(trimmedDescription),
            'G' => 1024 * 1024 * 1024 * long.Parse(trimmedDescription),
            _ => throw new ArgumentException($"Invalid description '{description}'")
        };
        return new(description, size, iterations);
    }
}

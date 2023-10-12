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

public class Configuration
{
    /// <summary>
    /// The bucket in which to upload the results. Should already exist and be accessible.
    /// </summary>
    public string ResultBucket { get; set; }

    /// <summary>
    /// The prefix for the bucket created; this then has a timestamp suffix applied.
    /// </summary>
    public string BucketPrefix { get; set; }

    /// <summary>
    /// The location in which to create the bucket.
    /// </summary>
    public string Location { get; set; }

    /// <summary>
    /// The prefix for the results file created; this then has a client type and timestamp suffix applied.
    /// </summary>
    public string ResultsPrefix { get; set; }

    /// <summary>
    /// The number of minutes to run the test for. This specifies when we start creating
    /// new test runs, so the tests can overrun this by a short time.
    /// </summary>
    public int DurationMinutes { get; set; }

    /// <summary>
    /// A map where the key is the size of the object to upload/download (with an optional
    /// suffix of K, M or G for kibibytes, mebibytes or gibibytes), and the
    /// value is the number of iterations to perform per run.
    /// </summary>
    public Dictionary<string, int> SampleIterations { get; set; }

    public List<TestSample> GetSamples() =>
        SampleIterations.Select(TestSample.Create).OrderBy(it => it.Size).ToList();
}

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

using NSubstitute.Core;
using System;
using System.Diagnostics;
using System.Linq;
using Xunit;

namespace Google.Cloud.BigQuery.V2.IntegrationTests;

[Collection(nameof(BigQueryFixture))]
public class BigQueryTimeRangeTest
{
    private readonly BigQueryFixture _fixture;

    public BigQueryTimeRangeTest(BigQueryFixture fixture)
    {
        _fixture = fixture;
    }

    private static readonly DateTime SampleDate1 = new DateTime(2000, 1, 1);
    private static readonly DateTime SampleDate2 = new DateTime(2024, 5, 30);
    private static readonly DateTime SampleDateTime1 = new DateTime(2000, 1, 1, 1, 2, 3).AddTicks(456789_0);
    private static readonly DateTime SampleDateTime2 = new DateTime(2024, 5, 30, 18, 19, 20).AddMilliseconds(987);
    private static readonly DateTime SampleTimestamp1 = DateTime.SpecifyKind(SampleDateTime1, DateTimeKind.Utc);
    private static readonly DateTime SampleTimestamp2 = DateTime.SpecifyKind(SampleDateTime2, DateTimeKind.Utc);

    public static TheoryData<string, BigQueryTimeRange> QueryData = new()
    {
        // Dates
        { "SELECT RANGE<DATE> \"[2000-01-01, 2024-05-30)\"", BigQueryTimeRange.ForDate(SampleDate1, SampleDate2) },
        { "SELECT RANGE<DATE> \"[UNBOUNDED, 2024-05-30)\"", BigQueryTimeRange.ForDate(null, SampleDate2) },
        { "SELECT RANGE<DATE> \"[2000-01-01, UNBOUNDED)\"", BigQueryTimeRange.ForDate(SampleDate1, null) },
        { "SELECT RANGE<DATE> \"[UNBOUNDED, UNBOUNDED)\"", BigQueryTimeRange.ForDate(null, null) },
        // Just to check that using a different literal form in the query doesn't cause problems...
        { "SELECT RANGE<DATE> \"[NULL, 2024-05-30)\"", BigQueryTimeRange.ForDate(null, SampleDate2) },
        { "SELECT RANGE<DATE> \"[2000-01-01, NULL)\"", BigQueryTimeRange.ForDate(SampleDate1, null) },
        { "SELECT RANGE<DATE> \"[NULL, NULL)\"", BigQueryTimeRange.ForDate(null, null) },

        // DateTimes
        { "SELECT RANGE<DATETIME> \"[2000-01-01T01:02:03.456789, 2024-05-30T18:19:20.987)\"", BigQueryTimeRange.ForDateTime(SampleDateTime1, SampleDateTime2) },
        { "SELECT RANGE<DATETIME> \"[UNBOUNDED, 2024-05-30T18:19:20.987)\"", BigQueryTimeRange.ForDateTime(null, SampleDateTime2) },
        { "SELECT RANGE<DATETIME> \"[2000-01-01T01:02:03.456789, UNBOUNDED)\"", BigQueryTimeRange.ForDateTime(SampleDateTime1, null) },
        { "SELECT RANGE<DATETIME> \"[UNBOUNDED, UNBOUNDED)\"", BigQueryTimeRange.ForDateTime(null, null) },

        // Timestamps
        { "SELECT RANGE<TIMESTAMP> \"[2000-01-01T01:02:03.456789Z, 2024-05-30T18:19:20.987Z)\"", BigQueryTimeRange.ForTimestamp(SampleTimestamp1, SampleTimestamp2) },
        { "SELECT RANGE<TIMESTAMP> \"[UNBOUNDED, 2024-05-30T18:19:20.987Z)\"", BigQueryTimeRange.ForTimestamp(null, SampleTimestamp2) },
        { "SELECT RANGE<TIMESTAMP> \"[2000-01-01T01:02:03.456789Z, UNBOUNDED)\"", BigQueryTimeRange.ForTimestamp(SampleTimestamp1, null) },
        { "SELECT RANGE<TIMESTAMP> \"[UNBOUNDED, UNBOUNDED)\"", BigQueryTimeRange.ForTimestamp(null, null) },
    };

    [Theory, MemberData(nameof(QueryData))]
    public void Query(string query, BigQueryTimeRange expectedValue)
    {
        var client = BigQueryClient.Create(_fixture.ProjectId);
        var results = client.ExecuteQuery(query, null);
        var row = results.Single();
        Assert.Equal(expectedValue, row[0]);
    }

    [Fact]
    public void TimestampAsDouble()
    {
        var client = BigQueryClient.Create(_fixture.ProjectId);
        var results = client.ExecuteQuery(
            "SELECT RANGE<TIMESTAMP> \"[2000-01-01T01:02:03.456789Z, 2024-05-30T18:19:20.987Z)\"",
            null,
            resultsOptions: new GetQueryResultsOptions { UseInt64Timestamp = false });
        var row = results.Single();
        string v = (string) row.RawRow.F[0].V;
        Assert.Equal(BigQueryTimeRange.ForTimestamp(SampleTimestamp1, SampleTimestamp2), row[0]);
    }

    [Fact]
    public void NullRange()
    {
        var client = BigQueryClient.Create(_fixture.ProjectId);
        var results = client.ExecuteQuery(
            "SELECT CAST(NULL AS RANGE<TIMESTAMP>)",
            null,
            resultsOptions: new GetQueryResultsOptions { UseInt64Timestamp = false });
        var row = results.Single();
        Assert.Null(row[0]);
    }
}

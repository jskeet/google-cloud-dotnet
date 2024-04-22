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

using System;

namespace Google.Cloud.BigQuery.V2;

/// <summary>
/// A range of chronological values corresponding to BigQuery DATE, DATETIME
/// or TIMESTAMP values.
/// </summary>
public struct BigQueryTimeRange : IEquatable<BigQueryTimeRange>
{
    /// <summary>
    /// 
    /// </summary>
    public DateTime Start { get; }

    /// <summary>
    /// 
    /// </summary>
    public DateTime End { get; }

    /// <summary>
    /// The element type of this range. Currently, only
    /// <see cref="BigQueryDbType.Date"/>, <see cref="BigQueryDbType.DateTime"/>
    /// and <see cref="BigQueryDbType.Timestamp"/> are supported.
    /// </summary>
    public BigQueryDbType RangeElementType { get; }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="start"></param>
    /// <param name="end"></param>
    public BigQueryTimeRange(DateTime start, DateTime end)
    {
        // TODO: Infer the type based on start and end
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="start"></param>
    /// <param name="end"></param>
    /// <param name="rangeElementType"></param>
    public BigQueryTimeRange(DateTime start, DateTime end, BigQueryDbType rangeElementType)
    {
        // TODO: Validate that the element type is appropriate for the kind of start and end
        // TODO: Validate that start is not later than end?
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="start"></param>
    /// <param name="end"></param>
    /// <returns></returns>
    public static BigQueryTimeRange ForDateTime(DateTime start, DateTime end) =>
        new BigQueryTimeRange(start, end, BigQueryDbType.DateTime);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="start"></param>
    /// <param name="end"></param>
    /// <returns></returns>
    public static BigQueryTimeRange ForDate(DateTime start, DateTime end) =>
        new BigQueryTimeRange(start, end, BigQueryDbType.Date);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="start"></param>
    /// <param name="end"></param>
    /// <returns></returns>
    public static BigQueryTimeRange ForTimestamp(DateTime start, DateTime end) =>
        new BigQueryTimeRange(start, end, BigQueryDbType.Timestamp);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="start"></param>
    /// <param name="end"></param>
    /// <returns></returns>
    public static BigQueryTimeRange ForTimestamp(DateTimeOffset start, DateTimeOffset end) =>
        new BigQueryTimeRange(start.UtcDateTime, end.UtcDateTime, BigQueryDbType.Timestamp);

    internal static BigQueryTimeRange Parse(string text, BigQueryDbType rangeElementType)
    {
        return default;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="other"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public bool Equals(BigQueryTimeRange other) => throw new NotImplementedException();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public override bool Equals(object obj) => obj is BigQueryTimeRange other && Equals(other);

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public override int GetHashCode() => 0; // FIXME

    internal string ToJson() => throw new NotImplementedException();

    // TODO: Maybe use ToJson?
    /// <inheritdoc />
    public override string ToString() => base.ToString();
}

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

using Google.Api.Gax;
using Google.Apis.Bigquery.v2.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Globalization;

namespace Google.Cloud.BigQuery.V2;

/// <summary>
/// A range of chronological values corresponding to BigQuery DATE, DATETIME
/// or TIMESTAMP values.
/// </summary>
public struct BigQueryTimeRange : IEquatable<BigQueryTimeRange>
{
    /// <summary>
    /// The start value, expressed as a <see cref="DateTime"/>, or null for
    /// a range which has an unbounded start.
    /// </summary>
    /// <remarks>
    /// If <see cref="RangeElementType"/> is <see cref="BigQueryDbType.Date"/> or
    /// <see cref="BigQueryDbType.DateTime"/>, the <see cref="DateTime.Kind"/>
    /// of the value will always be <see cref="DateTimeKind.Unspecified"/>. If the
    /// <see cref="RangeElementType"/> is <see cref="BigQueryDbType.Timestamp"/>,
    /// the <see cref="DateTime.Kind"/> of the value will always be
    /// <see cref="DateTimeKind.Utc"/>.
    /// </remarks>
    public DateTime? Start { get; }

    /// <summary>
    /// The end value, expressed as a <see cref="DateTime"/>, or null for
    /// a range which has an unbounded end.
    /// </summary>
    public DateTime? End { get; }

    /// <summary>
    /// The element type of this range. Currently, only
    /// <see cref="BigQueryDbType.Date"/>, <see cref="BigQueryDbType.DateTime"/>
    /// and <see cref="BigQueryDbType.Timestamp"/> are supported.
    /// </summary>
    public BigQueryDbType RangeElementType { get; }

    /// <summary>
    /// Constructs a new range with the specified bounds and range element type.
    /// </summary>
    /// <remarks>
    /// The range element type must be <see cref="BigQueryDbType.Date"/>,
    /// <see cref="BigQueryDbType.DateTime"/> or <see cref="BigQueryDbType.Timestamp"/>,
    /// and if the start/end values are non-null, they must have an appropropriate <see cref="DateTime.Kind"/>:
    /// a DATE or DATETIME value must always have a kind of <see cref="DateTimeKind.Unspecified"/>,
    /// whereas a TIMESTAMP value must always have a kind of <see cref="DateTimeKind.Utc"/>.
    /// </remarks>
    /// <param name="start">The start of the range, or null if the range should have an unbounded start.</param>
    /// <param name="end">The end of the range, or null if the range should have an unbounded end.</param>
    /// <param name="rangeElementType">The element type of the range.</param>
    public BigQueryTimeRange(DateTime? start, DateTime? end, BigQueryDbType rangeElementType)
    {
        GaxPreconditions.CheckArgument(
            rangeElementType != BigQueryDbType.Date ||
            rangeElementType != BigQueryDbType.DateTime ||
            rangeElementType != BigQueryDbType.Timestamp,
            nameof(rangeElementType), "Range element type must be Date, DateTime or Timestamp");

        ValidateKind(start, nameof(start));
        ValidateKind(end, nameof(start));
        // TODO: Check that BQ itself guarantees this.
        // Note: this is not the same as start <= end, due to nullability.
        GaxPreconditions.CheckArgument(!(end < start),
            nameof(end), "The start of a range must not be later than the end.");

        RangeElementType = rangeElementType;
        Start = start;
        End = end;

        void ValidateKind(DateTime? value, string paramName)
        {
            if (value is not DateTime { Kind: DateTimeKind kind })
            {
                return;
            }
            switch (rangeElementType)
            {
                case BigQueryDbType.Date:
                case BigQueryDbType.DateTime:
                    GaxPreconditions.CheckArgument(kind == DateTimeKind.Unspecified,
                        paramName, "Values in a {0} range must have a Kind of Unspecified", rangeElementType);
                    break;
                case BigQueryDbType.Timestamp:
                    GaxPreconditions.CheckArgument(kind == DateTimeKind.Utc,
                        paramName, "Values in a {0} range must have a Kind of Utc", rangeElementType);
                    break;
            }
        }
    }

    /// <summary>
    /// Constructs a new range with a range element type of <see cref="BigQueryDbType.DateTime"/>.
    /// </summary>
    /// <param name="start">The start of the range, or null if the range should have an unbounded start.</param>
    /// <param name="end">The end of the range, or null if the range should have an unbounded end.</param>
    /// <returns>A range for the given values.</returns>
    public static BigQueryTimeRange ForDateTime(DateTime? start, DateTime? end) =>
        new(start, end, BigQueryDbType.DateTime);

    /// <summary>
    /// Constructs a new range with a range element type of <see cref="BigQueryDbType.Date"/>.
    /// </summary>
    /// <param name="start">The start of the range, or null if the range should have an unbounded start.</param>
    /// <param name="end">The end of the range, or null if the range should have an unbounded end.</param>
    /// <returns>A range for the given values.</returns>
    public static BigQueryTimeRange ForDate(DateTime? start, DateTime? end) =>
        new(start, end, BigQueryDbType.Date);

    /// <summary>
    /// Constructs a new range with a range element type of <see cref="BigQueryDbType.Timestamp"/>.
    /// </summary>
    /// <param name="start">The start of the range, or null if the range should have an unbounded start.</param>
    /// <param name="end">The end of the range, or null if the range should have an unbounded end.</param>
    /// <returns>A range for the given values.</returns>
    public static BigQueryTimeRange ForTimestamp(DateTime? start, DateTime? end) =>
        new(start, end, BigQueryDbType.Timestamp);

    /// <summary>
    /// Constructs a new range with a range element type of <see cref="BigQueryDbType.Timestamp"/>.
    /// </summary>
    /// <remarks>The values are converted to UTC as part of constructing the range; the same instant
    /// of time is represented in the result, but the original information about the UTC offset is lost.</remarks>
    /// <param name="start">The start of the range, or null if the range should have an unbounded start.</param>
    /// <param name="end">The end of the range, or null if the range should have an unbounded end.</param>
    /// <returns>A range for the given values.</returns>
    public static BigQueryTimeRange ForTimestamp(DateTimeOffset? start, DateTimeOffset? end) =>
        ForTimestamp(start?.UtcDateTime, end?.UtcDateTime);

    /// <summary>
    /// Parses the given value as a range. The expected format is "[start, end)"
    /// where "start" and "end" are either "NULL" or a value of the appropriate type,
    /// parsed by <paramref name="elementConverter"/>.
    /// </summary>
    /// <param name="text"></param>
    /// <param name="rangeElementType"></param>
    /// <param name="elementConverter">The converter to use on each non-empty bound..</param>
    /// <returns>A range parsed from the given value.</returns>
    internal static BigQueryTimeRange Parse(string text, BigQueryDbType rangeElementType, Func<string, DateTime> elementConverter)
    {
        GaxPreconditions.CheckNotNull(text, nameof(text));
        GaxPreconditions.CheckArgument(
            rangeElementType != BigQueryDbType.Date ||
            rangeElementType != BigQueryDbType.DateTime ||
            rangeElementType != BigQueryDbType.Timestamp,
            nameof(rangeElementType), "Range element type must be Date, DateTime or Timestamp");
        if (!text.StartsWith("[", StringComparison.Ordinal) ||
            !text.EndsWith(")", StringComparison.Ordinal))
        {
            throw new ArgumentException($"Invalid range literal '{text}'", nameof(text));
        }

        // Note: this is pretty inefficient, but it's simple to understand. We can optimize
        // later if necessary.
        string inner = text.Substring(1, text.Length - 2);
        string[] bits = inner.Split(',');
        if (bits.Length != 2)
        {
            throw new ArgumentException($"Invalid range literal '{text}'", nameof(text));
        }
        var start = bits[0].Trim();
        var end = bits[1].Trim();

        return new BigQueryTimeRange(ConvertValue(start), ConvertValue(end), rangeElementType);

        DateTime? ConvertValue(string value) =>
            value.Equals("NULL", StringComparison.OrdinalIgnoreCase) ||
            value.Equals("UNBOUNDED", StringComparison.OrdinalIgnoreCase)
            ? null
            : elementConverter(value);
    }

    /// <inheritdoc />
    public bool Equals(BigQueryTimeRange other) =>
        RangeElementType == other.RangeElementType &&
        Start == other.Start &&
        End == other.End;

    /// <inheritdoc />
    public override bool Equals(object obj) => obj is BigQueryTimeRange other && Equals(other);

    /// <inheritdoc />
    public override int GetHashCode() => GaxEqualityHelpers.CombineHashCodes(
        (int) RangeElementType,
        Start?.GetHashCode() ?? 0,
        End?.GetHashCode() ?? 0);

    internal InsertRowJson ToInsertRowJson()
    {
        var rangeElementType = RangeElementType;
        return new InsertRowJson { Start = Convert(Start), End = Convert(End) };

        string Convert(DateTime? value)
        {
            if (value is not DateTime v)
            {
                return null;
            }
            return rangeElementType switch
            {
                BigQueryDbType.Date => v.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture),
                BigQueryDbType.DateTime => v.ToString("yyyy-MM-dd'T'HH:mm:ss.FFFFFF", CultureInfo.InvariantCulture),
                // TODO: Check if this is okay... we could convert to microseconds.
                BigQueryDbType.Timestamp => v.ToString("yyyy-MM-dd'T'HH:mm:ss.FFFFFF'Z'", CultureInfo.InvariantCulture),
                _ => throw new InvalidOperationException($"Invalid range element type {rangeElementType}")
            };
        }
    }

    /// <inheritdoc />
    public override string ToString()
    {
        var rangeElementType = RangeElementType;
        return $"RANGE<{EnumMap.ToApiValue(RangeElementType)}> \"[{Convert(Start)}, {Convert(End)})\"";

        string Convert(DateTime? value)
        {
            if (value is not DateTime v)
            {
                return "UNBOUNDED";
            }
            return rangeElementType switch
            {
                BigQueryDbType.Date => v.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture),
                BigQueryDbType.DateTime => v.ToString("yyyy-MM-dd'T'HH:mm:ss.FFFFFF", CultureInfo.InvariantCulture),
                BigQueryDbType.Timestamp => v.ToString("yyyy-MM-dd'T'HH:mm:ss.FFFFFF'Z'", CultureInfo.InvariantCulture),
                _ => throw new InvalidOperationException($"Invalid range element type {rangeElementType}")
            };
        }
    }

    /// <summary>
    /// Converts this range to a <see cref="RangeValue"/> for use in query parameters.
    /// </summary>
    internal RangeValue ToRangeValue()
    {
        var rangeElementType = RangeElementType;
        return new RangeValue { Start = Convert(Start), End = Convert(End) };

        QueryParameterValue Convert(DateTime? value)
        {
            if (value is not DateTime v)
            {
                return null;
            }
            string text = rangeElementType switch
            {
                BigQueryDbType.Date => v.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture),
                BigQueryDbType.DateTime => v.ToString("yyyy-MM-dd'T'HH:mm:ss.FFFFFF", CultureInfo.InvariantCulture),
                // TODO: Check if this is okay... we could convert to microseconds.
                BigQueryDbType.Timestamp => v.ToString("yyyy-MM-dd'T'HH:mm:ss.FFFFFF'Z'", CultureInfo.InvariantCulture),
                _ => throw new InvalidOperationException($"Invalid range element type {rangeElementType}")
            };
            return new QueryParameterValue { Value = text };
        }
    }

    internal class InsertRowJson
    {
        [JsonProperty("start")]
        internal string Start { get; set; }

        [JsonProperty("end")]
        internal string End { get; set; }
    }
}

// Copyright 2016 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Apis.Bigquery.v2.Data;

namespace Google.Cloud.BigQuery.V2
{
    /// <summary>
    /// Extension methods over table schema fields.
    /// </summary>
    public static class TableFieldSchemaExtensions
    {
        /// <summary>
        /// Returns the type of a field as a <see cref="BigQueryDbType"/>.
        /// </summary>
        internal static BigQueryDbType GetFieldType(this TableFieldSchema field) =>
            EnumMap<BigQueryDbType>.ToValue(field.Type);

        /// <summary>
        /// Returns the mode of a field as a <see cref="BigQueryFieldMode"/>.
        /// If the mode isn't specified, it defaults to Nullable.
        /// </summary>
        internal static BigQueryFieldMode GetFieldMode(this TableFieldSchema field) =>
            field.Mode == null ? BigQueryFieldMode.Nullable : EnumMap<BigQueryFieldMode>.ToValue(field.Mode);

        /// <summary>
        /// Returns the range element type of the given schema field
        /// </summary>
        /// <param name="field">The field to determine the range element type of.</param>
        /// <returns>The range element type of the field, or null if the field type is not a range.</returns>
        public static BigQueryDbType? GetRangeElementType(this TableFieldSchema field) =>
            field.RangeElementType?.Type is string rangeElementType
            ? EnumMap<BigQueryDbType>.ToValue(rangeElementType)
            : null;

        /// <summary>
        /// Sets the range element type of the given schema field.
        /// </summary>
        /// <param name="field">The field to set the range element type on.</param>
        /// <param name="rangeElementType">The range element type, or null to clear any existing range element type.</param>
        public static void SetRangeElementType(this TableFieldSchema field, BigQueryDbType? rangeElementType) =>
            field.RangeElementType = rangeElementType is null
                ? null
                : new() { Type = EnumMap.ToApiValue(rangeElementType.Value) };
    }
}

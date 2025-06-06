// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Agents.Persistent
{
    /// <summary> Possible API response formats. </summary>
    public readonly partial struct ResponseFormat : IEquatable<ResponseFormat>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ResponseFormat"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ResponseFormat(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TextValue = "text";
        private const string JsonObjectValue = "json_object";

        /// <summary> `text` format should be used for requests involving any sort of ToolCall. </summary>
        public static ResponseFormat Text { get; } = new ResponseFormat(TextValue);
        /// <summary> Using `json_object` format will limit the usage of ToolCall to only functions. </summary>
        public static ResponseFormat JsonObject { get; } = new ResponseFormat(JsonObjectValue);
        /// <summary> Determines if two <see cref="ResponseFormat"/> values are the same. </summary>
        public static bool operator ==(ResponseFormat left, ResponseFormat right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ResponseFormat"/> values are not the same. </summary>
        public static bool operator !=(ResponseFormat left, ResponseFormat right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ResponseFormat"/>. </summary>
        public static implicit operator ResponseFormat(string value) => new ResponseFormat(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ResponseFormat other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ResponseFormat other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Define the destination's element. The element is the body or the attributes of the message, to which the json array mapper will write the output map. </summary>
    public readonly partial struct PipelineGroupJsonMapperElement : IEquatable<PipelineGroupJsonMapperElement>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PipelineGroupJsonMapperElement"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PipelineGroupJsonMapperElement(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BodyValue = "body";
        private const string AttributesValue = "attributes";

        /// <summary> Read or write the json array from or to the body of the message. </summary>
        public static PipelineGroupJsonMapperElement Body { get; } = new PipelineGroupJsonMapperElement(BodyValue);
        /// <summary> Read or write the json array from or to the attributes of the message. </summary>
        public static PipelineGroupJsonMapperElement Attributes { get; } = new PipelineGroupJsonMapperElement(AttributesValue);
        /// <summary> Determines if two <see cref="PipelineGroupJsonMapperElement"/> values are the same. </summary>
        public static bool operator ==(PipelineGroupJsonMapperElement left, PipelineGroupJsonMapperElement right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PipelineGroupJsonMapperElement"/> values are not the same. </summary>
        public static bool operator !=(PipelineGroupJsonMapperElement left, PipelineGroupJsonMapperElement right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="PipelineGroupJsonMapperElement"/>. </summary>
        public static implicit operator PipelineGroupJsonMapperElement(string value) => new PipelineGroupJsonMapperElement(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PipelineGroupJsonMapperElement other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PipelineGroupJsonMapperElement other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

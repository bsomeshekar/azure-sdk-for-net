// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.RedisEnterprise.Models
{
    /// <summary> Clustering policy - default is OSSCluster. This property can be updated only if the current value is NoCluster. If the value is OSSCluster or EnterpriseCluster, it cannot be updated without deleting the database. </summary>
    public readonly partial struct RedisEnterpriseClusteringPolicy : IEquatable<RedisEnterpriseClusteringPolicy>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RedisEnterpriseClusteringPolicy"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RedisEnterpriseClusteringPolicy(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnterpriseClusterValue = "EnterpriseCluster";
        private const string OssClusterValue = "OSSCluster";
        private const string NoClusterValue = "NoCluster";

        /// <summary> Enterprise clustering policy uses only the classic redis protocol, which does not support redis cluster commands. </summary>
        public static RedisEnterpriseClusteringPolicy EnterpriseCluster { get; } = new RedisEnterpriseClusteringPolicy(EnterpriseClusterValue);
        /// <summary> OSS clustering policy follows the redis cluster specification, and requires all clients to support redis clustering. </summary>
        public static RedisEnterpriseClusteringPolicy OssCluster { get; } = new RedisEnterpriseClusteringPolicy(OssClusterValue);
        /// <summary> The NoCluster policy is used for non-clustered Redis instances that do not require clustering features. </summary>
        public static RedisEnterpriseClusteringPolicy NoCluster { get; } = new RedisEnterpriseClusteringPolicy(NoClusterValue);
        /// <summary> Determines if two <see cref="RedisEnterpriseClusteringPolicy"/> values are the same. </summary>
        public static bool operator ==(RedisEnterpriseClusteringPolicy left, RedisEnterpriseClusteringPolicy right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RedisEnterpriseClusteringPolicy"/> values are not the same. </summary>
        public static bool operator !=(RedisEnterpriseClusteringPolicy left, RedisEnterpriseClusteringPolicy right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="RedisEnterpriseClusteringPolicy"/>. </summary>
        public static implicit operator RedisEnterpriseClusteringPolicy(string value) => new RedisEnterpriseClusteringPolicy(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RedisEnterpriseClusteringPolicy other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RedisEnterpriseClusteringPolicy other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

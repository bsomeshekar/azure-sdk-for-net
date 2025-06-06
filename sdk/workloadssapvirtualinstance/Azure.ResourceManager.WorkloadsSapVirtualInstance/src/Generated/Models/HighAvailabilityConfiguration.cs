// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.WorkloadsSapVirtualInstance.Models
{
    /// <summary> Gets or sets the high availability configuration. </summary>
    internal partial class HighAvailabilityConfiguration
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="HighAvailabilityConfiguration"/>. </summary>
        /// <param name="highAvailabilityType"> The high availability type. </param>
        public HighAvailabilityConfiguration(SapHighAvailabilityType highAvailabilityType)
        {
            HighAvailabilityType = highAvailabilityType;
        }

        /// <summary> Initializes a new instance of <see cref="HighAvailabilityConfiguration"/>. </summary>
        /// <param name="highAvailabilityType"> The high availability type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal HighAvailabilityConfiguration(SapHighAvailabilityType highAvailabilityType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            HighAvailabilityType = highAvailabilityType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="HighAvailabilityConfiguration"/> for deserialization. </summary>
        internal HighAvailabilityConfiguration()
        {
        }

        /// <summary> The high availability type. </summary>
        public SapHighAvailabilityType HighAvailabilityType { get; set; }
    }
}

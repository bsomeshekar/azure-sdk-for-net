// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    public partial class EdgeOrderStageDetails : IUtf8JsonSerializable, IJsonModel<EdgeOrderStageDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EdgeOrderStageDetails>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<EdgeOrderStageDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeOrderStageDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EdgeOrderStageDetails)} does not support writing '{format}' format.");
            }

            if (options.Format != "W" && Optional.IsDefined(StageStatus))
            {
                writer.WritePropertyName("stageStatus"u8);
                writer.WriteStringValue(StageStatus.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(StageName))
            {
                writer.WritePropertyName("stageName"u8);
                writer.WriteStringValue(StageName.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (options.Format != "W" && Optional.IsDefined(StartOn))
            {
                writer.WritePropertyName("startTime"u8);
                writer.WriteStringValue(StartOn.Value, "O");
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value, ModelSerializationExtensions.JsonDocumentOptions))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        EdgeOrderStageDetails IJsonModel<EdgeOrderStageDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeOrderStageDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EdgeOrderStageDetails)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEdgeOrderStageDetails(document.RootElement, options);
        }

        internal static EdgeOrderStageDetails DeserializeEdgeOrderStageDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            EdgeOrderStageStatus? stageStatus = default;
            EdgeOrderStageName? stageName = default;
            string displayName = default;
            DateTimeOffset? startTime = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("stageStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    stageStatus = new EdgeOrderStageStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("stageName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    stageName = new EdgeOrderStageName(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new EdgeOrderStageDetails(stageStatus, stageName, displayName, startTime, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<EdgeOrderStageDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeOrderStageDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerEdgeOrderContext.Default);
                default:
                    throw new FormatException($"The model {nameof(EdgeOrderStageDetails)} does not support writing '{options.Format}' format.");
            }
        }

        EdgeOrderStageDetails IPersistableModel<EdgeOrderStageDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EdgeOrderStageDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeEdgeOrderStageDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EdgeOrderStageDetails)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<EdgeOrderStageDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

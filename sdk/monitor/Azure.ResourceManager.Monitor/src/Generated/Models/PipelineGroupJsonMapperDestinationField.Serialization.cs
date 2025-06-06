// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    public partial class PipelineGroupJsonMapperDestinationField : IUtf8JsonSerializable, IJsonModel<PipelineGroupJsonMapperDestinationField>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PipelineGroupJsonMapperDestinationField>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<PipelineGroupJsonMapperDestinationField>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PipelineGroupJsonMapperDestinationField>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PipelineGroupJsonMapperDestinationField)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Destination))
            {
                writer.WritePropertyName("destination"u8);
                writer.WriteStringValue(Destination.Value.ToString());
            }
            if (Optional.IsDefined(FieldName))
            {
                writer.WritePropertyName("fieldName"u8);
                writer.WriteStringValue(FieldName);
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

        PipelineGroupJsonMapperDestinationField IJsonModel<PipelineGroupJsonMapperDestinationField>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PipelineGroupJsonMapperDestinationField>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PipelineGroupJsonMapperDestinationField)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePipelineGroupJsonMapperDestinationField(document.RootElement, options);
        }

        internal static PipelineGroupJsonMapperDestinationField DeserializePipelineGroupJsonMapperDestinationField(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            PipelineGroupJsonMapperElement? destination = default;
            string fieldName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("destination"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    destination = new PipelineGroupJsonMapperElement(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("fieldName"u8))
                {
                    fieldName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new PipelineGroupJsonMapperDestinationField(destination, fieldName, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PipelineGroupJsonMapperDestinationField>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PipelineGroupJsonMapperDestinationField>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerMonitorContext.Default);
                default:
                    throw new FormatException($"The model {nameof(PipelineGroupJsonMapperDestinationField)} does not support writing '{options.Format}' format.");
            }
        }

        PipelineGroupJsonMapperDestinationField IPersistableModel<PipelineGroupJsonMapperDestinationField>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PipelineGroupJsonMapperDestinationField>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializePipelineGroupJsonMapperDestinationField(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PipelineGroupJsonMapperDestinationField)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PipelineGroupJsonMapperDestinationField>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ContainerService.Models
{
    public partial class ContainerServiceDateSpan : IUtf8JsonSerializable, IJsonModel<ContainerServiceDateSpan>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContainerServiceDateSpan>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ContainerServiceDateSpan>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceDateSpan>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerServiceDateSpan)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("start"u8);
            writer.WriteStringValue(Start, "D");
            writer.WritePropertyName("end"u8);
            writer.WriteStringValue(End, "D");
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

        ContainerServiceDateSpan IJsonModel<ContainerServiceDateSpan>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceDateSpan>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContainerServiceDateSpan)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContainerServiceDateSpan(document.RootElement, options);
        }

        internal static ContainerServiceDateSpan DeserializeContainerServiceDateSpan(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset start = default;
            DateTimeOffset end = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("start"u8))
                {
                    start = property.Value.GetDateTimeOffset("D");
                    continue;
                }
                if (property.NameEquals("end"u8))
                {
                    end = property.Value.GetDateTimeOffset("D");
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ContainerServiceDateSpan(start, end, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Start), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  start: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  start: ");
                var formattedDateTimeString = TypeFormatters.ToString(Start, "o");
                builder.AppendLine($"'{formattedDateTimeString}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(End), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  end: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  end: ");
                var formattedDateTimeString = TypeFormatters.ToString(End, "o");
                builder.AppendLine($"'{formattedDateTimeString}'");
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ContainerServiceDateSpan>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceDateSpan>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerContainerServiceContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ContainerServiceDateSpan)} does not support writing '{options.Format}' format.");
            }
        }

        ContainerServiceDateSpan IPersistableModel<ContainerServiceDateSpan>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContainerServiceDateSpan>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeContainerServiceDateSpan(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContainerServiceDateSpan)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContainerServiceDateSpan>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

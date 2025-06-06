// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class VirtualMachineCaptureContent : IUtf8JsonSerializable, IJsonModel<VirtualMachineCaptureContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VirtualMachineCaptureContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<VirtualMachineCaptureContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineCaptureContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineCaptureContent)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("vhdPrefix"u8);
            writer.WriteStringValue(VhdPrefix);
            writer.WritePropertyName("destinationContainerName"u8);
            writer.WriteStringValue(DestinationContainerName);
            writer.WritePropertyName("overwriteVhds"u8);
            writer.WriteBooleanValue(OverwriteVhds);
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

        VirtualMachineCaptureContent IJsonModel<VirtualMachineCaptureContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineCaptureContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VirtualMachineCaptureContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVirtualMachineCaptureContent(document.RootElement, options);
        }

        internal static VirtualMachineCaptureContent DeserializeVirtualMachineCaptureContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string vhdPrefix = default;
            string destinationContainerName = default;
            bool overwriteVhds = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("vhdPrefix"u8))
                {
                    vhdPrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("destinationContainerName"u8))
                {
                    destinationContainerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("overwriteVhds"u8))
                {
                    overwriteVhds = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new VirtualMachineCaptureContent(vhdPrefix, destinationContainerName, overwriteVhds, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VirtualMachineCaptureContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineCaptureContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerComputeContext.Default);
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineCaptureContent)} does not support writing '{options.Format}' format.");
            }
        }

        VirtualMachineCaptureContent IPersistableModel<VirtualMachineCaptureContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VirtualMachineCaptureContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeVirtualMachineCaptureContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VirtualMachineCaptureContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VirtualMachineCaptureContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

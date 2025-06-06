// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class AkamaiSignatureHeaderAuthenticationKey : IUtf8JsonSerializable, IJsonModel<AkamaiSignatureHeaderAuthenticationKey>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AkamaiSignatureHeaderAuthenticationKey>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AkamaiSignatureHeaderAuthenticationKey>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AkamaiSignatureHeaderAuthenticationKey>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AkamaiSignatureHeaderAuthenticationKey)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Identifier))
            {
                writer.WritePropertyName("identifier"u8);
                writer.WriteStringValue(Identifier);
            }
            if (Optional.IsDefined(Base64Key))
            {
                writer.WritePropertyName("base64Key"u8);
                writer.WriteStringValue(Base64Key);
            }
            if (Optional.IsDefined(ExpireOn))
            {
                writer.WritePropertyName("expiration"u8);
                writer.WriteStringValue(ExpireOn.Value, "O");
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

        AkamaiSignatureHeaderAuthenticationKey IJsonModel<AkamaiSignatureHeaderAuthenticationKey>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AkamaiSignatureHeaderAuthenticationKey>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AkamaiSignatureHeaderAuthenticationKey)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAkamaiSignatureHeaderAuthenticationKey(document.RootElement, options);
        }

        internal static AkamaiSignatureHeaderAuthenticationKey DeserializeAkamaiSignatureHeaderAuthenticationKey(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string identifier = default;
            string base64Key = default;
            DateTimeOffset? expiration = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("identifier"u8))
                {
                    identifier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("base64Key"u8))
                {
                    base64Key = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("expiration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiration = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AkamaiSignatureHeaderAuthenticationKey(identifier, base64Key, expiration, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AkamaiSignatureHeaderAuthenticationKey>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AkamaiSignatureHeaderAuthenticationKey>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerMediaContext.Default);
                default:
                    throw new FormatException($"The model {nameof(AkamaiSignatureHeaderAuthenticationKey)} does not support writing '{options.Format}' format.");
            }
        }

        AkamaiSignatureHeaderAuthenticationKey IPersistableModel<AkamaiSignatureHeaderAuthenticationKey>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AkamaiSignatureHeaderAuthenticationKey>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeAkamaiSignatureHeaderAuthenticationKey(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AkamaiSignatureHeaderAuthenticationKey)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AkamaiSignatureHeaderAuthenticationKey>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

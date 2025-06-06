// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Vision.Face
{
    internal partial class VerifyFromLargePersonGroupRequest : IUtf8JsonSerializable, IJsonModel<VerifyFromLargePersonGroupRequest>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VerifyFromLargePersonGroupRequest>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<VerifyFromLargePersonGroupRequest>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VerifyFromLargePersonGroupRequest>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VerifyFromLargePersonGroupRequest)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("faceId"u8);
            writer.WriteStringValue(FaceId);
            writer.WritePropertyName("largePersonGroupId"u8);
            writer.WriteStringValue(LargePersonGroupId);
            writer.WritePropertyName("personId"u8);
            writer.WriteStringValue(PersonId);
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

        VerifyFromLargePersonGroupRequest IJsonModel<VerifyFromLargePersonGroupRequest>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VerifyFromLargePersonGroupRequest>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VerifyFromLargePersonGroupRequest)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVerifyFromLargePersonGroupRequest(document.RootElement, options);
        }

        internal static VerifyFromLargePersonGroupRequest DeserializeVerifyFromLargePersonGroupRequest(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Guid faceId = default;
            string largePersonGroupId = default;
            Guid personId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("faceId"u8))
                {
                    faceId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("largePersonGroupId"u8))
                {
                    largePersonGroupId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("personId"u8))
                {
                    personId = property.Value.GetGuid();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new VerifyFromLargePersonGroupRequest(faceId, largePersonGroupId, personId, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VerifyFromLargePersonGroupRequest>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VerifyFromLargePersonGroupRequest>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureAIVisionFaceContext.Default);
                default:
                    throw new FormatException($"The model {nameof(VerifyFromLargePersonGroupRequest)} does not support writing '{options.Format}' format.");
            }
        }

        VerifyFromLargePersonGroupRequest IPersistableModel<VerifyFromLargePersonGroupRequest>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VerifyFromLargePersonGroupRequest>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeVerifyFromLargePersonGroupRequest(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VerifyFromLargePersonGroupRequest)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<VerifyFromLargePersonGroupRequest>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static VerifyFromLargePersonGroupRequest FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeVerifyFromLargePersonGroupRequest(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}

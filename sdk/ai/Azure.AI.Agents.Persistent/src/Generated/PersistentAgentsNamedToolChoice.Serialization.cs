// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Agents.Persistent
{
    public partial class PersistentAgentsNamedToolChoice : IUtf8JsonSerializable, IJsonModel<PersistentAgentsNamedToolChoice>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PersistentAgentsNamedToolChoice>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<PersistentAgentsNamedToolChoice>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PersistentAgentsNamedToolChoice>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PersistentAgentsNamedToolChoice)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type.ToString());
            if (Optional.IsDefined(Function))
            {
                writer.WritePropertyName("function"u8);
                writer.WriteObjectValue(Function, options);
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

        PersistentAgentsNamedToolChoice IJsonModel<PersistentAgentsNamedToolChoice>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PersistentAgentsNamedToolChoice>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PersistentAgentsNamedToolChoice)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePersistentAgentsNamedToolChoice(document.RootElement, options);
        }

        internal static PersistentAgentsNamedToolChoice DeserializePersistentAgentsNamedToolChoice(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            PersistentAgentsNamedToolChoiceType type = default;
            FunctionName function = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = new PersistentAgentsNamedToolChoiceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("function"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    function = FunctionName.DeserializeFunctionName(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new PersistentAgentsNamedToolChoice(type, function, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PersistentAgentsNamedToolChoice>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PersistentAgentsNamedToolChoice>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureAIAgentsPersistentContext.Default);
                default:
                    throw new FormatException($"The model {nameof(PersistentAgentsNamedToolChoice)} does not support writing '{options.Format}' format.");
            }
        }

        PersistentAgentsNamedToolChoice IPersistableModel<PersistentAgentsNamedToolChoice>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PersistentAgentsNamedToolChoice>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializePersistentAgentsNamedToolChoice(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PersistentAgentsNamedToolChoice)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<PersistentAgentsNamedToolChoice>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static PersistentAgentsNamedToolChoice FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializePersistentAgentsNamedToolChoice(document.RootElement);
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

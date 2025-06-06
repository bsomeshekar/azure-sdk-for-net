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
    public partial class UpdateToolResourcesOptions : IUtf8JsonSerializable, IJsonModel<UpdateToolResourcesOptions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UpdateToolResourcesOptions>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<UpdateToolResourcesOptions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateToolResourcesOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UpdateToolResourcesOptions)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(CodeInterpreter))
            {
                writer.WritePropertyName("code_interpreter"u8);
                writer.WriteObjectValue(CodeInterpreter, options);
            }
            if (Optional.IsDefined(FileSearch))
            {
                writer.WritePropertyName("file_search"u8);
                writer.WriteObjectValue(FileSearch, options);
            }
            if (Optional.IsDefined(AzureAISearch))
            {
                writer.WritePropertyName("azure_ai_search"u8);
                writer.WriteObjectValue(AzureAISearch, options);
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

        UpdateToolResourcesOptions IJsonModel<UpdateToolResourcesOptions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateToolResourcesOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UpdateToolResourcesOptions)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUpdateToolResourcesOptions(document.RootElement, options);
        }

        internal static UpdateToolResourcesOptions DeserializeUpdateToolResourcesOptions(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            UpdateCodeInterpreterToolResourceOptions codeInterpreter = default;
            UpdateFileSearchToolResourceOptions fileSearch = default;
            AzureAISearchResource azureAiSearch = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code_interpreter"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    codeInterpreter = UpdateCodeInterpreterToolResourceOptions.DeserializeUpdateCodeInterpreterToolResourceOptions(property.Value, options);
                    continue;
                }
                if (property.NameEquals("file_search"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fileSearch = UpdateFileSearchToolResourceOptions.DeserializeUpdateFileSearchToolResourceOptions(property.Value, options);
                    continue;
                }
                if (property.NameEquals("azure_ai_search"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureAiSearch = AzureAISearchResource.DeserializeAzureAISearchResource(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new UpdateToolResourcesOptions(codeInterpreter, fileSearch, azureAiSearch, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<UpdateToolResourcesOptions>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateToolResourcesOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureAIAgentsPersistentContext.Default);
                default:
                    throw new FormatException($"The model {nameof(UpdateToolResourcesOptions)} does not support writing '{options.Format}' format.");
            }
        }

        UpdateToolResourcesOptions IPersistableModel<UpdateToolResourcesOptions>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UpdateToolResourcesOptions>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeUpdateToolResourcesOptions(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(UpdateToolResourcesOptions)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<UpdateToolResourcesOptions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static UpdateToolResourcesOptions FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content, ModelSerializationExtensions.JsonDocumentOptions);
            return DeserializeUpdateToolResourcesOptions(document.RootElement);
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

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ResourceGraph.Models
{
    public partial class ResourceQueryContent : IUtf8JsonSerializable, IJsonModel<ResourceQueryContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ResourceQueryContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ResourceQueryContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceQueryContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceQueryContent)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(Subscriptions))
            {
                writer.WritePropertyName("subscriptions"u8);
                writer.WriteStartArray();
                foreach (var item in Subscriptions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ManagementGroups))
            {
                writer.WritePropertyName("managementGroups"u8);
                writer.WriteStartArray();
                foreach (var item in ManagementGroups)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("query"u8);
            writer.WriteStringValue(Query);
            if (Optional.IsDefined(Options))
            {
                writer.WritePropertyName("options"u8);
                writer.WriteObjectValue(Options, options);
            }
            if (Optional.IsCollectionDefined(Facets))
            {
                writer.WritePropertyName("facets"u8);
                writer.WriteStartArray();
                foreach (var item in Facets)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
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

        ResourceQueryContent IJsonModel<ResourceQueryContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceQueryContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ResourceQueryContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceQueryContent(document.RootElement, options);
        }

        internal static ResourceQueryContent DeserializeResourceQueryContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> subscriptions = default;
            IList<string> managementGroups = default;
            string query = default;
            ResourceQueryRequestOptions options0 = default;
            IList<FacetRequest> facets = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("subscriptions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    subscriptions = array;
                    continue;
                }
                if (property.NameEquals("managementGroups"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    managementGroups = array;
                    continue;
                }
                if (property.NameEquals("query"u8))
                {
                    query = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("options"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    options0 = ResourceQueryRequestOptions.DeserializeResourceQueryRequestOptions(property.Value, options);
                    continue;
                }
                if (property.NameEquals("facets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FacetRequest> array = new List<FacetRequest>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FacetRequest.DeserializeFacetRequest(item, options));
                    }
                    facets = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ResourceQueryContent(
                subscriptions ?? new ChangeTrackingList<string>(),
                managementGroups ?? new ChangeTrackingList<string>(),
                query,
                options0,
                facets ?? new ChangeTrackingList<FacetRequest>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ResourceQueryContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceQueryContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerResourceGraphContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ResourceQueryContent)} does not support writing '{options.Format}' format.");
            }
        }

        ResourceQueryContent IPersistableModel<ResourceQueryContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ResourceQueryContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeResourceQueryContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ResourceQueryContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ResourceQueryContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

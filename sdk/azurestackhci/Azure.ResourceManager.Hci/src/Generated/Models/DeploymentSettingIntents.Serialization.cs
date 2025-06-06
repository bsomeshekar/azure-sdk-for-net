// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Hci.Models
{
    public partial class DeploymentSettingIntents : IUtf8JsonSerializable, IJsonModel<DeploymentSettingIntents>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DeploymentSettingIntents>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DeploymentSettingIntents>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeploymentSettingIntents>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeploymentSettingIntents)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsCollectionDefined(TrafficType))
            {
                writer.WritePropertyName("trafficType"u8);
                writer.WriteStartArray();
                foreach (var item in TrafficType)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Adapter))
            {
                writer.WritePropertyName("adapter"u8);
                writer.WriteStartArray();
                foreach (var item in Adapter)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(OverrideVirtualSwitchConfiguration))
            {
                writer.WritePropertyName("overrideVirtualSwitchConfiguration"u8);
                writer.WriteBooleanValue(OverrideVirtualSwitchConfiguration.Value);
            }
            if (Optional.IsDefined(VirtualSwitchConfigurationOverrides))
            {
                writer.WritePropertyName("virtualSwitchConfigurationOverrides"u8);
                writer.WriteObjectValue(VirtualSwitchConfigurationOverrides, options);
            }
            if (Optional.IsDefined(OverrideQosPolicy))
            {
                writer.WritePropertyName("overrideQosPolicy"u8);
                writer.WriteBooleanValue(OverrideQosPolicy.Value);
            }
            if (Optional.IsDefined(QosPolicyOverrides))
            {
                writer.WritePropertyName("qosPolicyOverrides"u8);
                writer.WriteObjectValue(QosPolicyOverrides, options);
            }
            if (Optional.IsDefined(OverrideAdapterProperty))
            {
                writer.WritePropertyName("overrideAdapterProperty"u8);
                writer.WriteBooleanValue(OverrideAdapterProperty.Value);
            }
            if (Optional.IsDefined(AdapterPropertyOverrides))
            {
                writer.WritePropertyName("adapterPropertyOverrides"u8);
                writer.WriteObjectValue(AdapterPropertyOverrides, options);
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

        DeploymentSettingIntents IJsonModel<DeploymentSettingIntents>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeploymentSettingIntents>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DeploymentSettingIntents)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDeploymentSettingIntents(document.RootElement, options);
        }

        internal static DeploymentSettingIntents DeserializeDeploymentSettingIntents(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            IList<string> trafficType = default;
            IList<string> adapter = default;
            bool? overrideVirtualSwitchConfiguration = default;
            DeploymentSettingVirtualSwitchConfigurationOverrides virtualSwitchConfigurationOverrides = default;
            bool? overrideQosPolicy = default;
            DeploymentSettingQosPolicyOverrides qosPolicyOverrides = default;
            bool? overrideAdapterProperty = default;
            DeploymentSettingAdapterPropertyOverrides adapterPropertyOverrides = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("trafficType"u8))
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
                    trafficType = array;
                    continue;
                }
                if (property.NameEquals("adapter"u8))
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
                    adapter = array;
                    continue;
                }
                if (property.NameEquals("overrideVirtualSwitchConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    overrideVirtualSwitchConfiguration = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("virtualSwitchConfigurationOverrides"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    virtualSwitchConfigurationOverrides = DeploymentSettingVirtualSwitchConfigurationOverrides.DeserializeDeploymentSettingVirtualSwitchConfigurationOverrides(property.Value, options);
                    continue;
                }
                if (property.NameEquals("overrideQosPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    overrideQosPolicy = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("qosPolicyOverrides"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    qosPolicyOverrides = DeploymentSettingQosPolicyOverrides.DeserializeDeploymentSettingQosPolicyOverrides(property.Value, options);
                    continue;
                }
                if (property.NameEquals("overrideAdapterProperty"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    overrideAdapterProperty = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("adapterPropertyOverrides"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    adapterPropertyOverrides = DeploymentSettingAdapterPropertyOverrides.DeserializeDeploymentSettingAdapterPropertyOverrides(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DeploymentSettingIntents(
                name,
                trafficType ?? new ChangeTrackingList<string>(),
                adapter ?? new ChangeTrackingList<string>(),
                overrideVirtualSwitchConfiguration,
                virtualSwitchConfigurationOverrides,
                overrideQosPolicy,
                qosPolicyOverrides,
                overrideAdapterProperty,
                adapterPropertyOverrides,
                serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Name), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  name: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Name))
                {
                    builder.Append("  name: ");
                    if (Name.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Name}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Name}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(TrafficType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  trafficType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(TrafficType))
                {
                    if (TrafficType.Any())
                    {
                        builder.Append("  trafficType: ");
                        builder.AppendLine("[");
                        foreach (var item in TrafficType)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("    '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"    '{item}'");
                            }
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Adapter), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  adapter: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Adapter))
                {
                    if (Adapter.Any())
                    {
                        builder.Append("  adapter: ");
                        builder.AppendLine("[");
                        foreach (var item in Adapter)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("    '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"    '{item}'");
                            }
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(OverrideVirtualSwitchConfiguration), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  overrideVirtualSwitchConfiguration: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(OverrideVirtualSwitchConfiguration))
                {
                    builder.Append("  overrideVirtualSwitchConfiguration: ");
                    var boolValue = OverrideVirtualSwitchConfiguration.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(VirtualSwitchConfigurationOverrides), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  virtualSwitchConfigurationOverrides: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(VirtualSwitchConfigurationOverrides))
                {
                    builder.Append("  virtualSwitchConfigurationOverrides: ");
                    BicepSerializationHelpers.AppendChildObject(builder, VirtualSwitchConfigurationOverrides, options, 2, false, "  virtualSwitchConfigurationOverrides: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(OverrideQosPolicy), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  overrideQosPolicy: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(OverrideQosPolicy))
                {
                    builder.Append("  overrideQosPolicy: ");
                    var boolValue = OverrideQosPolicy.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(QosPolicyOverrides), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  qosPolicyOverrides: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(QosPolicyOverrides))
                {
                    builder.Append("  qosPolicyOverrides: ");
                    BicepSerializationHelpers.AppendChildObject(builder, QosPolicyOverrides, options, 2, false, "  qosPolicyOverrides: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(OverrideAdapterProperty), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  overrideAdapterProperty: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(OverrideAdapterProperty))
                {
                    builder.Append("  overrideAdapterProperty: ");
                    var boolValue = OverrideAdapterProperty.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AdapterPropertyOverrides), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  adapterPropertyOverrides: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AdapterPropertyOverrides))
                {
                    builder.Append("  adapterPropertyOverrides: ");
                    BicepSerializationHelpers.AppendChildObject(builder, AdapterPropertyOverrides, options, 2, false, "  adapterPropertyOverrides: ");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<DeploymentSettingIntents>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeploymentSettingIntents>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, AzureResourceManagerHciContext.Default);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(DeploymentSettingIntents)} does not support writing '{options.Format}' format.");
            }
        }

        DeploymentSettingIntents IPersistableModel<DeploymentSettingIntents>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DeploymentSettingIntents>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data, ModelSerializationExtensions.JsonDocumentOptions);
                        return DeserializeDeploymentSettingIntents(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DeploymentSettingIntents)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DeploymentSettingIntents>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.EventGrid
{
    public partial class NamespaceTopicResource : IJsonModel<NamespaceTopicData>
    {
        void IJsonModel<NamespaceTopicData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<NamespaceTopicData>)Data).Write(writer, options);

        NamespaceTopicData IJsonModel<NamespaceTopicData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<NamespaceTopicData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<NamespaceTopicData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<NamespaceTopicData>(Data, options, AzureResourceManagerEventGridContext.Default);

        NamespaceTopicData IPersistableModel<NamespaceTopicData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<NamespaceTopicData>(data, options, AzureResourceManagerEventGridContext.Default);

        string IPersistableModel<NamespaceTopicData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<NamespaceTopicData>)Data).GetFormatFromOptions(options);
    }
}

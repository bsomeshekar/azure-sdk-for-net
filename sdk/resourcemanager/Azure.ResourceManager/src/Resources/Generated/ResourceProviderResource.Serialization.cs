// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Resources
{
    public partial class ResourceProviderResource : IJsonModel<ResourceProviderData>
    {
        void IJsonModel<ResourceProviderData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ResourceProviderData>)Data).Write(writer, options);

        ResourceProviderData IJsonModel<ResourceProviderData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ResourceProviderData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<ResourceProviderData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<ResourceProviderData>(Data, options, AzureResourceManagerContext.Default);

        ResourceProviderData IPersistableModel<ResourceProviderData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ResourceProviderData>(data, options, AzureResourceManagerContext.Default);

        string IPersistableModel<ResourceProviderData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ResourceProviderData>)Data).GetFormatFromOptions(options);
    }
}

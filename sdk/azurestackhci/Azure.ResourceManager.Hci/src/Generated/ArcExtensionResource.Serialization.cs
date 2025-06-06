// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Hci
{
    public partial class ArcExtensionResource : IJsonModel<ArcExtensionData>
    {
        void IJsonModel<ArcExtensionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ArcExtensionData>)Data).Write(writer, options);

        ArcExtensionData IJsonModel<ArcExtensionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ArcExtensionData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<ArcExtensionData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<ArcExtensionData>(Data, options, AzureResourceManagerHciContext.Default);

        ArcExtensionData IPersistableModel<ArcExtensionData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ArcExtensionData>(data, options, AzureResourceManagerHciContext.Default);

        string IPersistableModel<ArcExtensionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ArcExtensionData>)Data).GetFormatFromOptions(options);
    }
}

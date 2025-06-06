// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Network
{
    public partial class ProbeResource : IJsonModel<ProbeData>
    {
        void IJsonModel<ProbeData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<ProbeData>)Data).Write(writer, options);

        ProbeData IJsonModel<ProbeData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<ProbeData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<ProbeData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<ProbeData>(Data, options, AzureResourceManagerNetworkContext.Default);

        ProbeData IPersistableModel<ProbeData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<ProbeData>(data, options, AzureResourceManagerNetworkContext.Default);

        string IPersistableModel<ProbeData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<ProbeData>)Data).GetFormatFromOptions(options);
    }
}

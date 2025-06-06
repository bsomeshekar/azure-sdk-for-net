// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.Purview
{
    public partial class PurviewPrivateEndpointConnectionResource : IJsonModel<PurviewPrivateEndpointConnectionData>
    {
        void IJsonModel<PurviewPrivateEndpointConnectionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<PurviewPrivateEndpointConnectionData>)Data).Write(writer, options);

        PurviewPrivateEndpointConnectionData IJsonModel<PurviewPrivateEndpointConnectionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<PurviewPrivateEndpointConnectionData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<PurviewPrivateEndpointConnectionData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<PurviewPrivateEndpointConnectionData>(Data, options, AzureResourceManagerPurviewContext.Default);

        PurviewPrivateEndpointConnectionData IPersistableModel<PurviewPrivateEndpointConnectionData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<PurviewPrivateEndpointConnectionData>(data, options, AzureResourceManagerPurviewContext.Default);

        string IPersistableModel<PurviewPrivateEndpointConnectionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<PurviewPrivateEndpointConnectionData>)Data).GetFormatFromOptions(options);
    }
}

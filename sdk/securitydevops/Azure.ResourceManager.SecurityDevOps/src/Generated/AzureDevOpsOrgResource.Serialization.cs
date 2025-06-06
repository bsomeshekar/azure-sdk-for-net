// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.SecurityDevOps
{
    public partial class AzureDevOpsOrgResource : IJsonModel<AzureDevOpsOrgData>
    {
        void IJsonModel<AzureDevOpsOrgData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<AzureDevOpsOrgData>)Data).Write(writer, options);

        AzureDevOpsOrgData IJsonModel<AzureDevOpsOrgData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<AzureDevOpsOrgData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<AzureDevOpsOrgData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<AzureDevOpsOrgData>(Data, options, AzureResourceManagerSecurityDevOpsContext.Default);

        AzureDevOpsOrgData IPersistableModel<AzureDevOpsOrgData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<AzureDevOpsOrgData>(data, options, AzureResourceManagerSecurityDevOpsContext.Default);

        string IPersistableModel<AzureDevOpsOrgData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<AzureDevOpsOrgData>)Data).GetFormatFromOptions(options);
    }
}

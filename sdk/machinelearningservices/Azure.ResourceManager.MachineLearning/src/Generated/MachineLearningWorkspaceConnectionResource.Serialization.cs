// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;

namespace Azure.ResourceManager.MachineLearning
{
    public partial class MachineLearningWorkspaceConnectionResource : IJsonModel<MachineLearningWorkspaceConnectionData>
    {
        void IJsonModel<MachineLearningWorkspaceConnectionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<MachineLearningWorkspaceConnectionData>)Data).Write(writer, options);

        MachineLearningWorkspaceConnectionData IJsonModel<MachineLearningWorkspaceConnectionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<MachineLearningWorkspaceConnectionData>)Data).Create(ref reader, options);

        BinaryData IPersistableModel<MachineLearningWorkspaceConnectionData>.Write(ModelReaderWriterOptions options) => ModelReaderWriter.Write<MachineLearningWorkspaceConnectionData>(Data, options, AzureResourceManagerMachineLearningContext.Default);

        MachineLearningWorkspaceConnectionData IPersistableModel<MachineLearningWorkspaceConnectionData>.Create(BinaryData data, ModelReaderWriterOptions options) => ModelReaderWriter.Read<MachineLearningWorkspaceConnectionData>(data, options, AzureResourceManagerMachineLearningContext.Default);

        string IPersistableModel<MachineLearningWorkspaceConnectionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => ((IPersistableModel<MachineLearningWorkspaceConnectionData>)Data).GetFormatFromOptions(options);
    }
}

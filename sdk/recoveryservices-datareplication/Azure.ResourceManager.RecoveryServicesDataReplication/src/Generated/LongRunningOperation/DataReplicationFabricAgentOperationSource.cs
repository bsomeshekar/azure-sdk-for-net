// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesDataReplication
{
    internal class DataReplicationFabricAgentOperationSource : IOperationSource<DataReplicationFabricAgentResource>
    {
        private readonly ArmClient _client;

        internal DataReplicationFabricAgentOperationSource(ArmClient client)
        {
            _client = client;
        }

        DataReplicationFabricAgentResource IOperationSource<DataReplicationFabricAgentResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<DataReplicationFabricAgentData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerRecoveryServicesDataReplicationContext.Default);
            return new DataReplicationFabricAgentResource(_client, data);
        }

        async ValueTask<DataReplicationFabricAgentResource> IOperationSource<DataReplicationFabricAgentResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<DataReplicationFabricAgentData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerRecoveryServicesDataReplicationContext.Default);
            return await Task.FromResult(new DataReplicationFabricAgentResource(_client, data)).ConfigureAwait(false);
        }
    }
}

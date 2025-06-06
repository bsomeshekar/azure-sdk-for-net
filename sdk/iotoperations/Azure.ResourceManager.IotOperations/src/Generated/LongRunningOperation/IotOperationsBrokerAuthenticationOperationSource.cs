// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.ClientModel.Primitives;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.IotOperations
{
    internal class IotOperationsBrokerAuthenticationOperationSource : IOperationSource<IotOperationsBrokerAuthenticationResource>
    {
        private readonly ArmClient _client;

        internal IotOperationsBrokerAuthenticationOperationSource(ArmClient client)
        {
            _client = client;
        }

        IotOperationsBrokerAuthenticationResource IOperationSource<IotOperationsBrokerAuthenticationResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<IotOperationsBrokerAuthenticationData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerIotOperationsContext.Default);
            return new IotOperationsBrokerAuthenticationResource(_client, data);
        }

        async ValueTask<IotOperationsBrokerAuthenticationResource> IOperationSource<IotOperationsBrokerAuthenticationResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            var data = ModelReaderWriter.Read<IotOperationsBrokerAuthenticationData>(response.Content, ModelReaderWriterOptions.Json, AzureResourceManagerIotOperationsContext.Default);
            return await Task.FromResult(new IotOperationsBrokerAuthenticationResource(_client, data)).ConfigureAwait(false);
        }
    }
}

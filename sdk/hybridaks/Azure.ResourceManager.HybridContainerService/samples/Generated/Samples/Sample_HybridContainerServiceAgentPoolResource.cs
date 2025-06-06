// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager.HybridContainerService.Models;
using NUnit.Framework;

namespace Azure.ResourceManager.HybridContainerService.Samples
{
    public partial class Sample_HybridContainerServiceAgentPoolResource
    {
        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Get_GetAgentPool()
        {
            // Generated from example definition: specification/hybridaks/resource-manager/Microsoft.HybridContainerService/stable/2024-01-01/examples/GetAgentPool.json
            // this example is just showing the usage of "agentPool_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HybridContainerServiceAgentPoolResource created on azure
            // for more information of creating HybridContainerServiceAgentPoolResource, please refer to the document of HybridContainerServiceAgentPoolResource
            string connectedClusterResourceUri = "subscriptions/fd3c3665-1729-4b7b-9a38-238e83b0f98b/resourceGroups/testrg/providers/Microsoft.Kubernetes/connectedClusters/test-hybridakscluster";
            string agentPoolName = "testnodepool";
            ResourceIdentifier hybridContainerServiceAgentPoolResourceId = HybridContainerServiceAgentPoolResource.CreateResourceIdentifier(connectedClusterResourceUri, agentPoolName);
            HybridContainerServiceAgentPoolResource hybridContainerServiceAgentPool = client.GetHybridContainerServiceAgentPoolResource(hybridContainerServiceAgentPoolResourceId);

            // invoke the operation
            HybridContainerServiceAgentPoolResource result = await hybridContainerServiceAgentPool.GetAsync();

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HybridContainerServiceAgentPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Delete_DeleteAgentPool()
        {
            // Generated from example definition: specification/hybridaks/resource-manager/Microsoft.HybridContainerService/stable/2024-01-01/examples/DeleteAgentPool.json
            // this example is just showing the usage of "agentPool_Delete" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HybridContainerServiceAgentPoolResource created on azure
            // for more information of creating HybridContainerServiceAgentPoolResource, please refer to the document of HybridContainerServiceAgentPoolResource
            string connectedClusterResourceUri = "subscriptions/fd3c3665-1729-4b7b-9a38-238e83b0f98b/resourceGroups/testrg/providers/Microsoft.Kubernetes/connectedClusters/test-hybridakscluster";
            string agentPoolName = "testnodepool";
            ResourceIdentifier hybridContainerServiceAgentPoolResourceId = HybridContainerServiceAgentPoolResource.CreateResourceIdentifier(connectedClusterResourceUri, agentPoolName);
            HybridContainerServiceAgentPoolResource hybridContainerServiceAgentPool = client.GetHybridContainerServiceAgentPoolResource(hybridContainerServiceAgentPoolResourceId);

            // invoke the operation
            await hybridContainerServiceAgentPool.DeleteAsync(WaitUntil.Completed);

            Console.WriteLine("Succeeded");
        }

        [Test]
        [Ignore("Only validating compilation of examples")]
        public async Task Update_PutAgentPool()
        {
            // Generated from example definition: specification/hybridaks/resource-manager/Microsoft.HybridContainerService/stable/2024-01-01/examples/PutAgentPool.json
            // this example is just showing the usage of "agentPool_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this HybridContainerServiceAgentPoolResource created on azure
            // for more information of creating HybridContainerServiceAgentPoolResource, please refer to the document of HybridContainerServiceAgentPoolResource
            string connectedClusterResourceUri = "subscriptions/fd3c3665-1729-4b7b-9a38-238e83b0f98b/resourceGroups/testrg/providers/Microsoft.Kubernetes/connectedClusters/test-hybridakscluster";
            string agentPoolName = "testnodepool";
            ResourceIdentifier hybridContainerServiceAgentPoolResourceId = HybridContainerServiceAgentPoolResource.CreateResourceIdentifier(connectedClusterResourceUri, agentPoolName);
            HybridContainerServiceAgentPoolResource hybridContainerServiceAgentPool = client.GetHybridContainerServiceAgentPoolResource(hybridContainerServiceAgentPoolResourceId);

            // invoke the operation
            HybridContainerServiceAgentPoolData data = new HybridContainerServiceAgentPoolData
            {
                OSType = HybridContainerServiceOSType.Linux,
                NodeLabels =
{
["env"] = "dev",
["goal"] = "test"
},
                NodeTaints = { "env=prod:NoSchedule", "sku=gpu:NoSchedule" },
                Count = 1,
                VmSize = "Standard_A4_v2",
            };
            ArmOperation<HybridContainerServiceAgentPoolResource> lro = await hybridContainerServiceAgentPool.UpdateAsync(WaitUntil.Completed, data);
            HybridContainerServiceAgentPoolResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            HybridContainerServiceAgentPoolData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }
    }
}

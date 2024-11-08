// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.Sql;

/// <summary>
/// Properties of a private endpoint connection.
/// </summary>
public partial class ServerPrivateEndpointConnectionProperties : ProvisionableConstruct
{
    /// <summary>
    /// Gets or sets Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> PrivateEndpointId 
    {
        get { Initialize(); return _privateEndpointId!; }
    }
    private BicepValue<ResourceIdentifier>? _privateEndpointId;

    /// <summary>
    /// Group IDs.
    /// </summary>
    public BicepList<string> GroupIds 
    {
        get { Initialize(); return _groupIds!; }
    }
    private BicepList<string>? _groupIds;

    /// <summary>
    /// Connection state of the private endpoint connection.
    /// </summary>
    public SqlPrivateLinkServiceConnectionStateProperty ConnectionState 
    {
        get { Initialize(); return _connectionState!; }
    }
    private SqlPrivateLinkServiceConnectionStateProperty? _connectionState;

    /// <summary>
    /// State of the private endpoint connection.
    /// </summary>
    public BicepValue<SqlPrivateEndpointProvisioningState> ProvisioningState 
    {
        get { Initialize(); return _provisioningState!; }
    }
    private BicepValue<SqlPrivateEndpointProvisioningState>? _provisioningState;

    /// <summary>
    /// Creates a new ServerPrivateEndpointConnectionProperties.
    /// </summary>
    public ServerPrivateEndpointConnectionProperties()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// ServerPrivateEndpointConnectionProperties.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _privateEndpointId = DefineProperty<ResourceIdentifier>("PrivateEndpointId", ["privateEndpoint", "id"], isOutput: true);
        _groupIds = DefineListProperty<string>("GroupIds", ["groupIds"], isOutput: true);
        _connectionState = DefineModelProperty<SqlPrivateLinkServiceConnectionStateProperty>("ConnectionState", ["privateLinkServiceConnectionState"], isOutput: true);
        _provisioningState = DefineProperty<SqlPrivateEndpointProvisioningState>("ProvisioningState", ["provisioningState"], isOutput: true);
    }
}

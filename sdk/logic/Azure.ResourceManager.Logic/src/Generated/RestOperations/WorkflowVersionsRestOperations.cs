// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Logic.Models;

namespace Azure.ResourceManager.Logic
{
    internal partial class WorkflowVersionsRestOperations
    {
        private readonly TelemetryDetails _userAgent;
        private readonly HttpPipeline _pipeline;
        private readonly Uri _endpoint;
        private readonly string _apiVersion;

        /// <summary> Initializes a new instance of WorkflowVersionsRestOperations. </summary>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="applicationId"> The application id to use for user agent. </param>
        /// <param name="endpoint"> server parameter. </param>
        /// <param name="apiVersion"> Api Version. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="pipeline"/> or <paramref name="apiVersion"/> is null. </exception>
        public WorkflowVersionsRestOperations(HttpPipeline pipeline, string applicationId, Uri endpoint = null, string apiVersion = default)
        {
            _pipeline = pipeline ?? throw new ArgumentNullException(nameof(pipeline));
            _endpoint = endpoint ?? new Uri("https://management.azure.com");
            _apiVersion = apiVersion ?? "2019-05-01";
            _userAgent = new TelemetryDetails(GetType().Assembly, applicationId);
        }

        internal RequestUriBuilder CreateListRequestUri(string subscriptionId, string resourceGroupName, string workflowName, int? top)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Logic/workflows/", false);
            uri.AppendPath(workflowName, true);
            uri.AppendPath("/versions", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (top != null)
            {
                uri.AppendQuery("$top", top.Value, true);
            }
            return uri;
        }

        internal HttpMessage CreateListRequest(string subscriptionId, string resourceGroupName, string workflowName, int? top)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Logic/workflows/", false);
            uri.AppendPath(workflowName, true);
            uri.AppendPath("/versions", false);
            uri.AppendQuery("api-version", _apiVersion, true);
            if (top != null)
            {
                uri.AppendQuery("$top", top.Value, true);
            }
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets a list of workflow versions. </summary>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="workflowName"> The workflow name. </param>
        /// <param name="top"> The number of items to be included in the result. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="workflowName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="workflowName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<LogicWorkflowVersionListResult>> ListAsync(string subscriptionId, string resourceGroupName, string workflowName, int? top = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(workflowName, nameof(workflowName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, workflowName, top);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LogicWorkflowVersionListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = LogicWorkflowVersionListResult.DeserializeLogicWorkflowVersionListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets a list of workflow versions. </summary>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="workflowName"> The workflow name. </param>
        /// <param name="top"> The number of items to be included in the result. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="workflowName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="workflowName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<LogicWorkflowVersionListResult> List(string subscriptionId, string resourceGroupName, string workflowName, int? top = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(workflowName, nameof(workflowName));

            using var message = CreateListRequest(subscriptionId, resourceGroupName, workflowName, top);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LogicWorkflowVersionListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = LogicWorkflowVersionListResult.DeserializeLogicWorkflowVersionListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateGetRequestUri(string subscriptionId, string resourceGroupName, string workflowName, string versionId)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Logic/workflows/", false);
            uri.AppendPath(workflowName, true);
            uri.AppendPath("/versions/", false);
            uri.AppendPath(versionId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            return uri;
        }

        internal HttpMessage CreateGetRequest(string subscriptionId, string resourceGroupName, string workflowName, string versionId)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendPath("/subscriptions/", false);
            uri.AppendPath(subscriptionId, true);
            uri.AppendPath("/resourceGroups/", false);
            uri.AppendPath(resourceGroupName, true);
            uri.AppendPath("/providers/Microsoft.Logic/workflows/", false);
            uri.AppendPath(workflowName, true);
            uri.AppendPath("/versions/", false);
            uri.AppendPath(versionId, true);
            uri.AppendQuery("api-version", _apiVersion, true);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets a workflow version. </summary>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="workflowName"> The workflow name. </param>
        /// <param name="versionId"> The workflow versionId. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workflowName"/> or <paramref name="versionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workflowName"/> or <paramref name="versionId"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<LogicWorkflowVersionData>> GetAsync(string subscriptionId, string resourceGroupName, string workflowName, string versionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(workflowName, nameof(workflowName));
            Argument.AssertNotNullOrEmpty(versionId, nameof(versionId));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, workflowName, versionId);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LogicWorkflowVersionData value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = LogicWorkflowVersionData.DeserializeLogicWorkflowVersionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((LogicWorkflowVersionData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets a workflow version. </summary>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="workflowName"> The workflow name. </param>
        /// <param name="versionId"> The workflow versionId. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workflowName"/> or <paramref name="versionId"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/>, <paramref name="workflowName"/> or <paramref name="versionId"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<LogicWorkflowVersionData> Get(string subscriptionId, string resourceGroupName, string workflowName, string versionId, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(workflowName, nameof(workflowName));
            Argument.AssertNotNullOrEmpty(versionId, nameof(versionId));

            using var message = CreateGetRequest(subscriptionId, resourceGroupName, workflowName, versionId);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LogicWorkflowVersionData value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = LogicWorkflowVersionData.DeserializeLogicWorkflowVersionData(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                case 404:
                    return Response.FromValue((LogicWorkflowVersionData)null, message.Response);
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        internal RequestUriBuilder CreateListNextPageRequestUri(string nextLink, string subscriptionId, string resourceGroupName, string workflowName, int? top)
        {
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            return uri;
        }

        internal HttpMessage CreateListNextPageRequest(string nextLink, string subscriptionId, string resourceGroupName, string workflowName, int? top)
        {
            var message = _pipeline.CreateMessage();
            var request = message.Request;
            request.Method = RequestMethod.Get;
            var uri = new RawRequestUriBuilder();
            uri.Reset(_endpoint);
            uri.AppendRawNextLink(nextLink, false);
            request.Uri = uri;
            request.Headers.Add("Accept", "application/json");
            _userAgent.Apply(message);
            return message;
        }

        /// <summary> Gets a list of workflow versions. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="workflowName"> The workflow name. </param>
        /// <param name="top"> The number of items to be included in the result. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="workflowName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="workflowName"/> is an empty string, and was expected to be non-empty. </exception>
        public async Task<Response<LogicWorkflowVersionListResult>> ListNextPageAsync(string nextLink, string subscriptionId, string resourceGroupName, string workflowName, int? top = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(workflowName, nameof(workflowName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, workflowName, top);
            await _pipeline.SendAsync(message, cancellationToken).ConfigureAwait(false);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LogicWorkflowVersionListResult value = default;
                        using var document = await JsonDocument.ParseAsync(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions, cancellationToken).ConfigureAwait(false);
                        value = LogicWorkflowVersionListResult.DeserializeLogicWorkflowVersionListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }

        /// <summary> Gets a list of workflow versions. </summary>
        /// <param name="nextLink"> The URL to the next page of results. </param>
        /// <param name="subscriptionId"> The subscription id. </param>
        /// <param name="resourceGroupName"> The resource group name. </param>
        /// <param name="workflowName"> The workflow name. </param>
        /// <param name="top"> The number of items to be included in the result. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nextLink"/>, <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="workflowName"/> is null. </exception>
        /// <exception cref="ArgumentException"> <paramref name="subscriptionId"/>, <paramref name="resourceGroupName"/> or <paramref name="workflowName"/> is an empty string, and was expected to be non-empty. </exception>
        public Response<LogicWorkflowVersionListResult> ListNextPage(string nextLink, string subscriptionId, string resourceGroupName, string workflowName, int? top = null, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(nextLink, nameof(nextLink));
            Argument.AssertNotNullOrEmpty(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNullOrEmpty(resourceGroupName, nameof(resourceGroupName));
            Argument.AssertNotNullOrEmpty(workflowName, nameof(workflowName));

            using var message = CreateListNextPageRequest(nextLink, subscriptionId, resourceGroupName, workflowName, top);
            _pipeline.Send(message, cancellationToken);
            switch (message.Response.Status)
            {
                case 200:
                    {
                        LogicWorkflowVersionListResult value = default;
                        using var document = JsonDocument.Parse(message.Response.ContentStream, ModelSerializationExtensions.JsonDocumentOptions);
                        value = LogicWorkflowVersionListResult.DeserializeLogicWorkflowVersionListResult(document.RootElement);
                        return Response.FromValue(value, message.Response);
                    }
                default:
                    throw new RequestFailedException(message.Response);
            }
        }
    }
}

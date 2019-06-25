// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ApiManagement
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PolicySnippetOperations.
    /// </summary>
    public static partial class PolicySnippetOperationsExtensions
    {
            /// <summary>
            /// Lists all policy snippets.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='scope'>
            /// Policy scope. Possible values include: 'Tenant', 'Product', 'Api',
            /// 'Operation', 'All'
            /// </param>
            public static PolicySnippetsCollection ListByService(this IPolicySnippetOperations operations, string resourceGroupName, string serviceName, PolicyScopeContract? scope = default(PolicyScopeContract?))
            {
                return operations.ListByServiceAsync(resourceGroupName, serviceName, scope).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all policy snippets.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='serviceName'>
            /// The name of the API Management service.
            /// </param>
            /// <param name='scope'>
            /// Policy scope. Possible values include: 'Tenant', 'Product', 'Api',
            /// 'Operation', 'All'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PolicySnippetsCollection> ListByServiceAsync(this IPolicySnippetOperations operations, string resourceGroupName, string serviceName, PolicyScopeContract? scope = default(PolicyScopeContract?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByServiceWithHttpMessagesAsync(resourceGroupName, serviceName, scope, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
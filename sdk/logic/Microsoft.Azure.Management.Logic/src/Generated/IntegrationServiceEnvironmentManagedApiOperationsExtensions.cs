// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Logic
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for IntegrationServiceEnvironmentManagedApiOperations.
    /// </summary>
    public static partial class IntegrationServiceEnvironmentManagedApiOperationsExtensions
    {
            /// <summary>
            /// Gets the managed Api operations.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroup'>
            /// The resource group.
            /// </param>
            /// <param name='integrationServiceEnvironmentName'>
            /// The integration service environment name.
            /// </param>
            /// <param name='apiName'>
            /// The api name.
            /// </param>
            public static IPage<ApiOperation> List(this IIntegrationServiceEnvironmentManagedApiOperations operations, string resourceGroup, string integrationServiceEnvironmentName, string apiName)
            {
                return operations.ListAsync(resourceGroup, integrationServiceEnvironmentName, apiName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the managed Api operations.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroup'>
            /// The resource group.
            /// </param>
            /// <param name='integrationServiceEnvironmentName'>
            /// The integration service environment name.
            /// </param>
            /// <param name='apiName'>
            /// The api name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ApiOperation>> ListAsync(this IIntegrationServiceEnvironmentManagedApiOperations operations, string resourceGroup, string integrationServiceEnvironmentName, string apiName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroup, integrationServiceEnvironmentName, apiName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets the managed Api operations.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ApiOperation> ListNext(this IIntegrationServiceEnvironmentManagedApiOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the managed Api operations.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ApiOperation>> ListNextAsync(this IIntegrationServiceEnvironmentManagedApiOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}

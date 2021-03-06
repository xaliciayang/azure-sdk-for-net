// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DigitalTwins
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PrivateLinkResourcesOperations.
    /// </summary>
    public static partial class PrivateLinkResourcesOperationsExtensions
    {
            /// <summary>
            /// List private link resources for given Digital Twin.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the DigitalTwinsInstance.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the DigitalTwinsInstance.
            /// </param>
            public static GroupIdInformationResponse List(this IPrivateLinkResourcesOperations operations, string resourceGroupName, string resourceName)
            {
                return operations.ListAsync(resourceGroupName, resourceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List private link resources for given Digital Twin.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the DigitalTwinsInstance.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the DigitalTwinsInstance.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GroupIdInformationResponse> ListAsync(this IPrivateLinkResourcesOperations operations, string resourceGroupName, string resourceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, resourceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get the specified private link resource for the given Digital Twin.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the DigitalTwinsInstance.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the DigitalTwinsInstance.
            /// </param>
            /// <param name='resourceId'>
            /// The name of the private link resource.
            /// </param>
            public static GroupIdInformation Get(this IPrivateLinkResourcesOperations operations, string resourceGroupName, string resourceName, string resourceId)
            {
                return operations.GetAsync(resourceGroupName, resourceName, resourceId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get the specified private link resource for the given Digital Twin.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group that contains the DigitalTwinsInstance.
            /// </param>
            /// <param name='resourceName'>
            /// The name of the DigitalTwinsInstance.
            /// </param>
            /// <param name='resourceId'>
            /// The name of the private link resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GroupIdInformation> GetAsync(this IPrivateLinkResourcesOperations operations, string resourceGroupName, string resourceName, string resourceId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, resourceName, resourceId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}

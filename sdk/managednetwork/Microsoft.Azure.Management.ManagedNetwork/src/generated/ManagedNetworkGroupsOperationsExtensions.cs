// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ManagedNetwork
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ManagedNetworkGroupsOperations.
    /// </summary>
    public static partial class ManagedNetworkGroupsOperationsExtensions
    {
            /// <summary>
            /// The Get ManagedNetworkGroups operation gets a Managed Network Group
            /// specified by the resource group, Managed Network name, and group name
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='managedNetworkName'>
            /// The name of the Managed Network.
            /// </param>
            /// <param name='managedNetworkGroupName'>
            /// The name of the Managed Network Group.
            /// </param>
            public static ManagedNetworkGroup Get(this IManagedNetworkGroupsOperations operations, string resourceGroupName, string managedNetworkName, string managedNetworkGroupName)
            {
                return operations.GetAsync(resourceGroupName, managedNetworkName, managedNetworkGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Get ManagedNetworkGroups operation gets a Managed Network Group
            /// specified by the resource group, Managed Network name, and group name
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='managedNetworkName'>
            /// The name of the Managed Network.
            /// </param>
            /// <param name='managedNetworkGroupName'>
            /// The name of the Managed Network Group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ManagedNetworkGroup> GetAsync(this IManagedNetworkGroupsOperations operations, string resourceGroupName, string managedNetworkName, string managedNetworkGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, managedNetworkName, managedNetworkGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The Put ManagedNetworkGroups operation creates or updates a Managed Network
            /// Group resource
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='managedNetworkGroup'>
            /// Parameters supplied to the create/update a Managed Network Group resource
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='managedNetworkName'>
            /// The name of the Managed Network.
            /// </param>
            /// <param name='managedNetworkGroupName'>
            /// The name of the Managed Network Group.
            /// </param>
            public static ManagedNetworkGroup CreateOrUpdate(this IManagedNetworkGroupsOperations operations, ManagedNetworkGroup managedNetworkGroup, string resourceGroupName, string managedNetworkName, string managedNetworkGroupName)
            {
                return operations.CreateOrUpdateAsync(managedNetworkGroup, resourceGroupName, managedNetworkName, managedNetworkGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Put ManagedNetworkGroups operation creates or updates a Managed Network
            /// Group resource
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='managedNetworkGroup'>
            /// Parameters supplied to the create/update a Managed Network Group resource
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='managedNetworkName'>
            /// The name of the Managed Network.
            /// </param>
            /// <param name='managedNetworkGroupName'>
            /// The name of the Managed Network Group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ManagedNetworkGroup> CreateOrUpdateAsync(this IManagedNetworkGroupsOperations operations, ManagedNetworkGroup managedNetworkGroup, string resourceGroupName, string managedNetworkName, string managedNetworkGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(managedNetworkGroup, resourceGroupName, managedNetworkName, managedNetworkGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The Delete ManagedNetworkGroups operation deletes a Managed Network Group
            /// specified by the resource group, Managed Network name, and group name
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='managedNetworkName'>
            /// The name of the Managed Network.
            /// </param>
            /// <param name='managedNetworkGroupName'>
            /// The name of the Managed Network Group.
            /// </param>
            public static void Delete(this IManagedNetworkGroupsOperations operations, string resourceGroupName, string managedNetworkName, string managedNetworkGroupName)
            {
                operations.DeleteAsync(resourceGroupName, managedNetworkName, managedNetworkGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Delete ManagedNetworkGroups operation deletes a Managed Network Group
            /// specified by the resource group, Managed Network name, and group name
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='managedNetworkName'>
            /// The name of the Managed Network.
            /// </param>
            /// <param name='managedNetworkGroupName'>
            /// The name of the Managed Network Group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IManagedNetworkGroupsOperations operations, string resourceGroupName, string managedNetworkName, string managedNetworkGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, managedNetworkName, managedNetworkGroupName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// The ListByManagedNetwork ManagedNetworkGroup operation retrieves all the
            /// Managed Network Groups in a specified Managed Networks in a paginated
            /// format.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='managedNetworkName'>
            /// The name of the Managed Network.
            /// </param>
            /// <param name='top'>
            /// May be used to limit the number of results in a page for list queries.
            /// </param>
            /// <param name='skiptoken'>
            /// Skiptoken is only used if a previous operation returned a partial result.
            /// If a previous response contains a nextLink element, the value of the
            /// nextLink element will include a skiptoken parameter that specifies a
            /// starting point to use for subsequent calls.
            /// </param>
            public static IPage<ManagedNetworkGroup> ListByManagedNetwork(this IManagedNetworkGroupsOperations operations, string resourceGroupName, string managedNetworkName, int? top = default(int?), string skiptoken = default(string))
            {
                return operations.ListByManagedNetworkAsync(resourceGroupName, managedNetworkName, top, skiptoken).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The ListByManagedNetwork ManagedNetworkGroup operation retrieves all the
            /// Managed Network Groups in a specified Managed Networks in a paginated
            /// format.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='managedNetworkName'>
            /// The name of the Managed Network.
            /// </param>
            /// <param name='top'>
            /// May be used to limit the number of results in a page for list queries.
            /// </param>
            /// <param name='skiptoken'>
            /// Skiptoken is only used if a previous operation returned a partial result.
            /// If a previous response contains a nextLink element, the value of the
            /// nextLink element will include a skiptoken parameter that specifies a
            /// starting point to use for subsequent calls.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<ManagedNetworkGroup>> ListByManagedNetworkAsync(this IManagedNetworkGroupsOperations operations, string resourceGroupName, string managedNetworkName, int? top = default(int?), string skiptoken = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByManagedNetworkWithHttpMessagesAsync(resourceGroupName, managedNetworkName, top, skiptoken, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The Put ManagedNetworkGroups operation creates or updates a Managed Network
            /// Group resource
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='managedNetworkGroup'>
            /// Parameters supplied to the create/update a Managed Network Group resource
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='managedNetworkName'>
            /// The name of the Managed Network.
            /// </param>
            /// <param name='managedNetworkGroupName'>
            /// The name of the Managed Network Group.
            /// </param>
            public static ManagedNetworkGroup BeginCreateOrUpdate(this IManagedNetworkGroupsOperations operations, ManagedNetworkGroup managedNetworkGroup, string resourceGroupName, string managedNetworkName, string managedNetworkGroupName)
            {
                return operations.BeginCreateOrUpdateAsync(managedNetworkGroup, resourceGroupName, managedNetworkName, managedNetworkGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Put ManagedNetworkGroups operation creates or updates a Managed Network
            /// Group resource
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='managedNetworkGroup'>
            /// Parameters supplied to the create/update a Managed Network Group resource
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='managedNetworkName'>
            /// The name of the Managed Network.
            /// </param>
            /// <param name='managedNetworkGroupName'>
            /// The name of the Managed Network Group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ManagedNetworkGroup> BeginCreateOrUpdateAsync(this IManagedNetworkGroupsOperations operations, ManagedNetworkGroup managedNetworkGroup, string resourceGroupName, string managedNetworkName, string managedNetworkGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(managedNetworkGroup, resourceGroupName, managedNetworkName, managedNetworkGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// The Delete ManagedNetworkGroups operation deletes a Managed Network Group
            /// specified by the resource group, Managed Network name, and group name
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='managedNetworkName'>
            /// The name of the Managed Network.
            /// </param>
            /// <param name='managedNetworkGroupName'>
            /// The name of the Managed Network Group.
            /// </param>
            public static void BeginDelete(this IManagedNetworkGroupsOperations operations, string resourceGroupName, string managedNetworkName, string managedNetworkGroupName)
            {
                operations.BeginDeleteAsync(resourceGroupName, managedNetworkName, managedNetworkGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The Delete ManagedNetworkGroups operation deletes a Managed Network Group
            /// specified by the resource group, Managed Network name, and group name
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='managedNetworkName'>
            /// The name of the Managed Network.
            /// </param>
            /// <param name='managedNetworkGroupName'>
            /// The name of the Managed Network Group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IManagedNetworkGroupsOperations operations, string resourceGroupName, string managedNetworkName, string managedNetworkGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, managedNetworkName, managedNetworkGroupName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// The ListByManagedNetwork ManagedNetworkGroup operation retrieves all the
            /// Managed Network Groups in a specified Managed Networks in a paginated
            /// format.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<ManagedNetworkGroup> ListByManagedNetworkNext(this IManagedNetworkGroupsOperations operations, string nextPageLink)
            {
                return operations.ListByManagedNetworkNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// The ListByManagedNetwork ManagedNetworkGroup operation retrieves all the
            /// Managed Network Groups in a specified Managed Networks in a paginated
            /// format.
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
            public static async Task<IPage<ManagedNetworkGroup>> ListByManagedNetworkNextAsync(this IManagedNetworkGroupsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByManagedNetworkNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}

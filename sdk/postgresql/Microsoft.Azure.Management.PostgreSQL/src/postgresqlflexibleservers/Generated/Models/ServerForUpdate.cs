// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.PostgreSQL.FlexibleServers.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents a server to be updated.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ServerForUpdate
    {
        /// <summary>
        /// Initializes a new instance of the ServerForUpdate class.
        /// </summary>
        public ServerForUpdate()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ServerForUpdate class.
        /// </summary>
        /// <param name="location">The location the resource resides
        /// in.</param>
        /// <param name="sku">The SKU (pricing tier) of the server.</param>
        /// <param name="administratorLoginPassword">The password of the
        /// administrator login.</param>
        /// <param name="storageProfile">Storage profile of a server.</param>
        /// <param name="haEnabled">stand by count value can be either enabled
        /// or disabled. Possible values include: 'Enabled', 'Disabled'</param>
        /// <param name="maintenanceWindow">Maintenance window of a
        /// server.</param>
        /// <param name="tags">Application-specific metadata in the form of
        /// key-value pairs.</param>
        public ServerForUpdate(string location = default(string), Sku sku = default(Sku), string administratorLoginPassword = default(string), StorageProfile storageProfile = default(StorageProfile), HAEnabledEnum? haEnabled = default(HAEnabledEnum?), MaintenanceWindow maintenanceWindow = default(MaintenanceWindow), IDictionary<string, string> tags = default(IDictionary<string, string>))
        {
            Location = location;
            Sku = sku;
            AdministratorLoginPassword = administratorLoginPassword;
            StorageProfile = storageProfile;
            HaEnabled = haEnabled;
            MaintenanceWindow = maintenanceWindow;
            Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the location the resource resides in.
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the SKU (pricing tier) of the server.
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Gets or sets the password of the administrator login.
        /// </summary>
        [JsonProperty(PropertyName = "properties.administratorLoginPassword")]
        public string AdministratorLoginPassword { get; set; }

        /// <summary>
        /// Gets or sets storage profile of a server.
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageProfile")]
        public StorageProfile StorageProfile { get; set; }

        /// <summary>
        /// Gets or sets stand by count value can be either enabled or
        /// disabled. Possible values include: 'Enabled', 'Disabled'
        /// </summary>
        [JsonProperty(PropertyName = "properties.haEnabled")]
        public HAEnabledEnum? HaEnabled { get; set; }

        /// <summary>
        /// Gets or sets maintenance window of a server.
        /// </summary>
        [JsonProperty(PropertyName = "properties.maintenanceWindow")]
        public MaintenanceWindow MaintenanceWindow { get; set; }

        /// <summary>
        /// Gets or sets application-specific metadata in the form of key-value
        /// pairs.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Sku != null)
            {
                Sku.Validate();
            }
        }
    }
}

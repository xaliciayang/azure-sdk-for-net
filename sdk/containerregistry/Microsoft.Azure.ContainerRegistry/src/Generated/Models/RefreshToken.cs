// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.ContainerRegistry.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class RefreshToken
    {
        /// <summary>
        /// Initializes a new instance of the RefreshToken class.
        /// </summary>
        public RefreshToken()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RefreshToken class.
        /// </summary>
        /// <param name="refreshTokenProperty">The refresh token to be used for
        /// generating access tokens</param>
        public RefreshToken(string refreshTokenProperty = default(string))
        {
            RefreshTokenProperty = refreshTokenProperty;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the refresh token to be used for generating access
        /// tokens
        /// </summary>
        [JsonProperty(PropertyName = "refresh_token")]
        public string RefreshTokenProperty { get; set; }

    }
}

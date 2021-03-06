// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    /// <summary> The DatastoreCredentials. </summary>
    public partial class DatastoreCredentials
    {
        /// <summary> Initializes a new instance of DatastoreCredentials. </summary>
        /// <param name="type"> Credential type used to authentication with storage. </param>
        public DatastoreCredentials(CredentialsType type)
        {
            Type = type;
        }

        /// <summary> Initializes a new instance of DatastoreCredentials. </summary>
        /// <param name="type"> Credential type used to authentication with storage. </param>
        /// <param name="accountKey"> . </param>
        /// <param name="certificate"> . </param>
        /// <param name="sas"> . </param>
        /// <param name="servicePrincipal"> . </param>
        /// <param name="sqlAdmin"> . </param>
        internal DatastoreCredentials(CredentialsType type, AccountKeySection accountKey, CertificateSection certificate, SasSection sas, ServicePrincipalSection servicePrincipal, SqlAdminSection sqlAdmin)
        {
            Type = type;
            AccountKey = accountKey;
            Certificate = certificate;
            Sas = sas;
            ServicePrincipal = servicePrincipal;
            SqlAdmin = sqlAdmin;
        }

        /// <summary> Credential type used to authentication with storage. </summary>
        public CredentialsType Type { get; set; }
        public AccountKeySection AccountKey { get; set; }
        public CertificateSection Certificate { get; set; }
        public SasSection Sas { get; set; }
        public ServicePrincipalSection ServicePrincipal { get; set; }
        public SqlAdminSection SqlAdmin { get; set; }
    }
}

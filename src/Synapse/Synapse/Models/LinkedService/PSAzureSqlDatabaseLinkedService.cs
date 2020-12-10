// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Commands.Synapse.Models
{
    using global::Azure.Analytics.Synapse.Artifacts.Models;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
        using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Microsoft Azure SQL Database linked service.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PSAzureSqlDatabaseLinkedService : PSLinkedService
    {
        /// <summary>
        /// Initializes a new instance of the PSAzureSqlDatabaseLinkedService
        /// class.
        /// </summary>
        public PSAzureSqlDatabaseLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the connection string. Type: string, SecureString or
        /// AzureKeyVaultSecretReference.
        /// </summary>
        public object ConnectionString { get; set; }

        /// <summary>
        /// Gets or sets the Azure key vault secret reference of password in
        /// connection string.
        /// </summary>
        public AzureKeyVaultSecretReference Password { get; set; }

        /// <summary>
        /// Gets or sets the ID of the service principal used to authenticate
        /// against Azure SQL Database. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        public object ServicePrincipalId { get; set; }

        /// <summary>
        /// Gets or sets the key of the service principal used to authenticate
        /// against Azure SQL Database.
        /// </summary>
        public SecretBase ServicePrincipalKey { get; set; }

        /// <summary>
        /// Gets or sets the name or ID of the tenant to which the service
        /// principal belongs. Type: string (or Expression with resultType
        /// string).
        /// </summary>
        public object Tenant { get; set; }

        /// <summary>
        /// Gets or sets the encrypted credential used for authentication.
        /// Credentials are encrypted using the integration runtime credential
        /// manager. Type: string (or Expression with resultType string).
        /// </summary>
        public object EncryptedCredential { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (ConnectionString == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ConnectionString");
            }
        }
    }
}


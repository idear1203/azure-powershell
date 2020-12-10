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
    /// Linked service for Teradata data source.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PSTeradataLinkedService : PSLinkedService
    {
        /// <summary>
        /// Initializes a new instance of the PSTeradataLinkedService class.
        /// </summary>
        public PSTeradataLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets teradata ODBC connection string. Type: string,
        /// SecureString or AzureKeyVaultSecretReference.
        /// </summary>
        public object ConnectionString { get; set; }

        /// <summary>
        /// Gets or sets server name for connection. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        public object Server { get; set; }

        /// <summary>
        /// Gets or sets authenticationType to be used for connection. Possible
        /// values include: 'Basic', 'Windows'
        /// </summary>
        public string AuthenticationType { get; set; }

        /// <summary>
        /// Gets or sets username for authentication. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        public object Username { get; set; }

        /// <summary>
        /// Gets or sets password for authentication.
        /// </summary>
        public SecretBase Password { get; set; }

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
        }
    }
}


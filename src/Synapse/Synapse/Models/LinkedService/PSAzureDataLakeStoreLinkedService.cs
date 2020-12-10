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
    /// Azure Data Lake Store linked service.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PSAzureDataLakeStoreLinkedService : PSLinkedService
    {
        /// <summary>
        /// Initializes a new instance of the PSAzureDataLakeStoreLinkedService
        /// class.
        /// </summary>
        public PSAzureDataLakeStoreLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets data Lake Store service URI. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        public object DataLakeStoreUri { get; set; }

        /// <summary>
        /// Gets or sets the ID of the application used to authenticate against
        /// the Azure Data Lake Store account. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        public object ServicePrincipalId { get; set; }

        /// <summary>
        /// Gets or sets the Key of the application used to authenticate
        /// against the Azure Data Lake Store account.
        /// </summary>
        public SecretBase ServicePrincipalKey { get; set; }

        /// <summary>
        /// Gets or sets the name or ID of the tenant to which the service
        /// principal belongs. Type: string (or Expression with resultType
        /// string).
        /// </summary>
        public object Tenant { get; set; }

        /// <summary>
        /// Gets or sets data Lake Store account name. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        public object AccountName { get; set; }

        /// <summary>
        /// Gets or sets data Lake Store account subscription ID (if different
        /// from Data Factory account). Type: string (or Expression with
        /// resultType string).
        /// </summary>
        public object SubscriptionId { get; set; }

        /// <summary>
        /// Gets or sets data Lake Store account resource group name (if
        /// different from Data Factory account). Type: string (or Expression
        /// with resultType string).
        /// </summary>
        public object ResourceGroupName { get; set; }

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
            if (DataLakeStoreUri == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DataLakeStoreUri");
            }
        }
    }
}


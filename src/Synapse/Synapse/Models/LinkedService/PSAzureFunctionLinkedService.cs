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
    /// Azure Function linked service.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PSAzureFunctionLinkedService : PSLinkedService
    {
        /// <summary>
        /// Initializes a new instance of the PSAzureFunctionLinkedService
        /// class.
        /// </summary>
        public PSAzureFunctionLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the endpoint of the Azure Function App. URL will be in
        /// the format https://&amp;lt;accountName&amp;gt;.azurewebsites.net.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.functionAppUrl")]
        public object FunctionAppUrl { get; set; }

        /// <summary>
        /// Gets or sets function or Host key for Azure Function App.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.functionKey")]
        public SecretBase FunctionKey { get; set; }

        /// <summary>
        /// Gets or sets the encrypted credential used for authentication.
        /// Credentials are encrypted using the integration runtime credential
        /// manager. Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.encryptedCredential")]
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
            if (FunctionAppUrl == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FunctionAppUrl");
            }
        }
    }
}


// <using global::Azure.Analytics.Synapse.Artifacts.Models;auto-generated>
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
    /// Azure Data Explorer (Kusto) linked service.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PSAzureDataExplorerLinkedService : PSLinkedService
    {
        /// <summary>
        /// Initializes a new instance of the PSAzureDataExplorerLinkedService
        /// class.
        /// </summary>
        public PSAzureDataExplorerLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the endpoint of Azure Data Explorer (the engine's
        /// endpoint). URL will be in the format
        /// https://&amp;lt;clusterName&amp;gt;.&amp;lt;regionName&amp;gt;.kusto.windows.net.
        /// Type: string (or Expression with resultType string)
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.endpoint")]
        public object Endpoint { get; set; }

        /// <summary>
        /// Gets or sets the ID of the service principal used to authenticate
        /// against Azure Data Explorer. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.servicePrincipalId")]
        public object ServicePrincipalId { get; set; }

        /// <summary>
        /// Gets or sets the key of the service principal used to authenticate
        /// against Kusto.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.servicePrincipalKey")]
        public SecretBase ServicePrincipalKey { get; set; }

        /// <summary>
        /// Gets or sets database name for connection. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.database")]
        public object Database { get; set; }

        /// <summary>
        /// Gets or sets the name or ID of the tenant to which the service
        /// principal belongs. Type: string (or Expression with resultType
        /// string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.tenant")]
        public object Tenant { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Endpoint == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Endpoint");
            }
            if (ServicePrincipalId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ServicePrincipalId");
            }
            if (ServicePrincipalKey == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ServicePrincipalKey");
            }
            if (Database == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Database");
            }
            if (Tenant == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Tenant");
            }
        }

        public override LinkedService ToSdkObject()
        {
            var linkedService = new AzureDataExplorerLinkedService(this.Endpoint, this.ServicePrincipalId, this.ServicePrincipalKey, this.Database, this.Tenant);
            SetProperties(linkedService);
            return linkedService;
        }
    }
}


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
    /// Common Data Service for Apps linked service.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PSCommonDataServiceForAppsLinkedService : PSLinkedService
    {
        /// <summary>
        /// Initializes a new instance of the
        /// PSCommonDataServiceForAppsLinkedService class.
        /// </summary>
        public PSCommonDataServiceForAppsLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the deployment type of the Common Data Service for
        /// Apps instance. 'Online' for Common Data Service for Apps Online and
        /// 'OnPremisesWithIfd' for Common Data Service for Apps on-premises
        /// with Ifd. Type: string (or Expression with resultType string).
        /// Possible values include: 'Online', 'OnPremisesWithIfd'
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.deploymentType")]
        public string DeploymentType { get; set; }

        /// <summary>
        /// Gets or sets the host name of the on-premises Common Data Service
        /// for Apps server. The property is required for on-prem and not
        /// allowed for online. Type: string (or Expression with resultType
        /// string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.hostName")]
        public object HostName { get; set; }

        /// <summary>
        /// Gets or sets the port of on-premises Common Data Service for Apps
        /// server. The property is required for on-prem and not allowed for
        /// online. Default is 443. Type: integer (or Expression with
        /// resultType integer), minimum: 0.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.port")]
        public object Port { get; set; }

        /// <summary>
        /// Gets or sets the URL to the Microsoft Common Data Service for Apps
        /// server. The property is required for on-line and not allowed for
        /// on-prem. Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.serviceUri")]
        public object ServiceUri { get; set; }

        /// <summary>
        /// Gets or sets the organization name of the Common Data Service for
        /// Apps instance. The property is required for on-prem and required
        /// for online when there are more than one Common Data Service for
        /// Apps instances associated with the user. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.organizationName")]
        public object OrganizationName { get; set; }

        /// <summary>
        /// Gets or sets the authentication type to connect to Common Data
        /// Service for Apps server. 'Office365' for online scenario, 'Ifd' for
        /// on-premises with Ifd scenario. 'AADServicePrincipal' for
        /// Server-To-Server authentication in online scenario. Type: string
        /// (or Expression with resultType string). Possible values include:
        /// 'Office365', 'Ifd', 'AADServicePrincipal'
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.authenticationType")]
        public string AuthenticationType { get; set; }

        /// <summary>
        /// Gets or sets user name to access the Common Data Service for Apps
        /// instance. Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.username")]
        public object Username { get; set; }

        /// <summary>
        /// Gets or sets password to access the Common Data Service for Apps
        /// instance.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.password")]
        public SecretBase Password { get; set; }

        /// <summary>
        /// Gets or sets the client ID of the application in Azure Active
        /// Directory used for Server-To-Server authentication. Type: string
        /// (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.servicePrincipalId")]
        public object ServicePrincipalId { get; set; }

        /// <summary>
        /// Gets or sets the service principal credential type to use in
        /// Server-To-Server authentication. 'ServicePrincipalKey' for
        /// key/secret, 'ServicePrincipalCert' for certificate. Type: string
        /// (or Expression with resultType string). Possible values include:
        /// 'ServicePrincipalKey', 'ServicePrincipalCert'
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.servicePrincipalCredentialType")]
        public string ServicePrincipalCredentialType { get; set; }

        /// <summary>
        /// Gets or sets the credential of the service principal object in
        /// Azure Active Directory. If servicePrincipalCredentialType is
        /// 'ServicePrincipalKey', servicePrincipalCredential can be
        /// SecureString or AzureKeyVaultSecretReference. If
        /// servicePrincipalCredentialType is 'ServicePrincipalCert',
        /// servicePrincipalCredential can only be
        /// AzureKeyVaultSecretReference.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.servicePrincipalCredential")]
        public SecretBase ServicePrincipalCredential { get; set; }

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
            if (DeploymentType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DeploymentType");
            }
            if (AuthenticationType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AuthenticationType");
            }
        }
    }
}


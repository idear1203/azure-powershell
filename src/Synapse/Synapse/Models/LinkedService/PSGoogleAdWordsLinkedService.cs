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
    /// Google AdWords service linked service.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PSGoogleAdWordsLinkedService : PSLinkedService
    {
        /// <summary>
        /// Initializes a new instance of the PSGoogleAdWordsLinkedService
        /// class.
        /// </summary>
        public PSGoogleAdWordsLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Client customer ID of the AdWords account that you
        /// want to fetch report data for.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.clientCustomerID")]
        public object ClientCustomerID { get; set; }

        /// <summary>
        /// Gets or sets the developer token associated with the manager
        /// account that you use to grant access to the AdWords API.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.developerToken")]
        public SecretBase DeveloperToken { get; set; }

        /// <summary>
        /// Gets or sets the OAuth 2.0 authentication mechanism used for
        /// authentication. ServiceAuthentication can only be used on
        /// self-hosted IR. Possible values include: 'ServiceAuthentication',
        /// 'UserAuthentication'
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.authenticationType")]
        public string AuthenticationType { get; set; }

        /// <summary>
        /// Gets or sets the refresh token obtained from Google for authorizing
        /// access to AdWords for UserAuthentication.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.refreshToken")]
        public SecretBase RefreshToken { get; set; }

        /// <summary>
        /// Gets or sets the client id of the google application used to
        /// acquire the refresh token. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.clientId")]
        public object ClientId { get; set; }

        /// <summary>
        /// Gets or sets the client secret of the google application used to
        /// acquire the refresh token.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.clientSecret")]
        public SecretBase ClientSecret { get; set; }

        /// <summary>
        /// Gets or sets the service account email ID that is used for
        /// ServiceAuthentication and can only be used on self-hosted IR.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.email")]
        public object Email { get; set; }

        /// <summary>
        /// Gets or sets the full path to the .p12 key file that is used to
        /// authenticate the service account email address and can only be used
        /// on self-hosted IR.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.keyFilePath")]
        public object KeyFilePath { get; set; }

        /// <summary>
        /// Gets or sets the full path of the .pem file containing trusted CA
        /// certificates for verifying the server when connecting over SSL.
        /// This property can only be set when using SSL on self-hosted IR. The
        /// default value is the cacerts.pem file installed with the IR.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.trustedCertPath")]
        public object TrustedCertPath { get; set; }

        /// <summary>
        /// Gets or sets specifies whether to use a CA certificate from the
        /// system trust store or from a specified PEM file. The default value
        /// is false.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.useSystemTrustStore")]
        public object UseSystemTrustStore { get; set; }

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
            if (ClientCustomerID == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ClientCustomerID");
            }
            if (DeveloperToken == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DeveloperToken");
            }
            if (AuthenticationType == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "AuthenticationType");
            }
        }

        public override LinkedService ToSdkObject()
        {
            var linkedService = new GoogleAdWordsLinkedService(this.ClientCustomerID, this.DeveloperToken, this.AuthenticationType);
            linkedService.RefreshToken = this.RefreshToken;
            linkedService.ClientId = this.ClientId;
            linkedService.ClientSecret = this.ClientSecret;
            linkedService.Email = this.Email;
            linkedService.KeyFilePath = this.KeyFilePath;
            linkedService.TrustedCertPath = this.TrustedCertPath;
            linkedService.UseSystemTrustStore = this.UseSystemTrustStore;
            linkedService.EncryptedCredential = this.EncryptedCredential;
            SetProperties(linkedService);
            return linkedService;
        }
    }
}


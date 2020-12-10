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
    /// A linked service for an SSH File Transfer Protocol (SFTP) server.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PSSftpServerLinkedService : PSLinkedService
    {
        /// <summary>
        /// Initializes a new instance of the PSSftpServerLinkedService class.
        /// </summary>
        public PSSftpServerLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the SFTP server host name. Type: string (or Expression
        /// with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.host")]
        public object Host { get; set; }

        /// <summary>
        /// Gets or sets the TCP port number that the SFTP server uses to
        /// listen for client connections. Default value is 22. Type: integer
        /// (or Expression with resultType integer), minimum: 0.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.port")]
        public object Port { get; set; }

        /// <summary>
        /// Gets or sets the authentication type to be used to connect to the
        /// FTP server. Possible values include: 'Basic', 'SshPublicKey'
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.authenticationType")]
        public string AuthenticationType { get; set; }

        /// <summary>
        /// Gets or sets the username used to log on to the SFTP server. Type:
        /// string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.userName")]
        public object UserName { get; set; }

        /// <summary>
        /// Gets or sets password to logon the SFTP server for Basic
        /// authentication.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.password")]
        public SecretBase Password { get; set; }

        /// <summary>
        /// Gets or sets the encrypted credential used for authentication.
        /// Credentials are encrypted using the integration runtime credential
        /// manager. Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.encryptedCredential")]
        public object EncryptedCredential { get; set; }

        /// <summary>
        /// Gets or sets the SSH private key file path for SshPublicKey
        /// authentication. Only valid for on-premises copy. For on-premises
        /// copy with SshPublicKey authentication, either PrivateKeyPath or
        /// PrivateKeyContent should be specified. SSH private key should be
        /// OpenSSH format. Type: string (or Expression with resultType
        /// string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.privateKeyPath")]
        public object PrivateKeyPath { get; set; }

        /// <summary>
        /// Gets or sets base64 encoded SSH private key content for
        /// SshPublicKey authentication. For on-premises copy with SshPublicKey
        /// authentication, either PrivateKeyPath or PrivateKeyContent should
        /// be specified. SSH private key should be OpenSSH format.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.privateKeyContent")]
        public SecretBase PrivateKeyContent { get; set; }

        /// <summary>
        /// Gets or sets the password to decrypt the SSH private key if the SSH
        /// private key is encrypted.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.passPhrase")]
        public SecretBase PassPhrase { get; set; }

        /// <summary>
        /// Gets or sets if true, skip the SSH host key validation. Default
        /// value is false. Type: boolean (or Expression with resultType
        /// boolean).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.skipHostKeyValidation")]
        public object SkipHostKeyValidation { get; set; }

        /// <summary>
        /// Gets or sets the host key finger-print of the SFTP server. When
        /// SkipHostKeyValidation is false, HostKeyFingerprint should be
        /// specified. Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.hostKeyFingerprint")]
        public object HostKeyFingerprint { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Host == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Host");
            }
        }

        public override LinkedService ToSdkObject()
        {
            var linkedService = new SftpServerLinkedService(this.Host);
            linkedService.Port = this.Port;
            linkedService.AuthenticationType = this.AuthenticationType;
            linkedService.UserName = this.UserName;
            linkedService.Password = this.Password;
            linkedService.EncryptedCredential = this.EncryptedCredential;
            linkedService.PrivateKeyPath = this.PrivateKeyPath;
            linkedService.PrivateKeyContent = this.PrivateKeyContent;
            linkedService.PassPhrase = this.PassPhrase;
            linkedService.SkipHostKeyValidation = this.SkipHostKeyValidation;
            linkedService.HostKeyFingerprint = this.HostKeyFingerprint;
            SetProperties(linkedService);
            return linkedService;
        }
    }
}


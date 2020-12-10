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
    /// Linked service for Amazon S3.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PSAmazonS3LinkedService : PSLinkedService
    {
        /// <summary>
        /// Initializes a new instance of the PSAmazonS3LinkedService class.
        /// </summary>
        public PSAmazonS3LinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the access key identifier of the Amazon S3 Identity
        /// and Access Management (IAM) user. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.accessKeyId")]
        public object AccessKeyId { get; set; }

        /// <summary>
        /// Gets or sets the secret access key of the Amazon S3 Identity and
        /// Access Management (IAM) user.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.secretAccessKey")]
        public SecretBase SecretAccessKey { get; set; }

        /// <summary>
        /// Gets or sets this value specifies the endpoint to access with the
        /// S3 Connector. This is an optional property; change it only if you
        /// want to try a different service endpoint or want to switch between
        /// https and http. Type: string (or Expression with resultType
        /// string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.serviceUrl")]
        public object ServiceUrl { get; set; }

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
        }
    }
}


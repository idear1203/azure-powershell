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
    /// Office365 linked service.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PSOffice365LinkedService : PSLinkedService
    {
        /// <summary>
        /// Initializes a new instance of the PSOffice365LinkedService class.
        /// </summary>
        public PSOffice365LinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets azure tenant ID to which the Office 365 account
        /// belongs. Type: string (or Expression with resultType string).
        /// </summary>
        public object Office365TenantId { get; set; }

        /// <summary>
        /// Gets or sets specify the tenant information under which your Azure
        /// AD web application resides. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        public object ServicePrincipalTenantId { get; set; }

        /// <summary>
        /// Gets or sets specify the application's client ID. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        public object ServicePrincipalId { get; set; }

        /// <summary>
        /// Gets or sets specify the application's key.
        /// </summary>
        public SecretBase ServicePrincipalKey { get; set; }

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
            if (Office365TenantId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Office365TenantId");
            }
            if (ServicePrincipalTenantId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ServicePrincipalTenantId");
            }
            if (ServicePrincipalId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ServicePrincipalId");
            }
            if (ServicePrincipalKey == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ServicePrincipalKey");
            }
        }
    }
}


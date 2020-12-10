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
    /// Azure Function activity.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PSAzureFunctionActivity : PSExecutionActivity
    {
        /// <summary>
        /// Initializes a new instance of the PSAzureFunctionActivity class.
        /// </summary>
        public PSAzureFunctionActivity()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets rest API method for target endpoint. Possible values
        /// include: 'GET', 'POST', 'PUT', 'DELETE', 'OPTIONS', 'HEAD', 'TRACE'
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.method")]
        public string Method { get; set; }

        /// <summary>
        /// Gets or sets name of the Function that the Azure Function Activity
        /// will call. Type: string (or Expression with resultType string)
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.functionName")]
        public object FunctionName { get; set; }

        /// <summary>
        /// Gets or sets represents the headers that will be sent to the
        /// request. For example, to set the language and type on a request:
        /// "headers" : { "Accept-Language": "en-us", "Content-Type":
        /// "application/json" }. Type: string (or Expression with resultType
        /// string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.headers")]
        public object Headers { get; set; }

        /// <summary>
        /// Gets or sets represents the payload that will be sent to the
        /// endpoint. Required for POST/PUT method, not allowed for GET method
        /// Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.body")]
        public object Body { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Method == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Method");
            }
            if (FunctionName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FunctionName");
            }
        }

        public override Activity ToSdkObject()
        {
            var activity = new AzureFunctionActivity(this.Name, this.Method, this.FunctionName);
            activity.Headers = this.Headers;
            activity.Body = this.Body;
            activity.LinkedServiceName = this.LinkedServiceName;
            activity.Policy = this.Policy?.ToSdkObject();
            SetProperties(activity);
            return activity;
        }
    }
}


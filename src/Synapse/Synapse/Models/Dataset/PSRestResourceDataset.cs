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
    /// A Rest service dataset.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PSRestResourceDataset : PSDataset
    {
        /// <summary>
        /// Initializes a new instance of the PSRestResourceDataset class.
        /// </summary>
        public PSRestResourceDataset()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the relative URL to the resource that the RESTful API
        /// provides. Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.relativeUrl")]
        public object RelativeUrl { get; set; }

        /// <summary>
        /// Gets or sets the HTTP method used to call the RESTful API. The
        /// default is GET. Type: string (or Expression with resultType
        /// string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.requestMethod")]
        public object RequestMethod { get; set; }

        /// <summary>
        /// Gets or sets the HTTP request body to the RESTful API if
        /// requestMethod is POST. Type: string (or Expression with resultType
        /// string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.requestBody")]
        public object RequestBody { get; set; }

        /// <summary>
        /// Gets or sets the additional HTTP headers in the request to the
        /// RESTful API. Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.additionalHeaders")]
        public object AdditionalHeaders { get; set; }

        /// <summary>
        /// Gets or sets the pagination rules to compose next page requests.
        /// Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.paginationRules")]
        public object PaginationRules { get; set; }

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

        public override Dataset ToSdkObject()
        {
            var dataset = new RestResourceDataset(this.LinkedServiceName);
            dataset.RelativeUrl = this.RelativeUrl;
            dataset.RequestMethod = this.RequestMethod;
            dataset.RequestBody = this.RequestBody;
            dataset.AdditionalHeaders = this.AdditionalHeaders;
            dataset.PaginationRules = this.PaginationRules;
            SetProperties(dataset);
            return dataset;
        }
    }
}


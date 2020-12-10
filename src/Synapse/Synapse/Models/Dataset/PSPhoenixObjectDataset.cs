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
    /// Phoenix server dataset.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PSPhoenixObjectDataset : PSDataset
    {
        /// <summary>
        /// Initializes a new instance of the PSPhoenixObjectDataset class.
        /// </summary>
        public PSPhoenixObjectDataset()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets this property will be retired. Please consider using
        /// schema + table properties instead.
        /// </summary>
        public object TableName { get; set; }

        /// <summary>
        /// Gets or sets the table name of the Phoenix. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        public object Table { get; set; }

        /// <summary>
        /// Gets or sets the schema name of the Phoenix. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        public object PhoenixObjectDatasetSchema { get; set; }

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


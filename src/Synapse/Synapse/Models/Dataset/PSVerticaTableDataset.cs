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
    /// Vertica dataset.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PSVerticaTableDataset : PSDataset
    {
        /// <summary>
        /// Initializes a new instance of the PSVerticaTableDataset class.
        /// </summary>
        public PSVerticaTableDataset()
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
        [JsonProperty(PropertyName = "typeProperties.tableName")]
        public object TableName { get; set; }

        /// <summary>
        /// Gets or sets the table name of the Vertica. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.table")]
        public object Table { get; set; }

        /// <summary>
        /// Gets or sets the schema name of the Vertica. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.schema")]
        public object VerticaTableDatasetSchema { get; set; }

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
            var dataset = new VerticaTableDataset(this.LinkedServiceName);
            dataset.TableName = this.TableName;
            dataset.Table = this.Table;
            dataset.SchemaTypePropertiesSchema = this.VerticaTableDatasetSchema;
            SetProperties(dataset);
            return dataset;
        }
    }
}


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
    /// The Office365 account.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PSOffice365Dataset : PSDataset
    {
        /// <summary>
        /// Initializes a new instance of the PSOffice365Dataset class.
        /// </summary>
        public PSOffice365Dataset()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the dataset to extract from Office 365. Type:
        /// string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.tableName")]
        public object TableName { get; set; }

        /// <summary>
        /// Gets or sets a predicate expression that can be used to filter the
        /// specific rows to extract from Office 365. Type: string (or
        /// Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.predicate")]
        public object Predicate { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (TableName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TableName");
            }
        }

        public override Dataset ToSdkObject()
        {
            var dataset = new Office365Dataset(this.LinkedServiceName, this.TableName);
            dataset.Predicate = this.Predicate;
            SetProperties(dataset);
            return dataset;
        }
    }
}


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
    using Microsoft.WindowsAzure.Commands.Utilities.Common;
        using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Activity to get metadata of dataset
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PSGetMetadataActivity : PSExecutionActivity
    {
        /// <summary>
        /// Initializes a new instance of the PSGetMetadataActivity class.
        /// </summary>
        public PSGetMetadataActivity()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets getMetadata activity dataset reference.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.dataset")]
        public DatasetReference Dataset { get; set; }

        /// <summary>
        /// Gets or sets fields of metadata to get from dataset.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.fieldList")]
        public IList<object> FieldList { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Dataset == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Dataset");
            }
        }

        public override Activity ToSdkObject()
        {
            var activity = new GetMetadataActivity(this.Name, this.Dataset);
            this.FieldList?.ForEach(item => activity.FieldList.Add(item));
            activity.LinkedServiceName = this.LinkedServiceName;
            activity.Policy = this.Policy?.ToSdkObject();
            SetProperties(activity);
            return activity;
        }
    }
}


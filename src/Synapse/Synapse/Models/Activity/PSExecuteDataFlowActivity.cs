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
    /// Execute data flow activity.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PSExecuteDataFlowActivity : PSExecutionActivity
    {
        /// <summary>
        /// Initializes a new instance of the PSExecuteDataFlowActivity class.
        /// </summary>
        public PSExecuteDataFlowActivity()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets data flow reference.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.dataFlow")]
        public PSDataFlowReference DataFlow { get; set; }

        /// <summary>
        /// Gets or sets staging info for execute data flow activity.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.staging")]
        public DataFlowStagingInfo Staging { get; set; }

        /// <summary>
        /// Gets or sets the integration runtime reference.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.integrationRuntime")]
        public IntegrationRuntimeReference IntegrationRuntime { get; set; }

        /// <summary>
        /// Gets or sets compute properties for data flow activity.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.compute")]
        public ExecuteDataFlowActivityTypePropertiesCompute Compute { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (DataFlow == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DataFlow");
            }
        }
    }
}


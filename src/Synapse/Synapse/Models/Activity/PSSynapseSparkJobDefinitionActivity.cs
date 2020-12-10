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
    /// Execute spark job activity.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PSSynapseSparkJobDefinitionActivity : PSActivity
    {
        /// <summary>
        /// Initializes a new instance of the SynapseSparkJobDefinitionActivity
        /// class.
        /// </summary>
        public PSSynapseSparkJobDefinitionActivity()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets synapse spark job reference.
        /// </summary>
        public SynapseSparkJobReference SparkJob { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (SparkJob == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "SparkJob");
            }
        }
    }
}


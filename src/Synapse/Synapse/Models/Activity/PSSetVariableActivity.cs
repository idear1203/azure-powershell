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
    /// Set value for a Variable.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PSSetVariableActivity : PSControlActivity
    {
        /// <summary>
        /// Initializes a new instance of the PSSetVariableActivity class.
        /// </summary>
        public PSSetVariableActivity()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the variable whose value needs to be set.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.variableName")]
        public string VariableName { get; set; }

        /// <summary>
        /// Gets or sets value to be set. Could be a static value or Expression
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.value")]
        public object Value { get; set; }

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


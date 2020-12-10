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
    /// Lookup activity.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PSLookupActivity : PSExecutionActivity
    {
        /// <summary>
        /// Initializes a new instance of the PSLookupActivity class.
        /// </summary>
        public PSLookupActivity()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets dataset-specific source properties, same as copy
        /// activity source.
        /// </summary>
        public PSCopySource Source { get; set; }

        /// <summary>
        /// Gets or sets lookup activity dataset reference.
        /// </summary>
        public DatasetReference Dataset { get; set; }

        /// <summary>
        /// Gets or sets whether to return first row or all rows. Default value
        /// is true. Type: boolean (or Expression with resultType boolean).
        /// </summary>
        public object FirstRowOnly { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Source == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Source");
            }
            if (Dataset == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Dataset");
            }
        }
    }
}


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
    /// Sap Business Warehouse Open Hub Destination Table properties.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PSSapOpenHubTableDataset : PSDataset
    {
        /// <summary>
        /// Initializes a new instance of the PSSapOpenHubTableDataset class.
        /// </summary>
        public PSSapOpenHubTableDataset()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the Open Hub Destination with destination
        /// type as Database Table. Type: string (or Expression with resultType
        /// string).
        /// </summary>
        public object OpenHubDestinationName { get; set; }

        /// <summary>
        /// Gets or sets whether to exclude the records of the last request.
        /// The default value is true. Type: boolean (or Expression with
        /// resultType boolean).
        /// </summary>
        public object ExcludeLastRequest { get; set; }

        /// <summary>
        /// Gets or sets the ID of request for delta loading. Once it is set,
        /// only data with requestId larger than the value of this property
        /// will be retrieved. The default value is 0. Type: integer (or
        /// Expression with resultType integer ).
        /// </summary>
        public object BaseRequestId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (OpenHubDestinationName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "OpenHubDestinationName");
            }
        }
    }
}


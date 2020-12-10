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
    /// Mapping data flow.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PSMappingDataFlow : PSDataFlow
    {
        /// <summary>
        /// Initializes a new instance of the MappingDataFlow class.
        /// </summary>
        public PSMappingDataFlow()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets list of sources in data flow.
        /// </summary>
        public IList<DataFlowSource> Sources { get; set; }

        /// <summary>
        /// Gets or sets list of sinks in data flow.
        /// </summary>
        public IList<DataFlowSink> Sinks { get; set; }

        /// <summary>
        /// Gets or sets list of transformations in data flow.
        /// </summary>
        public IList<Transformation> Transformations { get; set; }

        /// <summary>
        /// Gets or sets dataFlow script.
        /// </summary>
        public string Script { get; set; }
    }
}

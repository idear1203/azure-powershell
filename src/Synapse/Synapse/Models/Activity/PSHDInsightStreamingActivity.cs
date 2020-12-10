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
    /// HDInsight streaming activity type.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PSHDInsightStreamingActivity : PSExecutionActivity
    {
        /// <summary>
        /// Initializes a new instance of the PSHDInsightStreamingActivity
        /// class.
        /// </summary>
        public PSHDInsightStreamingActivity()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets storage linked service references.
        /// </summary>
        public IList<LinkedServiceReference> StorageLinkedServices { get; set; }

        /// <summary>
        /// Gets or sets user specified arguments to HDInsightActivity.
        /// </summary>
        public IList<object> Arguments { get; set; }

        /// <summary>
        /// Gets or sets debug info option. Possible values include: 'None',
        /// 'Always', 'Failure'
        /// </summary>
        public string GetDebugInfo { get; set; }

        /// <summary>
        /// Gets or sets mapper executable name. Type: string (or Expression
        /// with resultType string).
        /// </summary>
        public object Mapper { get; set; }

        /// <summary>
        /// Gets or sets reducer executable name. Type: string (or Expression
        /// with resultType string).
        /// </summary>
        public object Reducer { get; set; }

        /// <summary>
        /// Gets or sets input blob path. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        public object Input { get; set; }

        /// <summary>
        /// Gets or sets output blob path. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        public object Output { get; set; }

        /// <summary>
        /// Gets or sets paths to streaming job files. Can be directories.
        /// </summary>
        public IList<object> FilePaths { get; set; }

        /// <summary>
        /// Gets or sets linked service reference where the files are located.
        /// </summary>
        public LinkedServiceReference FileLinkedService { get; set; }

        /// <summary>
        /// Gets or sets combiner executable name. Type: string (or Expression
        /// with resultType string).
        /// </summary>
        public object Combiner { get; set; }

        /// <summary>
        /// Gets or sets command line environment values.
        /// </summary>
        public IList<object> CommandEnvironment { get; set; }

        /// <summary>
        /// Gets or sets allows user to specify defines for streaming job
        /// request.
        /// </summary>
        public IDictionary<string, object> Defines { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Mapper == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Mapper");
            }
            if (Reducer == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Reducer");
            }
            if (Input == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Input");
            }
            if (Output == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Output");
            }
            if (FilePaths == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FilePaths");
            }
        }
    }
}


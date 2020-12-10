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
    /// Copy activity.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class PSCopyActivity : PSExecutionActivity
    {
        /// <summary>
        /// Initializes a new instance of the PSCopyActivity class.
        /// </summary>
        public PSCopyActivity()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets copy activity source.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.source")]
        public PSCopySource Source { get; set; }

        /// <summary>
        /// Gets or sets copy activity sink.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.sink")]
        public PSCopySink Sink { get; set; }

        /// <summary>
        /// Gets or sets copy activity translator. If not specified, tabular
        /// translator is used.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.translator")]
        public object Translator { get; set; }

        /// <summary>
        /// Gets or sets specifies whether to copy data via an interim staging.
        /// Default value is false. Type: boolean (or Expression with
        /// resultType boolean).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.enableStaging")]
        public object EnableStaging { get; set; }

        /// <summary>
        /// Gets or sets specifies interim staging settings when EnableStaging
        /// is true.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.stagingSettings")]
        public PSStagingSettings StagingSettings { get; set; }

        /// <summary>
        /// Gets or sets maximum number of concurrent sessions opened on the
        /// source or sink to avoid overloading the data store. Type: integer
        /// (or Expression with resultType integer), minimum: 0.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.parallelCopies")]
        public object ParallelCopies { get; set; }

        /// <summary>
        /// Gets or sets maximum number of data integration units that can be
        /// used to perform this data movement. Type: integer (or Expression
        /// with resultType integer), minimum: 0.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.dataIntegrationUnits")]
        public object DataIntegrationUnits { get; set; }

        /// <summary>
        /// Gets or sets whether to skip incompatible row. Default value is
        /// false. Type: boolean (or Expression with resultType boolean).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.enableSkipIncompatibleRow")]
        public object EnableSkipIncompatibleRow { get; set; }

        /// <summary>
        /// Gets or sets redirect incompatible row settings when
        /// EnableSkipIncompatibleRow is true.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.redirectIncompatibleRowSettings")]
        public PSRedirectIncompatibleRowSettings RedirectIncompatibleRowSettings { get; set; }

        /// <summary>
        /// Gets or sets preserve Rules.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.preserveRules")]
        public IList<object> PreserveRules { get; set; }

        /// <summary>
        /// Gets or sets preserve rules.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.preserve")]
        public IList<object> Preserve { get; set; }

        /// <summary>
        /// Gets or sets list of inputs for the activity.
        /// </summary>
        [JsonProperty(PropertyName = "inputs")]
        public IList<DatasetReference> Inputs { get; set; }

        /// <summary>
        /// Gets or sets list of outputs for the activity.
        /// </summary>
        [JsonProperty(PropertyName = "outputs")]
        public IList<DatasetReference> Outputs { get; set; }

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
            if (Sink == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Sink");
            }
        }

        public override Activity ToSdkObject()
        {
            var activity = new CopyActivity(this.Name, this.Source?.ToSdkObject(), this.Sink?.ToSdkObject());
            this.Inputs?.ForEach(item => activity.Inputs.Add(item));
            this.Outputs?.ForEach(item => activity.Outputs.Add(item));
            activity.Translator = this.Translator;
            activity.EnableStaging = this.EnableStaging;
            activity.StagingSettings = this.StagingSettings?.ToSdkObject();
            activity.ParallelCopies = this.ParallelCopies;
            activity.DataIntegrationUnits = this.DataIntegrationUnits;
            activity.EnableSkipIncompatibleRow = this.EnableSkipIncompatibleRow;
            activity.RedirectIncompatibleRowSettings = this.RedirectIncompatibleRowSettings?.ToSdkObject();
            this.PreserveRules?.ForEach(item => activity.PreserveRules.Add(item));
            this.Preserve?.ForEach(item => activity.Preserve.Add(item));
            activity.LinkedServiceName = this.LinkedServiceName;
            activity.Policy = this.Policy?.ToSdkObject();
            SetProperties(activity);
            return activity;
        }
    }
}


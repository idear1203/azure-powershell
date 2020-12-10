﻿using Azure.Analytics.Synapse.Artifacts.Models;
using Microsoft.WindowsAzure.Commands.Utilities.Common;
using System.Collections.Generic;

namespace Microsoft.Azure.Commands.Synapse.Models
{
    public class PSDataFlowReference
    {
        public PSDataFlowReference() { }

        [JsonProperty(PropertyName = "type")]
        public DataFlowReferenceType? Type { get; set; }

        [JsonProperty(PropertyName = "referenceName")]
        public string ReferenceName { get; set; }

        [JsonProperty(PropertyName = "datasetParameters")]
        public object DatasetParameters { get; set; }

        public IDictionary<string, object> AdditionalProperties { get; set; }
    }
}

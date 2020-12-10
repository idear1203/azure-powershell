﻿using Azure.Analytics.Synapse.Artifacts.Models;

namespace Microsoft.Azure.Commands.Synapse.Models
{
    public class PSDataFlowResource : PSSubResource
    {
        public PSDataFlowResource(DataFlowResource dataFlowResource, string workspaceName)
            : base(dataFlowResource?.Id,
                  dataFlowResource?.Name,
                  dataFlowResource?.Type,
                  dataFlowResource?.Etag)
        {
            this.WorkspaceName = workspaceName;
            this.Properties = dataFlowResource?.Properties;
        }

        public string WorkspaceName { get; set; }

        public DataFlow Properties { get; set; }

        [JsonProperty(PropertyName = "properties")]
        internal PSDataFlow PropertiesForCreate { get; set; }

        public DataFlowResource ToSdkObject()
        {
            return new DataFlowResource(this.PropertiesForCreate?.ToSdkObject());
        }
    }
}

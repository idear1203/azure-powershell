﻿using Azure.Analytics.Synapse.Artifacts.Models;
using Microsoft.WindowsAzure.Commands.Utilities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Microsoft.Azure.Commands.Synapse.Models
{
    public class PSDataset
    {
        public PSDataset(Dataset dataset)
        {
            this.Description = dataset?.Description;
            this.Structure = dataset?.Structure;
            this.Schema = dataset?.Schema;
            this.LinkedServiceName = dataset?.LinkedServiceName;
            this.Parameters = dataset?.Parameters?
                    .Select(element => new KeyValuePair<string, PSParameterSpecification>(element.Key, new PSParameterSpecification(element.Value)))
                    .ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            this.Annotations = dataset?.Annotations;
            this.Folder = new PSDatasetFolder(dataset?.Folder);
            var propertiesEnum = dataset?.GetEnumerator();
            if (propertiesEnum != null)
            {
                this.AdditionalProperties = new Dictionary<string, object>();
                while (propertiesEnum.MoveNext())
                {
                    this.AdditionalProperties.Add(propertiesEnum.Current);
                }
            }
        }

        public PSDataset() { }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "structure")]
        public object Structure { get; set; }

        [JsonProperty(PropertyName = "schema")]
        public object Schema { get; set; }

        [JsonProperty(PropertyName = "linkedServiceName")]
        public LinkedServiceReference LinkedServiceName { get; set; }

        [JsonProperty(PropertyName = "parameters")]
        public IDictionary<string, PSParameterSpecification> Parameters { get; set; }

        [JsonProperty(PropertyName = "annotations")]
        public IList<object> Annotations { get; set; }

        [JsonProperty(PropertyName = "folder")]
        public PSDatasetFolder Folder { get; set; }

        public IDictionary<string, object> AdditionalProperties { get; set; }

        public virtual void Validate() { }
    }
}

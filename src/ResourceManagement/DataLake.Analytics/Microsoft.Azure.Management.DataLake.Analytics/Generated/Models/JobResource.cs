// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using Analytics;
    using Azure;
    using DataLake;
    using Management;
    using Azure;
    using Management;
    using DataLake;
    using Analytics;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The Data Lake Analytics job resources.
    /// </summary>
    public partial class JobResource
    {
        /// <summary>
        /// Initializes a new instance of the JobResource class.
        /// </summary>
        public JobResource() { }

        /// <summary>
        /// Initializes a new instance of the JobResource class.
        /// </summary>
        /// <param name="name">the name of the resource.</param>
        /// <param name="resourcePath">the path to the resource.</param>
        /// <param name="type">the job resource type. Possible values include:
        /// 'VertexResource', 'JobManagerResource', 'StatisticsResource',
        /// 'VertexResourceInUserFolder', 'JobManagerResourceInUserFolder',
        /// 'StatisticsResourceInUserFolder'</param>
        public JobResource(string name = default(string), string resourcePath = default(string), JobResourceType? type = default(JobResourceType?))
        {
            Name = name;
            ResourcePath = resourcePath;
            Type = type;
        }

        /// <summary>
        /// Gets or sets the name of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the path to the resource.
        /// </summary>
        [JsonProperty(PropertyName = "resourcePath")]
        public string ResourcePath { get; set; }

        /// <summary>
        /// Gets or sets the job resource type. Possible values include:
        /// 'VertexResource', 'JobManagerResource', 'StatisticsResource',
        /// 'VertexResourceInUserFolder', 'JobManagerResourceInUserFolder',
        /// 'StatisticsResourceInUserFolder'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public JobResourceType? Type { get; set; }

    }
}


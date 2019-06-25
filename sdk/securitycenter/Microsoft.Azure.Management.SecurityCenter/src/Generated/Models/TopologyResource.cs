// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    [Rest.Serialization.JsonTransformation]
    public partial class TopologyResource
    {
        /// <summary>
        /// Initializes a new instance of the TopologyResource class.
        /// </summary>
        public TopologyResource()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the TopologyResource class.
        /// </summary>
        /// <param name="id">Resource Id</param>
        /// <param name="name">Resource name</param>
        /// <param name="type">Resource type</param>
        /// <param name="location">Location where the resource is
        /// stored</param>
        /// <param name="calculatedDateTime">The UTC time on which the topology
        /// was calculated</param>
        /// <param name="topologyResources">Azure resources which are part of
        /// this topology resource</param>
        public TopologyResource(string id = default(string), string name = default(string), string type = default(string), string location = default(string), System.DateTime? calculatedDateTime = default(System.DateTime?), IList<TopologySingleResource> topologyResources = default(IList<TopologySingleResource>))
        {
            Id = id;
            Name = name;
            Type = type;
            Location = location;
            CalculatedDateTime = calculatedDateTime;
            TopologyResources = topologyResources;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets resource Id
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets resource name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; private set; }

        /// <summary>
        /// Gets resource type
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Gets location where the resource is stored
        /// </summary>
        [JsonProperty(PropertyName = "location")]
        public string Location { get; private set; }

        /// <summary>
        /// Gets the UTC time on which the topology was calculated
        /// </summary>
        [JsonProperty(PropertyName = "properties.calculatedDateTime")]
        public System.DateTime? CalculatedDateTime { get; private set; }

        /// <summary>
        /// Gets azure resources which are part of this topology resource
        /// </summary>
        [JsonProperty(PropertyName = "properties.topologyResources")]
        public IList<TopologySingleResource> TopologyResources { get; private set; }

    }
}
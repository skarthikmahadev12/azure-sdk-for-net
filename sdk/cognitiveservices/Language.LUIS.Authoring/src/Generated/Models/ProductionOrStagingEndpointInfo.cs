// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Language.LUIS.Authoring.Models
{
    using System.Linq;

    public partial class ProductionOrStagingEndpointInfo : EndpointInfo
    {
        /// <summary>
        /// Initializes a new instance of the ProductionOrStagingEndpointInfo
        /// class.
        /// </summary>
        public ProductionOrStagingEndpointInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ProductionOrStagingEndpointInfo
        /// class.
        /// </summary>
        /// <param name="versionId">The version ID to publish.</param>
        /// <param name="isStaging">Indicates if the staging slot should be
        /// used, instead of the Production one.</param>
        /// <param name="endpointUrl">The Runtime endpoint URL for this model
        /// version.</param>
        /// <param name="region">The target region that the application is
        /// published to.</param>
        /// <param name="assignedEndpointKey">The endpoint key.</param>
        /// <param name="endpointRegion">The endpoint's region.</param>
        /// <param name="failedRegions">Regions where publishing
        /// failed.</param>
        /// <param name="publishedDateTime">Timestamp when was last
        /// published.</param>
        public ProductionOrStagingEndpointInfo(string versionId = default(string), bool? isStaging = default(bool?), string endpointUrl = default(string), string region = default(string), string assignedEndpointKey = default(string), string endpointRegion = default(string), string failedRegions = default(string), string publishedDateTime = default(string))
            : base(versionId, isStaging, endpointUrl, region, assignedEndpointKey, endpointRegion, failedRegions, publishedDateTime)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
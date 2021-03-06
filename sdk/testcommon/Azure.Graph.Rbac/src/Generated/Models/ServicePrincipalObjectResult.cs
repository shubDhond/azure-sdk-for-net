// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Graph.Rbac.Models
{
    /// <summary> Service Principal Object Result. </summary>
    public partial class ServicePrincipalObjectResult
    {
        /// <summary> Initializes a new instance of ServicePrincipalObjectResult. </summary>
        internal ServicePrincipalObjectResult()
        {
        }

        /// <summary> Initializes a new instance of ServicePrincipalObjectResult. </summary>
        /// <param name="value"> The Object ID of the service principal with the specified application ID. </param>
        /// <param name="odataMetadata"> The URL representing edm equivalent. </param>
        internal ServicePrincipalObjectResult(string value, string odataMetadata)
        {
            Value = value;
            OdataMetadata = odataMetadata;
        }

        /// <summary> The Object ID of the service principal with the specified application ID. </summary>
        public string Value { get; }
        /// <summary> The URL representing edm equivalent. </summary>
        public string OdataMetadata { get; }
    }
}

// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> The UnknownNamedPolygonBase. </summary>
    internal partial class UnknownNamedPolygonBase : NamedPolygonBase
    {
        /// <summary> Initializes a new instance of UnknownNamedPolygonBase. </summary>
        /// <param name="type"> The Type discriminator for the derived types. </param>
        /// <param name="name"> Polygon name. Must be unique within the node. </param>
        internal UnknownNamedPolygonBase(string type, string name) : base(type, name)
        {
            Type = type ?? "Unknown";
        }
    }
}

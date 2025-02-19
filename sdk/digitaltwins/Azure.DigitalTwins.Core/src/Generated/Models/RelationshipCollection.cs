// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.DigitalTwins.Core
{
    /// <summary> A collection of relationships which relate digital twins together. </summary>
    internal partial class RelationshipCollection
    {
        /// <summary> Initializes a new instance of RelationshipCollection. </summary>
        /// <param name="value"> The relationship objects. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal RelationshipCollection(IEnumerable<object> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of RelationshipCollection. </summary>
        /// <param name="value"> The relationship objects. </param>
        /// <param name="nextLink"> A URI to retrieve the next page of objects. </param>
        internal RelationshipCollection(IReadOnlyList<object> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The relationship objects. </summary>
        public IReadOnlyList<object> Value { get; }
        /// <summary> A URI to retrieve the next page of objects. </summary>
        public string NextLink { get; }
    }
}

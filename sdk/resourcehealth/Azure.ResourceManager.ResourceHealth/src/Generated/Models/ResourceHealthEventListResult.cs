// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.ResourceHealth;

namespace Azure.ResourceManager.ResourceHealth.Models
{
    /// <summary> The List events operation response. </summary>
    internal partial class ResourceHealthEventListResult
    {
        /// <summary> Initializes a new instance of ResourceHealthEventListResult. </summary>
        /// <param name="value"> The list of event. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal ResourceHealthEventListResult(IEnumerable<ResourceHealthEventData> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of ResourceHealthEventListResult. </summary>
        /// <param name="value"> The list of event. </param>
        /// <param name="nextLink"> The URI to fetch the next page of events. Call ListNext() with this URI to fetch the next page of events. </param>
        internal ResourceHealthEventListResult(IReadOnlyList<ResourceHealthEventData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> The list of event. </summary>
        public IReadOnlyList<ResourceHealthEventData> Value { get; }
        /// <summary> The URI to fetch the next page of events. Call ListNext() with this URI to fetch the next page of events. </summary>
        public string NextLink { get; }
    }
}

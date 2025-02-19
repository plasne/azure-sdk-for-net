// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    /// <summary> Used by the Application Insights system to determine what kind of flow this component was created by. This is to be set to &apos;Bluefield&apos; when creating/updating a component via the REST API. </summary>
    public readonly partial struct FlowType : IEquatable<FlowType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="FlowType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FlowType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BluefieldValue = "Bluefield";

        /// <summary> Bluefield. </summary>
        public static FlowType Bluefield { get; } = new FlowType(BluefieldValue);
        /// <summary> Determines if two <see cref="FlowType"/> values are the same. </summary>
        public static bool operator ==(FlowType left, FlowType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FlowType"/> values are not the same. </summary>
        public static bool operator !=(FlowType left, FlowType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="FlowType"/>. </summary>
        public static implicit operator FlowType(string value) => new FlowType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FlowType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FlowType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}

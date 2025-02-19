// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HybridContainerService.Models
{
    /// <summary> The LinuxProfilePropertiesSshPublicKeysItem. </summary>
    public partial class LinuxProfilePropertiesSshPublicKeysItem
    {
        /// <summary> Initializes a new instance of LinuxProfilePropertiesSshPublicKeysItem. </summary>
        public LinuxProfilePropertiesSshPublicKeysItem()
        {
        }

        /// <summary> Initializes a new instance of LinuxProfilePropertiesSshPublicKeysItem. </summary>
        /// <param name="keyData"> KeyData - Certificate public key used to authenticate with VMs through SSH. The certificate must be in PEM format with or without headers. </param>
        internal LinuxProfilePropertiesSshPublicKeysItem(string keyData)
        {
            KeyData = keyData;
        }

        /// <summary> KeyData - Certificate public key used to authenticate with VMs through SSH. The certificate must be in PEM format with or without headers. </summary>
        public string KeyData { get; set; }
    }
}

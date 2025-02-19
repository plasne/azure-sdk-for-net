// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DevSpaces.Models
{
    /// <summary> Contains information used to connect to a Kubernetes cluster. </summary>
    public partial class KubernetesConnectionDetails : OrchestratorSpecificConnectionDetails
    {
        /// <summary> Initializes a new instance of KubernetesConnectionDetails. </summary>
        internal KubernetesConnectionDetails()
        {
            InstanceType = "Kubernetes";
        }

        /// <summary> Initializes a new instance of KubernetesConnectionDetails. </summary>
        /// <param name="instanceType"> Gets the Instance type. </param>
        /// <param name="kubeConfig"> Gets the kubeconfig for the cluster. </param>
        internal KubernetesConnectionDetails(string instanceType, string kubeConfig) : base(instanceType)
        {
            KubeConfig = kubeConfig;
            InstanceType = instanceType ?? "Kubernetes";
        }

        /// <summary> Gets the kubeconfig for the cluster. </summary>
        public string KubeConfig { get; }
    }
}

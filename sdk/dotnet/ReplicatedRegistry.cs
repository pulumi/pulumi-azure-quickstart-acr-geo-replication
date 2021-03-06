// *** WARNING: this file was generated by Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureQuickStartAcrGeoReplication
{
    [AzureQuickStartAcrGeoReplicationResourceType("azure-quickstart-acr-geo-replication:index:ReplicatedRegistry")]
    public partial class ReplicatedRegistry : Pulumi.ComponentResource
    {
        /// <summary>
        /// The login server url
        /// </summary>
        [Output("loginServer")]
        public Output<string> LoginServer { get; private set; } = null!;

        /// <summary>
        /// The Registry
        /// </summary>
        [Output("registry")]
        public Output<Pulumi.AzureNative.ContainerRegistry.Registry> Registry { get; private set; } = null!;

        /// <summary>
        /// The replication policy
        /// </summary>
        [Output("replication")]
        public Output<Pulumi.AzureNative.ContainerRegistry.Replication> Replication { get; private set; } = null!;


        /// <summary>
        /// Create a ReplicatedRegistry resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ReplicatedRegistry(string name, ReplicatedRegistryArgs args, ComponentResourceOptions? options = null)
            : base("azure-quickstart-acr-geo-replication:index:ReplicatedRegistry", name, args ?? new ReplicatedRegistryArgs(), MakeResourceOptions(options, ""), remote: true)
        {
        }

        private static ComponentResourceOptions MakeResourceOptions(ComponentResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new ComponentResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = ComponentResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
    }

    public sealed class ReplicatedRegistryArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Enable admin user that has push / pull permissions to the registry
        /// </summary>
        [Input("adminUserEnabled")]
        public Input<bool>? AdminUserEnabled { get; set; }

        /// <summary>
        /// Globally unique name of your azure container registry
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The location of the registry replica location
        /// </summary>
        [Input("replicationLocation", required: true)]
        public Input<string> ReplicationLocation { get; set; } = null!;

        /// <summary>
        /// The name of the enclosing resource group
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Tier of your Azure Container Registry. Geo-replication requires the Premium SKU
        /// </summary>
        [Input("sku")]
        public Input<string>? Sku { get; set; }

        public ReplicatedRegistryArgs()
        {
        }
    }
}

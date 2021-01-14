using Microsoft.Azure.Management.Synapse.Models;

namespace Microsoft.Azure.Commands.Synapse.Models.WorkspaceKey
{
    public class PSWorkspaceKey : PSSynapseProxyResource
    {
        public PSWorkspaceKey(Key key)
        {
            this.IsActiveCustomerManagedKey = key?.IsActiveCMK ?? false;
            this.KeyVaultUrl = key?.KeyVaultUrl;
        }

        public bool IsActiveCustomerManagedKey { get; set; } 

        public string KeyVaultUrl { get; set; } 
    }
}

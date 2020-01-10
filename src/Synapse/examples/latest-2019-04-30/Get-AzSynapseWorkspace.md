### Example 1: Get all workspaces in your current subscription
```powershell
PS C:\> Get-AzSynapseWorkspace

Location    Name                   Type
--------    ----                   ----
westus2     ws1                    Microsoft.Synapse/workspaces
westus2     ws2                    Microsoft.Synapse/workspaces
westus2     ws3                    Microsoft.Synapse/workspaces
westus2     ws4                    Microsoft.Synapse/workspaces
```

This command gets all the workspaces in your current subscription.

### Example 2: Get all workspaces in a resource group
```powershell
PS C:\> Get-AzSynapseWorkspace -ResourceGroupName ContosoResourceGroup

Location Name             Type
-------- ----             ----
westus2  ws1              Microsoft.Synapse/workspaces
westus2  ws2              Microsoft.Synapse/workspaces
```

This command gets all the workspaces in a resource group named ContosoResourceGroup.

### Example 3: Get a specific workspace
```powershell
PS C:\> Get-AzSynapseWorkspace -ResourceGroupName ContosoResourceGroup -Name ws1

Location Name             Type
-------- ----             ----
westus2  ws1              Microsoft.Synapse/workspaces
```

This command gets the workspace named ws1 in a resource group named ContosoResourceGroup.


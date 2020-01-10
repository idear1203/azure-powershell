### Example 1: Get all Big Data pools in a workspace
```powershell
PS C:\> Get-AzSynapseBigDataPool -ResourceGroupName ContosoResourceGroup -WorkspaceName ContosoWorkspace

Location Name       Type
-------- ----       ----
westus2  largepool  Microsoft.Synapse/workspaces/bigDataPools
westus2  mediumpool Microsoft.Synapse/workspaces/bigDataPools
westus2  smallpool  Microsoft.Synapse/workspaces/bigDataPools
```

This command gets all the Big Data pools in a workspace named ContosoWorkspace.

### Example 2: Get a specific Big Data pool
```powershell
PS C:\> Get-AzSynapseBigDataPool -ResourceGroupName ContosoResourceGroup -WorkspaceName ContosoWorkspace -Name largepool

Location Name      Type
-------- ----      ----
westus2  largepool Microsoft.Synapse/workspaces/bigDataPools
```

This command gets the Big Data pool named largepool in a workspace named ContosoWorkspace.


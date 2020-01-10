### Example 1: Get all SQL pools in a workspace
```powershell
PS C:\> Get-AzSynapseSqlPool -ResourceGroupName ContosoResourceGroup -WorkspaceName ContosoWorkspace

Location Name       Type
-------- ----       ----
westus2  sql        Microsoft.Synapse/workspaces/sqlPools
```

This command gets all the SQL pools in a workspace named ContosoWorkspace.

### Example 2: Get a specific SQL pool
```powershell
PS C:\> Get-AzSynapseSqlPool -ResourceGroupName ContosoResourceGroup -WorkspaceName ContosoWorkspace -Name sql

Location Name       Type
-------- ----       ----
westus2  sql        Microsoft.Synapse/workspaces/sqlPools
```

This command gets the SQL pool named sqlcompute in a workspace named ContosoWorkspace.


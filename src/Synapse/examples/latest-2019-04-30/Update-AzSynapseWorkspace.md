### Example 1: Add a tag for a Synapse workspace
```powershell
PS C:\> Update-AzSynapseWorkspace -ResourceGroupName ContosoResourceGroup -WorkspaceName ContosoWorkspace -Tag @{key = 'value'}

Location Name              Type
-------- ----              ----
eastus   ContosoWorkspace  Microsoft.Synapse/workspaces
```

This command adds a tag to a workspace named ContosoWorkspace


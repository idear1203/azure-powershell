### Example 1: Add a tag for a Big Data pool
```powershell
PS C:\> Update-AzSynapseBigDataPool -Name ConsotoSpark -ResourceGroupName ContosoResourceGroup -WorkspaceName ContosoWorkspace -Tag @{key = 'value'}

Location Name          Type
-------- ----          ----
         ConsotoSpark  Microsoft.Synapse/workspaces/bigDataPools
```

This command adds a tag to a Big Data pool named ContosoSpark in a workspace named ContosoWorkspace


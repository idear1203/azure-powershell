### Example 1: Update a Big Data pool
```powershell
PS C:\> Set-AzSynapseBigDataPool -Name ContosoSpark -ResourceGroupName ContosoResourceGroup -WorkspaceName ContosoWorkSpace -Location eastus -NodeCount 3 -NodeSize Medium -SparkVersion 2.4 -NodeSizeFamily MemoryOptimized

Location Name             Type
-------- ----             ----
eastus   ContosoWorkSpace Microsoft.Synapse/workspaces/bigDataPools
```

This command updates a Big Data pool named ContosoSpark in workspace named ContosoWorkspace


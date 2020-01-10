### Example 1: Create a Big Data pool
```powershell
PS C:\> New-AzSynapseBigDataPool -Name ContosoSpark -ResourceGroupName ContosoResourceGroup -WorkspaceName ContosoWorkSpace -Location eastus -NodeCount 3 -NodeSize Medium -SparkVersion 2.4 -NodeSizeFamily MemoryOptimized

Location Name             Type
-------- ----             ----
eastus   ContosoWorkSpace Microsoft.Synapse/workspaces/bigDataPools
```

This command creates a Big Data pool named ContosoSpark in workspace named ContosoWorkspace


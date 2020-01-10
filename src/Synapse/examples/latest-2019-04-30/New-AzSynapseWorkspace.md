### Example 1: Create a Synapse workspace
```powershell
PS C:\> New-AzSynapseWorkspace -Name ContosoWorkspace -ResourceGroupName ContosoResourceGroup -DefaultDataLakeStorageAccountUrl https://ContosoDataLakeStore.dfs.core.windows.net -DefaultDataLakeStorageFilesystem testfilesystem -SqlAdministratorLogin psuser1 -SqlAdministratorLoginPassword SomePassword123! -Location eastus -IdentityType SystemAssigned

```

This command creates a Synapse workspace named ContosoWorkspace that uses ContosoDataLakeStore Data Store, in the resource group named ContosoResourceGroup


### Example 1: Update a Synapse workspace
```powershell
PS C:\> Set-AzSynapseWorkspace -Name ContosoWorkspace -ResourceGroupName ContosoResourceGroup -DefaultDataLakeStorageAccountUrl https://ContosoDataLakeStore.dfs.core.windows.net -DefaultDataLakeStorageFilesystem testfilesystem -SqlAdministratorLogin psuser1 -SqlAdministratorLoginPassword SomePassword123! -Location eastus -IdentityType SystemAssigned

```

This command updates a Synapse workspace named ContosoWorkspace that uses ContosoDataLakeStore Data Store, in the resource group named ContosoResourceGroup


@{
  GUID = 'df6aea3a-f70b-44fa-a8db-3097d246aa90'
  RootModule = './Az.Synapse.psm1'
  ModuleVersion = '0.0.1'
  CompatiblePSEditions = 'Core', 'Desktop'
  Author = 'Microsoft Corporation'
  CompanyName = 'Microsoft Corporation'
  Copyright = 'Microsoft Corporation. All rights reserved.'
  Description = 'Microsoft Azure PowerShell: Synapse cmdlets'
  PowerShellVersion = '5.1'
  DotNetFrameworkVersion = '4.7.2'
  RequiredAssemblies = './bin/Az.Synapse.private.dll'
  FormatsToProcess = './Az.Synapse.format.ps1xml'
  CmdletsToExport = 'Get-AzSynapseBigDataPool', 'Get-AzSynapseSqlPool', 'Get-AzSynapseWorkspace', 'New-AzSynapseBigDataPool', 'New-AzSynapseSqlPool', 'New-AzSynapseWorkspace', 'Remove-AzSynapseBigDataPool', 'Remove-AzSynapseSqlPool', 'Remove-AzSynapseWorkspace', 'Resume-AzSynapseSqlPool', 'Suspend-AzSynapseSqlPool', 'Update-AzSynapseBigDataPool', 'Update-AzSynapseWorkspace', '*'
  AliasesToExport = '*'
  PrivateData = @{
    PSData = @{
      Tags = 'Azure', 'ResourceManager', 'ARM', 'PSModule', 'Synapse'
      LicenseUri = 'https://aka.ms/azps-license'
      ProjectUri = 'https://github.com/Azure/azure-powershell'
      ReleaseNotes = ''
      Profiles = 'latest-2019-04-30'
    }
  }
}

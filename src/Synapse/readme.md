<!-- region Generated -->
# Az.Synapse
This directory contains the PowerShell module for the Synapse service.

---
## Status
[![Az.Synapse](https://img.shields.io/powershellgallery/v/Az.Synapse.svg?style=flat-square&label=Az.Synapse "Az.Synapse")](https://www.powershellgallery.com/packages/Az.Synapse/)

## Info
- Modifiable: yes
- Generated: all
- Committed: yes
- Packaged: yes

---
## Detail
This module was primarily generated via [AutoRest](https://github.com/Azure/autorest) using the [PowerShell](https://github.com/Azure/autorest.powershell) extension.

## Module Requirements
- [Az.Accounts module](https://www.powershellgallery.com/packages/Az.Accounts/), version 1.6.0 or greater

## Authentication
AutoRest does not generate authentication code for the module. Authentication is handled via Az.Accounts by altering the HTTP payload before it is sent.

## Development
For information on how to develop for `Az.Synapse`, see [how-to.md](how-to.md).
<!-- endregion -->

---
## Generation Requirements
Use of the beta version of `autorest.powershell` generator requires the following:
- [NodeJS LTS](https://nodejs.org) (10.15.x LTS preferred)
  - **Note**: It *will not work* with Node < 10.x. Using 11.x builds may cause issues as they may introduce instability or breaking changes.
> If you want an easy way to install and update Node, [NVS - Node Version Switcher](../nodejs/installing-via-nvs.md) or [NVM - Node Version Manager](../nodejs/installing-via-nvm.md) is recommended.
- [AutoRest](https://aka.ms/autorest) v3 beta <br>`npm install -g autorest@beta`<br>&nbsp;
- PowerShell 6.0 or greater
  - If you don't have it installed, you can use the cross-platform npm package <br>`npm install -g pwsh`<br>&nbsp;
- .NET Core SDK 2.0 or greater
  - If you don't have it installed, you can use the cross-platform npm package <br>`npm install -g dotnet-sdk-2.2`<br>&nbsp;

## Run Generation
In this directory, run AutoRest:
> `autorest`

---
### AutoRest Configuration
> see https://aka.ms/autorest

``` yaml
require:
  - $(this-folder)/../readme.azure.md
  - $(repo)/specification/synapse/resource-manager/readme.md
  - $(repo)/specification/synapse/data-plane/readme.md

title: Synapse
module-version: 0.0.1
```

``` yaml
directive:
  # Rename cmdlets to following PowerShell Naming rules
  # If your cmdlet is performing a PUT operation (i.e., a full replacement on the server), the cmdlet should use the verb Set
  #- where:
  #    verb: Set
  #    subject: BigDataPool
  #  remove: true
  #- where:
  #    verb: Set
  #    subject: WorkSpace
  #  remove: true
  # POST operation should use verb Set
  - where:
      verb: Update
      subject: IntegrationRuntimeObjectMetadata
    set:
      verb: Set
  - where:
      verb: Update
      subject: IPFirewallRule
    remove: true
  # Add alias
  - where:
      verb: Update
      subject: IntegrationRuntimeObjectMetadata
    set:
      alias: Refresh-AzSynapseIntegrationRuntimeObjectMetadata
  # Hide cmdlets that will not be exported to users directly
  - where:
      verb: Get
      subject: IntegrationRuntimeOperationResult
    remove: true
  - where:
      verb: Get
      subject: IntegrationRuntimeOperationStatus
    remove: true
  - where:
      verb: Get
      subject: OperationAzureAsyncHeaderResult
    remove: true
  - where:
      verb: Get
      subject: OperationLocationHeaderResult
    remove: true
  - where:
      verb: Get
      subject: SqlPoolOperationResultLocationHeaderResult
    remove: true
  - where:
      verb: Get
      subject: SqlPoolOperationResultLocationHeader
    remove: true
  # The below directive hides any cmdlet not currently shipped with Az.Synapse
  - where:
      subject: ^(?!^BigDataPool$)(?!^Workspace$)(?!^SqlPool$).*$
    hide: true
  - where:
      verb: Rename
      subject: SqlPool
    hide: true
  # Remove Parameter Sets/cmdlets
  # For New-* cmdlets, remove the ‘ViaIdentity’ parameter sets
  - where:
      verb: Update
      variant: ^Update$|^UpdateViaIdentity$
    remove: true
  - where:
      verb: New
      variant: ^Create$|^CreateViaIdentity$|^CreateViaIdentityExpanded$
    remove: true
  - where:
      verb: Test
      variant: ^Check$|^CheckViaIdentity$|^CheckViaIdentityExpanded$
    remove: true
  # Format output
  - where:
      model-name: GenericResource
    set:
      format-table:
        properties:
          - Name
          - ResourceGroupName
          - Type
          - Location
        labels:
          Type: ResourceType
  # Format output
  - where:
      model-name: Workspace
    set:
      format-table:
        properties:
          - Name
          - ResourceGroupName
          - Location
          - DataLakeStorageAccountDetails
          - DefaultDataLakeStorageAccountUrl
          - DefaultDataLakeStorageFilesystem
          - SqlAdministratorLogin
          - ProvisioningState
```

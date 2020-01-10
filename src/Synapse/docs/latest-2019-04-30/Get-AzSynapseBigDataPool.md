---
external help file:
Module Name: Az.Synapse
online version: https://docs.microsoft.com/en-us/powershell/module/az.synapse/get-azsynapsebigdatapool
schema: 2.0.0
---

# Get-AzSynapseBigDataPool

## SYNOPSIS
Get a Big Data pool.

## SYNTAX

### List (Default)
```
Get-AzSynapseBigDataPool -ResourceGroupName <String> -WorkspaceName <String> [-SubscriptionId <String[]>]
 [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### Get
```
Get-AzSynapseBigDataPool -Name <String> -ResourceGroupName <String> -WorkspaceName <String>
 [-SubscriptionId <String[]>] [-DefaultProfile <PSObject>] [<CommonParameters>]
```

### GetViaIdentity
```
Get-AzSynapseBigDataPool -InputObject <ISynapseIdentity> [-DefaultProfile <PSObject>] [<CommonParameters>]
```

## DESCRIPTION
Get a Big Data pool.

## EXAMPLES

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

## PARAMETERS

### -DefaultProfile
The credentials, account, tenant, and subscription used for communication with Azure.

```yaml
Type: System.Management.Automation.PSObject
Parameter Sets: (All)
Aliases: AzureRMContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -InputObject
Identity Parameter
To construct, see NOTES section for INPUTOBJECT properties and create a hash table.

```yaml
Type: Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.ISynapseIdentity
Parameter Sets: GetViaIdentity
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: True (ByValue)
Accept wildcard characters: False
Dynamic: False
```

### -Name
Big Data pool name

```yaml
Type: System.String
Parameter Sets: Get
Aliases: BigDataPoolName

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -ResourceGroupName
The name of the resource group.
The name is case insensitive.

```yaml
Type: System.String
Parameter Sets: Get, List
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -SubscriptionId
The ID of the target subscription.

```yaml
Type: System.String[]
Parameter Sets: Get, List
Aliases:

Required: False
Position: Named
Default value: (Get-AzContext).Subscription.Id
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### -WorkspaceName
The name of the workspace

```yaml
Type: System.String
Parameter Sets: Get, List
Aliases:

Required: True
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
Dynamic: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see [about_CommonParameters](http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.ISynapseIdentity

## OUTPUTS

### Microsoft.Azure.PowerShell.Cmdlets.Synapse.Models.Api20190601Preview.IBigDataPoolResourceInfo

## ALIASES

## NOTES

### COMPLEX PARAMETER PROPERTIES
To create the parameters described below, construct a hash table containing the appropriate properties. For information on hash tables, run Get-Help about_Hash_Tables.

#### INPUTOBJECT <ISynapseIdentity>: Identity Parameter
  - `[ActionName <String>]`: Integration runtime action
  - `[BaselineName <VulnerabilityAssessmentPolicyBaselineName?>]`: The name of the vulnerability assessment rule baseline (default implies a baseline on a Sql pool level rule and master for workspace level rule).
  - `[BigDataPoolName <String>]`: Big Data pool name
  - `[BlobAuditingPolicyName <String>]`: The name of the blob auditing policy.
  - `[ColumnName <String>]`: The name of the column.
  - `[ConnectionPolicyName <ConnectionPolicyName?>]`: The name of the connection policy.
  - `[DataWarehouseUserActivityName <DataWarehouseUserActivityName?>]`: The activity name of the Sql pool. 
  - `[GeoBackupPolicyName <GeoBackupPolicyName?>]`: The name of the geo backup policy.
  - `[Id <String>]`: Resource identity path
  - `[IntegrationRuntimeName <String>]`: Integration runtime name
  - `[NodeName <String>]`: Integration runtime node name
  - `[OperationId <String>]`: Integration runtime operation ID
  - `[ResourceGroupName <String>]`: The name of the resource group. The name is case insensitive.
  - `[RuleId <String>]`: The vulnerability assessment rule ID.
  - `[RuleName <String>]`: The IP firewall rule name
  - `[ScanId <String>]`: The vulnerability assessment scan Id of the scan to retrieve.
  - `[SchemaName <String>]`: The name of the schema.
  - `[SecurityAlertPolicyName <SecurityAlertPolicyName?>]`: The name of the security alert policy.
  - `[SensitivityLabelSource <WritableSensitivityLabelSource?>]`: The source of the sensitivity label.
  - `[SqlPoolName <String>]`: SQL pool name
  - `[SubscriptionId <String>]`: The ID of the target subscription.
  - `[TableName <String>]`: The name of the table.
  - `[TransparentDataEncryptionName <TransparentDataEncryptionName?>]`: The name of the transparent data encryption configuration.
  - `[VulnerabilityAssessmentName <VulnerabilityAssessmentName?>]`: The name of the vulnerability assessment.
  - `[WorkspaceName <String>]`: The name of the workspace

## RELATED LINKS


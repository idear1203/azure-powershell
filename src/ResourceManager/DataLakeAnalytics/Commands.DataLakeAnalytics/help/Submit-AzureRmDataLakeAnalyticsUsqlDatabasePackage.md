---
external help file: Microsoft.Azure.Commands.DataLakeAnalytics.dll-Help.xml
Module Name: AzureRM.DataLakeAnalytics
online version:
schema: 2.0.0
---

# Submit-AzureRmDataLakeAnalyticsUsqlDatabasePackage

## SYNOPSIS
Submits a U-SQL database deployment package.

## SYNTAX

### SubmitUSqlDatabasePackage (Default)
```
Submit-AzureRmDataLakeAnalyticsUsqlDatabasePackage [-Account] <String> [-Database] <String> [-Package] <String>
 [-PassThru] [-DefaultProfile <IAzureContextContainer>] [<CommonParameters>]
```

### SubmitUSqlDatabasePackageWithResourceGroup
```
Submit-AzureRmDataLakeAnalyticsUsqlDatabasePackage [-Account] <String> [-ResourceGroupName] <String>
 [-Database] <String> [-Package] <String> [-PassThru] [-DefaultProfile <IAzureContextContainer>]
 [<CommonParameters>]
```

## DESCRIPTION
The **Submit-AzureRmDataLakeAnalyticsUsqlDatabasePackage** cmdlet submits a U-SQL database deployment package to setup the database environment in Azure Data Lake Analytics.

## EXAMPLES

### Example 1: Submit a U-SQL database deployment package
```powershell
PS C:\> Submit-AdlUsqlDbPackage -Account "contosoadla" -Database "databaseName" -Package "packagePath"
```

This command submits a U-SQL database deployment package.

## PARAMETERS

### -Account
Name of a specific account.

```yaml
Type: String
Parameter Sets: (All)
Aliases: AccountName

Required: True
Position: 0
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -Database
Name of the database to deploy to.

```yaml
Type: String
Parameter Sets: (All)
Aliases: DatabaseName

Required: True
Position: 1
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -DefaultProfile
The credentials, account, tenant, and subscription used for communication with Azure.

```yaml
Type: IAzureContextContainer
Parameter Sets: (All)
Aliases: AzureRmContext, AzureCredential

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -Package
Path of the package to deploy.

```yaml
Type: String
Parameter Sets: (All)
Aliases:

Required: True
Position: 2
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### -PassThru
Indicates a boolean response should be returned indicating the result of the delete operation.

```yaml
Type: SwitchParameter
Parameter Sets: (All)
Aliases:

Required: False
Position: Named
Default value: None
Accept pipeline input: False
Accept wildcard characters: False
```

### -ResourceGroupName
Name of resource group under which want to retrieve the account.

```yaml
Type: String
Parameter Sets: SubmitUSqlDatabasePackageWithResourceGroup
Aliases:

Required: True
Position: 1
Default value: None
Accept pipeline input: True (ByPropertyName)
Accept wildcard characters: False
```

### CommonParameters
This cmdlet supports the common parameters: -Debug, -ErrorAction, -ErrorVariable, -InformationAction, -InformationVariable, -OutVariable, -OutBuffer, -PipelineVariable, -Verbose, -WarningAction, and -WarningVariable. For more information, see about_CommonParameters (http://go.microsoft.com/fwlink/?LinkID=113216).

## INPUTS

### System.String

## OUTPUTS

### System.Boolean

If PassThru is specified, returns true upon successful completion.

## NOTES

## RELATED LINKS

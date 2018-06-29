using System.Management.Automation;
using Microsoft.Azure.Commands.DataLakeAnalytics.Models;
using Microsoft.Azure.Commands.ResourceManager.Common.ArgumentCompleters;

namespace Microsoft.Azure.Commands.DataLakeAnalytics.Commands
{
    [Cmdlet(VerbsLifecycle.Submit, "AzureRmDataLakeAnalyticsUsqlDatabasePackage", DefaultParameterSetName = USqlDbPackageParameterSetName),
     OutputType(typeof(bool))]
    [Alias("Submit-AdlUsqlDbPackage")]
    public class SubmitAzureRmDataLakeAnalyticsUsqlDatabasePackage : DataLakeAnalyticsCmdletBase
    {
        internal const string USqlDbPackageParameterSetName = "SubmitUSqlDatabasePackage";
        internal const string USqlDbPackageWithResourceGroupParameterSetName = "SubmitUSqlDatabasePackageWithResourceGroup";

        [Parameter(ValueFromPipelineByPropertyName = true, Position = 0,
            Mandatory = true, HelpMessage = "Name of a specific account.")]
        [ValidateNotNullOrEmpty]
        [Alias("AccountName")]
        public string Account { get; set; }

        [Parameter(ParameterSetName = USqlDbPackageWithResourceGroupParameterSetName, ValueFromPipelineByPropertyName = true,
            Position = 1, Mandatory = true,
            HelpMessage = "Name of resource group under which want to retrieve the account.")]
        [ResourceGroupCompleter]
        [ValidateNotNullOrEmpty]
        public string ResourceGroupName { get; set; }

        [Parameter(ParameterSetName = USqlDbPackageParameterSetName, ValueFromPipelineByPropertyName = true, Position = 1,
            Mandatory = true, HelpMessage = "Name of the database to deploy to.")]
        [Parameter(ParameterSetName = USqlDbPackageWithResourceGroupParameterSetName, ValueFromPipelineByPropertyName = true,
            Position = 2, Mandatory = true,
            HelpMessage = "Name of the database to deploy to.")]
        [ValidateNotNullOrEmpty]
        [Alias("DatabaseName")]
        public string Database { get; set; } 

        [Parameter(ParameterSetName = USqlDbPackageParameterSetName, ValueFromPipelineByPropertyName = true, Position = 2,
            Mandatory = true, HelpMessage = "Path of the package to deploy.")]
        [Parameter(ParameterSetName = USqlDbPackageWithResourceGroupParameterSetName, ValueFromPipelineByPropertyName = true,
            Position = 3, Mandatory = true,
            HelpMessage = "Path of the package to deploy.")]
        [ValidateNotNullOrEmpty]
        public string Package { get; set; }

        [Parameter(Mandatory = false,
            HelpMessage = "Indicates a boolean response should be returned indicating the result of the delete operation.")]
        public SwitchParameter PassThru { get; set; }

        public override void ExecuteCmdlet()
        {
            string jobPrefix = "DeployDatabase" + Database + "_";
            DataLakeAnalyticsClient.SubmitUsqlDatabsePackage(ResourceGroupName, Account, jobPrefix, Package, Database);
            if (PassThru)
            {
                WriteObject(true);
            }
        }
    }
}

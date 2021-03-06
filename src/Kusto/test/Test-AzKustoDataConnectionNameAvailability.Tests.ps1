Describe 'Test-AzKustoDataConnectionNameAvailability' {
    BeforeAll{
        $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
        if (-Not (Test-Path -Path $loadEnvPath)) {
            $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
        }
        . ($loadEnvPath)
        $TestRecordingFile = Join-Path $PSScriptRoot 'Test-AzKustoDataConnectionNameAvailability.Recording.json'
        $currentPath = $PSScriptRoot
        while (-not $mockingPath) {
            $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
            $currentPath = Split-Path -Path $currentPath -Parent
        }
        . ($mockingPath | Select-Object -First 1).FullName
    }
    It 'CheckExpanded' {
        $resourceGroupName = $env.resourceGroupNamefordc
        $clusterName = $env.clusterNamefordc
        $databaseName = $env.databaseNamefordc
        $dataConnectionName = $env.dataConnectionName

        $availability = Test-AzKustoDataConnectionNameAvailability -ResourceGroupName $resourceGroupName -ClusterName $clusterName -DatabaseName $databaseName -Name $dataConnectionName
        $availability.NameAvailable | Should -Be $false
    }

    It 'CheckViaIdentityExpanded' {
        $resourceGroupName = $env.resourceGroupNamefordc
        $clusterName = $env.clusterNamefordc
        $databaseName = $env.databaseNamefordc
        $dataConnectionName = $env.dataConnectionName + $env.rstr4

        $database = Get-AzKustoDatabase -ResourceGroupName $resourceGroupName -ClusterName $clusterName -Name $databaseName
        $availability = Test-AzKustoDataConnectionNameAvailability -InputObject $database -Name $dataConnectionName
        $availability.NameAvailable | Should -Be $true
    }
}

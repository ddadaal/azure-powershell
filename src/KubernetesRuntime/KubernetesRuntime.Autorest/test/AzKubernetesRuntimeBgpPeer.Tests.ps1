
if (($null -eq $TestName) -or ($TestName -contains 'AzKubernetesRuntimeBgpPeer')) {
    $loadEnvPath = Join-Path $PSScriptRoot 'loadEnv.ps1'
    if (-Not (Test-Path -Path $loadEnvPath)) {
        $loadEnvPath = Join-Path $PSScriptRoot '..\loadEnv.ps1'
    }
    . ($loadEnvPath)
    $TestRecordingFile = Join-Path $PSScriptRoot 'AzKubernetesRuntimeBgpPeer.Recording.json'
    $currentPath = $PSScriptRoot
    while (-not $mockingPath) {
        $mockingPath = Get-ChildItem -Path $currentPath -Recurse -Include 'HttpPipelineMocking.ps1' -File
        $currentPath = Split-Path -Path $currentPath -Parent
    }
    . ($mockingPath | Select-Object -First 1).FullName
}

Describe 'AzKubernetesRuntimeBgpPeer' {

    $resourceUri = "/subscriptions/$($env.SubscriptionId)/resourceGroups/$($env.ResourceGroup)/providers/Microsoft.Kubernetes/connectedClusters/$($env.ArcName)"
    $extensionName = "arcnetworking"

    It 'Enables Networking service' {
        if ($TestMode -eq 'playback') {
            return
        }

        $output = Enable-AzKubernetesRuntimeLoadBalancer -ResourceUri $resourceUri

        $output.Extension.Name | Should -Be $extensionName

        { Get-AzKubernetesExtension -ResourceGroupName $env.ResourceGroup -ClusterName $env.ArcName -ClusterType ConnectedClusters -Name $extensionName } | Should -Not -Throw

    }

    It "Creates, Gets and Deletes a bgp peer" {

        $newBgpPeerName = "test1"
        $myAsn = "10000"
        $peerAsn = "20000"
        $peerAddress = "192.168.50.1"
        Write-Host "Creating a bgp peer"

        $output = New-AzKubernetesRuntimeBgpPeer `
            -ResourceUri $resourceUri `
            -Name $newBgpPeerName `
            -MyAsn $myAsn `
            -PeerAsn $peerAsn `
            -PeerAddress $peerAddress -Verbose

        $output.TypeProperty.Type | Should -Be $typeProperty.Type

        Get-AzKubernetesRuntimeBgpPeer -ResourceUri $resourceUri -Name $newBgpPeerName | ConvertTo-Json | Should -Be ($output | ConvertTo-Json)

        Remove-AzKubernetesRuntimeBgpPeer -ResourceUri $resourceUri -Name $newBgpPeerName

        { Get-AzKubernetesRuntimeBgpPeer -ResourceUri $resourceUri -Name $newBgpPeerName } | Should -Throw

    }

    It 'Disables networking service ' {

        if ($TestMode -eq 'playback') {
            return
        }

        Disable-AzKubernetesRuntimeLoadBalancer -ResourceUri $resourceUri

        { Get-AzKubernetesExtension -ResourceGroupName $env.ResourceGroup -ClusterName $env.ArcName -ClusterType ConnectedClusters -Name $extensionName } | Should -Throw
    }
}
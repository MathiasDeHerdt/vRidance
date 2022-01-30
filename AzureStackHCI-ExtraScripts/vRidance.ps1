# ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
# NAMING CONVENTIONS
#
# For functions --> verb-Subject
# ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

# ********************************************************************************************************
# FUNCTION: check the path to xml file exists
# ********************************************************************************************************
function check-PathXML {
    if (Test-Path $XML_Path) {
    }

    else {
        Write-Host "$XML_Path does not exist"
        Write-Host "Stopping the script!"

        exit 100
    }
}

# ********************************************************************************************************
# FUNCTION: check the path boot device path exists
# ********************************************************************************************************
function check-BootDevicePath {
    if (Test-Path $BootDevicePath) {
    }

    else {
        Write-Host "$BootDevicePath does not exist"
        Write-Host "Stopping the script!"

        exit 101
    }
}

# ********************************************************************************************************
# FUNCTION: check the boot device extention and assign the generation
# ********************************************************************************************************
function check-BootDeviceExtention {
    if ($BootDeviceExstention -eq "VHD") {
    }

    elseif ($BootDeviceExstention -eq "VHDX") {
    }

    else {
        Write-Host "$BootDeviceExstention is incorrect"
        Write-Host "    Should be VHD or VHDX"
        Write-Host "Stopping the script!"

        exit 102
    }
}


# ********************************************************************************************************
# FUNCTION: read data from xml file
# ********************************************************************************************************
function read-DataFromXML {
    param([string]$FileLocation)
    
    [Xml.XmlDocument]$script:XML_ConfigFile     = Get-Content -LiteralPath $FileLocation

    $script:XML_Config                          = $XML_ConfigFile.Configuration                                      

    # ====================================================================================
    # Credential not used anymore
    # ====================================================================================
    [Xml.XmlElement]$CredentialElement          = $XML_Config.Credentials                            

    $Script:RemoteMachineName                   = $CredentialElement.MachineName
    $Script:DomainAdmin                         = $CredentialElement.DomainAdmin

    # ====================================================================================
    # Create Virtual Machine
    # ====================================================================================
    [Xml.XmlElement]$CreateVMElement            = $XML_Config.CreateVM                                 

    $Script:Hostname                            = $CreateVMElement.HostName
    $Script:VMName                              = $CreateVMElement.VMName
    $Script:ClusterName                         = $CreateVMElement.ClusterName
    $Script:MemoryStartup                       = $CreateVMElement.MemoryStartup                                   
    $Script:MinimumBytes                        = $CreateVMElement.MinimumBytes
    $Script:MaximumBytes                        = $CreateVMElement.MaximumBytes
    $Script:BootDeviceExstention                = $CreateVMElement.BootDeviceExstention
    $Script:BootDevicePath                      = $CreateVMElement.BootDevicePath                                
    $Script:NetworkSwitchName                   = $CreateVMElement.NetworkAdapter
    $Script:LocationPath                        = $CreateVMElement.LocationPath

    check-BootDeviceExtention $BootDeviceExstention
    check-BootDevicePath $BootDevicePath

    create-VirtualMachine
}

# ********************************************************************************************************
# FUNCTION: Create virtual machines
# ********************************************************************************************************
function create-VirtualMachine {

    Write-Host "Creating virtual machine"	
    new-vm -ComputerName $Hostname -name $VMName -MemoryStartupBytes (Invoke-Expression $MemoryStartup) -Generation 2 -Path $LocationPath -SwitchName $NetworkSwitchName
    Start-Sleep -s 1

    Write-Host "Remove existing VMD drive"
    Remove-VMDvdDrive -VMName $VMName -ControllerNumber 1 -ControllerLocation 0
    Start-Sleep -s 1

    Write-Host "Adding VHD drive"
    Add-VMHardDiskDrive -VMName $VMName -ControllerType SCSI -Path $BootDevicePath
    Start-Sleep 1

    Write-Host "Assigning memory"
    Set-VMMemory $VMName -DynamicMemoryEnabled $true -MinimumBytes (Invoke-Expression $MinimumBytes) -MaximumBytes (Invoke-Expression $MaximumBytes) -Priority 80 -Buffer 25
    Start-Sleep 1

    migrate-VirtualMachineToCluster
}

# ********************************************************************************************************
# FUNCTION: Migrate virtual machine to cluster
# ********************************************************************************************************
function migrate-VirtualMachineToCluster {
    Write-Host "Adding VM to cluster"
    Add-ClusterVirtualMachineRole -Name $VMName -VirtualMachine $VMName -Cluster $ClusterName
}

# ********************************************************************************************************
# FUNCTION: The main script
# ********************************************************************************************************
function main-Script {
    $Path_Location = Get-Location
    $XML_Path = "$Path_Location\Config.xml"

    check-PathXML

    read-DataFromXML $XML_Path
}


main-Script

# ********************************************************************************************************
# Used sources
# ********************************************************************************************************
# https://docs.microsoft.com/en-us/powershell/module/hyper-v/?view=windowsserver2022-ps
# https://docs.microsoft.com/en-us/powershell/module/hyper-v/start-vm?view=windowsserver2022-ps
# https://docs.microsoft.com/en-us/azure-stack/hci/manage/vm-powershell
# https://docs.microsoft.com/en-us/powershell/module/hyper-v/add-vmharddiskdrive?view=windowsserver2022-ps
# https://www.reddit.com/r/PowerShell/comments/scwnry/azure_stack_hci_move_vm_from_node_to_cluster/
# https://docs.microsoft.com/en-us/powershell/module/failoverclusters/add-clustervirtualmachinerole?view=windowsserver2022-ps

# ********************************************************************************************************
# Community posts I made
# ********************************************************************************************************
# https://techcommunity.microsoft.com/t5/azure-stack/azure-stack-hci-move-vm-from-node-to-cluster/m-p/3071854
# https://www.reddit.com/r/PowerShell/comments/scwnry/azure_stack_hci_move_vm_from_node_to_cluster/
# https://stackoverflow.com/questions/70858498/azure-stack-hci-move-vm-from-node-to-cluster
# https://stackoverflow.com/questions/70858996/system-int64-error-input-string-was-not-in-a-correct-format
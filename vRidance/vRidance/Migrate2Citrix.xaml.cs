using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Renci.SshNet;

namespace vRidance
{
    /// <summary>
    /// Interaction logic for Migrate2Citrix.xaml
    /// </summary>
    public partial class Migrate2Citrix : Window
    {
        string citrix_host, citrix_username, citrix_password, folderPath;

        string os_type;

        bool nextIsClicked = false;
        string SrUuid = "";
        string DiskSize = "";

        Thread changeParamsThread;
        public Migrate2Citrix(string theme, string host, string var_username, string var_password, string var_path)
        {

            this.citrix_host = host;
            this.citrix_username = var_username;
            this.citrix_password = var_password;
            this.folderPath = var_path;

            this.nextIsClicked = false;
            InitializeComponent();

            rectClose.Visibility = Visibility.Hidden;

            if (theme.ToLower() == "dark")
            {
                var bc3 = new BrushConverter();
                Uri resourceUri3 = new Uri("Assets/bg_dark.png", UriKind.Relative);
                System.Windows.Resources.StreamResourceInfo streamInfo3 = System.Windows.Application.GetResourceStream(resourceUri3);

                BitmapFrame temp3 = BitmapFrame.Create(streamInfo3.Stream);
                var brush3 = new ImageBrush();
                brush3.ImageSource = temp3;

                grdMain4.Background = brush3;

                lblPMStart.Foreground = Brushes.White;
                //pwbPassword.Background = (Brush)bc3.ConvertFrom("#66DEDEDE");
                //txtUsername.Background = (Brush)bc3.ConvertFrom("#66DEDEDE");

                rectDark.Visibility = Visibility.Hidden;
                rectMode.Visibility = Visibility.Visible;


            }
            else if (theme.ToLower() == "light")
            {
                var bc3 = new BrushConverter();
                Uri resourceUri3 = new Uri("Assets/bg_light.png", UriKind.Relative);
                System.Windows.Resources.StreamResourceInfo streamInfo3 = System.Windows.Application.GetResourceStream(resourceUri3);

                BitmapFrame temp3 = BitmapFrame.Create(streamInfo3.Stream);
                var brush3 = new ImageBrush();
                brush3.ImageSource = temp3;

                grdMain4.Background = brush3;

                lblPMStart.Foreground = Brushes.Black;
                //pwbPassword.Background = (Brush)bc3.ConvertFrom("#661E1E1E");
                //txtUsername.Background = (Brush)bc3.ConvertFrom("#661E1E1E");

                rectDark.Visibility = Visibility.Visible;
                rectMode.Visibility = Visibility.Hidden;
            }

            changeParamsThread = new Thread(changeParams);
            changeParamsThread.Start();

        }

        private void rectMode_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                var bc2 = new BrushConverter();
                Uri resourceUri2 = new Uri("Assets/bg_light.png", UriKind.Relative);
                System.Windows.Resources.StreamResourceInfo streamInfo2 = System.Windows.Application.GetResourceStream(resourceUri2);

                BitmapFrame temp2 = BitmapFrame.Create(streamInfo2.Stream);
                var brush2 = new ImageBrush();
                brush2.ImageSource = temp2;

                grdMain4.Background = brush2;

                lblPMStart.Foreground = Brushes.Black;
                //pwbPassword.Background = (Brush)bc2.ConvertFrom("#661E1E1E");
                //txtUsername.Background = (Brush)bc2.ConvertFrom("#661E1E1E");

                rectDark.Visibility = Visibility.Visible;
                rectMode.Visibility = Visibility.Hidden;
            }
            catch (Exception)
            {

                //throw;
                System.Windows.MessageBox.Show("Something went wrong.");
            }
        }


        private void rectDark_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                var bc = new BrushConverter();
                Uri resourceUri = new Uri("Assets/bg_dark.png", UriKind.Relative);
                System.Windows.Resources.StreamResourceInfo streamInfo = System.Windows.Application.GetResourceStream(resourceUri);

                BitmapFrame temp = BitmapFrame.Create(streamInfo.Stream);
                var brush = new ImageBrush();
                brush.ImageSource = temp;

                grdMain4.Background = brush;

                lblPMStart.Foreground = Brushes.White;
                //pwbPassword.Background = (Brush)bc.ConvertFrom("#66DEDEDE");
                //txtUsername.Background = (Brush)bc.ConvertFrom("#66DEDEDE");

                rectDark.Visibility = Visibility.Hidden;
                rectMode.Visibility = Visibility.Visible;

            }
            catch (Exception)
            {

                //throw;
                System.Windows.MessageBox.Show("Something went wrong");
            }
        }

        private void rctTop_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ((MainWindow)this.Owner).Dragging();
        }

        private void rectClose_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }


        private void cbType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbType.SelectedIndex == 0)
            {
                List<string> versions = new List<string>();
                versions.Add("CentOS 7");
                versions.Add("CentOS 8");
                versions.Add("CoreOS");
                versions.Add("Debian Buster 10");
                versions.Add("Debian Jessie 8.0");
                versions.Add("Debian Stretch 9.0");
                versions.Add("NeoKylin Linux Server 7");
                versions.Add("Oracle Linux 7");
                versions.Add("Oracle Linux 8");
                versions.Add("Red Hat Enterprise Linux 7");
                versions.Add("Red Hat Enterprise Linux 8");
                versions.Add("Scientific Linux 7");
                versions.Add("SUSE Linux Enterprise 15 (64-bit)");
                versions.Add("SUSE Linux Enterprise Desktop 12 SP3 (64-bit)");
                versions.Add("SUSE Linux Enterprise Desktop 12 SP4 (64-bit)");
                versions.Add("SUSE Linux Enterprise Server 12 SP3 (64-bit)");
                versions.Add("SUSE Linux Enterprise Server 12 SP4 (64-bit)");
                versions.Add("SUSE Linux Enterprise Server 12 SP5 (64-bit)");
                versions.Add("Ubuntu Bionic Beaver 18.04");
                versions.Add("Ubuntu Focal Fossa 20.04");
                versions.Add("Ubuntu Xenial Xerus 160.4");
                cbVersion.ItemsSource = versions;
                cbVersion.IsEnabled = true;
            }
            else if (cbType.SelectedIndex == 1)
            {
                List<string> versions = new List<string>();
                versions.Add("Windows 8.1 (32-bit)");
                versions.Add("Windows 8.1 (64-bit)");
                versions.Add("Windows 10 (32-bit)");
                versions.Add("Windows 10 (64-bit)");
                versions.Add("Windows Server 2012 (64-bit)");
                versions.Add("Windows Server 2012 R2 (64-bit)");
                versions.Add("Windows Server 2016 (64-bit)");
                versions.Add("Windows Server 2019 (64-bit)");
                cbVersion.ItemsSource = versions;
                cbVersion.IsEnabled = true;
            }
        }


        private void rectNext_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

            if (cbType.SelectedIndex == 0)
            {
                if (cbVersion.SelectedIndex == 0) os_type = "CentOS 7";
                else if (cbVersion.SelectedIndex == 1) os_type = "CentOS 8";
                else if (cbVersion.SelectedIndex == 2) os_type = "CoreOS";
                else if (cbVersion.SelectedIndex == 3) os_type = "Debian Buster 10";
                else if (cbVersion.SelectedIndex == 4) os_type = "Debian Jessie 8.0";
                else if (cbVersion.SelectedIndex == 5) os_type = "Debian Stretch 9.0";
                else if (cbVersion.SelectedIndex == 6) os_type = "NeoKylin Linux Server 7";
                else if (cbVersion.SelectedIndex == 7) os_type = "Oracle Linux 7";
                else if (cbVersion.SelectedIndex == 8) os_type = "Oracle Linux 8";
                else if (cbVersion.SelectedIndex == 9) os_type = "Red Hat Enterprise Linux 7";
                else if (cbVersion.SelectedIndex == 10) os_type = "Red Hat Enterprise Linux 8";
                else if (cbVersion.SelectedIndex == 11) os_type = "Scientific Linux 7";
                else if (cbVersion.SelectedIndex == 12) os_type = "SUSE Linux Enterprise 15 (64-bit)";
                else if (cbVersion.SelectedIndex == 13) os_type = "SUSE Linux Enterprise Desktop 12 SP3 (64-bit)";
                else if (cbVersion.SelectedIndex == 14) os_type = "SUSE Linux Enterprise Desktop 12 SP4 (64-bit)";
                else if (cbVersion.SelectedIndex == 15) os_type = "SUSE Linux Enterprise Server 12 SP3 (64-bit)";
                else if (cbVersion.SelectedIndex == 16) os_type = "SUSE Linux Enterprise Server 12 SP4 (64-bit)";
                else if (cbVersion.SelectedIndex == 17) os_type = "SUSE Linux Enterprise Server 12 SP5 (64-bit)";
                else if (cbVersion.SelectedIndex == 18) os_type = "Ubuntu Bionic Beaver 18.04";
                else if (cbVersion.SelectedIndex == 19) os_type = "Ubuntu Focal Fossa 20.04";
                else if (cbVersion.SelectedIndex == 20) os_type = "Ubuntu Xenial Xerus 160.4";
            }
            else if (cbType.SelectedIndex == 1)
            {
                if (cbVersion.SelectedIndex == 0) os_type = "Windows 8.1 (32-bit)";
                else if (cbVersion.SelectedIndex == 1) os_type = "Windows 8.1 (64-bit)";
                else if (cbVersion.SelectedIndex == 2) os_type = "Windows 10 (32-bit)";
                else if (cbVersion.SelectedIndex == 3) os_type = "Windows 10 (64-bit)";
                else if (cbVersion.SelectedIndex == 4) os_type = "Windows Server 2012 (64-bit)";
                else if (cbVersion.SelectedIndex == 5) os_type = "Windows Server 2012 R2 (64-bit)";
                else if (cbVersion.SelectedIndex == 6) os_type = "Windows Server 2016 (64-bit)";
                else if (cbVersion.SelectedIndex == 7) os_type = "Windows Server 2019 (64-bit)";
            }

            SrUuid = txtSrUuid.Text;
            DiskSize = txtDiskSize.Text;
            lblCurrVM.Visibility = Visibility.Visible;

            nextIsClicked = true;

        }

        private void grdMain4_LayoutUpdated(object sender, EventArgs e)
        {
            if (cbVersion.SelectedIndex >= 0 && txtDiskSize.Text != "" && txtDiskSize.Text != null && txtSrUuid.Text != "" && txtSrUuid.Text != null)
            {
                rectNext.Opacity = 1;
                rectNext.IsEnabled = true;
            }
        }

        private void grdMain_Initialized(object sender, EventArgs e)
        {
            rectDark.Visibility = Visibility.Hidden;
            rectNext.Opacity = 0.5;
            rectNext.IsEnabled = false;
            cbVersion.IsEnabled = false;
        }

        public void changeParams()
        {
            if (folderPath != "")
            {
                string[] subdirectoryEntries = Directory.GetDirectories(folderPath);

                foreach (var var_subdirectory in subdirectoryEntries)
                {
                    DirectoryInfo di = new DirectoryInfo(@"" + var_subdirectory);
                    string DirectoryName = di.Name;
                    this.Dispatcher.Invoke(() =>
                    {

                        this.Dispatcher.Invoke(() => { pbProgress.Value = 0; });
                        lblCurrVM.Content = $"Settings for {DirectoryName}";
                        rectNext.Opacity = 0.5;
                        rectNext.IsEnabled = false;
                        cbVersion.IsEnabled = false;
                        List<string> types = new List<string>();
                        types.Add("Linux");
                        types.Add("Microsoft Windows");
                        cbType.ItemsSource = types;
                    });

                    while (true)
                    {
                        Thread.Sleep(100);
                        if (nextIsClicked == true)
                        {
                            this.Dispatcher.Invoke(() =>
                            {
                                cbType.IsEnabled = false;
                                cbVersion.IsEnabled = false;
                                rectNext.IsEnabled = false;
                                rectNext.Opacity = 0.5;
                                lblCurrVM.Content = $"Creating VM {DirectoryName}";
                            });
                            nextIsClicked = false;
                            createTheVMS(var_subdirectory.ToString());
                            //MessageBox.Show($"folderPath: {folderPath}, subdirectoryName: {DirectoryName}, proxHost: {prox_host}, username: {prox_username}, password: {prox_password}, start_vmid: {start_vmid}, os_type: {os_type}, cpu_cores: {cpu_cores}, memory: {memory}");
                            this.Dispatcher.Invoke(() =>
                            {
                                cbType.ItemsSource = "";
                                cbVersion.ItemsSource = "";
                                cbType.IsEnabled = true;
                                cbVersion.IsEnabled = true;
                                rectNext.IsEnabled = true;
                                rectNext.Opacity = 1;
                            });
                            break;
                        }
                    }
                }
            }

            this.Dispatcher.Invoke(() =>
            {
                rectClose.Visibility = Visibility.Visible;
                lblCurrVM.Content = $"Migration Completed!";
                cbType.IsEnabled = false;
                cbVersion.IsEnabled = false;
                this.Dispatcher.Invoke(() => { pbProgress.Value = 0; });
            });
        }

        public void createTheVMS(string subdirectory) 
        {
            string[] VMDirectory = Directory.GetFiles(@"" + subdirectory, "*-flat.vmdk");

            DirectoryInfo di = new DirectoryInfo(@"" + subdirectory);
            string DirectoryName = di.Name;

            if (os_type != null)
            {
                AuthenticationMethod method_citrix = new PasswordAuthenticationMethod(citrix_username, citrix_password);
                ConnectionInfo connection_citrix = new ConnectionInfo(citrix_host, citrix_username, method_citrix);
                var client = new SshClient(connection_citrix);

                if (os_type.Contains("Windows"))
                {
                    this.Dispatcher.Invoke(() => { pbProgress.Value = 0; });
                    Debug.WriteLine("Connecting to host...");
                    client.Connect();
                    Debug.WriteLine("Connected!");
                    Debug.WriteLine($"Creating VM {DirectoryName}, Please Wait...");
                    string createVM = $"xe vm-install template=\"{os_type}\" new-name-label=\"{DirectoryName}\" {SrUuid}";
                    this.Dispatcher.Invoke(() => { pbProgress.Value = 9.09; });
                    Debug.WriteLine(createVM); var createVMResult = client.RunCommand(createVM);
                    string vmUuid = createVMResult.Result.TrimEnd();
                    string createVdi = $"xe vdi-create sr-uuid=\"{SrUuid}\" name-label=\"{DirectoryName + "_Disk"}\" virtual-size={DiskSize}";
                    this.Dispatcher.Invoke(() => { pbProgress.Value += 9.09; });
                    Debug.WriteLine(createVdi); var createVdiResult = client.RunCommand(createVdi);
                    string vdiUuid = createVdiResult.Result.TrimEnd();
                    Debug.WriteLine(vdiUuid);
                    string importResult = "";
                    foreach (var file in VMDirectory)
                    {
                        FileInfo fi = new FileInfo(@"" + file);
                        string fileName = fi.Name;
                        this.Dispatcher.Invoke(() => { pbProgress.Value += 9.09; });
                        string vmdkImport = $"xe vdi-import uuid={vdiUuid} filename=/mnt/VMDKShare/{DirectoryName}/{fileName} format=raw --progress";
                        Debug.WriteLine(vmdkImport); var createImportResult = client.RunCommand(vmdkImport);
                        importResult = createImportResult.Result;
                        //Debug.WriteLine(importResult);
                        Debug.WriteLine("Importing file, please wait.");

                    }
                    string getVmVDI = $"xe vm-disk-list vm={vmUuid} | grep 'uuid ( RO)             :' | sed 's/^.*: //' | sed -n 2p";
                    this.Dispatcher.Invoke(() => { pbProgress.Value += 9.09; });
                    Debug.WriteLine(getVmVDI); var createExistingVDIResult = client.RunCommand(getVmVDI);
                    List<string> templateVDI = createExistingVDIResult.Result.ToCharArray().Select(c => c.ToString()).ToList();
                    string newLine = "";
                    foreach (string character in templateVDI)
                    {
                        //Debug.WriteLine(character);
                        newLine = newLine.Insert(newLine.Length, character.ToString());
                    }
                    //Debug.WriteLine(newLine);
                    string removeTemplateDisk = $"xe vdi-destroy uuid={newLine}";
                    this.Dispatcher.Invoke(() => { pbProgress.Value += 9.09; });
                    Debug.WriteLine(removeTemplateDisk); var removedDisk = client.RunCommand(removeTemplateDisk);
                    //HIER BOVEN BESTAANDE VM DISK VERWIJDEREN
                    string createVdb = $"xe vbd-create vm-uuid={vmUuid} device=0 vdi-uuid={vdiUuid} bootable=true mode=RW type=Disk";
                    this.Dispatcher.Invoke(() => { pbProgress.Value += 9.09; });
                    Debug.WriteLine(createVdb); var createVdbResult = client.RunCommand(createVdb);
                    string vdbUuid = createVdbResult.Result.TrimEnd();
                    Debug.WriteLine(vdbUuid);
                    string startVm = $"xe vm-start uuid={vmUuid}";
                    this.Dispatcher.Invoke(() => { pbProgress.Value += 9.09; });
                    Debug.WriteLine(startVm); var vmStartedResult = client.RunCommand(startVm);
                    string attachDisk = $"xe vbd-plug uuid={vdbUuid} device=0 vdi-uuid={vdiUuid}";
                    this.Dispatcher.Invoke(() => { pbProgress.Value += 9.09; });
                    Debug.WriteLine(attachDisk); var attachDiskResult = client.RunCommand(attachDisk);
                    string stopVm = $"xe vm-shutdown uuid={vmUuid}";
                    this.Dispatcher.Invoke(() => { pbProgress.Value += 9.09; });
                    Debug.WriteLine(stopVm); var stopVmResult = client.RunCommand(stopVm);
                    string changeBootOption = $"xe vm-param-set uuid={vmUuid} HVM-boot-params:firmware=uefi";
                    this.Dispatcher.Invoke(() => { pbProgress.Value += 9.09; });
                    Debug.WriteLine(changeBootOption); var changeBootOptionResult = client.RunCommand(changeBootOption);
                    string changeSecureBoot = $"xe vm-param-set uuid={vmUuid} platform:secureboot=false ";
                    this.Dispatcher.Invoke(() => { pbProgress.Value += 9.09; });
                    Debug.WriteLine(changeSecureBoot); var changeSecureBootResult = client.RunCommand(changeSecureBoot);
                    Debug.WriteLine(startVm); client.RunCommand(startVm);

                    client.Disconnect();

                }
                else if (os_type.Contains("CentOS") || os_type.Contains("CoreOS") || os_type.Contains("Debian") || os_type.Contains("Linux") || os_type.Contains("Red Hat") || os_type.Contains("Ubuntu") || os_type.Contains("SUSE"))
                {
                    this.Dispatcher.Invoke(() => { pbProgress.Value = 0; });
                    Debug.WriteLine("Connecting to host...");
                    client.Connect();
                    Debug.WriteLine("Connected!");
                    Debug.WriteLine($"Creating VM {DirectoryName}, Please Wait...");
                    string createVM = $"xe vm-install template=\"{os_type}\" new-name-label=\"{DirectoryName}\" {SrUuid}";
                    this.Dispatcher.Invoke(() => { pbProgress.Value = 12.5; });
                    Debug.WriteLine(createVM); var createVMResult = client.RunCommand(createVM);
                    string vmUuid = createVMResult.Result.TrimEnd();
                    string createVdi = $"xe vdi-create sr-uuid=\"{SrUuid}\" name-label=\"{DirectoryName + "_Disk"}\" virtual-size={DiskSize}";
                    this.Dispatcher.Invoke(() => { pbProgress.Value += 12.5; });
                    Debug.WriteLine(createVdi); var createVdiResult = client.RunCommand(createVdi);
                    string vdiUuid = createVdiResult.Result.TrimEnd();
                    Debug.WriteLine(vdiUuid);
                    string importResult = "";
                    foreach (var file in VMDirectory)
                    {
                        FileInfo fi = new FileInfo(@"" + file);
                        string fileName = fi.Name;
                        this.Dispatcher.Invoke(() => { pbProgress.Value += 12.5; });
                        string vmdkImport = $"xe vdi-import uuid={vdiUuid} filename=/mnt/VMDKShare/{DirectoryName}/{fileName} format=raw --progress";
                        Debug.WriteLine(vmdkImport); var createImportResult = client.RunCommand(vmdkImport);
                        importResult = createImportResult.Result;
                        //Debug.WriteLine(importResult);
                        Debug.WriteLine("Importing file, please wait.");

                    }
                    string getVmVDI = $"xe vm-disk-list vm={vmUuid} | grep 'uuid ( RO)             :' | sed 's/^.*: //' | sed -n 2p";
                    this.Dispatcher.Invoke(() => { pbProgress.Value += 12.5; });
                    Debug.WriteLine(getVmVDI); var createExistingVDIResult = client.RunCommand(getVmVDI);
                    List<string> templateVDI = createExistingVDIResult.Result.ToCharArray().Select(c => c.ToString()).ToList();
                    string newLine = "";
                    foreach (string character in templateVDI)
                    {
                        //Debug.WriteLine(character);
                        newLine = newLine.Insert(newLine.Length, character.ToString());
                    }
                    //Debug.WriteLine(newLine);
                    string removeTemplateDisk = $"xe vdi-destroy uuid={newLine}";
                    this.Dispatcher.Invoke(() => { pbProgress.Value += 12.5; });
                    Debug.WriteLine(removeTemplateDisk); var removedDisk = client.RunCommand(removeTemplateDisk);
                    //HIER BOVEN BESTAANDE VM DISK VERWIJDEREN
                    string createVdb = $"xe vbd-create vm-uuid={vmUuid} device=0 vdi-uuid={vdiUuid} bootable=true mode=RW type=Disk";
                    this.Dispatcher.Invoke(() => { pbProgress.Value += 12.5; });
                    Debug.WriteLine(createVdb); var createVdbResult = client.RunCommand(createVdb);
                    string vdbUuid = createVdbResult.Result.TrimEnd();
                    Debug.WriteLine(vdbUuid);
                    string startVm = $"xe vm-start uuid={vmUuid}";
                    Debug.WriteLine(startVm); var vmStartedResult = client.RunCommand(startVm);
                    string attachDisk = $"xe vbd-plug uuid={vdbUuid} device=0 vdi-uuid={vdiUuid}";
                    this.Dispatcher.Invoke(() => { pbProgress.Value = +12.5; });
                    Debug.WriteLine(attachDisk); var attachDiskResult = client.RunCommand(attachDisk);

                    client.Disconnect();

                }
            }

        }

    }
}

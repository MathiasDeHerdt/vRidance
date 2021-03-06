using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;
using Renci.SshNet;
using System.Threading;

namespace vRidance
{
    /// <summary>
    /// Interaction logic for Migrate2Prox.xaml
    /// </summary>
    public partial class Migrate2Prox : Window
    {
        string prox_host, prox_username, prox_password, folderPath;
        int start_vmid, cpu_cores, memory;

        string os_type;

        bool nextIsClicked = false, vmCreated = false;

        double progress;

        Thread changeParamsThread;
        public Migrate2Prox(string theme, string host, string var_username, string var_password, string var_path, int var_start_id)
        {
            this.prox_host = host;
            this.prox_username = var_username;
            this.prox_password = var_password;
            this.folderPath = var_path;
            this.start_vmid = var_start_id;

            this.nextIsClicked = false;

            InitializeComponent();

            rectClose.Visibility = Visibility.Hidden;
            lblInfo.Content = "";
            changeTheme(theme);

            changeParamsThread = new Thread(changeParams);
            changeParamsThread.Start();


        }

        private void changeTheme(string theme)
        {
            if (theme.ToLower() == "dark")
            {
                var bc = new BrushConverter();
                Uri resourceUri3 = new Uri("Assets/bg_dark.png", UriKind.Relative);
                System.Windows.Resources.StreamResourceInfo streamInfo3 = System.Windows.Application.GetResourceStream(resourceUri3);

                BitmapFrame temp3 = BitmapFrame.Create(streamInfo3.Stream);
                var brush3 = new ImageBrush();
                brush3.ImageSource = temp3;

                grdMain4.Background = brush3;

                lblPMStart.Foreground = Brushes.White;
                lblCores.Foreground = Brushes.White;
                lblCurrVM.Foreground = Brushes.White;
                lblMemory.Foreground = Brushes.White;
                lblType.Foreground = Brushes.White;
                lblVersion.Foreground = Brushes.White;

                txtCores.Foreground = Brushes.White;
                txtMemory.Foreground = Brushes.White;

                txtCores.Background = (Brush)bc.ConvertFrom("#66DEDEDE");
                txtMemory.Background = (Brush)bc.ConvertFrom("#66DEDEDE");

                rectDark.Visibility = Visibility.Hidden;
                rectMode.Visibility = Visibility.Visible;


            }
            else if (theme.ToLower() == "light")
            {
                var bc = new BrushConverter();
                Uri resourceUri3 = new Uri("Assets/bg_light.png", UriKind.Relative);
                System.Windows.Resources.StreamResourceInfo streamInfo3 = System.Windows.Application.GetResourceStream(resourceUri3);

                BitmapFrame temp3 = BitmapFrame.Create(streamInfo3.Stream);
                var brush3 = new ImageBrush();
                brush3.ImageSource = temp3;

                grdMain4.Background = brush3;

                lblPMStart.Foreground = Brushes.Black;
                lblCores.Foreground = Brushes.Black;
                lblCurrVM.Foreground = Brushes.Black;
                lblMemory.Foreground = Brushes.Black;
                lblType.Foreground = Brushes.Black;
                lblVersion.Foreground = Brushes.Black;

                txtCores.Foreground = Brushes.Black;
                txtMemory.Foreground = Brushes.Black;

                txtCores.Background = (Brush)bc.ConvertFrom("#661E1E1E");
                txtMemory.Background = (Brush)bc.ConvertFrom("#661E1E1E");

                rectDark.Visibility = Visibility.Visible;
                rectMode.Visibility = Visibility.Hidden;
            }
        }

        private void rectMode_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            try
            {
                changeTheme("light");
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
                changeTheme("dark");
            }
            catch (Exception)
            {

                //throw;
                System.Windows.MessageBox.Show("Something went wrong");
            }
        }

        private void txtCores_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (txtCores.Text == "" && txtCores.Text == null)
                {
                    rectNext.Opacity = 0.5;
                    rectNext.IsEnabled = false;
                }
                else if (txtCores.Text != "" && txtCores.Text != null && txtMemory.Text != "" && txtMemory.Text != null && cbVersion.SelectedIndex >= 0)
                {
                    if (((int.Parse(txtCores.Text) % 2 == 0 || int.Parse(txtCores.Text) == 1) && int.Parse(txtCores.Text) > 0) && (int.Parse(txtMemory.Text) % 256 == 0 && int.Parse(txtMemory.Text) > 0))
                    {
                        rectNext.Opacity = 1;
                        rectNext.IsEnabled = true;
                    }
                    else
                    {
                        rectNext.Opacity = 0.5;
                        rectNext.IsEnabled = false;
                    }
                }
            }
            catch (Exception) { rectNext.Opacity = 0.5; rectNext.IsEnabled = false; }  
        }

        private void txtMemory_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (txtMemory.Text == "" && txtMemory.Text == null)
                {
                    rectNext.Opacity = 0.5;
                    rectNext.IsEnabled = false;
                }
                else if (txtMemory.Text != "" && txtMemory.Text != null && txtCores.Text != "" && txtCores.Text != null && cbVersion.SelectedIndex >= 0)
                {
                    if ((int.Parse(txtMemory.Text) % 256 == 0 && int.Parse(txtMemory.Text) > 0) && ((int.Parse(txtCores.Text) % 2 == 0 || int.Parse(txtCores.Text) == 1) && int.Parse(txtCores.Text) > 0))
                    {
                        rectNext.Opacity = 1;
                        rectNext.IsEnabled = true;
                    }
                    else
                    {
                        rectNext.Opacity = 0.5;
                        rectNext.IsEnabled = false;
                    }
                }
            }
            catch (Exception) { rectNext.Opacity = 0.5; rectNext.IsEnabled = false; }
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
                versions.Add("5.x - 2.6 Kernel");
                versions.Add("2.4 Kernel");
                cbVersion.ItemsSource = versions;
                cbVersion.IsEnabled = true;
            }
            else if (cbType.SelectedIndex == 1)
            {
                List<string> versions = new List<string>();
                versions.Add("11/2022");
                versions.Add("10/2016/2019");
                versions.Add("8.x/2012/2012r2");
                versions.Add("7/2008r2");
                versions.Add("Vista/2008");
                versions.Add("XP/2003");
                versions.Add("2000");
                cbVersion.ItemsSource = versions;
                cbVersion.IsEnabled = true;
            }
        }


        private void rectNext_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (cbType.SelectedIndex == 0)
            {
                if (cbVersion.SelectedIndex == 0) os_type = "l26";
                else if (cbVersion.SelectedIndex == 1) os_type = "l24";
            }else if (cbType.SelectedIndex == 1)
            {
                if (cbVersion.SelectedIndex == 0) os_type = "win11";
                else if (cbVersion.SelectedIndex == 1) os_type = "win10";
                else if (cbVersion.SelectedIndex == 2) os_type = "win8";
                else if (cbVersion.SelectedIndex == 3) os_type = "win7";
                else if (cbVersion.SelectedIndex == 4) os_type = "w2k8";
                else if (cbVersion.SelectedIndex == 5) os_type = "w2k3";
                else if (cbVersion.SelectedIndex == 6) os_type = "w2k";
            }
            cpu_cores = int.Parse(txtCores.Text);
            memory = int.Parse(txtMemory.Text);
            nextIsClicked = true;
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
                    vmCreated = false;
                    DirectoryInfo di = new DirectoryInfo(@"" + var_subdirectory);
                    string DirectoryName = di.Name;
                    this.Dispatcher.Invoke(() => {

                        lblCurrVM.Content = $"Settings for {DirectoryName}";
                        rectNext.Opacity = 0.5;
                        rectNext.IsEnabled = false;
                        cbVersion.IsEnabled = false;
                        List<string> types = new List<string>();
                        types.Add("Linux");
                        types.Add("Microsoft Windows");
                        cbType.ItemsSource = types;
                    });

                    while(true)
                    {
                        Thread.Sleep(100);
                        if (nextIsClicked == true)
                        {
                            this.Dispatcher.Invoke(() =>
                            {
                                cbType.IsEnabled = false;
                                cbVersion.IsEnabled = false;
                                txtCores.IsEnabled = false;
                                txtMemory.IsEnabled = false;
                                rectNext.IsEnabled = false;
                                rectNext.Opacity = 0.5;
                                lblCurrVM.Content = $"Creating VM {DirectoryName}";
                            });
                            nextIsClicked = false;
                            createTheVMS(var_subdirectory.ToString());
                            
                            while (true) {
                                Thread.Sleep(100);
                                if (vmCreated == true) break;
                            }
                            this.Dispatcher.Invoke(() =>
                            {
                                txtCores.Text = "";
                                txtMemory.Text = "";
                                cbType.ItemsSource = "";
                                cbVersion.ItemsSource = "";
                                cbType.IsEnabled = true;
                                cbVersion.IsEnabled = true;
                                txtCores.IsEnabled = true;
                                txtMemory.IsEnabled = true;
                                rectNext.IsEnabled = true;
                                rectNext.Opacity = 1;
                            });
                            start_vmid++;
                            break;
                        }
                    }
                }
            }
            
            this.Dispatcher.Invoke(() =>
            {
                string curTheme = "";
                if (rectDark.Visibility == Visibility.Hidden) curTheme = "dark";
                else if (rectDark.Visibility == Visibility.Visible) curTheme = "light";
                EndScreen endScreen = new EndScreen(curTheme);
                ((MainWindow)this.Owner).Content = endScreen.Content;

                endScreen.Owner = ((MainWindow)this.Owner);
            });
        }

        public async Task createTheVMS(string subdirectory)
        {
            string[] VMDirectory = Directory.GetFiles(@"" + subdirectory, "*.vmdk");

            DirectoryInfo di = new DirectoryInfo(@"" + subdirectory);
            string DirectoryName = di.Name;

            AuthenticationMethod method_mkdir = new PasswordAuthenticationMethod(prox_username, prox_password);
            ConnectionInfo connection_mkdir = new ConnectionInfo(prox_host, prox_username, method_mkdir);
            var client_mkdir = new SshClient(connection_mkdir);
            client_mkdir.Connect();
            client_mkdir.RunCommand($"rm -rf /usr/src/{DirectoryName}");
            client_mkdir.RunCommand($"mkdir /usr/src/{DirectoryName}");
            client_mkdir.Disconnect();
            Thread.Sleep(100);

            using (SftpClient upload = new SftpClient(new PasswordConnectionInfo(prox_host, prox_username, prox_password)))
            {
                upload.Connect();
                foreach (var file in VMDirectory)
                {
                    FileInfo fi = new FileInfo(@"" + file);
                    this.Dispatcher.Invoke(() => { lblInfo.Content = $"Uploading {System.IO.Path.GetFileName(file)}"; });
                    long size = fi.Length;
                    using (Stream stream = File.OpenRead(file))
                    {
                        upload.UploadFile(stream, @"/usr/src/" + DirectoryName + "/" + System.IO.Path.GetFileName(file), x =>
                        {
                            long current = long.Parse(x.ToString());
                            progress = ((double)current / size) * 70;
                            this.Dispatcher.Invoke(() => { pbProgress.Value = progress; });
                        });
                    }
                }
                upload.Disconnect();
                Thread.Sleep(100);
            }

            if (os_type != null)
            {
                AuthenticationMethod method_prox = new PasswordAuthenticationMethod(prox_username, prox_password);
                ConnectionInfo connection_prox = new ConnectionInfo(prox_host, prox_username, method_prox);
                var client = new SshClient(connection_prox);
                string start = $"qm start {start_vmid}";

                if (os_type == "win11" || os_type == "win10" || os_type == "win8" || os_type == "win7" || os_type == "w2k8" || os_type == "w2k3" || os_type == "w2k")
                {

                    string createVM = $"qm create {start_vmid} --balloon 1024 --memory {memory} --sockets 1 --cores {cpu_cores} --onboot yes --name {DirectoryName} --ostype {os_type} --bootdisk ide0 --net0 e1000,bridge=vmbr0,firewall=1 --scsihw virtio-scsi-pci --bios ovmf";
                    string importDisk = $"qm importdisk {start_vmid} /usr/src/{DirectoryName}/{DirectoryName}.vmdk VM-Data --format raw";
                    string useDisk = $"qm set {start_vmid} --ide0 VM-Data:{start_vmid}/vm-{start_vmid}-disk-0.raw";
                    string changeBootOrder = $"qm set {start_vmid} --boot order='ide0;net0'";
                    string setUefi = $"qm set {start_vmid} --efidisk0 VM-Data:{start_vmid},format=qcow2,efitype=4m,pre-enrolled-keys=1";
                    string setTpm = $"qm set {start_vmid} --tpmstate0 VM-Data:{start_vmid},version=v2.0";

                    client.Connect();
                

                    this.Dispatcher.Invoke(() => { lblInfo.Content = $"Creating VM {DirectoryName}";});
                    var sendCommand = client.RunCommand(createVM);
                    for (int i = 70; i <= 75; i++) { this.Dispatcher.Invoke(() => { pbProgress.Value = i; }); await Task.Delay(50); }

                    this.Dispatcher.Invoke(() => { lblInfo.Content = $"Importing VMDK {DirectoryName}.vmdk to VM"; });                    
                    sendCommand = client.RunCommand(importDisk);
                    for (int i = 75; i <= 80; i++) { this.Dispatcher.Invoke(() => { pbProgress.Value = i; }); await Task.Delay(50); }

                    this.Dispatcher.Invoke(() => { lblInfo.Content = $"Using Disk vm-{start_vmid}-disk-0.raw"; });                    
                    sendCommand = client.RunCommand(useDisk);
                    for (int i = 80; i <= 85; i++) { this.Dispatcher.Invoke(() => { pbProgress.Value = i; }); await Task.Delay(50); }

                    this.Dispatcher.Invoke(() => { lblInfo.Content = $"Changing boot order"; });                    
                    sendCommand = client.RunCommand(changeBootOrder);
                    for (int i = 85; i <= 90; i++) { this.Dispatcher.Invoke(() => { pbProgress.Value = i; }); await Task.Delay(50); }

                    this.Dispatcher.Invoke(() => { lblInfo.Content = $"Creating EFI Disk"; });                    
                    sendCommand = client.RunCommand(setUefi);
                    for (int i = 90; i <= 95; i++) { this.Dispatcher.Invoke(() => { pbProgress.Value = i; }); await Task.Delay(50); }

                    this.Dispatcher.Invoke(() => { lblInfo.Content = $"Creating TPM State"; });                    
                    sendCommand = client.RunCommand(setTpm);
                    for (int i = 95; i <= 100; i++) { this.Dispatcher.Invoke(() => { pbProgress.Value = i; }); await Task.Delay(50); }
                    
                    sendCommand = client.RunCommand(start);
                    vmCreated = true;
                    client.Disconnect();
                }
                else if (os_type == "l26" || os_type == "l24")
                {
                    string createVM = $"qm create {start_vmid} --balloon 1024 --memory {memory} --sockets 1 --cores {cpu_cores} --onboot yes --name {DirectoryName} -ostype {os_type} --bootdisk scsi0 --net0 virtio,bridge=vmbr0,firewall=1 --scsihw virtio-scsi-pci";
                    string importDisk = $"qm importdisk {start_vmid} /usr/src/{DirectoryName}/{DirectoryName}.vmdk VM-Data --format raw";
                    string useDisk = $"qm set {start_vmid} --scsi0 VM-Data:{start_vmid}/vm-{start_vmid}-disk-0.raw";
                    string changeBootOrder = $"qm set {start_vmid} --boot order='scsi0;net0'";

                    client.Connect();

                    this.Dispatcher.Invoke(() => { lblInfo.Content = $"Creating VM {DirectoryName}"; });
                    var sendCommand = client.RunCommand(createVM);
                    for (int i = 70; i <= 77; i++) { this.Dispatcher.Invoke(() => { pbProgress.Value = i; }); await Task.Delay(50); }

                    this.Dispatcher.Invoke(() => { lblInfo.Content = $"Importing VMDK {DirectoryName}.vmdk to VM"; });
                    sendCommand = client.RunCommand(importDisk);
                    for (int i = 77; i <= 86; i++) { this.Dispatcher.Invoke(() => { pbProgress.Value = i; }); await Task.Delay(50); }

                    this.Dispatcher.Invoke(() => { lblInfo.Content = $"Using Disk vm-{start_vmid}-disk-0.raw"; });
                    sendCommand = client.RunCommand(useDisk);
                    for (int i = 86; i <= 93; i++) { this.Dispatcher.Invoke(() => { pbProgress.Value = i; }); await Task.Delay(50); }

                    this.Dispatcher.Invoke(() => { lblInfo.Content = $"Changing boot order"; });
                    sendCommand = client.RunCommand(changeBootOrder);
                    for (int i = 93; i <= 101; i++) { this.Dispatcher.Invoke(() => { pbProgress.Value = i; }); await Task.Delay(50); }

                    sendCommand = client.RunCommand(start);
                    vmCreated = true;
                    client.Disconnect();
                }
            }
            lblInfo.Content = "";
            pbProgress.Value = 0;
            progress = 0;
        }

    }
}

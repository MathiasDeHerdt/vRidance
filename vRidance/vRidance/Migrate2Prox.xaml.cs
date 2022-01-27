﻿using System;
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
        int start_vmid;

        string os_type, cpu_cores, memory;

        bool nextIsClicked = false;

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

        private void txtCores_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(txtCores.Text == "" && txtCores == null)
            {
                rectNext.Opacity = 0.5;
                rectNext.IsEnabled = false;
            }else if (txtCores.Text != "" && txtCores != null && txtMemory.Text != "" && txtMemory != null && cbVersion.SelectedIndex >= 0)
            {
                rectNext.Opacity = 1;
                rectNext.IsEnabled = true;
            }
        }

        private void txtMemory_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtMemory.Text == "" && txtMemory == null)
            {
                rectNext.Opacity = 0.5;
                rectNext.IsEnabled = false;
            }
            else if (txtMemory.Text != "" && txtMemory != null && txtCores.Text != "" && txtCores != null && cbVersion.SelectedIndex >= 0)
            {
                rectNext.Opacity = 1;
                rectNext.IsEnabled = true;
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

            cpu_cores = txtCores.Text;
            memory = txtMemory.Text;


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
                            //MessageBox.Show($"folderPath: {folderPath}, subdirectoryName: {DirectoryName}, proxHost: {prox_host}, username: {prox_username}, password: {prox_password}, start_vmid: {start_vmid}, os_type: {os_type}, cpu_cores: {cpu_cores}, memory: {memory}");
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
                txtCores.IsEnabled = false;
                txtMemory.IsEnabled = false;

                EndScreen endScreen = new EndScreen();
                this.Content = endScreen.Content;

                endScreen.Owner = this;
            });
        }

        public void createTheVMS(string subdirectory)
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

            using (SftpClient upload = new SftpClient(new PasswordConnectionInfo(prox_host, prox_username, prox_password)))
            {
                upload.Connect();
                foreach (var file in VMDirectory)
                {
                    FileInfo fi = new FileInfo(@"" + file);
                    long size = fi.Length;
                    using (Stream stream = File.OpenRead(file))
                    {
                        upload.UploadFile(stream, @"/usr/src/" + DirectoryName + "/" + System.IO.Path.GetFileName(file), x => { /*Console.WriteLine($"Uploading {System.IO.Path.GetFileName(file)}"); Console.WriteLine($"{x / 1024 / 1024} / {size / 1024 / 1024}");*/ });
                    }
                }
                upload.Disconnect();
            }

            if (os_type != null)
            {
                AuthenticationMethod method_prox = new PasswordAuthenticationMethod(prox_username, prox_password);
                ConnectionInfo connection_prox = new ConnectionInfo(prox_host, prox_username, method_prox);
                var client = new SshClient(connection_prox);

                if (os_type == "win11" || os_type == "win10" || os_type == "win8" || os_type == "win7" || os_type == "w2k8" || os_type == "w2k3" || os_type == "w2k")
                {

                    //Console.WriteLine($"Creating VM {DirectoryName}, Please Wait...");
                    string createVM = $"qm create {start_vmid} --balloon 1024 --memory {memory} --sockets 1 --cores {cpu_cores} --onboot yes --name {DirectoryName} --ostype {os_type} --bootdisk ide0 --net0 e1000,bridge=vmbr0,firewall=1 --scsihw virtio-scsi-pci --bios ovmf";
                    string importDisk = $"qm importdisk {start_vmid} /usr/src/{DirectoryName}/{DirectoryName}.vmdk VM-Data --format raw";
                    string useDisk = $"qm set {start_vmid} --ide0 VM-Data:{start_vmid}/vm-{start_vmid}-disk-0.raw";
                    string changeBootOrder = $"qm set {start_vmid} --boot order='ide0;net0'";
                    string setUefi = $"qm set {start_vmid} --efidisk0 VM-Data:{start_vmid},format=qcow2,efitype=4m,pre-enrolled-keys=1";
                    string setTpm = $"qm set {start_vmid} --tpmstate0 VM-Data:{start_vmid},version=v2.0";
                    client.Connect();
                
                    var sendCommand = client.RunCommand(createVM);
                    sendCommand = client.RunCommand(importDisk);
                    sendCommand = client.RunCommand(useDisk);
                    sendCommand = client.RunCommand(changeBootOrder);
                    sendCommand = client.RunCommand(setUefi);
                    sendCommand = client.RunCommand(setTpm);

                    client.Disconnect();

                }
                else if (os_type == "l26" || os_type == "l24")
                {
                    //Console.WriteLine($"Creating VM {DirectoryName}, Please Wait...");
                    string createVM = $"qm create {start_vmid} --balloon 1024 --memory {memory} --sockets 1 --cores {cpu_cores} --onboot yes --name {DirectoryName} -ostype {os_type} --bootdisk scsi0 --net0 virtio,bridge=vmbr0,firewall=1 --scsihw virtio-scsi-pci";
                    string importDisk = $"qm importdisk {start_vmid} /usr/src/{DirectoryName}/{DirectoryName}.vmdk VM-Data --format raw";
                    string useDisk = $"qm set {start_vmid} --scsi0 VM-Data:{start_vmid}/vm-{start_vmid}-disk-0.raw";
                    string changeBootOrder = $"qm set {start_vmid} --boot order='scsi0;net0'";

                    client.Connect();
                    var sendCommand = client.RunCommand(createVM);
                    sendCommand = client.RunCommand(importDisk);
                    sendCommand = client.RunCommand(useDisk);
                    sendCommand = client.RunCommand(changeBootOrder);

                   client.Disconnect();

                }
            }
            start_vmid++;
        }

    }
}

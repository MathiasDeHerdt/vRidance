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
using Renci.SshNet;

namespace vRidance
{
    /// <summary>
    /// Interaction logic for ProxMoxLogin.xaml
    /// </summary>
    public partial class ProxMoxLogin : Window
    {
        string path;
        public ProxMoxLogin(string theme, string path2vmdk)
        {
            InitializeComponent();

            this.path = path2vmdk;

            changeTheme(theme);
        }
        private void rectClose_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
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

                lblPMLogin.Foreground = Brushes.White;
                lblUsername.Foreground = Brushes.White;
                lblPassword.Foreground = Brushes.White;
                lblIP.Foreground = Brushes.White;
                lblvmId.Foreground = Brushes.White;

                pwbPassword.Foreground = Brushes.White;
                txtUsername.Foreground = Brushes.White;
                txtIP.Foreground = Brushes.White;
                txtVMID.Foreground = Brushes.White;

                pwbPassword.Background = (Brush)bc.ConvertFrom("#66DEDEDE");
                txtUsername.Background = (Brush)bc.ConvertFrom("#66DEDEDE");
                txtIP.Background = (Brush)bc.ConvertFrom("#66DEDEDE");
                txtVMID.Background = (Brush)bc.ConvertFrom("#66DEDEDE");

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

                lblPMLogin.Foreground = Brushes.Black;
                lblUsername.Foreground = Brushes.Black;
                lblPassword.Foreground = Brushes.Black;
                lblIP.Foreground = Brushes.Black;
                lblvmId.Foreground = Brushes.Black;

                pwbPassword.Foreground = Brushes.Black;
                txtUsername.Foreground = Brushes.Black;
                txtIP.Foreground = Brushes.Black;
                txtVMID.Foreground = Brushes.Black;

                pwbPassword.Background = (Brush)bc.ConvertFrom("#661E1E1E");
                txtUsername.Background = (Brush)bc.ConvertFrom("#661E1E1E");
                txtIP.Background = (Brush)bc.ConvertFrom("#661E1E1E");
                txtVMID.Background = (Brush)bc.ConvertFrom("#661E1E1E");

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

        private void rctTop_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ((MainWindow)this.Owner).Dragging();
        }

        private void grdMain_Initialized(object sender, EventArgs e)
        {
            rectDark.Visibility = Visibility.Hidden;
            rectNext.Opacity = 0.5;
            rectNext.IsEnabled = false;
        }

        private void rectNext_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            string ip = txtIP.Text;
            string username = txtUsername.Text;
            string password = pwbPassword.Password.ToString();
            int first_vmid = int.Parse(txtVMID.Text);

            AuthenticationMethod method_checkCon = new PasswordAuthenticationMethod(username, password);
            ConnectionInfo connection_checkCon = new ConnectionInfo(ip, username, method_checkCon);
            var client_checkCon= new SshClient(connection_checkCon);

            try
            {
                client_checkCon.Connect();

                string curTheme = "";
                string thepath = this.path;
                if (rectDark.Visibility == Visibility.Hidden) curTheme = "dark";
                else if (rectDark.Visibility == Visibility.Visible) curTheme = "light";
                Migrate2Prox migration2proxmox = new Migrate2Prox(curTheme, ip, username, password, thepath, first_vmid); //HIER MOETEN GECONVERTEERDE FILES MEEGEGEVEN WORDEN
                ((MainWindow)this.Owner).Content = migration2proxmox.Content;

                client_checkCon.Disconnect();

                migration2proxmox.Owner = ((MainWindow)this.Owner);
            }
            catch (Exception)
            {
                MessageBox.Show($"Unable to make a connection to {ip}");
            }
        }

        private void grdMain4_LayoutUpdated(object sender, EventArgs e)
        {
            try
            {
                System.Net.IPAddress ipAddress;
                if (txtUsername.Text != "" && txtUsername != null && pwbPassword.Password != "" && txtVMID.Text != "" && txtVMID != null && System.Net.IPAddress.TryParse(txtIP.Text, out ipAddress) && int.Parse(txtVMID.Text) % 1 == 0)
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
            catch (Exception) { }
        }
    }
}

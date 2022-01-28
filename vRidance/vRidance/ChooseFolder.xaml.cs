using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace vRidance
{
    /// <summary>
    /// Interaction logic for ChooseFolder.xaml
    /// </summary>
    public partial class ChooseFolder : Window
    {
        string platform;
        public ChooseFolder(string theme, string var_platform)
        {
            InitializeComponent();

            this.platform = var_platform;

            if (theme.ToLower() == "dark")
            {
                var bc3 = new BrushConverter();
                Uri resourceUri3 = new Uri("Assets/bg_dark.png", UriKind.Relative);
                System.Windows.Resources.StreamResourceInfo streamInfo3 = System.Windows.Application.GetResourceStream(resourceUri3);

                BitmapFrame temp3 = BitmapFrame.Create(streamInfo3.Stream);
                var brush3 = new ImageBrush();
                brush3.ImageSource = temp3;

                grdMain3.Background = brush3;

                lblInfo.Foreground = Brushes.White;
                lblSelectFolder.Foreground = Brushes.White;

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

                grdMain3.Background = brush3;

                lblInfo.Foreground = Brushes.Black;
                lblSelectFolder.Foreground = Brushes.Black;

                rectDark.Visibility = Visibility.Visible;
                rectMode.Visibility = Visibility.Hidden;
            }
        }
        private void rectClose_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
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

                grdMain3.Background = brush2;

                rectDark.Visibility = Visibility.Visible;
                rectMode.Visibility = Visibility.Hidden;

                lblInfo.Foreground = Brushes.Black;
                lblSelectFolder.Foreground = Brushes.Black;

                lblInfo.Foreground = Brushes.Black;
                lblSelectFolder.Foreground = Brushes.Black;
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

                grdMain3.Background = brush;

                lblInfo.Foreground = Brushes.White;
                lblSelectFolder.Foreground = Brushes.White;

                rectDark.Visibility = Visibility.Hidden;
                rectMode.Visibility = Visibility.Visible;

            }
            catch (Exception)
            {
                System.Windows.MessageBox.Show("Something went wrong");
            }
        }

        private void rctTop_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ((MainWindow)this.Owner).Dragging();
        }

        private void txtPath_TextChanged(object sender, TextChangedEventArgs e)
        {
            string systemPath = txtPath.Text;
            if (Directory.Exists(systemPath) && (systemPath != null || systemPath != ""))
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

        }

        private void txtPath_LayoutUpdated(object sender, EventArgs e)
        {
            string systemPath = txtPath.Text;
            if (systemPath == "" || systemPath == null)
            {
                rectNext.Opacity = 0.5;
                rectNext.IsEnabled = false;
            }
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (!string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    txtPath.Text = fbd.SelectedPath;
                }
                else if (txtPath.Text == "") 
                {
                    System.Windows.MessageBox.Show("ERROR: Filepath empty!");
                }
            }


        }
        public void rectNext_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            string curTheme = "";
            string path2vmdk = txtPath.Text;
            if (rectDark.Visibility == Visibility.Hidden) curTheme = "dark";
            else if (rectDark.Visibility == Visibility.Visible) curTheme = "light";

            switch (platform)
            {
                case "proxmox":
                    ProxMoxLogin proxmoxLogin = new ProxMoxLogin(curTheme, path2vmdk);
                    ((MainWindow)this.Owner).Content = proxmoxLogin.Content;

                    proxmoxLogin.Owner = ((MainWindow)this.Owner);
                    break;

                case "citrix":
                    CitrixLogin citrixLogin = new CitrixLogin(curTheme, path2vmdk);
                    ((MainWindow)this.Owner).Content = citrixLogin.Content;

                    citrixLogin.Owner = ((MainWindow)this.Owner);
                    break;
            }
        }
    }
}

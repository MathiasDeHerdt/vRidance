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

namespace vRidance
{
    /// <summary>
    /// Interaction logic for CitrixLogin.xaml
    /// </summary>
    public partial class CitrixLogin : Window
    {
        string path;
        public CitrixLogin(string theme, string path2vmdk)
        {
            InitializeComponent();


            this.path = path2vmdk;

            if (theme.ToLower() == "dark")
            {
                var bc3 = new BrushConverter();
                Uri resourceUri3 = new Uri("Assets/bg_dark.png", UriKind.Relative);
                System.Windows.Resources.StreamResourceInfo streamInfo3 = System.Windows.Application.GetResourceStream(resourceUri3);

                BitmapFrame temp3 = BitmapFrame.Create(streamInfo3.Stream);
                var brush3 = new ImageBrush();
                brush3.ImageSource = temp3;

                grdMain4.Background = brush3;

                lblIP.Foreground = Brushes.White;
                lblUsername.Foreground = Brushes.White;
                lblPassword.Foreground = Brushes.White;
                pwbPassword.Foreground = Brushes.White;
                txtUsername.Foreground = Brushes.White;
                pwbPassword.Background = (Brush)bc3.ConvertFrom("#66DEDEDE");
                txtUsername.Background = (Brush)bc3.ConvertFrom("#66DEDEDE");
                txtIP.Background = (Brush)bc3.ConvertFrom("#66DEDEDE");

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

                lblIP.Foreground = Brushes.Black;
                lblUsername.Foreground = Brushes.Black;
                lblPassword.Foreground = Brushes.Black;
                pwbPassword.Foreground = Brushes.Black;
                txtUsername.Foreground = Brushes.Black;
                pwbPassword.Background = (Brush)bc3.ConvertFrom("#661E1E1E");
                txtUsername.Background = (Brush)bc3.ConvertFrom("#661E1E1E");
                txtIP.Background = (Brush)bc3.ConvertFrom("#661E1E1E");

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

                grdMain4.Background = brush2;

                lblIP.Foreground = Brushes.Black;
                lblUsername.Foreground = Brushes.Black;
                lblPassword.Foreground = Brushes.Black;
                pwbPassword.Foreground = Brushes.Black;
                txtUsername.Foreground = Brushes.Black;
                pwbPassword.Background = (Brush)bc2.ConvertFrom("#661E1E1E");
                txtUsername.Background = (Brush)bc2.ConvertFrom("#661E1E1E");
                txtIP.Background = (Brush)bc2.ConvertFrom("#661E1E1E");

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

                lblIP.Foreground = Brushes.White;
                lblUsername.Foreground = Brushes.White;
                lblPassword.Foreground = Brushes.White;
                pwbPassword.Foreground = Brushes.White;
                txtUsername.Foreground = Brushes.White;
                pwbPassword.Background = (Brush)bc.ConvertFrom("#66DEDEDE");
                txtUsername.Background = (Brush)bc.ConvertFrom("#66DEDEDE");
                txtIP.Background = (Brush)bc.ConvertFrom("#66DEDEDE");

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

        private void grdMain_Initialized(object sender, EventArgs e)
        {
            rectDark.Visibility = Visibility.Hidden;
            rectNext.Opacity = 0.5;
            rectNext.IsEnabled = false;
        }


        private void grdMain4_LayoutUpdated(object sender, EventArgs e)
        {
            System.Net.IPAddress ipAddress;
            if (txtUsername.Text != "" && txtUsername != null && pwbPassword.Password != "" && System.Net.IPAddress.TryParse(txtIP.Text, out ipAddress))
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

        private void rectNext_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            string ip = txtIP.Text;
            string username = txtUsername.Text;
            string password = pwbPassword.Password.ToString();
            string curTheme = "";
            string thepath = this.path;
            if (rectDark.Visibility == Visibility.Hidden) curTheme = "dark";
            else if (rectDark.Visibility == Visibility.Visible) curTheme = "light";


            Migrate2Citrix migration2citrix = new Migrate2Citrix(curTheme, ip, username, password, thepath);
            ((MainWindow)this.Owner).Content = migration2citrix.Content;

            migration2citrix.Owner = ((MainWindow)this.Owner);
        }
    }
}

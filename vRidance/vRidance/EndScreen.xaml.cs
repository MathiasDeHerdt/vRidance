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
    /// Interaction logic for EndScreen.xaml
    /// </summary>
    public partial class EndScreen : Window
    {
        public EndScreen(string theme)
        {
            InitializeComponent();

            changeTheme(theme);
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

                grdMain.Background = brush3;

                lblTitle.Foreground = Brushes.White;
                lblExplanation.Foreground = Brushes.White;

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

                grdMain.Background = brush3;

                lblTitle.Foreground = Brushes.Black;
                lblExplanation.Foreground = Brushes.Black;

                rectDark.Visibility = Visibility.Visible;
                rectMode.Visibility = Visibility.Hidden;


            }
        }
    }
    
}

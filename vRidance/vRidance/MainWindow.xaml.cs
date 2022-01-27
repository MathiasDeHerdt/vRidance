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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;
using Microsoft.Win32;
using System.Windows.Forms;

namespace vRidance
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        List<String> itemList = new List<String>();
        public MainWindow()
        {
            InitializeComponent();
            rectDark.Visibility = Visibility.Hidden;

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

            }
            catch (Exception)
            {

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

            }
            catch (Exception)
            {
                System.Windows.MessageBox.Show("Something went wrong");
            }
        }

        public void Dragging()
        {
            this.DragMove();
        }

        private void rctTop_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Dragging();
        }


        private void rectNext_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            string curTheme="";
            if (rectDark.Visibility == Visibility.Hidden) curTheme = "dark";
            else if (rectDark.Visibility == Visibility.Visible) curTheme = "light";
            MigrateSelection win2 = new MigrateSelection(itemList, curTheme);
            this.Content = win2.Content;

            win2.Owner = this;
        }
    }
}
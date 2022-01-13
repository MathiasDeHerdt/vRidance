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
    /// Interaction logic for SaveFiles.xaml
    /// </summary>
    public partial class SaveFiles : Window
    {
        public SaveFiles()
        {
            InitializeComponent();
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

                grdMain.Background = brush2;

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

                grdMain.Background = brush;

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


        private void txtPath_TextChanged(object sender, TextChangedEventArgs e)
        {
            string systemPath = txtPath.Text;
            if (Directory.Exists(systemPath) && (systemPath != null || systemPath != ""))
            {
                rectSave.Opacity = 1;
                rectSave.IsEnabled = true;
            }
        }

        private void grdMain_Initialized(object sender, EventArgs e)
        {
            rectDark.Visibility = Visibility.Hidden;
            rectSave.Opacity = 0.5;
            rectSave.IsEnabled = false;
        }

        private void txtPath_LayoutUpdated(object sender, EventArgs e)
        {
            string systemPath = txtPath.Text;
            if (systemPath == "" || systemPath == null)
            {
                rectSave.Opacity = 0.5;
                rectSave.IsEnabled = false;
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
                else
                {
                    System.Windows.MessageBox.Show("ERROR: Filepath empty!");
                }
            }


        }

        private void rectSave_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            using (System.IO.StreamWriter outfile = new System.IO.StreamWriter(txtPath.Text.ToString()))
            {
                outfile.Write(txtPath.Text+@"\GECONVERTEERDE FILE.txt");
            }
        }
    }
}

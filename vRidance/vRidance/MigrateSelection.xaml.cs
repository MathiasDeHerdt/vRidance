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
using System.Diagnostics;

namespace vRidance
{
    /// <summary>
    /// Interaction logic for MigrateSelection.xaml
    /// </summary>
    public partial class MigrateSelection : Window
    {
        List<String> listOfItems = new List<String>(); //New list for selected files
        public MigrateSelection(List<String> itemList)
        {
            listOfItems = itemList; //setting old list from the first page to the new list on this page
            InitializeComponent();


            var bc3 = new BrushConverter();
            Uri resourceUri3 = new Uri("Assets/bg_dark.png", UriKind.Relative);
            System.Windows.Resources.StreamResourceInfo streamInfo3 = System.Windows.Application.GetResourceStream(resourceUri3);

            BitmapFrame temp3 = BitmapFrame.Create(streamInfo3.Stream);
            var brush3 = new ImageBrush();
            brush3.ImageSource = temp3;

            grdMain2.Background = brush3;


            rectNext2.Visibility = Visibility.Hidden;
            rectNextDis2.Visibility = Visibility.Visible;
            rectNextDis2.IsEnabled = false;


        }


        public void ConvertToPlatform(int i)
        {

            switch (i)
            {
                case 0:
                    //CONVERTEREN GEBEURD HIER (PROXMOX)
                    MessageBox.Show("PROXMOX is checked");
                    /*foreach (string file in listOfItems)
                    {
                        MessageBox.Show($"{file.ToString()}");
                    }*/
                    break;

                case 1:
                    //CONVERTEREN GEBEURD HIER (NUTANIX)
                    MessageBox.Show("NUTANIX is checked");
                    break;

                case 2:
                    //CONVERTEREN GEBEURD HIER (CITRIX)
                    MessageBox.Show("CITRIX is checked");
                    break;
                case 3:
                    //CONVERTEREN GEBEURD HIER (AZURESTACKHCI)
                    MessageBox.Show("AZURESTACKHCI is checked");
                    break;
                default:
                    //error catch (no value)
                    break;
            }
        }

        private void rectClose_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();

        }

        private void rctTop_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            ((MainWindow)this.Owner).Dragging();
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

                grdMain2.Background = brush2;
                lblAzureStack.Foreground = Brushes.Black;
                lblCitrix.Foreground = Brushes.Black;
                lblNutanix.Foreground = Brushes.Black;
                lblProxmox.Foreground = Brushes.Black;

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

                grdMain2.Background = brush;
                lblAzureStack.Foreground = Brushes.White;
                lblCitrix.Foreground = Brushes.White;
                lblNutanix.Foreground = Brushes.White;
                lblProxmox.Foreground = Brushes.White;

                rectDark.Visibility = Visibility.Hidden;
                rectMode.Visibility = Visibility.Visible;
            }
            catch (Exception)
            {

                //throw;
                System.Windows.MessageBox.Show("Something went wrong");
            }
        }

        private void rectNext2_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            CheckBox[] checkBoxes = new CheckBox[4];
            checkBoxes[0] = chckProxmox;
            checkBoxes[1] = chckNutanix;
            checkBoxes[2] = chckCitrix;
            checkBoxes[3] = chckAzureStack;

            for (int i = 0; i <= checkBoxes.Count() - 1; i++)
            {

                if (checkBoxes[i].IsChecked == true && checkBoxes[i].IsEnabled)
                {
                    ConvertToPlatform(i);
                }

            }

            SaveFiles win3 = new SaveFiles(); //HIER MOETEN GECONVERTEERDE FILES MEEGEGEVEN WORDEN
            Application.Current.MainWindow.Content = win3.Content;
            if (win3.IsLoaded == true)
            {
                win3.Owner = this;
            }

        }

        private void grdMain2_LayoutUpdated(object sender, EventArgs e)
        {
            if (chckAzureStack.IsChecked == true || chckCitrix.IsChecked == true || chckNutanix.IsChecked == true || chckProxmox.IsChecked == true)
            {
                rectNext2.Visibility = Visibility.Visible;
                rectNextDis2.Visibility = Visibility.Hidden;
            }
            else
            {
                rectNext2.Visibility = Visibility.Hidden;
                rectNextDis2.Visibility = Visibility.Visible;
                rectNextDis2.IsEnabled = false;
            }
        }
    }
}

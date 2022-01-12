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
            //btnNext.IsEnabled = false;
            rectDark.Visibility = Visibility.Hidden;
            rectNext.Visibility = Visibility.Hidden;
            rectNextDis.Visibility = Visibility.Visible;
            rectNextDis.IsEnabled = false;

        }

        /*private void btnUpload_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            openFileDialog.Filter = "All Files (*.*)|*.*";
            openFileDialog.Title = "Select vSphere Files";
            openFileDialog.FilterIndex = 1;
            openFileDialog.Multiselect = true;
            try
            {
                if (openFileDialog.ShowDialog() == true)
                {
                    string sFileName = openFileDialog.FileName;
                    string[] arrAllFiles = openFileDialog.FileNames;
                    foreach (string file in arrAllFiles)
                    {
                       itemList.Add(file);
                    }
                    lstItems.ItemsSource = itemList;
                }

                if (lstItems != null)
                {
                    btnNext.IsEnabled = true;
                    btnNext.Visibility = Visibility.Visible;
                }
            }
            catch (Exception)
            {

                throw;
            }
               
        }

        private void btnNext_Click(object sender, RoutedEventArgs e)
        {
            MigrateSelection win2 = new MigrateSelection(itemList);
            this.Content = win2.Content;
            //MigrateSelection win2 = new MigrateSelection();
            //win2.Show();
        }*/

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
                //btnUpload.Background = Brushes.White;
                //btnUpload.Foreground = Brushes.Black;
                lstItems.Background = (Brush)bc2.ConvertFrom("#66DEDEDE");
                lstItems.Foreground = Brushes.Black;
                lstItems.BorderBrush = null;
                //btnUpload.BorderBrush = Brushes.Black;
                //btnNext.Background = Brushes.White;
                //btnNext.Foreground = Brushes.Black;
                //btnNext.BorderBrush = Brushes.Black;

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
                ///bg_dark.png
                //btnUpload.Background = (Brush)bc.ConvertFrom("#FF353434");
                //btnUpload.Foreground = Brushes.White;
                lstItems.Background = (Brush)bc.ConvertFrom("#661E1E1E");
                lstItems.Foreground = Brushes.White;
                //btnUpload.BorderBrush = null;

                //btnNext.Background = (Brush)bc.ConvertFrom("#FF353434");
                //btnNext.Foreground = Brushes.White;
                //btnNext.BorderBrush = null;

                rectDark.Visibility = Visibility.Hidden;
                rectMode.Visibility = Visibility.Visible;
            }
            catch (Exception)
            {

                //throw;
                System.Windows.MessageBox.Show("Something went wrong");
            }
        }

        //private void grdMain_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        //{
        //    this.DragMove();
        //}

        public void Dragging()
        {
            this.DragMove();

        }

        private void rctTop_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Dragging();
        }

        private void rectUpload_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            openFileDialog.Filter = "All Files (*.*)|*.*";
            openFileDialog.Title = "Select vSphere Files";
            openFileDialog.FilterIndex = 1;
            openFileDialog.Multiselect = true;
            try
            {
                if (openFileDialog.ShowDialog() == true)
                {
                    string sFileName = openFileDialog.FileName;
                    string[] arrAllFiles = openFileDialog.FileNames;
                    foreach (string file in arrAllFiles)
                    {
                        itemList.Add(file);
                    }
                    lstItems.ItemsSource = itemList;
                }

                if (lstItems.HasItems == true)
                {
                    rectNext.Visibility = Visibility.Visible;
                    rectNextDis.Visibility = Visibility.Hidden;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void rectNext_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            MigrateSelection win2 = new MigrateSelection(itemList);
            this.Content = win2.Content;

            win2.Owner = this;
        }
    }
}
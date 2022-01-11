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
            btnNext.IsEnabled = false;
            btnNext.Visibility = Visibility.Hidden;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            grdMain.Background = Brushes.White;
            btnUpload.Background = Brushes.White;
            btnUpload.Foreground = Brushes.Black;
            lstItems.Background = Brushes.LightGray;
            lstItems.Foreground = Brushes.Black;
            btnUpload.BorderBrush = Brushes.Black;
            btnNext.Background = Brushes.White;
            btnNext.Foreground = Brushes.Black;
            btnNext.BorderBrush = Brushes.Black;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            var bc = new BrushConverter();
            grdMain.Background = (Brush)bc.ConvertFrom("#FF252526");
            btnUpload.Background = (Brush)bc.ConvertFrom("#FF353434");
            btnUpload.Foreground = Brushes.White;
            lstItems.Background = (Brush)bc.ConvertFrom("#FF1E1E1E");
            lstItems.Foreground = Brushes.White;
            btnUpload.BorderBrush = null;

            btnNext.Background = (Brush)bc.ConvertFrom("#FF353434");
            btnNext.Foreground = Brushes.White;
            btnNext.BorderBrush = null;
        }

        private void btnUpload_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
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
        }
    }
}
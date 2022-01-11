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
        }

        private void btnNext2_Click(object sender, RoutedEventArgs e)
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
    }
}

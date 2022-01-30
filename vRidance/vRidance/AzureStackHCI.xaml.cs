using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Xml;
using System.Collections.ObjectModel;
using System.Reflection;
// using System.Management.Automation;

namespace vRidance
{
    /// <summary>
    /// Interaction logic for AzureStackHCI.xaml
    /// </summary>
    public partial class AzureStackHCI : Window
    {
        public AzureStackHCI(string theme)
        {
            InitializeComponent();
            Debug.WriteLine("Begin");

            recCreateVM.IsEnabled = false;
            recCreateVM.Opacity = 0.5;
        }

        // ---------------------------------------------------------------------------------------------------
        // Buttons
        // ---------------------------------------------------------------------------------------------------

        private void recCreateVM_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

            Debug.WriteLine("Creating VM");

            Debug.WriteLine("Writing to xml");

            XmlTextWriter xmlWriter2 = new XmlTextWriter("config.xml", System.Text.Encoding.UTF8);

            xmlWriter2.Formatting = Formatting.Indented;
            xmlWriter2.WriteStartDocument();
            xmlWriter2.WriteComment("creating an XML file");

            xmlWriter2.WriteStartElement("Configuration");

            xmlWriter2.WriteStartElement("CreateVM");
            xmlWriter2.WriteElementString("HostName", txtHostName.Text.ToString());
            xmlWriter2.WriteElementString("VMName", txtVMName.Text.ToString());
            xmlWriter2.WriteElementString("ClusterName", txtClusterName.Text.ToString());
            xmlWriter2.WriteElementString("MemoryStartup", txtStartMemory.Text.ToString());
            xmlWriter2.WriteElementString("MinimumBytes", txtMinimumBytes.Text.ToString());
            xmlWriter2.WriteElementString("MaximumBytes", txtMaximumBytes.Text.ToString());
            xmlWriter2.WriteElementString("BootDeviceExstention", txtBootDeviceExtention.Text.ToString());
            xmlWriter2.WriteElementString("BootDevicePath", txtBootDevicePath.Text.ToString());
            xmlWriter2.WriteElementString("NetworkAdapter", txtNetworkAdapter.Text.ToString());
            xmlWriter2.WriteElementString("LocationPath", txtLocationPath.Text.ToString());

            xmlWriter2.WriteEndElement();
            xmlWriter2.WriteEndDocument();
            xmlWriter2.Flush();
            xmlWriter2.Close();

            System.Windows.Application.Current.Shutdown();
        }

        private void rectClose_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void Grid_LayoutUpdated(object sender, EventArgs e)
        {
            if (txtBootDevicePath.Text != "" && txtBootDevicePath != null && txtLocationPath.Text != "" && txtLocationPath != null && txtMinimumBytes.Text != "" && txtMinimumBytes != null && txtMaximumBytes.Text != "" && txtMaximumBytes != null && txtStartMemory.Text != "" && txtStartMemory != null && txtClusterName.Text != "" & txtClusterName != null && txtVMName.Text != "" && txtVMName != null && txtHostName.Text != "" && txtHostName != null && txtBootDeviceExtention.Text != "" && txtBootDeviceExtention != null && txtNetworkAdapter.Text != "" && txtNetworkAdapter != null)
            {
                recCreateVM.IsEnabled = true;
                recCreateVM.Opacity = 1;
            }
            else
            {
                recCreateVM.IsEnabled = false;
                recCreateVM.Opacity = 0.5;
            }
        }
    }
}

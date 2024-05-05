using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WIA;

using System.Drawing.Imaging;

namespace ExtBloq
{
    public partial class scan : Form
    {
        private DeviceManager deviceManager;

       
        public scan()
        {
            InitializeComponent();
            deviceManager = new DeviceManager();
        }


        private void scan_Load(object sender, EventArgs e)
        {
            /*
            // Populate listbox with available scanners
            foreach (DeviceInfo scanner in deviceManager.DeviceInfos)
            {
                if (scanner.Type == WiaDeviceType.ScannerDeviceType)
                {
                    listBox1.Items.Add(scanner.Properties["Name"].get_Value());
                }
            }
            */
        }
        private bool IsScannerReady(DeviceInfo scannerInfo)
        {
            try
            {
                // Try connecting to the scanner to check its readiness
                Device scanner = scannerInfo.Connect();
                return true;
            }
            catch (COMException ex)
            {
                // If an exception is thrown, the scanner is not ready
                return false;
            }
        }
        private void buttonPreview_Click(object sender, EventArgs e)
        {
            // Check if a scanner is selected
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a scanner.");
                return;
            }

            // Get selected scanner
            string selectedScannerName = listBox1.SelectedItem.ToString();
            Device scanner = null;
            foreach (DeviceInfo scannerInfo in deviceManager.DeviceInfos)
            {
                if (scannerInfo.Type == WiaDeviceType.ScannerDeviceType &&
                    scannerInfo.Properties["Name"].get_Value().ToString() == selectedScannerName)
                {
                    scanner = scannerInfo.Connect();
                    break;
                }
            }

            // Check if scanner is found
            if (scanner == null)
            {
                MessageBox.Show("Scanner not found.");
                return;
            }

            // Preview the document
            try
            {
                // Use a standard dialog for image acquisition
                WIA.CommonDialog commonDialog = new WIA.CommonDialog();
                ImageFile image = (ImageFile)commonDialog.ShowAcquireImage(
                    WiaDeviceType.ScannerDeviceType,
                    WiaImageIntent.ColorIntent,
                    WiaImageBias.MaximizeQuality,
                    FormatID.wiaFormatJPEG,
                    false,
                    true,
                    false);

                // Check if the acquired image is not null
                if (image != null)
                {
                    // Convert image data to byte array
                    byte[] imageData = (byte[])image.FileData.get_BinaryData();

                    // Display previewed image in PictureBox
                    using (MemoryStream memoryStream = new MemoryStream(imageData))
                    {
                        pictureBox1.Image = Image.FromStream(memoryStream);
                    }
                }
                else
                {
                    MessageBox.Show("Preview canceled or failed.");
                }
            }
            catch (COMException ex)
            {
                MessageBox.Show($"An error occurred during the preview process: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       private void buttonScan_Click(object sender, EventArgs e)
        {// Check if a scanner is selected
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a scanner.");
                return;
            }

            // Get selected scanner
            string selectedScannerName = listBox1.SelectedItem.ToString();
            Device scanner = null;
            foreach (DeviceInfo scannerInfo in deviceManager.DeviceInfos)
            {
                if (scannerInfo.Type == WiaDeviceType.ScannerDeviceType &&
                    scannerInfo.Properties["Name"].get_Value().ToString() == selectedScannerName)
                {
                    scanner = scannerInfo.Connect();
                    break;
                }
            }

            // Check if scanner is found
            if (scanner == null)
            {
                MessageBox.Show("Scanner not found.");
                return;
            }

            // Scan document
            Item scannerItem = scanner.Items[1];
            
            ImageFile scannedImage = (ImageFile)scannerItem.Transfer(WIA.FormatID.wiaFormatJPEG);



            // Retrieve image data
            byte[] imageData = (byte[])scannedImage.FileData.get_BinaryData();

            // Create a MemoryStream from the image data
            using (MemoryStream memoryStream = new MemoryStream(imageData))
            {
                // Display scanned image in picturebox
                pictureBox1.Image = Image.FromStream(memoryStream);
            }

            MessageBox.Show("Scan Complete!");
        }

        private void buttonRefreshList_Click(object sender, EventArgs e)
        {
            // Clear existing items in the listbox
            listBox1.Items.Clear();

            // Populate listbox with available scanners
            foreach (DeviceInfo scanner in deviceManager.DeviceInfos)
            {
                if (scanner.Type == WiaDeviceType.ScannerDeviceType)
                {
                    listBox1.Items.Add(scanner.Properties["Name"].get_Value());
                }
            }
        }
    }
    }
    



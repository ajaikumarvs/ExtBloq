using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ipfs.Http; 


namespace ExtBloq
{
    public partial class ipfs : Form
    {
        private string filepath = @"C:\Users\ajaik\Desktop\app.py";
        
        public ipfs()
        {

            
            InitializeComponent();
            
        }

        private async void ipfs_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filepath))
            {
                MessageBox.Show("Please select a file to upload.");
                return;
            }

            try
            {
                await UploadFileToIpfs(filepath);
                MessageBox.Show("File uploaded successfully to IPFS.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error uploading file to IPFS: {ex.Message}");
            }
        }


        private async Task UploadFileToIpfs(string filePath)
        {
            // Create an instance of IpfsClient
            var ipfs = new IpfsClient();

            // Read the file into a byte array
            byte[] fileBytes = File.ReadAllBytes(filePath);

            // Upload the file to IPFS
            var file = await ipfs.FileSystem.AddAsync(new MemoryStream(fileBytes));

            // The 'file' variable now contains information about the uploaded file,
            // including its hash, which can be used to retrieve it from IPFS.
            Console.WriteLine($"Uploaded file. IPFS hash: {file.Id}");
            textboxOutput.Text = file.Id;

            // Since IpfsClient doesn't implement IDisposable, you don't need to dispose it.
        }



        private void SelectFile()
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                filepath = openFileDialog.FileName;
            }
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            SelectFile();
        }

        private void buttonUpload_Click(object sender, EventArgs e)
        {

        }
    }
}

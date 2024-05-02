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
using Ipfs;
using System.Security.Cryptography.X509Certificates;


namespace ExtBloq
{
    public partial class ipfs : Form
    {

        private string filepath;
        private IpfsClient IpfsClient;
        public ipfs()
        {

            InitializeComponent();
            IpfsClient = new IpfsClient();
            
        }
        
        public ipfs(string filepath):this()
        {
            this.filepath = filepath;
        }

        private void ipfs_Load(object sender, EventArgs e)
        {
            textBoxPath.Text = this.filepath;
            labelFilePath.Text = this.filepath;

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
                textBoxPath.Text = openFileDialog.FileName;


                if (IsImageFile(filepath))
                {
                    pictureBox1.Image = Image.FromFile(filepath);
                }
                else
                {
                    pictureBox1.Image = pictureBoxFileSelect.Image;
                    MessageBox.Show("An image file was not selected, so akipping image preview.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
               
            }
        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {
            SelectFile();
        }

        private async void buttonUpload_Click(object sender, EventArgs e)
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





        private async void RetrieveFileFromIpfs(string fileId)
        {
            try
            {
                // Retrieve the file from IPFS
                var file = await IpfsClient.FileSystem.GetAsync(fileId);

                // Save the file to a location of your choice
                // For example, you can save it to the user's temporary folder
                string recvFilePath = Path.Combine(Path.GetTempPath(), fileId);
                
                using (var fileStream = File.Create(recvFilePath))
                {
                    await file.CopyToAsync(fileStream);
                }

                MessageBox.Show($"File retrieved successfully. Path: {recvFilePath}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving file from IPFS: {ex.Message}");
            }
        }

        private void buttonGet_Click(object sender, EventArgs e)
        {
            RetrieveFileFromIpfs(textboxReturn.Text);
        }

        private void textBoxPath_TextChanged(object sender, EventArgs e)
        {
            labelFilePath.Text = textBoxPath.Text;
        }




        private bool IsImageFile(string filePath)
        {
            string extension = Path.GetExtension(filePath);
            return extension.Equals(".bmp", StringComparison.OrdinalIgnoreCase) ||
                   extension.Equals(".jpg", StringComparison.OrdinalIgnoreCase) ||
                   extension.Equals(".jpeg", StringComparison.OrdinalIgnoreCase) ||
                   extension.Equals(".gif", StringComparison.OrdinalIgnoreCase) ||
                   extension.Equals(".png", StringComparison.OrdinalIgnoreCase);
        }


    }

    }

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtBloq
{
    public partial class ConvtoText : Form
    {
        private string filepath;
        public ConvtoText()
        {
            InitializeComponent();
            
        }
        public ConvtoText(string filepath):this()
        {
            
            this.filepath = filepath;
        }

        private void ConvtoText_Load(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(filepath)) // Check if filepath is not null or empty
            {
                try
                {
                    pictureBox1.Image = Image.FromFile(filepath); // Load the image into pictureBox1
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image: " + ex.Message);
                }
            }
        }

        private void buttonEnBase64_Click(object sender, EventArgs e)
        {
            // Convert image to Base64
            try
            {
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    pictureBox1.Image.Save(memoryStream, pictureBox1.Image.RawFormat);
                    byte[] imageBytes = memoryStream.ToArray();
                    string base64String = Convert.ToBase64String(imageBytes);
                    progressBar1.Maximum = (int)Math.Ceiling((double)base64String.Length / 4096); // Set the maximum value based on the length of Base64 string
                    outputTextBox.Text = base64String;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error encoding image to Base64: " + ex.Message);
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
            openFileDialog1.Title = "Select an Image File";
            

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                filepath = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(filepath);
            }
        }

        private void buttonEnHex_Click(object sender, EventArgs e)
        {
            try
            {
                // Convert image to HEX
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    pictureBox1.Image.Save(memoryStream, pictureBox1.Image.RawFormat);
                    byte[] imageBytes = memoryStream.ToArray();
                    progressBar1.Maximum = imageBytes.Length;
                    StringBuilder hexString = new StringBuilder();
                    for (int i = 0; i < imageBytes.Length; i++)
                    {
                        hexString.Append(imageBytes[i].ToString("X2"));
                        progressBar1.Value = i;
                    }
                    outputTextBox.Text = hexString.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error encoding HEX string: " + ex.Message);
            }
        }

        private void buttonDecBase64_Click(object sender, EventArgs e)
        {
            // Convert Base64 string to image
            try
            {
                progressBar1.Value = 0;
                byte[] imageBytes = Convert.FromBase64String(outputTextBox.Text);
                progressBar1.Maximum = imageBytes.Length;
                using (MemoryStream memoryStream = new MemoryStream(imageBytes))
                {
                    pictureBox1.Image = Image.FromStream(memoryStream);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error decoding Base64 string: " + ex.Message);
            }
        }

        private void buttonDecHex_Click(object sender, EventArgs e)
        {
            // Convert HEX string to image
            try
            {
                progressBar1.Value = 0;
                string hexString = outputTextBox.Text;
                byte[] imageBytes = new byte[hexString.Length / 2];
                for (int i = 0; i < imageBytes.Length; i++)
                {
                    imageBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
                    progressBar1.Value = i;
                }
                using (MemoryStream memoryStream = new MemoryStream(imageBytes))
                {
                    pictureBox1.Image = Image.FromStream(memoryStream);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error decoding HEX string: " + ex.Message);
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "JPEG Image|*.jpg|PNG Image|*.png|Bitmap Image|*.bmp|GIF Image|*.gif";
                saveFileDialog1.Title = "Save an Image File";
                saveFileDialog1.ShowDialog();

                // If the file name is not an empty string, open it for saving.
                if (saveFileDialog1.FileName != "")
                {
                    // Saves the Image via a FileStream created by the OpenFile method.
                    System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                    // Saves the Image in the appropriate format based upon the extension.
                    switch (saveFileDialog1.FilterIndex)
                    {
                        case 1:
                            pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                            break;
                        case 2:
                            pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Png);
                            break;
                        case 3:
                            pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                            break;
                        case 4:
                            pictureBox1.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Gif);
                            break;
                    }

                    fs.Close();
                }
            }
            else
            {
                MessageBox.Show("No image to save.");
            }
        }

        private void buttonCopyAll_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(outputTextBox.Text);
        }
    }
}

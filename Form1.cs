using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;
using System.Web.UI;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using Emgu.CV.Util;







namespace ExtBloq
{
    public partial class Form1 : Form
    {
        private Bitmap originalImage;
        private Rectangle nameROI = new Rectangle(209, 504, 1056, 58); // Example ROI coordinates for name field
        private Rectangle addressROI = new Rectangle(365, 783, 1277, 60); // Example ROI coordinates for address field
        private Rectangle phoneROI = new Rectangle(50, 190, 150, 50); // Example ROI coordinates for phone field


        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            label1.Visible = false;

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                originalImage = new Bitmap(openFileDialog.FileName);
                pictureBox1.Image = originalImage;

                // Extract data from ROIs
                string name = ExtractTextFromROI(nameROI);
                string address = ExtractTextFromROI(addressROI);
                string phone = ExtractTextFromROI(phoneROI);

                // Display extracted data
                nametextBox.Text = name;
                addresstextBox.Text = address;
                phonetextBox.Text = phone;
            }

        }

        private string ExtractTextFromROI(Rectangle roi)
        {
            using (Bitmap roiImage = new Bitmap(roi.Width, roi.Height))
            {
                using (Graphics g = Graphics.FromImage(roiImage))
                {
                    g.DrawImage(originalImage, 0, 0, roi, GraphicsUnit.Pixel);
                }

                using (TesseractEngine engine = new TesseractEngine("C:\\Users\\ajaik\\Desktop\\Tesseract", "eng", EngineMode.Default))
                {
                    using (Tesseract.Page page = engine.Process(roiImage))
                    {
                        return page.GetText();

                    }


                    }
                }
            }

        private void addresstextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    }

                
 







































































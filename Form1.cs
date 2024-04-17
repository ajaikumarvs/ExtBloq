﻿using System;
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
        private Rectangle nameROI = new Rectangle(202, 507, 853, 76); // ROI coordinates for name field
        private Rectangle sexROI = new Rectangle(1098,507,140,73);  //Sex ROI
        private Rectangle branchROI = new Rectangle(326,591,591,62);  //Branch ROI
        private Rectangle dobdayROI = new Rectangle(1100,617,365,46); //DOB Day ROI
        private Rectangle dobmonthROI = new Rectangle(); //DOB Month ROI
        private Rectangle dobyearROI = new Rectangle(); //DOB Year ROI
        private Rectangle rollnoROI = new Rectangle(288,678,386,47); //Roll No ROI
        private Rectangle admissionnoROI = new Rectangle(876,686,489,65);// Admission number ROI
        private Rectangle rankROI = new Rectangle(397,739,372,64); // Rank entrance test
        private Rectangle dateofjoinROI = new Rectangle(955,758,541,54); // Date of joining ROI
        private Rectangle uniregnoROI= new Rectangle(480,825,614,59); //University registration number ROI
        private Rectangle addln1ROI = new Rectangle(611,890,922,51); // Address line 1 
        private Rectangle addln2ROI = new Rectangle(611,956,921,55); // address line 2 
        private Rectangle mobilenumROI = new Rectangle(269,1026,454,62); // mobile number 

        private Rectangle addressROI = new Rectangle(365, 783, 1277, 60); // ROI coordinates for address field

        private Rectangle homephonenoROI = new Rectangle(50, 190, 150, 50); //ROI coordinates for home phone field
        private Rectangle religionROI = new Rectangle(328,1106,394,52); //Religion 
        private Rectangle emailROI = new Rectangle(830,1103,655,57); //Email
        private Rectangle eduqualifypercentROI = new Rectangle(630,1176,901,60); // Educational Qualification Percentage 
        private Rectangle physicsmarkROI = new Rectangle(221,1250,336,56); // Physics marks
        private Rectangle chemistrymarkROI = new Rectangle(692,1244,289,64); // Chemistry marks
        private Rectangle mathsmarkROI = new Rectangle(); // Maths marks
        private Rectangle permanantadd1ROI = new Rectangle(); // Permanent address of father line 1
        private Rectangle permanantadd2ROI = new Rectangle(); // Permanent address of father line 2 
        private Rectangle telephonenumberROI = new Rectangle(); // Telephone number
        private Rectangle annualincomeROI = new Rectangle(1119, 1462, 368, 61); // Annual income
        private Rectangle fatheroffadd1ROI = new Rectangle(); // official address of father line 1
        private Rectangle fatheroffadd2ROI = new Rectangle(); // official address of father line 2
        private Rectangle fatherofftelephonenumberROI = new Rectangle(); // official telephone number
        private Rectangle stdcodeROI = new Rectangle(); // STD code
        private Rectangle motheroffaddROI = new Rectangle(); // official address of mother
        private Rectangle motherofftelephonenumberROI = new Rectangle(); // official telephone number of mother
        private Rectangle motheroffstdcodeROI = new Rectangle(); // STD code of mother
        private Rectangle scholarshipROI = new Rectangle(); // Scholarship
        private Rectangle medicalissuesROI = new Rectangle(); //    Medical issues














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
                string sex = ExtractTextFromROI(sexROI);
                string branch = ExtractTextFromROI(branchROI);
                string dob = ExtractTextFromROI(dobdayROI);
                string rollno = ExtractTextFromROI(rollnoROI);
                string admissionno = ExtractTextFromROI(admissionnoROI);
                string rankno = ExtractTextFromROI(rankROI);
                string dateofjoin = ExtractTextFromROI(dateofjoinROI);
                string uniregno = ExtractTextFromROI(uniregnoROI);
                string mobilenum = ExtractTextFromROI(mobilenumROI);
                string email = ExtractTextFromROI(emailROI);
                string annualincome = ExtractTextFromROI((annualincomeROI));
                string addln1 = ExtractTextFromROI(addln1ROI);
                string addln2 = ExtractTextFromROI(addln2ROI);
                string homephoneno = ExtractTextFromROI(homephonenoROI);
                string religion = ExtractTextFromROI(religionROI);
                string eduqualifypercent = ExtractTextFromROI(eduqualifypercentROI);

                // Display extracted data
                nametextBox.Text = name;
                addresstextBox.Text = address;
                genderBox.Text = sex;
                branchBox.Text = branch;
                dobBox.Text = dob;
                rollnoBox.Text = rollno;
                admissionnoBox.Text = admissionno;
                rankBox.Text = rankno;
                dateofjoinBox.Text = dateofjoin;
                uniregnoBox.Text = uniregno;
                mobilenoBox.Text = mobilenum;
                emailBox.Text = email;
                annualincomeBox.Text = annualincome;
                fulladdBox.Text = addln1 + " " + addln2;
                homephonenoBox.Text = homephoneno;
                religionBox.Text = religion;
                eduqualificationBox.Text = eduqualifypercent;

                
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

                
 







































































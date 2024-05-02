namespace ExtBloq
{
    partial class ConvtoText
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOpen = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.outputTextBox = new System.Windows.Forms.RichTextBox();
            this.buttonCopyAll = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.buttonEnBase64 = new System.Windows.Forms.Button();
            this.buttonEnHex = new System.Windows.Forms.Button();
            this.buttonDecBase64 = new System.Windows.Forms.Button();
            this.buttonDecHex = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonReset = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(12, 12);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(153, 23);
            this.buttonOpen.TabIndex = 0;
            this.buttonOpen.Text = "Open Image";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(28, 97);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(446, 484);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Location = new System.Drawing.Point(480, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(15, 513);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(501, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Options";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Location = new System.Drawing.Point(715, 81);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(15, 513);
            this.panel2.TabIndex = 3;
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(736, 97);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(477, 484);
            this.outputTextBox.TabIndex = 4;
            this.outputTextBox.Text = "";
            // 
            // buttonCopyAll
            // 
            this.buttonCopyAll.Location = new System.Drawing.Point(1158, 38);
            this.buttonCopyAll.Name = "buttonCopyAll";
            this.buttonCopyAll.Size = new System.Drawing.Size(75, 23);
            this.buttonCopyAll.TabIndex = 5;
            this.buttonCopyAll.Text = "Copy All";
            this.buttonCopyAll.UseVisualStyleBackColor = true;
            this.buttonCopyAll.Click += new System.EventHandler(this.buttonCopyAll_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel3.Location = new System.Drawing.Point(12, 78);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1221, 13);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel4.Location = new System.Drawing.Point(12, 81);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(14, 516);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel5.Location = new System.Drawing.Point(1219, 81);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(14, 513);
            this.panel5.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel6.Location = new System.Drawing.Point(12, 584);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1221, 13);
            this.panel6.TabIndex = 4;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel7.Location = new System.Drawing.Point(495, 125);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(220, 10);
            this.panel7.TabIndex = 6;
            // 
            // buttonEnBase64
            // 
            this.buttonEnBase64.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonEnBase64.Location = new System.Drawing.Point(506, 185);
            this.buttonEnBase64.Name = "buttonEnBase64";
            this.buttonEnBase64.Size = new System.Drawing.Size(195, 39);
            this.buttonEnBase64.TabIndex = 7;
            this.buttonEnBase64.Text = "Convert to Base64";
            this.buttonEnBase64.UseVisualStyleBackColor = false;
            this.buttonEnBase64.Click += new System.EventHandler(this.buttonEnBase64_Click);
            // 
            // buttonEnHex
            // 
            this.buttonEnHex.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonEnHex.Location = new System.Drawing.Point(506, 230);
            this.buttonEnHex.Name = "buttonEnHex";
            this.buttonEnHex.Size = new System.Drawing.Size(195, 39);
            this.buttonEnHex.TabIndex = 8;
            this.buttonEnHex.Text = "Convert to HEX";
            this.buttonEnHex.UseVisualStyleBackColor = false;
            this.buttonEnHex.Click += new System.EventHandler(this.buttonEnHex_Click);
            // 
            // buttonDecBase64
            // 
            this.buttonDecBase64.BackColor = System.Drawing.Color.Gold;
            this.buttonDecBase64.Location = new System.Drawing.Point(506, 474);
            this.buttonDecBase64.Name = "buttonDecBase64";
            this.buttonDecBase64.Size = new System.Drawing.Size(195, 39);
            this.buttonDecBase64.TabIndex = 9;
            this.buttonDecBase64.Text = "Create from Base64";
            this.buttonDecBase64.UseVisualStyleBackColor = false;
            this.buttonDecBase64.Click += new System.EventHandler(this.buttonDecBase64_Click);
            // 
            // buttonDecHex
            // 
            this.buttonDecHex.BackColor = System.Drawing.Color.Gold;
            this.buttonDecHex.Location = new System.Drawing.Point(506, 519);
            this.buttonDecHex.Name = "buttonDecHex";
            this.buttonDecHex.Size = new System.Drawing.Size(195, 39);
            this.buttonDecHex.TabIndex = 10;
            this.buttonDecHex.Text = "Create from HEX";
            this.buttonDecHex.UseVisualStyleBackColor = false;
            this.buttonDecHex.Click += new System.EventHandler(this.buttonDecHex_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(510, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Encoding";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(510, 458);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Decoding";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.PaleGreen;
            this.button5.Location = new System.Drawing.Point(506, 341);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(195, 23);
            this.button5.TabIndex = 13;
            this.button5.Text = "Save Image";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 67);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1220, 10);
            this.progressBar1.TabIndex = 14;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(82, 38);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(83, 23);
            this.buttonReset.TabIndex = 15;
            this.buttonReset.Text = "Reset Image";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // ConvtoText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 608);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonDecHex);
            this.Controls.Add(this.buttonDecBase64);
            this.Controls.Add(this.buttonEnHex);
            this.Controls.Add(this.buttonEnBase64);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.buttonCopyAll);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonOpen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ConvtoText";
            this.Text = "Convert to Text";
            this.Load += new System.EventHandler(this.ConvtoText_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox outputTextBox;
        private System.Windows.Forms.Button buttonCopyAll;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button buttonEnBase64;
        private System.Windows.Forms.Button buttonEnHex;
        private System.Windows.Forms.Button buttonDecBase64;
        private System.Windows.Forms.Button buttonDecHex;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}
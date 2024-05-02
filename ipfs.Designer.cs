namespace ExtBloq
{
    partial class ipfs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ipfs));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textboxOutput = new System.Windows.Forms.RichTextBox();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.textboxReturn = new System.Windows.Forms.RichTextBox();
            this.buttonGet = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelFilePath = new System.Windows.Forms.Label();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.textBoxrecvpath = new System.Windows.Forms.TextBox();
            this.progressBarSend = new System.Windows.Forms.ProgressBar();
            this.progressBarRecv = new System.Windows.Forms.ProgressBar();
            this.pictureBoxFileSelect = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFileSelect)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(187, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(392, 287);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textboxOutput
            // 
            this.textboxOutput.Location = new System.Drawing.Point(187, 458);
            this.textboxOutput.Name = "textboxOutput";
            this.textboxOutput.Size = new System.Drawing.Size(392, 95);
            this.textboxOutput.TabIndex = 1;
            this.textboxOutput.Text = "";
            // 
            // buttonUpload
            // 
            this.buttonUpload.Location = new System.Drawing.Point(187, 402);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(75, 23);
            this.buttonUpload.TabIndex = 2;
            this.buttonUpload.Text = "Upload";
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(504, 401);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(75, 23);
            this.buttonSelect.TabIndex = 3;
            this.buttonSelect.Text = "Select File";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // textboxReturn
            // 
            this.textboxReturn.Location = new System.Drawing.Point(892, 96);
            this.textboxReturn.Name = "textboxReturn";
            this.textboxReturn.Size = new System.Drawing.Size(476, 287);
            this.textboxReturn.TabIndex = 4;
            this.textboxReturn.Text = "";
            // 
            // buttonGet
            // 
            this.buttonGet.Location = new System.Drawing.Point(1293, 401);
            this.buttonGet.Name = "buttonGet";
            this.buttonGet.Size = new System.Drawing.Size(75, 23);
            this.buttonGet.TabIndex = 5;
            this.buttonGet.Text = "Get File";
            this.buttonGet.UseVisualStyleBackColor = true;
            this.buttonGet.Click += new System.EventHandler(this.buttonGet_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(13, 13);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(149, 120);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // labelFilePath
            // 
            this.labelFilePath.AutoSize = true;
            this.labelFilePath.Location = new System.Drawing.Point(187, 80);
            this.labelFilePath.Name = "labelFilePath";
            this.labelFilePath.Size = new System.Drawing.Size(149, 13);
            this.labelFilePath.TabIndex = 7;
            this.labelFilePath.Text = "No file path detected currently";
            // 
            // textBoxPath
            // 
            this.textBoxPath.Location = new System.Drawing.Point(187, 57);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(392, 20);
            this.textBoxPath.TabIndex = 8;
            this.textBoxPath.TextChanged += new System.EventHandler(this.textBoxPath_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 442);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Generated file hash";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(504, 429);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Copy";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBoxrecvpath
            // 
            this.textBoxrecvpath.Location = new System.Drawing.Point(892, 403);
            this.textBoxrecvpath.Name = "textBoxrecvpath";
            this.textBoxrecvpath.Size = new System.Drawing.Size(392, 20);
            this.textBoxrecvpath.TabIndex = 11;
            // 
            // progressBarSend
            // 
            this.progressBarSend.Location = new System.Drawing.Point(187, 387);
            this.progressBarSend.Name = "progressBarSend";
            this.progressBarSend.Size = new System.Drawing.Size(392, 10);
            this.progressBarSend.TabIndex = 12;
            // 
            // progressBarRecv
            // 
            this.progressBarRecv.Location = new System.Drawing.Point(892, 389);
            this.progressBarRecv.Name = "progressBarRecv";
            this.progressBarRecv.Size = new System.Drawing.Size(475, 10);
            this.progressBarRecv.TabIndex = 13;
            // 
            // pictureBoxFileSelect
            // 
            this.pictureBoxFileSelect.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFileSelect.Image")));
            this.pictureBoxFileSelect.Location = new System.Drawing.Point(678, 428);
            this.pictureBoxFileSelect.Name = "pictureBoxFileSelect";
            this.pictureBoxFileSelect.Size = new System.Drawing.Size(136, 125);
            this.pictureBoxFileSelect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFileSelect.TabIndex = 14;
            this.pictureBoxFileSelect.TabStop = false;
            this.pictureBoxFileSelect.Visible = false;
            // 
            // ipfs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1439, 565);
            this.Controls.Add(this.pictureBoxFileSelect);
            this.Controls.Add(this.progressBarRecv);
            this.Controls.Add(this.progressBarSend);
            this.Controls.Add(this.textBoxrecvpath);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.labelFilePath);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.buttonGet);
            this.Controls.Add(this.textboxReturn);
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.buttonUpload);
            this.Controls.Add(this.textboxOutput);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ipfs";
            this.Text = "ipfs";
            this.Load += new System.EventHandler(this.ipfs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFileSelect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox textboxOutput;
        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.RichTextBox textboxReturn;
        private System.Windows.Forms.Button buttonGet;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelFilePath;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox textBoxrecvpath;
        private System.Windows.Forms.ProgressBar progressBarSend;
        private System.Windows.Forms.ProgressBar progressBarRecv;
        private System.Windows.Forms.PictureBox pictureBoxFileSelect;
    }
}
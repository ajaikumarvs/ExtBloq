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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textboxOutput = new System.Windows.Forms.RichTextBox();
            this.buttonUpload = new System.Windows.Forms.Button();
            this.buttonSelect = new System.Windows.Forms.Button();
            this.textboxReturn = new System.Windows.Forms.RichTextBox();
            this.buttonGet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(149, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(392, 287);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textboxOutput
            // 
            this.textboxOutput.Location = new System.Drawing.Point(548, 13);
            this.textboxOutput.Name = "textboxOutput";
            this.textboxOutput.Size = new System.Drawing.Size(190, 286);
            this.textboxOutput.TabIndex = 1;
            this.textboxOutput.Text = "";
            // 
            // buttonUpload
            // 
            this.buttonUpload.Location = new System.Drawing.Point(349, 306);
            this.buttonUpload.Name = "buttonUpload";
            this.buttonUpload.Size = new System.Drawing.Size(75, 23);
            this.buttonUpload.TabIndex = 2;
            this.buttonUpload.Text = "Upload";
            this.buttonUpload.UseVisualStyleBackColor = true;
            this.buttonUpload.Click += new System.EventHandler(this.buttonUpload_Click);
            // 
            // buttonSelect
            // 
            this.buttonSelect.Location = new System.Drawing.Point(430, 305);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.Size = new System.Drawing.Size(75, 23);
            this.buttonSelect.TabIndex = 3;
            this.buttonSelect.Text = "Select File";
            this.buttonSelect.UseVisualStyleBackColor = true;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
            // 
            // textboxReturn
            // 
            this.textboxReturn.Location = new System.Drawing.Point(963, 142);
            this.textboxReturn.Name = "textboxReturn";
            this.textboxReturn.Size = new System.Drawing.Size(100, 96);
            this.textboxReturn.TabIndex = 4;
            this.textboxReturn.Text = "";
            // 
            // buttonGet
            // 
            this.buttonGet.Location = new System.Drawing.Point(963, 245);
            this.buttonGet.Name = "buttonGet";
            this.buttonGet.Size = new System.Drawing.Size(75, 23);
            this.buttonGet.TabIndex = 5;
            this.buttonGet.Text = "Get File";
            this.buttonGet.UseVisualStyleBackColor = true;
            // 
            // ipfs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 485);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox textboxOutput;
        private System.Windows.Forms.Button buttonUpload;
        private System.Windows.Forms.Button buttonSelect;
        private System.Windows.Forms.RichTextBox textboxReturn;
        private System.Windows.Forms.Button buttonGet;
    }
}
namespace BitCode
{
    partial class Form1
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
            this.btnGenerateImage = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.btnRead = new System.Windows.Forms.Button();
            this.txtReaded = new System.Windows.Forms.TextBox();
            this.txtOutBinary = new System.Windows.Forms.TextBox();
            this.txtInBinary = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(12, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(547, 324);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnGenerateImage
            // 
            this.btnGenerateImage.Location = new System.Drawing.Point(12, 37);
            this.btnGenerateImage.Name = "btnGenerateImage";
            this.btnGenerateImage.Size = new System.Drawing.Size(547, 23);
            this.btnGenerateImage.TabIndex = 1;
            this.btnGenerateImage.Text = "Generate";
            this.btnGenerateImage.UseVisualStyleBackColor = true;
            this.btnGenerateImage.Click += new System.EventHandler(this.btnGenerateImage_Click);
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(12, 11);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(547, 20);
            this.txtCode.TabIndex = 2;
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(12, 396);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(263, 23);
            this.btnRead.TabIndex = 3;
            this.btnRead.Text = "Read image";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // txtReaded
            // 
            this.txtReaded.Location = new System.Drawing.Point(281, 398);
            this.txtReaded.Name = "txtReaded";
            this.txtReaded.ReadOnly = true;
            this.txtReaded.Size = new System.Drawing.Size(278, 20);
            this.txtReaded.TabIndex = 4;
            // 
            // txtOutBinary
            // 
            this.txtOutBinary.Location = new System.Drawing.Point(565, 11);
            this.txtOutBinary.Multiline = true;
            this.txtOutBinary.Name = "txtOutBinary";
            this.txtOutBinary.ReadOnly = true;
            this.txtOutBinary.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutBinary.Size = new System.Drawing.Size(278, 161);
            this.txtOutBinary.TabIndex = 5;
            // 
            // txtInBinary
            // 
            this.txtInBinary.Location = new System.Drawing.Point(565, 255);
            this.txtInBinary.Multiline = true;
            this.txtInBinary.Name = "txtInBinary";
            this.txtInBinary.ReadOnly = true;
            this.txtInBinary.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInBinary.Size = new System.Drawing.Size(278, 161);
            this.txtInBinary.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(855, 428);
            this.Controls.Add(this.txtInBinary);
            this.Controls.Add(this.txtOutBinary);
            this.Controls.Add(this.txtReaded);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.btnGenerateImage);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGenerateImage;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.TextBox txtReaded;
        private System.Windows.Forms.TextBox txtOutBinary;
        private System.Windows.Forms.TextBox txtInBinary;
    }
}


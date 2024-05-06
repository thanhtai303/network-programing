namespace Assignment_4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnDownload = new Button();
            txtURL = new TextBox();
            folderBrowserDialog1 = new FolderBrowserDialog();
            pictureBox1 = new PictureBox();
            lbURL = new Label();
            lbPicture = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnDownload
            // 
            btnDownload.BackColor = SystemColors.ActiveCaption;
            btnDownload.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDownload.Location = new Point(655, 25);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(200, 63);
            btnDownload.TabIndex = 0;
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = false;
            btnDownload.Click += btnDownload_Click;
            // 
            // txtURL
            // 
            txtURL.Location = new Point(12, 25);
            txtURL.Name = "txtURL";
            txtURL.Size = new Size(606, 23);
            txtURL.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(12, 94);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(843, 480);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // lbURL
            // 
            lbURL.AutoSize = true;
            lbURL.Location = new Point(12, 9);
            lbURL.Name = "lbURL";
            lbURL.Size = new Size(28, 15);
            lbURL.TabIndex = 3;
            lbURL.Text = "URL";
            // 
            // lbPicture
            // 
            lbPicture.AutoSize = true;
            lbPicture.Location = new Point(12, 76);
            lbPicture.Name = "lbPicture";
            lbPicture.Size = new Size(114, 15);
            lbPicture.TabIndex = 4;
            lbPicture.Text = "Downloaded Picture";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 586);
            Controls.Add(lbPicture);
            Controls.Add(lbURL);
            Controls.Add(pictureBox1);
            Controls.Add(txtURL);
            Controls.Add(btnDownload);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDownload;
        private TextBox txtURL;
        private FolderBrowserDialog folderBrowserDialog1;
        private PictureBox pictureBox1;
        private Label lbURL;
        private Label lbPicture;
    }
}

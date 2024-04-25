namespace CSE306_Lab1_NguyenThanhTai_2031200020
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
            utf8Encoding = new RadioButton();
            unicode = new RadioButton();
            txtFilePath = new TextBox();
            btnBrowse = new Button();
            btnReadFile = new Button();
            txtContent = new TextBox();
            btnSaveFile = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            lbEncoding = new Label();
            lbFilePath = new Label();
            lbContent = new Label();
            SuspendLayout();
            // 
            // utf8Encoding
            // 
            utf8Encoding.AutoSize = true;
            utf8Encoding.BackgroundImageLayout = ImageLayout.None;
            utf8Encoding.Checked = true;
            utf8Encoding.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            utf8Encoding.Location = new Point(12, 66);
            utf8Encoding.Name = "utf8Encoding";
            utf8Encoding.Size = new Size(53, 19);
            utf8Encoding.TabIndex = 0;
            utf8Encoding.TabStop = true;
            utf8Encoding.Text = "UTF8";
            utf8Encoding.UseVisualStyleBackColor = true;
            // 
            // unicode
            // 
            unicode.AutoSize = true;
            unicode.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            unicode.Location = new Point(12, 91);
            unicode.Name = "unicode";
            unicode.Size = new Size(69, 19);
            unicode.TabIndex = 1;
            unicode.Text = "Unicode";
            unicode.UseVisualStyleBackColor = true;
            // 
            // txtFilePath
            // 
            txtFilePath.Location = new Point(12, 151);
            txtFilePath.Multiline = true;
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(504, 40);
            txtFilePath.TabIndex = 2;
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = SystemColors.GradientActiveCaption;
            btnBrowse.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBrowse.Location = new Point(522, 151);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(100, 40);
            btnBrowse.TabIndex = 3;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // btnReadFile
            // 
            btnReadFile.BackColor = SystemColors.GradientActiveCaption;
            btnReadFile.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReadFile.Location = new Point(12, 197);
            btnReadFile.Name = "btnReadFile";
            btnReadFile.Size = new Size(119, 40);
            btnReadFile.TabIndex = 4;
            btnReadFile.Text = "Read from a file";
            btnReadFile.UseVisualStyleBackColor = false;
            btnReadFile.Click += btnReadFile_Click;
            // 
            // txtContent
            // 
            txtContent.Location = new Point(12, 294);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.ScrollBars = ScrollBars.Both;
            txtContent.Size = new Size(610, 180);
            txtContent.TabIndex = 5;
            // 
            // btnSaveFile
            // 
            btnSaveFile.BackColor = SystemColors.GradientActiveCaption;
            btnSaveFile.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveFile.Location = new Point(12, 480);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(150, 32);
            btnSaveFile.TabIndex = 6;
            btnSaveFile.Text = "Save content to a file";
            btnSaveFile.UseVisualStyleBackColor = false;
            btnSaveFile.Click += btnSaveFile_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // lbEncoding
            // 
            lbEncoding.AutoSize = true;
            lbEncoding.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbEncoding.Location = new Point(12, 42);
            lbEncoding.Name = "lbEncoding";
            lbEncoding.Size = new Size(140, 21);
            lbEncoding.TabIndex = 7;
            lbEncoding.Text = "Select an encoding";
            // 
            // lbFilePath
            // 
            lbFilePath.AutoSize = true;
            lbFilePath.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbFilePath.Location = new Point(12, 127);
            lbFilePath.Name = "lbFilePath";
            lbFilePath.Size = new Size(69, 21);
            lbFilePath.TabIndex = 8;
            lbFilePath.Text = "File path";
            // 
            // lbContent
            // 
            lbContent.AutoSize = true;
            lbContent.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbContent.Location = new Point(16, 270);
            lbContent.Name = "lbContent";
            lbContent.Size = new Size(65, 21);
            lbContent.TabIndex = 9;
            lbContent.Text = "Content";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 546);
            Controls.Add(lbContent);
            Controls.Add(lbFilePath);
            Controls.Add(lbEncoding);
            Controls.Add(btnSaveFile);
            Controls.Add(txtContent);
            Controls.Add(btnReadFile);
            Controls.Add(btnBrowse);
            Controls.Add(txtFilePath);
            Controls.Add(unicode);
            Controls.Add(utf8Encoding);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton utf8Encoding;
        private RadioButton unicode;
        private TextBox txtFilePath;
        private Button btnBrowse;
        private Button btnReadFile;
        private TextBox txtContent;
        private Button btnSaveFile;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Label lbEncoding;
        private Label lbFilePath;
        private Label lbContent;
    }
}

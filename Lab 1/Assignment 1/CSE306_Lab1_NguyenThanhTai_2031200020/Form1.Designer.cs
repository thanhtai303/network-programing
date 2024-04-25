namespace CSE306_Lab1_NguyenThanhTai_2031200020
{
    partial class streamReaderAndWriter
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
            lbFilePath = new Label();
            txtFilePath = new TextBox();
            btnBrowse = new Button();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            btnReadFile = new Button();
            lbContent = new Label();
            txtContent = new TextBox();
            btnSaveContent = new Button();
            SuspendLayout();
            // 
            // lbFilePath
            // 
            lbFilePath.AutoSize = true;
            lbFilePath.Location = new Point(12, 39);
            lbFilePath.Name = "lbFilePath";
            lbFilePath.Size = new Size(92, 15);
            lbFilePath.TabIndex = 0;
            lbFilePath.Text = "File Path to read";
            // 
            // txtFilePath
            // 
            txtFilePath.Location = new Point(12, 57);
            txtFilePath.Multiline = true;
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(425, 35);
            txtFilePath.TabIndex = 1;
            txtFilePath.TextChanged += txtFilePath_TextChanged;
            // 
            // btnBrowse
            // 
            btnBrowse.BackColor = SystemColors.ActiveCaption;
            btnBrowse.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBrowse.Location = new Point(442, 57);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(130, 35);
            btnBrowse.TabIndex = 2;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = false;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnReadFile
            // 
            btnReadFile.BackColor = SystemColors.ActiveCaption;
            btnReadFile.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReadFile.Location = new Point(12, 97);
            btnReadFile.Name = "btnReadFile";
            btnReadFile.Size = new Size(206, 35);
            btnReadFile.TabIndex = 3;
            btnReadFile.Text = "Read the file and show to texbox";
            btnReadFile.UseVisualStyleBackColor = false;
            btnReadFile.Click += btnReadFile_Click;
            // 
            // lbContent
            // 
            lbContent.AutoSize = true;
            lbContent.Location = new Point(12, 150);
            lbContent.Name = "lbContent";
            lbContent.Size = new Size(50, 15);
            lbContent.TabIndex = 4;
            lbContent.Text = "Content";
            // 
            // txtContent
            // 
            txtContent.Location = new Point(12, 168);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.ScrollBars = ScrollBars.Both;
            txtContent.Size = new Size(560, 291);
            txtContent.TabIndex = 5;
            // 
            // btnSaveContent
            // 
            btnSaveContent.BackColor = SystemColors.ActiveCaption;
            btnSaveContent.Location = new Point(12, 465);
            btnSaveContent.Name = "btnSaveContent";
            btnSaveContent.Size = new Size(164, 35);
            btnSaveContent.TabIndex = 6;
            btnSaveContent.Text = "Save content to a new file";
            btnSaveContent.UseVisualStyleBackColor = false;
            btnSaveContent.Click += btnSaveContent_Click;
            // 
            // streamReaderAndWriter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(584, 547);
            Controls.Add(btnSaveContent);
            Controls.Add(txtContent);
            Controls.Add(lbContent);
            Controls.Add(btnReadFile);
            Controls.Add(btnBrowse);
            Controls.Add(txtFilePath);
            Controls.Add(lbFilePath);
            Name = "streamReaderAndWriter";
            Text = "Stream Reader and Writer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbFilePath;
        private TextBox txtFilePath;
        private Button btnBrowse;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
        private Button btnReadFile;
        private Label lbContent;
        private TextBox txtContent;
        private Button btnSaveContent;
    }
}

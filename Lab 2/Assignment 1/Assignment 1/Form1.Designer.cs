namespace Assignment_1
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
            txtFileList = new TextBox();
            btnUpload = new Button();
            listBoxStatus = new ListBox();
            lbFileList = new Label();
            lbStatus = new Label();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // txtFileList
            // 
            txtFileList.Location = new Point(12, 60);
            txtFileList.Multiline = true;
            txtFileList.Name = "txtFileList";
            txtFileList.ScrollBars = ScrollBars.Both;
            txtFileList.Size = new Size(440, 175);
            txtFileList.TabIndex = 0;
            // 
            // btnUpload
            // 
            btnUpload.BackColor = SystemColors.GradientInactiveCaption;
            btnUpload.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpload.Location = new Point(458, 106);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(165, 70);
            btnUpload.TabIndex = 1;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = false;
            btnUpload.Click += btnUpload_Click;
            // 
            // listBoxStatus
            // 
            listBoxStatus.FormattingEnabled = true;
            listBoxStatus.ItemHeight = 15;
            listBoxStatus.Location = new Point(12, 270);
            listBoxStatus.Name = "listBoxStatus";
            listBoxStatus.ScrollAlwaysVisible = true;
            listBoxStatus.Size = new Size(610, 244);
            listBoxStatus.TabIndex = 2;
            // 
            // lbFileList
            // 
            lbFileList.AutoSize = true;
            lbFileList.Location = new Point(12, 42);
            lbFileList.Name = "lbFileList";
            lbFileList.Size = new Size(43, 15);
            lbFileList.TabIndex = 3;
            lbFileList.Text = "File list";
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Location = new Point(12, 252);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(39, 15);
            lbStatus.TabIndex = 4;
            lbStatus.Text = "Status";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.Multiselect = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(634, 526);
            Controls.Add(lbStatus);
            Controls.Add(lbFileList);
            Controls.Add(listBoxStatus);
            Controls.Add(btnUpload);
            Controls.Add(txtFileList);
            Name = "Form1";
            Text = "Multi-Thread Upload Image";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFileList;
        private Button btnUpload;
        private ListBox listBoxStatus;
        private Label lbFileList;
        private Label lbStatus;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}

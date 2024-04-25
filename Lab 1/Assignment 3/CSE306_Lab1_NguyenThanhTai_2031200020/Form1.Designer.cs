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
            txtStudentID = new TextBox();
            txtFullName = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            txtAddress = new TextBox();
            btnSelectChangePicture = new Button();
            btnReadFile = new Button();
            btnSaveFile = new Button();
            btnReadAndDeserialize = new Button();
            btnSerializeAndSave = new Button();
            ofdPicture = new OpenFileDialog();
            sfdPicture = new SaveFileDialog();
            pictureBox = new PictureBox();
            lbStudentID = new Label();
            lbFullName = new Label();
            lbDateOfBirth = new Label();
            lbAddress = new Label();
            lbAvatar = new Label();
            ofdBinary = new OpenFileDialog();
            sfdBinary = new SaveFileDialog();
            ofdJson = new OpenFileDialog();
            sfdJson = new SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(12, 52);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(328, 23);
            txtStudentID.TabIndex = 0;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(12, 118);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(328, 23);
            txtFullName.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 184);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(216, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(12, 255);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(328, 92);
            txtAddress.TabIndex = 3;
            // 
            // btnSelectChangePicture
            // 
            btnSelectChangePicture.BackColor = SystemColors.InactiveCaption;
            btnSelectChangePicture.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelectChangePicture.Location = new Point(367, 52);
            btnSelectChangePicture.Name = "btnSelectChangePicture";
            btnSelectChangePicture.Size = new Size(110, 30);
            btnSelectChangePicture.TabIndex = 4;
            btnSelectChangePicture.Text = "Select/Change";
            btnSelectChangePicture.UseVisualStyleBackColor = false;
            btnSelectChangePicture.Click += btnSelectChangePicture_Click;
            // 
            // btnReadFile
            // 
            btnReadFile.BackColor = SystemColors.InactiveCaption;
            btnReadFile.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReadFile.Location = new Point(60, 379);
            btnReadFile.Name = "btnReadFile";
            btnReadFile.Size = new Size(180, 30);
            btnReadFile.TabIndex = 5;
            btnReadFile.Text = "Read from a file";
            btnReadFile.UseVisualStyleBackColor = false;
            btnReadFile.Click += btnReadFile_Click;
            // 
            // btnSaveFile
            // 
            btnSaveFile.BackColor = SystemColors.InactiveCaption;
            btnSaveFile.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveFile.Location = new Point(60, 429);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(180, 30);
            btnSaveFile.TabIndex = 6;
            btnSaveFile.Text = "Save to a file";
            btnSaveFile.UseVisualStyleBackColor = false;
            btnSaveFile.Click += btnSaveFile_Click;
            // 
            // btnReadAndDeserialize
            // 
            btnReadAndDeserialize.BackColor = SystemColors.InactiveCaption;
            btnReadAndDeserialize.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReadAndDeserialize.Location = new Point(360, 379);
            btnReadAndDeserialize.Name = "btnReadAndDeserialize";
            btnReadAndDeserialize.Size = new Size(180, 30);
            btnReadAndDeserialize.TabIndex = 7;
            btnReadAndDeserialize.Text = "Read from a file and deserialize ";
            btnReadAndDeserialize.UseVisualStyleBackColor = false;
            btnReadAndDeserialize.Click += btnReadAndDeserialize_Click;
            // 
            // btnSerializeAndSave
            // 
            btnSerializeAndSave.BackColor = SystemColors.InactiveCaption;
            btnSerializeAndSave.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSerializeAndSave.Location = new Point(360, 429);
            btnSerializeAndSave.Name = "btnSerializeAndSave";
            btnSerializeAndSave.Size = new Size(180, 30);
            btnSerializeAndSave.TabIndex = 8;
            btnSerializeAndSave.Text = "Serialize and save to a file";
            btnSerializeAndSave.UseVisualStyleBackColor = false;
            btnSerializeAndSave.Click += btnSerializeAndSave_Click;
            // 
            // ofdPicture
            // 
            ofdPicture.FileName = "ofdPicture";
            // 
            // pictureBox
            // 
            pictureBox.BorderStyle = BorderStyle.FixedSingle;
            pictureBox.Location = new Point(367, 88);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(255, 164);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.TabIndex = 9;
            pictureBox.TabStop = false;
            // 
            // lbStudentID
            // 
            lbStudentID.AutoSize = true;
            lbStudentID.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbStudentID.Location = new Point(12, 34);
            lbStudentID.Name = "lbStudentID";
            lbStudentID.Size = new Size(65, 15);
            lbStudentID.TabIndex = 10;
            lbStudentID.Text = "Student ID";
            // 
            // lbFullName
            // 
            lbFullName.AutoSize = true;
            lbFullName.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbFullName.Location = new Point(12, 100);
            lbFullName.Name = "lbFullName";
            lbFullName.Size = new Size(59, 15);
            lbFullName.TabIndex = 11;
            lbFullName.Text = "Full name";
            // 
            // lbDateOfBirth
            // 
            lbDateOfBirth.AutoSize = true;
            lbDateOfBirth.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDateOfBirth.Location = new Point(12, 166);
            lbDateOfBirth.Name = "lbDateOfBirth";
            lbDateOfBirth.Size = new Size(74, 15);
            lbDateOfBirth.TabIndex = 12;
            lbDateOfBirth.Text = "Date of birth";
            // 
            // lbAddress
            // 
            lbAddress.AutoSize = true;
            lbAddress.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbAddress.Location = new Point(12, 237);
            lbAddress.Name = "lbAddress";
            lbAddress.Size = new Size(49, 15);
            lbAddress.TabIndex = 13;
            lbAddress.Text = "Address";
            // 
            // lbAvatar
            // 
            lbAvatar.AutoSize = true;
            lbAvatar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbAvatar.Location = new Point(367, 34);
            lbAvatar.Name = "lbAvatar";
            lbAvatar.Size = new Size(41, 15);
            lbAvatar.TabIndex = 14;
            lbAvatar.Text = "Avatar";
            // 
            // ofdBinary
            // 
            ofdBinary.FileName = "ofdBinary";
            // 
            // ofdJson
            // 
            ofdJson.FileName = "ofdJson";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(634, 518);
            Controls.Add(lbAvatar);
            Controls.Add(lbAddress);
            Controls.Add(lbDateOfBirth);
            Controls.Add(lbFullName);
            Controls.Add(lbStudentID);
            Controls.Add(pictureBox);
            Controls.Add(btnSerializeAndSave);
            Controls.Add(btnReadAndDeserialize);
            Controls.Add(btnSaveFile);
            Controls.Add(btnReadFile);
            Controls.Add(btnSelectChangePicture);
            Controls.Add(txtAddress);
            Controls.Add(dateTimePicker1);
            Controls.Add(txtFullName);
            Controls.Add(txtStudentID);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtStudentID;
        private TextBox txtFullName;
        private DateTimePicker dateTimePicker1;
        private TextBox txtAddress;
        private Button btnSelectChangePicture;
        private Button btnReadFile;
        private Button btnSaveFile;
        private Button btnReadAndDeserialize;
        private Button btnSerializeAndSave;
        private OpenFileDialog ofdPicture;
        private SaveFileDialog sfdPicture;
        private PictureBox pictureBox;
        private Label lbStudentID;
        private Label lbFullName;
        private Label lbDateOfBirth;
        private Label lbAddress;
        private Label lbAvatar;
        private OpenFileDialog ofdBinary;
        private SaveFileDialog sfdBinary;
        private OpenFileDialog ofdJson;
        private SaveFileDialog sfdJson;
    }
}

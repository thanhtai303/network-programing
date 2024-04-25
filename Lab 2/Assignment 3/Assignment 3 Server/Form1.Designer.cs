namespace Assignment_3_Server
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
            pictureBox1 = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            btnListen = new Button();
            txtIPAddress = new TextBox();
            txtPort = new TextBox();
            btnSave = new Button();
            lbIPAddress = new Label();
            lbPort = new Label();
            lbPicture = new Label();
            saveFileDialog1 = new SaveFileDialog();
            txtStatus = new TextBox();
            lbStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(12, 132);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(726, 444);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnListen
            // 
            btnListen.BackColor = SystemColors.GradientActiveCaption;
            btnListen.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnListen.Location = new Point(753, 38);
            btnListen.Name = "btnListen";
            btnListen.Size = new Size(100, 41);
            btnListen.TabIndex = 1;
            btnListen.Text = "Listen";
            btnListen.UseVisualStyleBackColor = false;
            btnListen.Click += btnListen_Click;
            // 
            // txtIPAddress
            // 
            txtIPAddress.Location = new Point(12, 48);
            txtIPAddress.Name = "txtIPAddress";
            txtIPAddress.Size = new Size(170, 23);
            txtIPAddress.TabIndex = 2;
            // 
            // txtPort
            // 
            txtPort.Location = new Point(299, 48);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(170, 23);
            txtPort.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.GradientActiveCaption;
            btnSave.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(745, 310);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(108, 48);
            btnSave.TabIndex = 4;
            btnSave.Text = "Save picture";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // lbIPAddress
            // 
            lbIPAddress.AutoSize = true;
            lbIPAddress.Location = new Point(12, 30);
            lbIPAddress.Name = "lbIPAddress";
            lbIPAddress.Size = new Size(62, 15);
            lbIPAddress.TabIndex = 5;
            lbIPAddress.Text = "IP Address";
            // 
            // lbPort
            // 
            lbPort.AutoSize = true;
            lbPort.Location = new Point(299, 30);
            lbPort.Name = "lbPort";
            lbPort.Size = new Size(29, 15);
            lbPort.TabIndex = 6;
            lbPort.Text = "Port";
            // 
            // lbPicture
            // 
            lbPicture.AutoSize = true;
            lbPicture.Location = new Point(12, 114);
            lbPicture.Name = "lbPicture";
            lbPicture.Size = new Size(44, 15);
            lbPicture.TabIndex = 7;
            lbPicture.Text = "Picture";
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(568, 48);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(170, 23);
            txtStatus.TabIndex = 8;
            txtStatus.Text = "Waiting to connect...";
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Location = new Point(568, 30);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(39, 15);
            lbStatus.TabIndex = 9;
            lbStatus.Text = "Status";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(865, 588);
            Controls.Add(lbStatus);
            Controls.Add(txtStatus);
            Controls.Add(lbPicture);
            Controls.Add(lbPort);
            Controls.Add(lbIPAddress);
            Controls.Add(btnSave);
            Controls.Add(txtPort);
            Controls.Add(txtIPAddress);
            Controls.Add(btnListen);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private OpenFileDialog openFileDialog1;
        private Button btnListen;
        private TextBox txtIPAddress;
        private TextBox txtPort;
        private Button btnSave;
        private Label lbIPAddress;
        private Label lbPort;
        private Label lbPicture;
        private SaveFileDialog saveFileDialog1;
        private TextBox txtStatus;
        private Label lbStatus;
    }
}

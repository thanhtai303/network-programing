namespace Assignment_3_Client
{
    partial class formClientApp
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
            txtFilePath = new TextBox();
            btnChooseAPicture = new Button();
            openFileDialog1 = new OpenFileDialog();
            pictureBox1 = new PictureBox();
            btnSendImage = new Button();
            txtStatus = new TextBox();
            txtIPAddress = new TextBox();
            txtPort = new TextBox();
            lbIPAddress = new Label();
            lbPort = new Label();
            lbStatus = new Label();
            lbFilePath = new Label();
            lbPicture = new Label();
            btnConnect = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtFilePath
            // 
            txtFilePath.Location = new Point(12, 95);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(650, 23);
            txtFilePath.TabIndex = 0;
            // 
            // btnChooseAPicture
            // 
            btnChooseAPicture.BackColor = SystemColors.GradientActiveCaption;
            btnChooseAPicture.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChooseAPicture.Location = new Point(670, 94);
            btnChooseAPicture.Name = "btnChooseAPicture";
            btnChooseAPicture.Size = new Size(120, 23);
            btnChooseAPicture.TabIndex = 1;
            btnChooseAPicture.Text = "Choose a picture";
            btnChooseAPicture.UseVisualStyleBackColor = false;
            btnChooseAPicture.Click += btnChooseAndSendAPicture_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(12, 161);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(650, 409);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // btnSendImage
            // 
            btnSendImage.BackColor = SystemColors.GradientActiveCaption;
            btnSendImage.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSendImage.Location = new Point(668, 338);
            btnSendImage.Name = "btnSendImage";
            btnSendImage.Size = new Size(122, 57);
            btnSendImage.TabIndex = 3;
            btnSendImage.Text = "Send picture";
            btnSendImage.UseVisualStyleBackColor = false;
            btnSendImage.Click += btnSendImage_Click;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(512, 42);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(150, 23);
            txtStatus.TabIndex = 4;
            txtStatus.Text = "Waiting to connect...";
            // 
            // txtIPAddress
            // 
            txtIPAddress.Location = new Point(12, 42);
            txtIPAddress.Name = "txtIPAddress";
            txtIPAddress.Size = new Size(150, 23);
            txtIPAddress.TabIndex = 5;
            // 
            // txtPort
            // 
            txtPort.Location = new Point(269, 42);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(150, 23);
            txtPort.TabIndex = 6;
            // 
            // lbIPAddress
            // 
            lbIPAddress.AutoSize = true;
            lbIPAddress.Location = new Point(12, 24);
            lbIPAddress.Name = "lbIPAddress";
            lbIPAddress.Size = new Size(62, 15);
            lbIPAddress.TabIndex = 8;
            lbIPAddress.Text = "IP Address";
            // 
            // lbPort
            // 
            lbPort.AutoSize = true;
            lbPort.Location = new Point(269, 24);
            lbPort.Name = "lbPort";
            lbPort.Size = new Size(29, 15);
            lbPort.TabIndex = 9;
            lbPort.Text = "Port";
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Location = new Point(512, 24);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(39, 15);
            lbStatus.TabIndex = 10;
            lbStatus.Text = "Status";
            // 
            // lbFilePath
            // 
            lbFilePath.AutoSize = true;
            lbFilePath.Location = new Point(12, 77);
            lbFilePath.Name = "lbFilePath";
            lbFilePath.Size = new Size(52, 15);
            lbFilePath.TabIndex = 11;
            lbFilePath.Text = "File path";
            // 
            // lbPicture
            // 
            lbPicture.AutoSize = true;
            lbPicture.Location = new Point(12, 143);
            lbPicture.Name = "lbPicture";
            lbPicture.Size = new Size(71, 15);
            lbPicture.TabIndex = 12;
            lbPicture.Text = "Your picture";
            // 
            // btnConnect
            // 
            btnConnect.BackColor = SystemColors.GradientActiveCaption;
            btnConnect.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConnect.ForeColor = SystemColors.ControlText;
            btnConnect.Location = new Point(670, 41);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(120, 23);
            btnConnect.TabIndex = 13;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = false;
            btnConnect.Click += btnConnect_Click;
            // 
            // formClientApp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(800, 582);
            Controls.Add(btnConnect);
            Controls.Add(lbPicture);
            Controls.Add(lbFilePath);
            Controls.Add(lbStatus);
            Controls.Add(lbPort);
            Controls.Add(lbIPAddress);
            Controls.Add(txtPort);
            Controls.Add(txtIPAddress);
            Controls.Add(txtStatus);
            Controls.Add(btnSendImage);
            Controls.Add(pictureBox1);
            Controls.Add(btnChooseAPicture);
            Controls.Add(txtFilePath);
            Name = "formClientApp";
            Text = "Client App";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFilePath;
        private Button btnChooseAPicture;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBox1;
        private Button btnSendImage;
        private TextBox txtStatus;
        private TextBox txtIPAddress;
        private TextBox txtPort;
        private Label lbIPAddress;
        private Label lbPort;
        private Label lbStatus;
        private Label lbFilePath;
        private Label lbPicture;
        private Button btnConnect;
    }
}

namespace Assignment_2_Client
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
            listBoxContent = new ListBox();
            txtServerPort = new TextBox();
            txtServerIP = new TextBox();
            txtText = new TextBox();
            btnSend = new Button();
            btnConnect = new Button();
            lbContent = new Label();
            lbText = new Label();
            lbIPAddress = new Label();
            lbPort = new Label();
            SuspendLayout();
            // 
            // listBoxContent
            // 
            listBoxContent.FormattingEnabled = true;
            listBoxContent.ItemHeight = 15;
            listBoxContent.Location = new Point(12, 208);
            listBoxContent.Name = "listBoxContent";
            listBoxContent.ScrollAlwaysVisible = true;
            listBoxContent.Size = new Size(459, 229);
            listBoxContent.TabIndex = 12;
            // 
            // txtServerPort
            // 
            txtServerPort.Location = new Point(224, 41);
            txtServerPort.Name = "txtServerPort";
            txtServerPort.Size = new Size(148, 23);
            txtServerPort.TabIndex = 11;
            // 
            // txtServerIP
            // 
            txtServerIP.Location = new Point(12, 41);
            txtServerIP.Name = "txtServerIP";
            txtServerIP.Size = new Size(161, 23);
            txtServerIP.TabIndex = 10;
            // 
            // txtText
            // 
            txtText.Location = new Point(12, 98);
            txtText.Multiline = true;
            txtText.Name = "txtText";
            txtText.Size = new Size(378, 80);
            txtText.TabIndex = 9;
            // 
            // btnSend
            // 
            btnSend.BackColor = SystemColors.GradientActiveCaption;
            btnSend.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSend.Location = new Point(396, 126);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(75, 23);
            btnSend.TabIndex = 8;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // btnConnect
            // 
            btnConnect.BackColor = SystemColors.GradientActiveCaption;
            btnConnect.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConnect.Location = new Point(396, 41);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(75, 23);
            btnConnect.TabIndex = 7;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = false;
            btnConnect.Click += btnConnect_Click;
            // 
            // lbContent
            // 
            lbContent.AutoSize = true;
            lbContent.Location = new Point(12, 190);
            lbContent.Name = "lbContent";
            lbContent.Size = new Size(50, 15);
            lbContent.TabIndex = 13;
            lbContent.Text = "Content";
            // 
            // lbText
            // 
            lbText.AutoSize = true;
            lbText.Location = new Point(12, 80);
            lbText.Name = "lbText";
            lbText.Size = new Size(28, 15);
            lbText.TabIndex = 14;
            lbText.Text = "Text";
            // 
            // lbIPAddress
            // 
            lbIPAddress.AutoSize = true;
            lbIPAddress.Location = new Point(16, 23);
            lbIPAddress.Name = "lbIPAddress";
            lbIPAddress.Size = new Size(62, 15);
            lbIPAddress.TabIndex = 15;
            lbIPAddress.Text = "IP Address";
            // 
            // lbPort
            // 
            lbPort.AutoSize = true;
            lbPort.Location = new Point(224, 23);
            lbPort.Name = "lbPort";
            lbPort.Size = new Size(29, 15);
            lbPort.TabIndex = 16;
            lbPort.Text = "Port";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 449);
            Controls.Add(lbPort);
            Controls.Add(lbIPAddress);
            Controls.Add(lbText);
            Controls.Add(lbContent);
            Controls.Add(listBoxContent);
            Controls.Add(txtServerPort);
            Controls.Add(txtServerIP);
            Controls.Add(txtText);
            Controls.Add(btnSend);
            Controls.Add(btnConnect);
            Name = "Form1";
            Text = "Client App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxContent;
        private TextBox txtServerPort;
        private TextBox txtServerIP;
        private TextBox txtText;
        private Button btnSend;
        private Button btnConnect;
        private Label lbContent;
        private Label lbText;
        private Label lbIPAddress;
        private Label lbPort;
    }
}

namespace Assignment_2_Server
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
            btnListen = new Button();
            btnSend = new Button();
            txtText = new TextBox();
            txtServerIP = new TextBox();
            txtServerPort = new TextBox();
            listBoxContent = new ListBox();
            lbContent = new Label();
            lbText = new Label();
            lbIPAddress = new Label();
            lbPort = new Label();
            SuspendLayout();
            // 
            // btnListen
            // 
            btnListen.BackColor = SystemColors.GradientActiveCaption;
            btnListen.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnListen.Location = new Point(393, 53);
            btnListen.Name = "btnListen";
            btnListen.Size = new Size(75, 23);
            btnListen.TabIndex = 0;
            btnListen.Text = "Listen";
            btnListen.UseVisualStyleBackColor = false;
            btnListen.Click += btnListen_Click;
            // 
            // btnSend
            // 
            btnSend.BackColor = SystemColors.GradientActiveCaption;
            btnSend.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSend.Location = new Point(393, 132);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(75, 23);
            btnSend.TabIndex = 1;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // txtText
            // 
            txtText.Location = new Point(12, 106);
            txtText.Multiline = true;
            txtText.Name = "txtText";
            txtText.Size = new Size(350, 75);
            txtText.TabIndex = 2;
            // 
            // txtServerIP
            // 
            txtServerIP.Location = new Point(12, 53);
            txtServerIP.Name = "txtServerIP";
            txtServerIP.Size = new Size(161, 23);
            txtServerIP.TabIndex = 4;
            // 
            // txtServerPort
            // 
            txtServerPort.Location = new Point(200, 53);
            txtServerPort.Name = "txtServerPort";
            txtServerPort.Size = new Size(162, 23);
            txtServerPort.TabIndex = 5;
            // 
            // listBoxContent
            // 
            listBoxContent.FormattingEnabled = true;
            listBoxContent.ItemHeight = 15;
            listBoxContent.Location = new Point(12, 218);
            listBoxContent.Name = "listBoxContent";
            listBoxContent.ScrollAlwaysVisible = true;
            listBoxContent.Size = new Size(456, 229);
            listBoxContent.TabIndex = 6;
            // 
            // lbContent
            // 
            lbContent.AutoSize = true;
            lbContent.Location = new Point(12, 200);
            lbContent.Name = "lbContent";
            lbContent.Size = new Size(50, 15);
            lbContent.TabIndex = 7;
            lbContent.Text = "Content";
            // 
            // lbText
            // 
            lbText.AutoSize = true;
            lbText.Location = new Point(12, 88);
            lbText.Name = "lbText";
            lbText.Size = new Size(28, 15);
            lbText.TabIndex = 8;
            lbText.Text = "Text";
            // 
            // lbIPAddress
            // 
            lbIPAddress.AutoSize = true;
            lbIPAddress.Location = new Point(12, 35);
            lbIPAddress.Name = "lbIPAddress";
            lbIPAddress.Size = new Size(62, 15);
            lbIPAddress.TabIndex = 9;
            lbIPAddress.Text = "IP Address";
            // 
            // lbPort
            // 
            lbPort.AutoSize = true;
            lbPort.Location = new Point(200, 35);
            lbPort.Name = "lbPort";
            lbPort.Size = new Size(29, 15);
            lbPort.TabIndex = 10;
            lbPort.Text = "Port";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 459);
            Controls.Add(lbPort);
            Controls.Add(lbIPAddress);
            Controls.Add(lbText);
            Controls.Add(lbContent);
            Controls.Add(listBoxContent);
            Controls.Add(txtServerPort);
            Controls.Add(txtServerIP);
            Controls.Add(txtText);
            Controls.Add(btnSend);
            Controls.Add(btnListen);
            Name = "Form1";
            Text = "Server App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnListen;
        private Button btnSend;
        private TextBox txtText;
        private TextBox txtServerIP;
        private TextBox txtServerPort;
        private ListBox listBoxContent;
        private Label lbContent;
        private Label lbText;
        private Label lbIPAddress;
        private Label lbPort;
    }
}

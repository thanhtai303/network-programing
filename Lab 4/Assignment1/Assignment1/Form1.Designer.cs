namespace Assignment1
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
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            txtGmail = new TextBox();
            txtPort = new TextBox();
            txtFrom = new TextBox();
            txtTo = new TextBox();
            txtFile = new TextBox();
            txtTitle = new TextBox();
            txtMessage = new TextBox();
            btnSend = new Button();
            btnChooseList = new Button();
            openFileDialog1 = new OpenFileDialog();
            btnChooseFile = new Button();
            groupBox1 = new GroupBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            groupBox3 = new GroupBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(75, 35);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(243, 23);
            txtUserName.TabIndex = 0;
            txtUserName.Text = "tai.nguyen.cit20@eiu.edu.vn";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(75, 64);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(243, 23);
            txtPassword.TabIndex = 1;
            txtPassword.Text = "rhtu vlfb dslo ptiz";
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtGmail
            // 
            txtGmail.Location = new Point(50, 30);
            txtGmail.Name = "txtGmail";
            txtGmail.Size = new Size(239, 23);
            txtGmail.TabIndex = 2;
            txtGmail.Text = "smtp.gmail.com";
            // 
            // txtPort
            // 
            txtPort.Location = new Point(50, 59);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(239, 23);
            txtPort.TabIndex = 3;
            txtPort.Text = "587";
            // 
            // txtFrom
            // 
            txtFrom.Location = new Point(93, 31);
            txtFrom.Name = "txtFrom";
            txtFrom.Size = new Size(583, 23);
            txtFrom.TabIndex = 4;
            txtFrom.Text = "tai.nguyen.cit20@eiu.edu.vn";
            // 
            // txtTo
            // 
            txtTo.Location = new Point(93, 94);
            txtTo.Multiline = true;
            txtTo.Name = "txtTo";
            txtTo.ScrollBars = ScrollBars.Both;
            txtTo.Size = new Size(583, 112);
            txtTo.TabIndex = 5;
            // 
            // txtFile
            // 
            txtFile.Location = new Point(93, 226);
            txtFile.Multiline = true;
            txtFile.Name = "txtFile";
            txtFile.ScrollBars = ScrollBars.Both;
            txtFile.Size = new Size(583, 110);
            txtFile.TabIndex = 6;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(93, 359);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(583, 23);
            txtTitle.TabIndex = 7;
            txtTitle.Text = "Thanh Tai";
            // 
            // txtMessage
            // 
            txtMessage.Location = new Point(93, 411);
            txtMessage.Multiline = true;
            txtMessage.Name = "txtMessage";
            txtMessage.ScrollBars = ScrollBars.Both;
            txtMessage.Size = new Size(583, 157);
            txtMessage.TabIndex = 8;
            txtMessage.Text = "thanh tai dep trai 1234";
            // 
            // btnSend
            // 
            btnSend.Location = new Point(702, 476);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(75, 23);
            btnSend.TabIndex = 9;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // btnChooseList
            // 
            btnChooseList.Location = new Point(702, 145);
            btnChooseList.Name = "btnChooseList";
            btnChooseList.Size = new Size(75, 23);
            btnChooseList.TabIndex = 10;
            btnChooseList.Text = "Choose list";
            btnChooseList.UseVisualStyleBackColor = true;
            btnChooseList.Click += btnChooseList_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnChooseFile
            // 
            btnChooseFile.Location = new Point(702, 266);
            btnChooseFile.Name = "btnChooseFile";
            btnChooseFile.Size = new Size(75, 23);
            btnChooseFile.TabIndex = 11;
            btnChooseFile.Text = "Choose file";
            btnChooseFile.UseVisualStyleBackColor = true;
            btnChooseFile.Click += btnChooseFile_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtUserName);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(338, 100);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Loggin Setting";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 67);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 38);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 2;
            label1.Text = "User name";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtGmail);
            groupBox2.Controls.Add(txtPort);
            groupBox2.Location = new Point(382, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(306, 100);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 67);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 5;
            label4.Text = "Port";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 38);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 4;
            label3.Text = "Gmail";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(txtFrom);
            groupBox3.Controls.Add(txtFile);
            groupBox3.Controls.Add(txtTo);
            groupBox3.Controls.Add(txtMessage);
            groupBox3.Controls.Add(btnChooseList);
            groupBox3.Controls.Add(btnChooseFile);
            groupBox3.Controls.Add(txtTitle);
            groupBox3.Controls.Add(btnSend);
            groupBox3.Location = new Point(12, 138);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(792, 574);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "Email detail";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 411);
            label9.Name = "label9";
            label9.Size = new Size(53, 15);
            label9.TabIndex = 16;
            label9.Text = "Message";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 359);
            label8.Name = "label8";
            label8.Size = new Size(29, 15);
            label8.TabIndex = 15;
            label8.Text = "Title";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 226);
            label7.Name = "label7";
            label7.Size = new Size(74, 15);
            label7.TabIndex = 14;
            label7.Text = "File attached";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 31);
            label6.Name = "label6";
            label6.Size = new Size(65, 15);
            label6.TabIndex = 13;
            label6.Text = "Email from";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 90);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 12;
            label5.Text = "Email to";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 724);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtUserName;
        private TextBox txtPassword;
        private TextBox txtGmail;
        private TextBox txtPort;
        private TextBox txtFrom;
        private TextBox txtTo;
        private TextBox txtFile;
        private TextBox txtTitle;
        private TextBox txtMessage;
        private Button btnSend;
        private Button btnChooseList;
        private OpenFileDialog openFileDialog1;
        private Button btnChooseFile;
        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private Label label4;
        private Label label3;
        private GroupBox groupBox3;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label8;
        private Label label9;
    }
}

namespace Assignment2
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
            txtServer = new TextBox();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            txtPort = new TextBox();
            txtPath = new TextBox();
            txtStatus = new TextBox();
            txtServerPath = new TextBox();
            treeView1 = new TreeView();
            openFileDialog1 = new OpenFileDialog();
            btnLogin = new Button();
            listBoxFolder = new ListBox();
            listBoxFile = new ListBox();
            lisBoxServerFolder = new ListBox();
            listBoxServerFile = new ListBox();
            btnUpload = new Button();
            btnDownload = new Button();
            btnRename = new Button();
            txtNewFileName = new TextBox();
            btnDelete = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            saveFileDialog1 = new SaveFileDialog();
            SuspendLayout();
            // 
            // txtServer
            // 
            txtServer.Location = new Point(102, 23);
            txtServer.Name = "txtServer";
            txtServer.Size = new Size(379, 23);
            txtServer.TabIndex = 0;
            txtServer.Text = "ftp://127.0.0.1";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(102, 49);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(220, 23);
            txtUser.TabIndex = 1;
            txtUser.Text = "anonymous";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(102, 78);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(379, 23);
            txtPassword.TabIndex = 2;
            // 
            // txtPort
            // 
            txtPort.Location = new Point(381, 49);
            txtPort.Name = "txtPort";
            txtPort.Size = new Size(100, 23);
            txtPort.TabIndex = 3;
            txtPort.Text = "21";
            // 
            // txtPath
            // 
            txtPath.Location = new Point(102, 165);
            txtPath.Name = "txtPath";
            txtPath.Size = new Size(369, 23);
            txtPath.TabIndex = 4;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(694, 23);
            txtStatus.Multiline = true;
            txtStatus.Name = "txtStatus";
            txtStatus.ScrollBars = ScrollBars.Both;
            txtStatus.Size = new Size(402, 52);
            txtStatus.TabIndex = 7;
            txtStatus.Text = "Waiting for connection...";
            // 
            // txtServerPath
            // 
            txtServerPath.Location = new Point(694, 81);
            txtServerPath.Name = "txtServerPath";
            txtServerPath.Size = new Size(402, 23);
            txtServerPath.TabIndex = 8;
            // 
            // treeView1
            // 
            treeView1.Location = new Point(12, 228);
            treeView1.Name = "treeView1";
            treeView1.Size = new Size(503, 324);
            treeView1.TabIndex = 11;
            treeView1.BeforeExpand += treeView_BeforeExpand;
            treeView1.NodeMouseClick += treeView1_NodeMouseClick;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(227, 107);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(74, 34);
            btnLogin.TabIndex = 12;
            btnLogin.Text = "Log in";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // listBoxFolder
            // 
            listBoxFolder.FormattingEnabled = true;
            listBoxFolder.ItemHeight = 15;
            listBoxFolder.Location = new Point(547, 228);
            listBoxFolder.Name = "listBoxFolder";
            listBoxFolder.ScrollAlwaysVisible = true;
            listBoxFolder.Size = new Size(219, 124);
            listBoxFolder.TabIndex = 13;
            // 
            // listBoxFile
            // 
            listBoxFile.FormattingEnabled = true;
            listBoxFile.ItemHeight = 15;
            listBoxFile.Location = new Point(547, 398);
            listBoxFile.Name = "listBoxFile";
            listBoxFile.ScrollAlwaysVisible = true;
            listBoxFile.Size = new Size(219, 154);
            listBoxFile.TabIndex = 14;
            // 
            // lisBoxServerFolder
            // 
            lisBoxServerFolder.FormattingEnabled = true;
            lisBoxServerFolder.ItemHeight = 15;
            lisBoxServerFolder.Location = new Point(877, 219);
            lisBoxServerFolder.Name = "lisBoxServerFolder";
            lisBoxServerFolder.ScrollAlwaysVisible = true;
            lisBoxServerFolder.Size = new Size(219, 124);
            lisBoxServerFolder.TabIndex = 15;
            // 
            // listBoxServerFile
            // 
            listBoxServerFile.FormattingEnabled = true;
            listBoxServerFile.ItemHeight = 15;
            listBoxServerFile.Location = new Point(877, 398);
            listBoxServerFile.Name = "listBoxServerFile";
            listBoxServerFile.ScrollAlwaysVisible = true;
            listBoxServerFile.Size = new Size(219, 154);
            listBoxServerFile.TabIndex = 16;
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(786, 267);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(75, 23);
            btnUpload.TabIndex = 17;
            btnUpload.Text = "Upload";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // btnDownload
            // 
            btnDownload.Location = new Point(786, 357);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(75, 23);
            btnDownload.TabIndex = 18;
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = true;
            btnDownload.Click += btnDownload_Click;
            // 
            // btnRename
            // 
            btnRename.Location = new Point(786, 168);
            btnRename.Name = "btnRename";
            btnRename.Size = new Size(75, 23);
            btnRename.TabIndex = 19;
            btnRename.Text = "Rename";
            btnRename.UseVisualStyleBackColor = true;
            btnRename.Click += btnRename_Click;
            // 
            // txtNewFileName
            // 
            txtNewFileName.Location = new Point(877, 168);
            txtNewFileName.Name = "txtNewFileName";
            txtNewFileName.Size = new Size(219, 23);
            txtNewFileName.TabIndex = 20;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(786, 458);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 21;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 23);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 22;
            label1.Text = "Server";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 52);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 23;
            label2.Text = "User";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(336, 52);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 24;
            label3.Text = "Port";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 81);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 25;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 168);
            label5.Name = "label5";
            label5.Size = new Size(84, 15);
            label5.TabIndex = 26;
            label5.Text = "Client file path";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(583, 31);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 27;
            label6.Text = "Status";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(583, 84);
            label7.Name = "label7";
            label7.Size = new Size(85, 15);
            label7.TabIndex = 28;
            label7.Text = "Server file path";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(877, 150);
            label8.Name = "label8";
            label8.Size = new Size(83, 15);
            label8.TabIndex = 29;
            label8.Text = "New file name";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 210);
            label9.Name = "label9";
            label9.Size = new Size(55, 15);
            label9.TabIndex = 30;
            label9.Text = "Tree view";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(547, 210);
            label10.Name = "label10";
            label10.Size = new Size(45, 15);
            label10.TabIndex = 31;
            label10.Text = "Folders";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(547, 380);
            label11.Name = "label11";
            label11.Size = new Size(30, 15);
            label11.TabIndex = 32;
            label11.Text = "Files";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(877, 201);
            label12.Name = "label12";
            label12.Size = new Size(45, 15);
            label12.TabIndex = 33;
            label12.Text = "Folders";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(877, 380);
            label13.Name = "label13";
            label13.Size = new Size(30, 15);
            label13.TabIndex = 34;
            label13.Text = "Files";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 564);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDelete);
            Controls.Add(txtNewFileName);
            Controls.Add(btnRename);
            Controls.Add(btnDownload);
            Controls.Add(btnUpload);
            Controls.Add(listBoxServerFile);
            Controls.Add(lisBoxServerFolder);
            Controls.Add(listBoxFile);
            Controls.Add(listBoxFolder);
            Controls.Add(btnLogin);
            Controls.Add(treeView1);
            Controls.Add(txtServerPath);
            Controls.Add(txtStatus);
            Controls.Add(txtPath);
            Controls.Add(txtPort);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(txtServer);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtServer;
        private TextBox txtUser;
        private TextBox txtPassword;
        private TextBox txtPort;
        private TextBox txtPath;
        private TextBox txtStatus;
        private TextBox txtServerPath;
        private TreeView treeView1;
        private OpenFileDialog openFileDialog1;
        private Button btnLogin;
        private ListBox listBoxFolder;
        private ListBox listBoxFile;
        private ListBox lisBoxServerFolder;
        private ListBox listBoxServerFile;
        private Button btnUpload;
        private Button btnDownload;
        private Button btnRename;
        private TextBox txtNewFileName;
        private Button btnDelete;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private SaveFileDialog saveFileDialog1;
    }
}

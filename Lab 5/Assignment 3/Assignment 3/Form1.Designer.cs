namespace Assignment_3
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
            txtOrigin = new TextBox();
            txtCipher = new TextBox();
            txtDecrypt = new TextBox();
            btnEncrypt = new Button();
            btnDecrypt = new Button();
            SuspendLayout();
            // 
            // txtOrigin
            // 
            txtOrigin.Location = new Point(137, 12);
            txtOrigin.Multiline = true;
            txtOrigin.Name = "txtOrigin";
            txtOrigin.ScrollBars = ScrollBars.Both;
            txtOrigin.Size = new Size(430, 105);
            txtOrigin.TabIndex = 0;
            // 
            // txtCipher
            // 
            txtCipher.Location = new Point(137, 174);
            txtCipher.Multiline = true;
            txtCipher.Name = "txtCipher";
            txtCipher.ScrollBars = ScrollBars.Both;
            txtCipher.Size = new Size(430, 105);
            txtCipher.TabIndex = 1;
            // 
            // txtDecrypt
            // 
            txtDecrypt.Location = new Point(137, 333);
            txtDecrypt.Multiline = true;
            txtDecrypt.Name = "txtDecrypt";
            txtDecrypt.ScrollBars = ScrollBars.Both;
            txtDecrypt.Size = new Size(430, 105);
            txtDecrypt.TabIndex = 2;
            // 
            // btnEncrypt
            // 
            btnEncrypt.Location = new Point(630, 26);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(113, 68);
            btnEncrypt.TabIndex = 3;
            btnEncrypt.Text = "Encrypt";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // btnDecrypt
            // 
            btnDecrypt.Location = new Point(630, 193);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(113, 68);
            btnDecrypt.TabIndex = 4;
            btnDecrypt.Text = "Decrypt";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDecrypt);
            Controls.Add(btnEncrypt);
            Controls.Add(txtDecrypt);
            Controls.Add(txtCipher);
            Controls.Add(txtOrigin);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOrigin;
        private TextBox txtCipher;
        private TextBox txtDecrypt;
        private Button btnEncrypt;
        private Button btnDecrypt;
    }
}

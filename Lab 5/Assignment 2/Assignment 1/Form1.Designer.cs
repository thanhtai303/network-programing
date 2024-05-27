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
            txtOriginalText = new TextBox();
            txtCipherText = new TextBox();
            txtDecryptedText = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnDecrypt = new Button();
            btnEncrypt = new Button();
            SuspendLayout();
            // 
            // txtOriginalText
            // 
            txtOriginalText.Location = new Point(142, 12);
            txtOriginalText.Multiline = true;
            txtOriginalText.Name = "txtOriginalText";
            txtOriginalText.ScrollBars = ScrollBars.Both;
            txtOriginalText.Size = new Size(461, 110);
            txtOriginalText.TabIndex = 0;
            // 
            // txtCipherText
            // 
            txtCipherText.Location = new Point(142, 170);
            txtCipherText.Multiline = true;
            txtCipherText.Name = "txtCipherText";
            txtCipherText.ScrollBars = ScrollBars.Both;
            txtCipherText.Size = new Size(461, 110);
            txtCipherText.TabIndex = 1;
            // 
            // txtDecryptedText
            // 
            txtDecryptedText.Location = new Point(142, 328);
            txtDecryptedText.Multiline = true;
            txtDecryptedText.Name = "txtDecryptedText";
            txtDecryptedText.ScrollBars = ScrollBars.Both;
            txtDecryptedText.Size = new Size(461, 110);
            txtDecryptedText.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 15);
            label1.Name = "label1";
            label1.Size = new Size(56, 15);
            label1.TabIndex = 3;
            label1.Text = "Plain text";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 173);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 4;
            label2.Text = "Cipher text";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 331);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 5;
            label3.Text = "Plain text";
            // 
            // btnDecrypt
            // 
            btnDecrypt.Location = new Point(657, 190);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(138, 67);
            btnDecrypt.TabIndex = 6;
            btnDecrypt.Text = "Decrypt";
            btnDecrypt.UseVisualStyleBackColor = true;
            btnDecrypt.Click += btnDecrypt_Click;
            // 
            // btnEncrypt
            // 
            btnEncrypt.Location = new Point(657, 35);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(138, 67);
            btnEncrypt.TabIndex = 7;
            btnEncrypt.Text = "Encrypt";
            btnEncrypt.UseVisualStyleBackColor = true;
            btnEncrypt.Click += btnEncrypt_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 450);
            Controls.Add(btnEncrypt);
            Controls.Add(btnDecrypt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDecryptedText);
            Controls.Add(txtCipherText);
            Controls.Add(txtOriginalText);
            Name = "Form1";
            Text = "RSA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtOriginalText;
        private TextBox txtCipherText;
        private TextBox txtDecryptedText;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnDecrypt;
        private Button btnEncrypt;
    }
}

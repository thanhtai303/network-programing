namespace Assignment_2
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
            txtURL = new TextBox();
            txtContent = new TextBox();
            btnGet = new Button();
            lbURL = new Label();
            lbContent = new Label();
            SuspendLayout();
            // 
            // txtURL
            // 
            txtURL.Location = new Point(12, 31);
            txtURL.Name = "txtURL";
            txtURL.Size = new Size(523, 23);
            txtURL.TabIndex = 0;
            // 
            // txtContent
            // 
            txtContent.Location = new Point(12, 97);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.ScrollBars = ScrollBars.Both;
            txtContent.Size = new Size(706, 500);
            txtContent.TabIndex = 1;
            // 
            // btnGet
            // 
            btnGet.BackColor = SystemColors.ActiveCaption;
            btnGet.Location = new Point(541, 31);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(177, 23);
            btnGet.TabIndex = 2;
            btnGet.Text = "Get";
            btnGet.UseVisualStyleBackColor = false;
            btnGet.Click += btnGet_Click;
            // 
            // lbURL
            // 
            lbURL.AutoSize = true;
            lbURL.Location = new Point(12, 13);
            lbURL.Name = "lbURL";
            lbURL.Size = new Size(28, 15);
            lbURL.TabIndex = 3;
            lbURL.Text = "URL";
            // 
            // lbContent
            // 
            lbContent.AutoSize = true;
            lbContent.Location = new Point(12, 79);
            lbContent.Name = "lbContent";
            lbContent.Size = new Size(50, 15);
            lbContent.TabIndex = 4;
            lbContent.Text = "Content";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(730, 609);
            Controls.Add(lbContent);
            Controls.Add(lbURL);
            Controls.Add(btnGet);
            Controls.Add(txtContent);
            Controls.Add(txtURL);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtURL;
        private TextBox txtContent;
        private Button btnGet;
        private Label lbURL;
        private Label lbContent;
    }
}

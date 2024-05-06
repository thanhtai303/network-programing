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
            txtURL = new TextBox();
            txtParameter = new TextBox();
            txtValue = new TextBox();
            txtContent = new TextBox();
            btnGet = new Button();
            lbURL = new Label();
            lbParameter = new Label();
            lbValue = new Label();
            lbContent = new Label();
            SuspendLayout();
            // 
            // txtURL
            // 
            txtURL.Location = new Point(12, 23);
            txtURL.Name = "txtURL";
            txtURL.Size = new Size(860, 23);
            txtURL.TabIndex = 0;
            // 
            // txtParameter
            // 
            txtParameter.Location = new Point(12, 75);
            txtParameter.Name = "txtParameter";
            txtParameter.Size = new Size(355, 23);
            txtParameter.TabIndex = 1;
            txtParameter.Text = "type";
            // 
            // txtValue
            // 
            txtValue.Location = new Point(12, 125);
            txtValue.Name = "txtValue";
            txtValue.Size = new Size(355, 23);
            txtValue.TabIndex = 2;
            txtValue.Text = "all";
            // 
            // txtContent
            // 
            txtContent.Location = new Point(12, 188);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.ScrollBars = ScrollBars.Both;
            txtContent.Size = new Size(860, 412);
            txtContent.TabIndex = 3;
            // 
            // btnGet
            // 
            btnGet.BackColor = SystemColors.ActiveCaption;
            btnGet.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGet.Location = new Point(506, 84);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(366, 64);
            btnGet.TabIndex = 4;
            btnGet.Text = "Get";
            btnGet.UseVisualStyleBackColor = false;
            btnGet.Click += btnGet_Click;
            // 
            // lbURL
            // 
            lbURL.AutoSize = true;
            lbURL.Location = new Point(12, 5);
            lbURL.Name = "lbURL";
            lbURL.Size = new Size(28, 15);
            lbURL.TabIndex = 5;
            lbURL.Text = "URL";
            // 
            // lbParameter
            // 
            lbParameter.AutoSize = true;
            lbParameter.Location = new Point(12, 57);
            lbParameter.Name = "lbParameter";
            lbParameter.Size = new Size(61, 15);
            lbParameter.TabIndex = 6;
            lbParameter.Text = "Parameter";
            // 
            // lbValue
            // 
            lbValue.AutoSize = true;
            lbValue.Location = new Point(12, 109);
            lbValue.Name = "lbValue";
            lbValue.Size = new Size(35, 15);
            lbValue.TabIndex = 7;
            lbValue.Text = "Value";
            // 
            // lbContent
            // 
            lbContent.AutoSize = true;
            lbContent.Location = new Point(12, 170);
            lbContent.Name = "lbContent";
            lbContent.Size = new Size(50, 15);
            lbContent.TabIndex = 8;
            lbContent.Text = "Content";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 612);
            Controls.Add(lbContent);
            Controls.Add(lbValue);
            Controls.Add(lbParameter);
            Controls.Add(lbURL);
            Controls.Add(btnGet);
            Controls.Add(txtContent);
            Controls.Add(txtValue);
            Controls.Add(txtParameter);
            Controls.Add(txtURL);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtURL;
        private TextBox txtParameter;
        private TextBox txtValue;
        private TextBox txtContent;
        private Button btnGet;
        private Label lbURL;
        private Label lbParameter;
        private Label lbValue;
        private Label lbContent;
    }
}

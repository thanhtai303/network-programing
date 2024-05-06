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
            txtURL = new TextBox();
            txtResult = new TextBox();
            btnResolve = new Button();
            lbURL = new Label();
            lbResult = new Label();
            SuspendLayout();
            // 
            // txtURL
            // 
            txtURL.Location = new Point(12, 37);
            txtURL.Name = "txtURL";
            txtURL.Size = new Size(573, 23);
            txtURL.TabIndex = 0;
            // 
            // txtResult
            // 
            txtResult.Location = new Point(12, 112);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.ScrollBars = ScrollBars.Both;
            txtResult.Size = new Size(729, 507);
            txtResult.TabIndex = 1;
            // 
            // btnResolve
            // 
            btnResolve.BackColor = SystemColors.ActiveCaption;
            btnResolve.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResolve.Location = new Point(591, 37);
            btnResolve.Name = "btnResolve";
            btnResolve.Size = new Size(150, 23);
            btnResolve.TabIndex = 2;
            btnResolve.Text = "Resolve";
            btnResolve.UseVisualStyleBackColor = false;
            btnResolve.Click += button1_Click;
            // 
            // lbURL
            // 
            lbURL.AutoSize = true;
            lbURL.Location = new Point(12, 19);
            lbURL.Name = "lbURL";
            lbURL.Size = new Size(28, 15);
            lbURL.TabIndex = 3;
            lbURL.Text = "URL";
            // 
            // lbResult
            // 
            lbResult.AutoSize = true;
            lbResult.Location = new Point(12, 94);
            lbResult.Name = "lbResult";
            lbResult.Size = new Size(39, 15);
            lbResult.TabIndex = 4;
            lbResult.Text = "Result";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(753, 631);
            Controls.Add(lbResult);
            Controls.Add(lbURL);
            Controls.Add(btnResolve);
            Controls.Add(txtResult);
            Controls.Add(txtURL);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtURL;
        private TextBox txtResult;
        private Button btnResolve;
        private Label lbURL;
        private Label lbResult;
    }
}

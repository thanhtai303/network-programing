using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] gmail;
        List<string> fileAttack = new List<string>();
        private void btnSend_Click(object sender, EventArgs e)
        {
            // Thread thread = new Thread(SendEmail);
            //  thread.Start();
            SendEmail();

        }

        void SendEmail()
        {
            NetworkCredential networkCredential =
                             new NetworkCredential(txtUserName.Text, txtPassword.Text);
            SmtpClient client = new SmtpClient();
            client.Host = txtGmail.Text;
            client.Port = Int32.Parse(txtPort.Text);
            client.UseDefaultCredentials = false;
            client.EnableSsl = true;
            client.Credentials = networkCredential;

            MailAddress from = new MailAddress(txtFrom.Text);
            MailMessage message = new MailMessage();
            message.From = from;
            foreach (string mail in gmail)
            {

                message.To.Add(new MailAddress(mail));
            }

            message.Subject = txtTitle.Text;
            message.SubjectEncoding = System.Text.Encoding.UTF8;
            message.Body = txtMessage.Text;
            message.BodyEncoding = System.Text.Encoding.UTF8;
            for (int i = 0; i < fileAttack.Count; i++)
            {
                message.Attachments.Add(new Attachment(fileAttack[i]));
            }
            client.Send(message);
            message.Dispose();
        }
        private void btnChooseList_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text File |*.txt|All Files|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                gmail = File.ReadLines(openFileDialog1.FileName).ToArray();
                for (int i = 0; i < gmail.Length; i++)
                {
                    txtTo.AppendText(gmail[i] + Environment.NewLine);
                }
            }
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files |*.txt|Image Files|*.jpg|All Files|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                fileAttack.Add(openFileDialog1.FileName);
                txtFile.AppendText(openFileDialog1.FileName + Environment.NewLine);
            }

        }
    }
}

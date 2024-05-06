using System.Net;
using System.Net.Http;

namespace Assignment_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IPAddress[] ip = Dns.GetHostAddresses(txtURL.Text);

            foreach (IPAddress ipAddr in ip)
            {
                txtResult.AppendText(ipAddr.ToString() + Environment.NewLine);
            }

        }
    }
}

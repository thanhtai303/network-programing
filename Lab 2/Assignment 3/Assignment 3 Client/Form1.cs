using System.Net.Sockets;
using System.Text;
using System.Net;

namespace Assignment_3_Client
{
    public partial class formClientApp : Form
    {
        public formClientApp()
        {
            InitializeComponent();
        }
        TcpClient client;
        NetworkStream networkStream;
        private void btnChooseAndSendAPicture_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files|*.jpg;*.png|All Files|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(txtFilePath.Text);
            }
        }
        private void btnSendImage_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(Send);
            thread.Start();
        }
        void Send()
        {
            try
            {
                byte[] bytes = File.ReadAllBytes(openFileDialog1.FileName);
                networkStream.Write(bytes, 0, bytes.Length);
                client.Close();
                networkStream.Close();
            }
            catch (Exception e)
            {
                client = new TcpClient(txtIPAddress.Text, Int32.Parse(txtPort.Text));
                networkStream = client.GetStream();
                byte[] bytes = File.ReadAllBytes(openFileDialog1.FileName);
                networkStream.Write(bytes, 0, bytes.Length);
                client.Close();
                networkStream.Close();
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                client = new TcpClient(txtIPAddress.Text, Int32.Parse(txtPort.Text));
                networkStream = client.GetStream();
                txtStatus.Text = "Connecting...";
            }
            catch (Exception Unhandle)
            {
                MessageBox.Show("IP Address or Port are not correct." + Environment.NewLine + "Please try again!", "Warning");
            }
        }
    }
}

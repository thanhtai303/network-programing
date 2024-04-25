using System.Net.Sockets;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
namespace Assignment_2_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TcpClient client;
        private void btnConnect_Click(object sender, EventArgs e)
        {
            client = new TcpClient(txtServerIP.Text, Int32.Parse(txtServerPort.Text));
            Thread thread = new Thread(Listen);
            thread.Start();

        }
        void Listen()
        {
            NetworkStream networkStream = client.GetStream();
            byte[] bytes = new byte[258];
            while (true)
            {
                int isRead = 0;
                String recievedData;
                while ((isRead = networkStream.Read(bytes, 0, bytes.Length)) > 0)
                {
                    recievedData = Encoding.UTF8.GetString(bytes, 0, isRead);
                    listBoxContent.Invoke(new Action(() =>
                    {
                        listBoxContent.Items.Add("Server: " + recievedData + Environment.NewLine);
                    }));
                }
            }
            Array.Clear(bytes, 0, bytes.Length);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            NetworkStream networkStream = client.GetStream();
            string text = txtText.Text;
            networkStream.Write(Encoding.UTF8.GetBytes(text), 0, Encoding.UTF8.GetBytes(text).Length);
            txtText.Clear();
        }
    }
}

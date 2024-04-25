using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Assignment_2_Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        TcpListener server;
        TcpClient client;
        private void btnListen_Click(object sender, EventArgs e)
        {
            server = new TcpListener(IPAddress.Parse(txtServerIP.Text), Int32.Parse(txtServerPort.Text));
            server.Start();

            listBoxContent.Items.Add("Waiting for a connection...");

            Thread thread = new Thread(Listen);
            thread.Start();

        }
        void Listen()
        {
            byte[] bytes = new byte[256];
            while (true)
            {
                client = server.AcceptTcpClient();
                listBoxContent.Invoke(new Action(() =>
                {
                    listBoxContent.Items.Add("Connected" + Environment.NewLine);
                }));
                NetworkStream networkStream = client.GetStream();
                int isRead = 0;
                string recievedData;
                while ((isRead = networkStream.Read(bytes, 0, bytes.Length)) != 0)
                {
                    recievedData = Encoding.UTF8.GetString(bytes, 0, bytes.Length);

                    listBoxContent.Invoke(new Action(() =>
                    {
                        listBoxContent.Items.Add("Client: " + recievedData + Environment.NewLine);
                    }));
                    Array.Clear(bytes, 0, bytes.Length);
                }
            }
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

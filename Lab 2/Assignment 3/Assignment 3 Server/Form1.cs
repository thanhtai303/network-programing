using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Text;
using System.Drawing.Imaging;

namespace Assignment_3_Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TcpListener server;
        TcpClient client;
        void Listen()
        {
            byte[] buffer = new byte[1024];
            while (true)
            {
                client = server.AcceptTcpClient();
                NetworkStream netStream = client.GetStream();
                int isread = 0;
                MemoryStream memoryStream = new MemoryStream();
                while ((isread = netStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    memoryStream.Write(buffer, 0, buffer.Length);
                }
                pictureBox1.Image = Image.FromStream(memoryStream);
            }
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            try
            {
                server = new TcpListener(IPAddress.Parse(txtIPAddress.Text), Int32.Parse(txtPort.Text));
                server.Start();
                txtStatus.Text = "Connecting...";
                Thread thread = new Thread(Listen);
                thread.Start();
            }catch (Exception ex)
            {
                MessageBox.Show("Something went wrong."+Environment.NewLine+"Please try again!", "Warning");
            }           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Image Files|*.jpg|All Files|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Save(saveFileDialog1.FileName);
            }
        }
        void Save(string filePath)
        {
            Image img = pictureBox1.Image;
            using (FileStream fileStream = new FileStream(filePath, FileMode.Create))
            {
                img.Save(fileStream,ImageFormat.Jpeg);
            }
        }
    }
}

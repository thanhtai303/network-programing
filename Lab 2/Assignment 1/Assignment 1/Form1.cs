using System.Diagnostics;
using System.Formats.Tar;
using System.Windows.Forms;

namespace Assignment_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Thread[] threads;
        int numberOfFile = 0;
        private void btnUpload_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files (*.jpg, *.png)|*.jpg; *.png| All Files |*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string[] filePaths = openFileDialog1.FileNames;
                numberOfFile = filePaths.Length;
                threads = new Thread[numberOfFile];

                for (int i = 0; i < numberOfFile; i++)
                {
                    txtFileList.AppendText(filePaths[i] + Environment.NewLine);
                    threads[i] = new Thread(UploadFile);
                    threads[i].Start(filePaths[i]);
                }
                Thread t = new Thread(JoinThreads);
                t.Start();
            }
        }

        void JoinThreads()
        {
            for (int i = 0; i < numberOfFile; i++)
            {
                threads[i].Join();
            }
        }

        void UploadFile(object _filePath)
        {
            string filePath = (string)_filePath;
            string fileName = Path.GetFileName(filePath);

            Action _uploading = delegate ()
            {
                listBoxStatus.Items.Add("Uploading " + fileName);
            };
            listBoxStatus.Invoke(_uploading);

            //Emulator waiting time
            Random r = new Random();
            int randomNumber = r.Next(2, 6);
            Thread.Sleep(randomNumber * 200);

            CopyFileToFolder(filePath);

            Action _uploaded = delegate ()
            {
                listBoxStatus.Items.Add(" * Uploaded " + fileName);
            };
            listBoxStatus.Invoke(_uploaded);
        }

        void CopyFileToFolder(string filePath)
        {
            string destinationDirectory = "./Image/";
            var destination = new DirectoryInfo(destinationDirectory);
            if (!destination.Exists)
            {
                destination.Create();
            }
            File.Copy(filePath, destinationDirectory + Path.GetFileName(filePath));
        }
    }
}

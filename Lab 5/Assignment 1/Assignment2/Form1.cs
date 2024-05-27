using Microsoft.VisualBasic.ApplicationServices;
using System.IO;
using System.Net;

namespace Assignment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void GetFileAndFolder(string _server, string _user, string _pass, string _path)
        {
            lisBoxServerFolder.Items.Clear();
            listBoxServerFile.Items.Clear();

            string url = _server + ":" + txtPort.Text + _path;

            FtpWebRequest request = (FtpWebRequest)WebRequest.Create(url);
            request.Method = WebRequestMethods.Ftp.ListDirectoryDetails;
            request.Credentials = new NetworkCredential(_user, _pass);

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            Stream responseStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(responseStream);

            string xml = reader.ReadToEnd();
            txtStatus.Text = response.StatusDescription;

            reader.Close();
            response.Close();

            string[] ls = xml.Split(new string[] { "\r\n" }, StringSplitOptions.None);
            foreach (string line in ls)
            {
                if (line.Length > 38)
                {
                    if (line.IndexOf("<DIR>", 0, 39) > 0)
                    {
                        lisBoxServerFolder.Items.Add(line.Substring(39));
                    }
                    else
                    {
                        listBoxServerFile.Items.Add(line.Substring(39));
                    }
                }
            }
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            GetFileAndFolder(txtServer.Text, txtUser.Text, txtPassword.Text, "/");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] drives = Environment.GetLogicalDrives();

            foreach (var drive in drives)
            {
                DriveInfo driveInfo = new DriveInfo(drive);
                int driveImage;
                switch (driveInfo.DriveType)
                {
                    case DriveType.CDRom:
                        driveImage = 3; break;
                    case DriveType.Network:
                        driveImage = 6; break;
                    case DriveType.NoRootDirectory:
                        driveImage = 8; break;
                    case DriveType.Unknown:
                        driveImage = 9; break;
                    default:
                        driveImage = 2; break;
                }
                TreeNode node = new TreeNode(drive.Substring(0, 1), driveImage, driveImage);
                node.Tag = drive;
                if (driveInfo.IsReady)
                {
                    node.Nodes.Add("...");
                }
                treeView1.Nodes.Add(node);
            }
        }

        private void treeView_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            if (e.Node.Nodes.Count > 0)
            {
                if (e.Node.Nodes[0].Text == "..." && e.Node.Nodes[0].Tag == null)
                {
                    string[] dirs = Directory.GetDirectories(e.Node.Tag.ToString());

                    foreach (string dir in dirs)
                    {
                        DirectoryInfo di = new DirectoryInfo(dir);
                        TreeNode node = new TreeNode(di.Name, 0, 1);
                        try
                        {
                            node.Tag = dir;
                            if (di.GetDirectories().Count() > 0)
                            {
                                node.Nodes.Add(null, "...", 0, 0);
                            }
                        }
                        catch (UnauthorizedAccessException)
                        {
                            node.ImageIndex = 12;
                            node.SelectedImageIndex = 12;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Directory Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            e.Node.Nodes.Add(node);
                        }

                    }
                }
            }
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            listBoxFolder.Items.Clear();
            listBoxFile.Items.Clear();
            txtPath.Text = e.Node.Tag.ToString();
            try
            {
                string[] fileEntries = Directory.GetFiles(e.Node.Tag.ToString());
                foreach (string fileEntry in fileEntries)
                {
                    listBoxFile.Items.Add(Path.GetFileName(fileEntry));
                }
                string[] folderEntries = Directory.GetDirectories(e.Node.Tag.ToString());
                foreach (string folderEntry in folderEntries)
                {
                    listBoxFolder.Items.Add(Path.GetFileName(folderEntry));
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Directory Error!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (listBoxFile.SelectedItems != null)
            {
                string _path = treeView1.SelectedNode.Tag.ToString() + "\\" +
                    listBoxFile.GetItemText(listBoxFile.SelectedItem);
                FileInfo thisFile = new FileInfo(_path);
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(new Uri(txtServer.Text + "/" + thisFile.Name));
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential(txtUser.Text, txtPassword.Text);
                byte[] bytes = File.ReadAllBytes(thisFile.FullName);
                using (Stream stream = request.GetRequestStream())
                {
                    stream.Write(bytes, 0, bytes.Length);
                    stream.Close();
                }
            }
        }

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            if (listBoxServerFile.SelectedItems != null)
            {
                saveFileDialog1.Filter = "Text Files|*.txt|JPG Image|*.jpg|All Files|*.*";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtServerPath.Text = listBoxServerFile.SelectedItem.ToString();

                    FtpWebRequest request = (FtpWebRequest)WebRequest.
                        Create(txtServer.Text + ":" + txtPort.Text + "/" + listBoxServerFile.SelectedItem.ToString());

                    request.Credentials = new NetworkCredential(txtUser.Text, txtPassword.Text);
                    request.Method = WebRequestMethods.Ftp.DownloadFile;


                    using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                    {
                        using (Stream responseStream = response.GetResponseStream())
                        {
                            using (FileStream fileStream = new FileStream(saveFileDialog1.FileName, FileMode.Create))
                            {
                                responseStream.CopyTo(fileStream);
                            }
                        }
                    }
                }
                MessageBox.Show("Download Successful!");
            }
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            if (listBoxServerFile.SelectedItems != null)
            {
                txtServerPath.Text = listBoxServerFile.SelectedItem.ToString();

                FtpWebRequest request = (FtpWebRequest)WebRequest.
                    Create(txtServer.Text + ":" + txtPort.Text + "/" + listBoxServerFile.SelectedItem.ToString());
                request.Credentials = new NetworkCredential(txtUser.Text, txtPassword.Text);
                request.Method = WebRequestMethods.Ftp.Rename;
                request.RenameTo = txtNewFileName.Text;
                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    MessageBox.Show($"File renamed successfully. Status: {response.StatusDescription}");
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBoxServerFile.SelectedItems != null)
            {
                txtServerPath.Text = listBoxServerFile.SelectedItem.ToString();

                FtpWebRequest request = (FtpWebRequest)WebRequest.
                    Create(txtServer.Text + ":" + txtPort.Text + "/" + listBoxServerFile.SelectedItem.ToString());
                request.Credentials = new NetworkCredential(txtUser.Text, txtPassword.Text);
                request.Method = WebRequestMethods.Ftp.DeleteFile;
                using (FtpWebResponse response = (FtpWebResponse)request.GetResponse())
                {
                    MessageBox.Show($"File deleted successfully. Status: {response.StatusDescription}");
                }

            }
        }
    }
}

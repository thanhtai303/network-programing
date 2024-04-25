using System.Text;

namespace CSE306_Lab1_NguyenThanhTai_2031200020
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files |*.txt|All Files |*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = openFileDialog1.FileName;
            }
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            using (FileStream fileStream = File.OpenRead(txtFilePath.Text))
            {
                byte[] bytes = new byte[1024];
                int readLenght;
                while ((readLenght = fileStream.Read(bytes, 0, bytes.Length)) > 0)
                {
                    if (utf8Encoding.Checked)
                    {
                        UTF8Encoding encode = new UTF8Encoding(true);
                        txtContent.Text = encode.GetString(bytes, 0, bytes.Length);
                    }
                    else
                    {
                        UnicodeEncoding encode = new UnicodeEncoding();
                        txtContent.Text = encode.GetString(bytes, 0, bytes.Length);
                    }
                }
            }
        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files |*.txt|All Files |*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (FileStream fileStream = File.Open(saveFileDialog1.FileName, FileMode.Create, FileAccess.ReadWrite))
                {
                    if (utf8Encoding.Checked)
                    {
                        byte[] bytes = new UTF8Encoding().GetBytes(txtContent.Text);
                        fileStream.Write(bytes, 0, bytes.Length);
                    }
                    else
                    {
                        byte[] bytes = new UnicodeEncoding().GetBytes(txtContent.Text);
                        fileStream.Write(bytes, 0, bytes.Length);
                    }
                }
            }
            txtContent.Clear();
            MessageBox.Show("Successful", "Note");
        }
    }
}

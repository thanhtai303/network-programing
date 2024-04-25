using System.Text;

namespace CSE306_Lab1_NguyenThanhTai_2031200020
{
    public partial class streamReaderAndWriter : Form
    {
        public streamReaderAndWriter()
        {
            InitializeComponent();
        }

        private void txtFilePath_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = ("Text Files |*.txt|All Files |*.*");
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    txtFilePath.Text = openFileDialog1.FileName;
                }
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            using (StreamReader sr = new StreamReader(txtFilePath.Text))
                {
                    txtContent.Text = sr.ReadToEnd();
                }
        }

        private void btnSaveContent_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = ("Text Files |*.txt|All Files |*.*");
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.ReadWrite)))
                {
                    sw.Write(txtContent.Text);    
                }
                txtContent.Clear();
                MessageBox.Show("Successful", "Note");
            }
        }
    }
}


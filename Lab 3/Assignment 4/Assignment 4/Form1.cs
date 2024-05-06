using System.Drawing.Imaging;

namespace Assignment_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                using (HttpClient client = new HttpClient())
                {
                    Uri uri = new Uri(txtURL.Text);
                    String fileName = Path.GetFileName(uri.AbsolutePath);

                    using (HttpResponseMessage result = await client.GetAsync(uri, HttpCompletionOption.ResponseHeadersRead))
                    {
                        result.EnsureSuccessStatusCode();
                        Stream stream = await result.Content.ReadAsStreamAsync();
                        Image img = Image.FromStream(stream);
                        pictureBox1.Image = img;
                        string filePath = Path.Combine(folderBrowserDialog1.SelectedPath, fileName);
                        using (FileStream fileStream = File.Create(filePath))
                        {
                            img.Save(fileStream, ImageFormat.Jpeg);
                        }
                    }
                }
            }
        }
    }
}

namespace Assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnGet_Click(object sender, EventArgs e)
        {
            HttpClient client = new HttpClient();
            String result = await client.GetStringAsync(txtURL.Text);
            txtContent.Text = result;
        }
    }
}

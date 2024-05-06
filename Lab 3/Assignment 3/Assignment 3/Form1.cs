namespace Assignment_3
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
            FormUrlEncodedContent data = new FormUrlEncodedContent(new Dictionary<string, string>
            {
                { txtParameter.Text, txtValue.Text }
            });
            HttpResponseMessage result = await client.PostAsync(txtURL.Text, data);
            txtContent.Text = await result.Content.ReadAsStringAsync();
        }

    }
}

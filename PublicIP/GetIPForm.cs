namespace PublicIP
{
    public partial class GetIPForm : Form
    {
        public GetIPForm()
        {
            InitializeComponent();

            this.Load += GetIPForm_Load;
            this.getButton.Click += GetButton_Click;
        }



        private void GetIPForm_Load(object? sender, EventArgs e)
        {
            GetPublicIPAddress();
        }

        private async void GetPublicIPAddress()
        {
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync("http://checkip.dyndns.org");
            string content = await response.Content.ReadAsStringAsync();

            string ip = ParseIpAddress(content);

            Clipboard.SetText(ip);
            this.ipTtextBox.Text = ip;
        }

        static string ParseIpAddress(string content)
        {
            int startIndex = content.IndexOf(':') + 1;
            int endIndex = content.IndexOf('<', startIndex);
            string ip = content.Substring(startIndex, endIndex - startIndex).Trim();
            return ip;
        }


        private void GetButton_Click(object? sender, EventArgs e)
        {
            GetPublicIPAddress();
        }
    }
}
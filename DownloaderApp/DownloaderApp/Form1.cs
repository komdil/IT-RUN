using System.Windows.Forms.VisualStyles;

namespace DownloaderApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You need to activate app");
        }


        private void button2_Click(object sender, EventArgs e)
        {
            var url = textBox1.Text;
            DownloadFromUrl(url);
        }

        private void DownloadFromUrl(string url)
        {
            //Download with http client
            Task.Run(() =>
            {
                Task.Delay(500).Wait();
            }).ContinueWith(s =>
            {
                this.Invoke(() =>
                {
                    listBox1.Items.Add("File downloaded");
                });
            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
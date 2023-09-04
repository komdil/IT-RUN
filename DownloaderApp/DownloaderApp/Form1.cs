using System.Threading;
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

        Semaphore semaphore;
        private void button2_Click(object sender, EventArgs e)
        {
            int sim = int.Parse(textBox2.Text);
            semaphore = new Semaphore(sim, sim);
            var downloadCount = int.Parse(textBox1.Text);
            for (int i = 0; i < downloadCount; i++)
            {
                DownloadFromUrl(i);
            }
        }

        private void DownloadFromUrl(int fileNumber)
        {
            //Download with http client
            Task.Run(() =>
            {
                semaphore.WaitOne();
                Task.Delay(1000).Wait();
                semaphore.Release();
            }).ContinueWith(s =>
            {
                this.Invoke(() =>
                {
                    listBox1.Items.Add($"File {fileNumber} downloaded");
                });
            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
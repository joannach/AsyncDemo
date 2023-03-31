using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Downloader
{
    public partial class Downloader : Form
    {
        public Downloader()
        {
            InitializeComponent();
        }

        private DateTime _startTime = DateTime.MaxValue;

        private void button1_Click(object sender, EventArgs e)
        {
            DisableDownloadButtons();
            StartTimer();
            using(var downloader = new System.Net.WebClient())
            {
                var page = downloader.DownloadString(url_textbox.Text);
            }
            StopTimer();
            EnableDownloadButtons();
        }

        private void EnableDownloadButtons()
        {
            button_downloadSync.Enabled = true;
            button_downloadAsync.Enabled = true;
        }

        private void DisableDownloadButtons()
        {
            button_downloadSync.Enabled = false;
            button_downloadAsync.Enabled = false;
        }

        private void StopTimer()
        {
            timer.Enabled = false;
            ShowDuration();
        }

        private void ShowDuration()
        {
            duration_v.Text = (DateTime.UtcNow - _startTime).TotalMilliseconds.ToString() + "ms";
        }

        private void StartTimer()
        {
            _startTime = DateTime.UtcNow;
            ShowDuration();
            timer.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DisableDownloadButtons();
            StartTimer();
            backgroundWorker.RunWorkerAsync();
        }

        private void url_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            var targetMethod = new Action(UpdateUI);
            this.Invoke(targetMethod);

            using(var downloader = new System.Net.WebClient())
            {
                var page = downloader.DownloadString(url_textbox.Text);
            }
        }

        private void UpdateUI()
        {
            this.Text = "Test label";
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            StopTimer();
            EnableDownloadButtons();
        }

        private void timer_tick(object sender, EventArgs e)
        {
            ShowDuration();
        }
    }
}

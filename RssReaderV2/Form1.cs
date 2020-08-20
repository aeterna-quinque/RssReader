using System;
using System.Windows.Forms;

namespace RssReader
{
    public partial class Form1 : Form
    {
        RssReader rss = new RssReader();
        string source = "https://habr.com/rss/interesting/";
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        int timeInterval = int.Parse(System.Configuration.ConfigurationSettings.AppSettings["RefreshTime"]);

        public Form1()
        {
            InitializeComponent();
            Refresher();
            timer.Tick += new EventHandler(RefreshButton_Click);
            timer.Interval = timeInterval;
            timer.Start();
            CurrTimeBox.Text = (timeInterval / 1000).ToString() + " seconds";
            CurrSiteBox.Text = rss.GetSiteName();
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            Refresher();
        }

        private void OutputBox_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void Refresher()
        {
            rss.GetNewArticles(source);
            OutputBox.Lines = rss.GetText();
            TimerReset();
        }

        private void TimeButton_Click(object sender, EventArgs e)
        {
            int time = int.Parse(TimeBox.Text) * 1000;
            timer.Interval = time;
            TimerReset();
            TimeBox.Clear();
            CurrTimeBox.Text = (time/1000).ToString() + " seconds";
        }

        private void PathButton_Click(object sender, EventArgs e)
        {
            string path = PathBox.Text;
            source = path;
            Refresher();
            PathBox.Clear();
            CurrSiteBox.Text = rss.GetSiteName();
        }

        private void TimerReset()
        {
            timer.Stop();
            timer.Start();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IP_Refresher;

namespace TrayApp
{
    public partial class ConfigWindow : Form
    {
        private BackgroundWorker bw;
        private Timer t;

        public ConfigWindow()
        {
            InitializeComponent();
            InitialiseBackgroundWorker();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            OVHIpLabel.Text = await IpRefresher.GetIp(IpType.Ovh);
            NetworkIPLabel.Text = await IpRefresher.GetIp(IpType.Internet);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IpRefresher.UpdateAsync();
        }

        private void NotRunningLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NotRunningLinkLabel.Hide();

            RunningLinkLabel.Show();
        }

        private void RunningLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RunningLinkLabel.Hide();

            NotRunningLinkLabel.Show();
        }

        private void InitialiseBackgroundWorker()
        {
            bw.DoWork += new DoWorkEventHandler(Start);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(Stop);
            bw.ProgressChanged += new ProgressChangedEventHandler(Change);
        }

        private void Start(object sender, DoWorkEventArgs e)
        {
            t = new Timer();
            t.Start();

        }

        private void Stop(object sender, RunWorkerCompletedEventArgs e)
        {
            t.Stop();
        }

        private void Change(object sender, ProgressChangedEventArgs e)
        {
            
        }
    }
}

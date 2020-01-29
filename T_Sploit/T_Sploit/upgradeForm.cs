using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using System.Xml;

namespace T_Sploit
{
    public partial class upgradeForm : Form
    {
        WebClient wc = new WebClient();
        public upgradeForm()
        {
            InitializeComponent();

            XmlDocument doc = new XmlDocument();
            doc.Load("update.xml");
            XmlNode update = doc.DocumentElement.SelectSingleNode("/root/update");
            string setup_update = update.InnerText;

            Uri xmlUrl = new Uri(setup_update);
            wc.DownloadFileAsync(xmlUrl, "upgrade.exe");
            wc.DownloadProgressChanged += wc_DownloadFileProgress;
            wc.DownloadFileCompleted += new AsyncCompletedEventHandler(SetupDownloadCompleted);
        }
        private void wc_DownloadFileProgress(object sender, DownloadProgressChangedEventArgs e)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                double recive = double.Parse(e.BytesReceived.ToString());
                double total = double.Parse(e.TotalBytesToReceive.ToString());
                double percentage = recive / total * 100;
                progressLabel.Text = $"Dwonloaded {string.Format("{0:0.##}", percentage)}%";
                downlaodProgressBar.Value = int.Parse(Math.Truncate(percentage).ToString());
            }));


        }
        private void SetupDownloadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            Process.Start("upgrade.exe");
            Application.Exit();
        }
        private void upgradeForm_Load(object sender, EventArgs e)
        {

        }
    }
}

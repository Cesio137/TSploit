using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace T_Sploit
{
    public partial class checkupdateForm : Form
    {
        WebClient wc = new WebClient();
        WebClient wClient = new WebClient();
        public checkupdateForm()
        {
            InitializeComponent();

            Uri xmlUrl = new Uri("https://raw.githubusercontent.com/Cesio137/TSploit/manifest/manifest/update.config");
            wc.DownloadFileAsync(xmlUrl, "update.xml");
            wc.DownloadProgressChanged += wc_DownloadFileProgress;
            wc.DownloadFileCompleted += new AsyncCompletedEventHandler(FileDownloadCompleted);
        }

        private void wc_DownloadFileProgress(object sender, DownloadProgressChangedEventArgs e)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                double recive = double.Parse(e.BytesReceived.ToString());
                double total = double.Parse(e.TotalBytesToReceive.ToString());
                double percentage = recive / total * 100;
                CircleProgressbar.Value = int.Parse(Math.Truncate(percentage).ToString());
            }));


        }

        private void FileDownloadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            notification_label.Text = "Checking for update";
            CircleProgressbar.Value = 0;
            string version = System.Configuration.ConfigurationManager.AppSettings["version"];
            int baseVersion = Int32.Parse(version);

            XmlDocument doc = new XmlDocument();
            doc.Load("update.xml");
            XmlNode node = doc.DocumentElement.SelectSingleNode("/root/stable");
            string stable = node.InnerText;
            int stableVersion = Int32.Parse(stable);

            if (baseVersion == stableVersion)
            {
                MessageBox.Show("Exploit are up to date");
                notification_label.Text = "Downloading Metadata";
                this.Close();           
            }
            else if (baseVersion < stableVersion)
            {
                XmlNode update = doc.DocumentElement.SelectSingleNode("/root/update");
                string setup_update = update.InnerText;

                DialogResult dialogResult = MessageBox.Show("Would you like to download it?", "An update is available", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Uri xmlUrl = new Uri(setup_update);
                    wClient.DownloadFileAsync(xmlUrl, "upgrade.exe");
                    wClient.DownloadProgressChanged += wClient_DownloadFileProgress;
                    wClient.DownloadFileCompleted += new AsyncCompletedEventHandler(SetupDownloadCompleted);

                    notification_label.Text = "Downloading Update Setup";
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                    notification_label.Text = "Downloading Metadata";
                    this.Close();
                }
            }
            else if (baseVersion > stableVersion)
            {
                DialogResult dialogResult = MessageBox.Show("WHAAATT!");
                notification_label.Text = "Downloading Metadata";
                this.Close();
            }
        }

        private void wClient_DownloadFileProgress(object sender, DownloadProgressChangedEventArgs e)
        {
            Invoke(new MethodInvoker(delegate ()
            {
                double recive = double.Parse(e.BytesReceived.ToString());
                double total = double.Parse(e.TotalBytesToReceive.ToString());
                double percentage = recive / total * 100;
                CircleProgressbar.Value = int.Parse(Math.Truncate(percentage).ToString());
            }));


        }
        private void SetupDownloadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            Process.Start("upgrade.exe");
            Application.Exit();
        }
    }
}

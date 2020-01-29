using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net;
using System.Xml;

namespace T_Sploit
{
    public partial class aboutForm : UserControl
    {
        WebClient wc = new WebClient();
        public aboutForm()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            foreach (var process in Process.GetProcessesByName("RobloxPlayerBeta"))
            {
                process.Kill();
            }
            foreach (var process in Process.GetProcessesByName("RobloxPlayer"))
            {
                process.Kill();
            }
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            notification_label.Visible = true;
            progress_metadata.Visible = true;
            progress_label.Visible = true;
            notification_label.Text = "Downloading data";
            Uri xmlUrl = new Uri("https://raw.githubusercontent.com/nathanmiguel123/TSploit/manifest/manifest/update.config");
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
                progress_label.Text = $"Dwonloaded {string.Format("{0:0.##}", percentage)}%";
                progress_metadata.Value = int.Parse(Math.Truncate(percentage).ToString());
            }));

            
        }
        private void FileDownloadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            notification_label.Text = "Checking for update";
            progress_metadata.Visible = false;
            progress_metadata.Value = 0;
            progress_label.Visible = false;
            progress_label.Text = "";
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
                notification_label.Text = "";
                notification_label.Visible = false;
            }
            else if (baseVersion < stableVersion)
            {
                DialogResult dialogResult = MessageBox.Show("do you want to download the update?", "Update is avaliable", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    optForm optform = new optForm();
                    upgradeForm upgradeform = new upgradeForm();
                    optform.Close();
                    upgradeform.Show();
                    notification_label.Text = "";
                    notification_label.Visible = false;
                }
                else if (dialogResult == DialogResult.No)
                {
                    //nothing
                    notification_label.Text = "";
                    notification_label.Visible = false;
                }
            }
            else if (baseVersion > stableVersion)
            {
                DialogResult dialogResult = MessageBox.Show("WHAAATT!");
                notification_label.Text = "";
                notification_label.Visible = false;
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/nathanmiguel123/TSploit/releases");
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/kCpH9DH");
        }
    }
}

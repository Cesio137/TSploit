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
            Uri xmlUrl = new Uri("https://raw.githubusercontent.com/nathanmiguel123/TSploit/manifest/manifest/update.config");
            wc.DownloadFileAsync(xmlUrl, "update.xml");
            wc.DownloadFileCompleted += new AsyncCompletedEventHandler(FileDownloadCompleted);
        }
        private void FileDownloadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            string version = System.Configuration.ConfigurationManager.AppSettings["version"];
            int baseVersion = Int32.Parse(version);

            XmlDocument doc = new XmlDocument();
            doc.Load("update.xml");
            XmlNode node = doc.DocumentElement.SelectSingleNode("/root/stable");
            XmlNode update = doc.DocumentElement.SelectSingleNode("/root/update");
            string setup_update = update.InnerText;
            string stable = node.InnerText;
            int stableVersion = Int32.Parse(stable);
            
            if (baseVersion == stableVersion)
            {
                MessageBox.Show("Exploit are up to date");
            }
            else if (baseVersion < stableVersion)
            {
                DialogResult dialogResult = MessageBox.Show("do you want to download the update?", "Update is avaliable", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Uri xmlUrl = new Uri(setup_update);
                    wc.DownloadFileAsync(xmlUrl, "update.exe");
                    wc.DownloadFileCompleted += new AsyncCompletedEventHandler(SetupDownloadCompleted);
                }
                else if (dialogResult == DialogResult.No)
                {
                    //nothing
                }
            }
            else if (baseVersion > stableVersion)
            {
                DialogResult dialogResult = MessageBox.Show("WHAAATT!");
            }
        }
        private void SetupDownloadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            Process.Start("update.exe");
            Application.Exit();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/nathanmiguel123/TSploit/releases");
        }
    }
}

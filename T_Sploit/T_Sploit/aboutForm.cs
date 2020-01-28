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
            string version = System.Configuration.ConfigurationManager.AppSettings["version"];
            int v = Int32.Parse(version);

            Uri xmlUrl = new Uri("https://raw.githubusercontent.com/nathanmiguel123/TSploit/master/manifest/update.config");
            wc.DownloadFileAsync(xmlUrl, "update.xml");

            XmlDocument update_info = new XmlDocument();
            update_info.Load("update.xml");

            foreach (XmlNode ndoe in update_info.DocumentElement)
            {

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_Sploit
{
    public partial class optionsForm : Form
    {
        public optionsForm()
        {
            InitializeComponent();
        }

        private void close_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/nathanmiguel123/TSploit/releases");
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/kCpH9DH");
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            checkupdateForm cfuForm = new checkupdateForm();
            cfuForm.ShowDialog();
        }
    }
}

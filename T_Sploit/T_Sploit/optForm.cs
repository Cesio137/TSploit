using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace T_Sploit
{
    public partial class optForm : Form
    {
        public optForm()
        {
            InitializeComponent();
        }

        private void close_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void scripthub_Btn_Click(object sender, EventArgs e)
        {
            scripthub_form1.Visible = true;
            aboutForm1.Visible = false;
        }

        private void about_Btn_Click(object sender, EventArgs e)
        {
            scripthub_form1.Visible = false;
            aboutForm1.Visible = true;
        }
    }
}

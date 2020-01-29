using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreDevs_API;
using EasyExploits;
using System.IO;

namespace T_Sploit
{
    public partial class TS_Form : Form
    {
        EasyExploits.Module module = new EasyExploits.Module();//easyexploit API
        ExploitAPI WRDmodule = new ExploitAPI();//WRD API
        int api_selection;//for execute right api
        public TS_Form()
        {
            InitializeComponent();
            string subdir = Directory.GetCurrentDirectory() + @"\Scripts";
            string updatedir = Directory.GetCurrentDirectory() + @"\upgrade.exe";
            string updatexml = Directory.GetCurrentDirectory() + @"\T_Sploit.exe.config";
            // If directory does not exist, create it. 
            if (!Directory.Exists(subdir))
            {
                Directory.CreateDirectory(subdir);
            }
            else
            {
                //nothing
            }

            if (File.Exists(updatexml))
            {
                File.Delete(updatedir);
            }
            else
            {
                //nothing
            }

            if (File.Exists(updatedir))
            {
                File.Delete(updatexml);
            }
            else
            {
                //nothing
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listScript_Box.Items.Clear();//Clear Items in the LuaScriptList
            Function.PopulateListBox(listScript_Box, "./Scripts", "*.txt");
            Function.PopulateListBox(listScript_Box, "./Scripts", "*.lua"); 
            
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (api_selection == 0)
            {
                MessageBox.Show("Under development");
            }
            else if (api_selection == 1)
            {
                module.ExecuteScript(Script_Box.Text);
            }
            else if (api_selection == 2)
            {
                this.WRDmodule.SendLuaScript(Script_Box.Text);
            }
        }

        private void close_Btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize_Btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void inject_Btn_Click(object sender, EventArgs e)
        {
            int api_dev = api_DropDown.selectedIndex;
            if (api_dev == 0)
            {
                MessageBox.Show("Under development");
                api_selection = 0;
            }
            else if (api_dev == 1)
            {
                module.LaunchExploit();
                api_selection = 1;
            }
            else if (api_dev == 2)
            {
                this.WRDmodule.LaunchExploit();
                api_selection = 2;
            }
        }

        private void clear_Btn_Click(object sender, EventArgs e)
        {
            Script_Box.Text = "";
        }

        private void load_Btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog opendialogfile = new OpenFileDialog();
            opendialogfile.Filter = "Lua File (*.lua)|*.lua|Text File (*.txt)|*.txt";
            opendialogfile.FilterIndex = 2;
            opendialogfile.RestoreDirectory = true;
            if (opendialogfile.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                Script_Box.Text = "";
                System.IO.Stream stream;
                if ((stream = opendialogfile.OpenFile()) == null)
                    return;
                using (stream)
                    this.Script_Box.Text = System.IO.File.ReadAllText(opendialogfile.FileName);
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show("An unexpected error has occured", "OOF!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void listScript_Box_SelectedIndexChanged(object sender, EventArgs e)=> Script_Box.Text = File.ReadAllText($"./Scripts/{listScript_Box.SelectedItem}");

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            listScript_Box.Items.Clear();//Clear Items in the LuaScriptList
            Function.PopulateListBox(listScript_Box, "./Scripts", "*.txt");
            Function.PopulateListBox(listScript_Box, "./Scripts", "*.lua");
        }

        private void api_DropDown_onItemSelected(object sender, EventArgs e)
        {
            int api_dev = api_DropDown.selectedIndex;
            if (api_dev == 0)
            {
                api_selection = 0;
            }
            else if (api_dev == 1)
            {
                api_selection = 1;
            }
            else if (api_dev == 2)
            {
                api_selection = 2;
            }
        }

        private void opt_Btn_Click(object sender, EventArgs e)
        {
            optionsForm opt1 = new optionsForm();
            opt1.ShowDialog();
        }

        private void imgui_Btn_Click(object sender, EventArgs e)
        {
            if (api_selection == 2)
            {
                this.WRDmodule.SendLuaCScript(Script_Box.Text);
            }
            else
            {
                MessageBox.Show("Select WRD API");
            }
        }
    }
}

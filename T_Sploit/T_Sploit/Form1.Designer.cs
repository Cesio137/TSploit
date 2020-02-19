namespace T_Sploit
{
    partial class TS_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TS_Form));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Script_Box = new FastColoredTextBoxNS.FastColoredTextBox();
            this.exe_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.clear_Btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.load_Btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.listScript_Box = new System.Windows.Forms.ListBox();
            this.inject_Btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.top_Bar = new System.Windows.Forms.Panel();
            this.refresh_btn = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureSuper_Box = new System.Windows.Forms.PictureBox();
            this.Head = new System.Windows.Forms.Label();
            this.opt_Btn = new Bunifu.Framework.UI.BunifuImageButton();
            this.minimize_Btn = new Bunifu.Framework.UI.BunifuImageButton();
            this.close_Btn = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.api_DropDown = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.imgui_Btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Script_Box)).BeginInit();
            this.top_Bar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refresh_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSuper_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opt_Btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_Btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_Btn)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(93, 26);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // Script_Box
            // 
            this.Script_Box.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Script_Box.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.Script_Box.AutoIndentCharsPatterns = "\r\n^\\s*[\\w\\.]+(\\s\\w+)?\\s*(?<range>=)\\s*(?<range>.+)\r\n";
            this.Script_Box.AutoScrollMinSize = new System.Drawing.Size(795, 70);
            this.Script_Box.BackBrush = null;
            this.Script_Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Script_Box.BracketsHighlightStrategy = FastColoredTextBoxNS.BracketsHighlightStrategy.Strategy2;
            this.Script_Box.CharHeight = 14;
            this.Script_Box.CharWidth = 8;
            this.Script_Box.CommentPrefix = "--";
            this.Script_Box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Script_Box.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.Script_Box.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Script_Box.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Script_Box.IsReplaceMode = false;
            this.Script_Box.Language = FastColoredTextBoxNS.Language.Lua;
            this.Script_Box.LeftBracket = '(';
            this.Script_Box.LeftBracket2 = '{';
            this.Script_Box.LineNumberColor = System.Drawing.Color.SpringGreen;
            this.Script_Box.Location = new System.Drawing.Point(0, 38);
            this.Script_Box.Name = "Script_Box";
            this.Script_Box.Paddings = new System.Windows.Forms.Padding(0);
            this.Script_Box.RightBracket = ')';
            this.Script_Box.RightBracket2 = '}';
            this.Script_Box.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(128)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.Script_Box.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("Script_Box.ServiceColors")));
            this.Script_Box.ServiceLinesColor = System.Drawing.Color.Transparent;
            this.Script_Box.Size = new System.Drawing.Size(599, 338);
            this.Script_Box.TabIndex = 4;
            this.Script_Box.Text = "--[[\r\n    The Super Exploit v1.2.2\r\n    Source Code: github.com/nathanmiguel123\r\n" +
    "    Youtube channel: https://www.youtube.com/channel/UCiiLg8_6VShZSTY669CRGgQ?vi" +
    "ew_as=subscriber\r\n]]";
            this.Script_Box.Zoom = 100;
            // 
            // exe_btn
            // 
            this.exe_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.exe_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.exe_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.exe_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exe_btn.BorderRadius = 0;
            this.exe_btn.ButtonText = "Execute";
            this.exe_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exe_btn.DisabledColor = System.Drawing.Color.Gray;
            this.exe_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.exe_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("exe_btn.Iconimage")));
            this.exe_btn.Iconimage_right = null;
            this.exe_btn.Iconimage_right_Selected = null;
            this.exe_btn.Iconimage_Selected = null;
            this.exe_btn.IconMarginLeft = 0;
            this.exe_btn.IconMarginRight = 0;
            this.exe_btn.IconRightVisible = false;
            this.exe_btn.IconRightZoom = 0D;
            this.exe_btn.IconVisible = false;
            this.exe_btn.IconZoom = 90D;
            this.exe_btn.IsTab = false;
            this.exe_btn.Location = new System.Drawing.Point(12, 394);
            this.exe_btn.Name = "exe_btn";
            this.exe_btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.exe_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.exe_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.exe_btn.selected = false;
            this.exe_btn.Size = new System.Drawing.Size(102, 35);
            this.exe_btn.TabIndex = 5;
            this.exe_btn.Text = "Execute";
            this.exe_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exe_btn.Textcolor = System.Drawing.Color.White;
            this.exe_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exe_btn.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // clear_Btn
            // 
            this.clear_Btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.clear_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clear_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.clear_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.clear_Btn.BorderRadius = 0;
            this.clear_Btn.ButtonText = "Clear";
            this.clear_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear_Btn.DisabledColor = System.Drawing.Color.Gray;
            this.clear_Btn.Iconcolor = System.Drawing.Color.Transparent;
            this.clear_Btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("clear_Btn.Iconimage")));
            this.clear_Btn.Iconimage_right = null;
            this.clear_Btn.Iconimage_right_Selected = null;
            this.clear_Btn.Iconimage_Selected = null;
            this.clear_Btn.IconMarginLeft = 0;
            this.clear_Btn.IconMarginRight = 0;
            this.clear_Btn.IconRightVisible = false;
            this.clear_Btn.IconRightZoom = 0D;
            this.clear_Btn.IconVisible = false;
            this.clear_Btn.IconZoom = 90D;
            this.clear_Btn.IsTab = false;
            this.clear_Btn.Location = new System.Drawing.Point(228, 394);
            this.clear_Btn.Name = "clear_Btn";
            this.clear_Btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.clear_Btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.clear_Btn.OnHoverTextColor = System.Drawing.Color.White;
            this.clear_Btn.selected = false;
            this.clear_Btn.Size = new System.Drawing.Size(102, 35);
            this.clear_Btn.TabIndex = 6;
            this.clear_Btn.Text = "Clear";
            this.clear_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.clear_Btn.Textcolor = System.Drawing.Color.White;
            this.clear_Btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_Btn.Click += new System.EventHandler(this.clear_Btn_Click);
            // 
            // load_Btn
            // 
            this.load_Btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.load_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.load_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.load_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.load_Btn.BorderRadius = 0;
            this.load_Btn.ButtonText = "Load File";
            this.load_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.load_Btn.DisabledColor = System.Drawing.Color.Gray;
            this.load_Btn.Iconcolor = System.Drawing.Color.Transparent;
            this.load_Btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("load_Btn.Iconimage")));
            this.load_Btn.Iconimage_right = null;
            this.load_Btn.Iconimage_right_Selected = null;
            this.load_Btn.Iconimage_Selected = null;
            this.load_Btn.IconMarginLeft = 0;
            this.load_Btn.IconMarginRight = 0;
            this.load_Btn.IconRightVisible = false;
            this.load_Btn.IconRightZoom = 0D;
            this.load_Btn.IconVisible = false;
            this.load_Btn.IconZoom = 90D;
            this.load_Btn.IsTab = false;
            this.load_Btn.Location = new System.Drawing.Point(336, 394);
            this.load_Btn.Name = "load_Btn";
            this.load_Btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.load_Btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.load_Btn.OnHoverTextColor = System.Drawing.Color.White;
            this.load_Btn.selected = false;
            this.load_Btn.Size = new System.Drawing.Size(102, 35);
            this.load_Btn.TabIndex = 7;
            this.load_Btn.Text = "Load File";
            this.load_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.load_Btn.Textcolor = System.Drawing.Color.White;
            this.load_Btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load_Btn.Click += new System.EventHandler(this.load_Btn_Click);
            // 
            // listScript_Box
            // 
            this.listScript_Box.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listScript_Box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.listScript_Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listScript_Box.ForeColor = System.Drawing.SystemColors.Menu;
            this.listScript_Box.FormattingEnabled = true;
            this.listScript_Box.Location = new System.Drawing.Point(607, 38);
            this.listScript_Box.Name = "listScript_Box";
            this.listScript_Box.Size = new System.Drawing.Size(176, 338);
            this.listScript_Box.TabIndex = 8;
            this.listScript_Box.SelectedIndexChanged += new System.EventHandler(this.listScript_Box_SelectedIndexChanged);
            // 
            // inject_Btn
            // 
            this.inject_Btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.inject_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.inject_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.inject_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.inject_Btn.BorderRadius = 0;
            this.inject_Btn.ButtonText = "        Inject";
            this.inject_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inject_Btn.DisabledColor = System.Drawing.Color.Gray;
            this.inject_Btn.Font = new System.Drawing.Font("MS Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inject_Btn.Iconcolor = System.Drawing.Color.Transparent;
            this.inject_Btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("inject_Btn.Iconimage")));
            this.inject_Btn.Iconimage_right = null;
            this.inject_Btn.Iconimage_right_Selected = null;
            this.inject_Btn.Iconimage_Selected = null;
            this.inject_Btn.IconMarginLeft = 0;
            this.inject_Btn.IconMarginRight = 0;
            this.inject_Btn.IconRightVisible = true;
            this.inject_Btn.IconRightZoom = 0D;
            this.inject_Btn.IconVisible = true;
            this.inject_Btn.IconZoom = 50D;
            this.inject_Btn.IsTab = false;
            this.inject_Btn.Location = new System.Drawing.Point(633, 394);
            this.inject_Btn.Name = "inject_Btn";
            this.inject_Btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.inject_Btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.inject_Btn.OnHoverTextColor = System.Drawing.Color.White;
            this.inject_Btn.selected = false;
            this.inject_Btn.Size = new System.Drawing.Size(124, 35);
            this.inject_Btn.TabIndex = 9;
            this.inject_Btn.Text = "        Inject";
            this.inject_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.inject_Btn.Textcolor = System.Drawing.Color.White;
            this.inject_Btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inject_Btn.Click += new System.EventHandler(this.inject_Btn_Click);
            // 
            // top_Bar
            // 
            this.top_Bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.top_Bar.Controls.Add(this.refresh_btn);
            this.top_Bar.Controls.Add(this.pictureSuper_Box);
            this.top_Bar.Controls.Add(this.Head);
            this.top_Bar.Controls.Add(this.opt_Btn);
            this.top_Bar.Controls.Add(this.minimize_Btn);
            this.top_Bar.Controls.Add(this.close_Btn);
            this.top_Bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_Bar.Location = new System.Drawing.Point(0, 0);
            this.top_Bar.Name = "top_Bar";
            this.top_Bar.Size = new System.Drawing.Size(784, 32);
            this.top_Bar.TabIndex = 10;
            // 
            // refresh_btn
            // 
            this.refresh_btn.BackColor = System.Drawing.Color.Transparent;
            this.refresh_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.refresh_btn.Image = ((System.Drawing.Image)(resources.GetObject("refresh_btn.Image")));
            this.refresh_btn.ImageActive = null;
            this.refresh_btn.Location = new System.Drawing.Point(637, 4);
            this.refresh_btn.Name = "refresh_btn";
            this.refresh_btn.Size = new System.Drawing.Size(24, 24);
            this.refresh_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.refresh_btn.TabIndex = 15;
            this.refresh_btn.TabStop = false;
            this.refresh_btn.Zoom = 10;
            this.refresh_btn.Click += new System.EventHandler(this.refresh_btn_Click);
            // 
            // pictureSuper_Box
            // 
            this.pictureSuper_Box.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureSuper_Box.Image = ((System.Drawing.Image)(resources.GetObject("pictureSuper_Box.Image")));
            this.pictureSuper_Box.InitialImage = null;
            this.pictureSuper_Box.Location = new System.Drawing.Point(0, 0);
            this.pictureSuper_Box.Name = "pictureSuper_Box";
            this.pictureSuper_Box.Size = new System.Drawing.Size(32, 32);
            this.pictureSuper_Box.TabIndex = 14;
            this.pictureSuper_Box.TabStop = false;
            // 
            // Head
            // 
            this.Head.AutoSize = true;
            this.Head.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Head.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Head.Location = new System.Drawing.Point(317, 6);
            this.Head.Name = "Head";
            this.Head.Size = new System.Drawing.Size(151, 20);
            this.Head.TabIndex = 3;
            this.Head.Text = "The Super Exploit";
            // 
            // opt_Btn
            // 
            this.opt_Btn.BackColor = System.Drawing.Color.Transparent;
            this.opt_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.opt_Btn.Image = ((System.Drawing.Image)(resources.GetObject("opt_Btn.Image")));
            this.opt_Btn.ImageActive = null;
            this.opt_Btn.Location = new System.Drawing.Point(607, 4);
            this.opt_Btn.Name = "opt_Btn";
            this.opt_Btn.Size = new System.Drawing.Size(24, 24);
            this.opt_Btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.opt_Btn.TabIndex = 2;
            this.opt_Btn.TabStop = false;
            this.opt_Btn.Zoom = 10;
            this.opt_Btn.Click += new System.EventHandler(this.opt_Btn_Click);
            // 
            // minimize_Btn
            // 
            this.minimize_Btn.BackColor = System.Drawing.Color.Transparent;
            this.minimize_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize_Btn.Image = ((System.Drawing.Image)(resources.GetObject("minimize_Btn.Image")));
            this.minimize_Btn.ImageActive = null;
            this.minimize_Btn.Location = new System.Drawing.Point(727, 4);
            this.minimize_Btn.Name = "minimize_Btn";
            this.minimize_Btn.Size = new System.Drawing.Size(24, 24);
            this.minimize_Btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimize_Btn.TabIndex = 1;
            this.minimize_Btn.TabStop = false;
            this.minimize_Btn.Zoom = 10;
            this.minimize_Btn.Click += new System.EventHandler(this.minimize_Btn_Click);
            // 
            // close_Btn
            // 
            this.close_Btn.BackColor = System.Drawing.Color.Transparent;
            this.close_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_Btn.Image = ((System.Drawing.Image)(resources.GetObject("close_Btn.Image")));
            this.close_Btn.ImageActive = null;
            this.close_Btn.Location = new System.Drawing.Point(757, 4);
            this.close_Btn.Name = "close_Btn";
            this.close_Btn.Size = new System.Drawing.Size(24, 24);
            this.close_Btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close_Btn.TabIndex = 0;
            this.close_Btn.TabStop = false;
            this.close_Btn.Zoom = 10;
            this.close_Btn.Click += new System.EventHandler(this.close_Btn_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.top_Bar;
            this.bunifuDragControl1.Vertical = true;
            // 
            // api_DropDown
            // 
            this.api_DropDown.BackColor = System.Drawing.Color.Transparent;
            this.api_DropDown.BorderRadius = 45;
            this.api_DropDown.DisabledColor = System.Drawing.Color.Gray;
            this.api_DropDown.ForeColor = System.Drawing.Color.White;
            this.api_DropDown.Items = new string[] {
        "The Super API",
        "Easy Exploit API",
        "WeAreDevs API",
        "ClubDark API"};
            this.api_DropDown.Location = new System.Drawing.Point(444, 394);
            this.api_DropDown.Name = "api_DropDown";
            this.api_DropDown.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.api_DropDown.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.api_DropDown.selectedIndex = -1;
            this.api_DropDown.Size = new System.Drawing.Size(155, 35);
            this.api_DropDown.TabIndex = 12;
            this.api_DropDown.onItemSelected += new System.EventHandler(this.api_DropDown_onItemSelected);
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.Head;
            this.bunifuDragControl2.Vertical = true;
            // 
            // imgui_Btn
            // 
            this.imgui_Btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.imgui_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.imgui_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.imgui_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imgui_Btn.BorderRadius = 0;
            this.imgui_Btn.ButtonText = "Lua C";
            this.imgui_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgui_Btn.DisabledColor = System.Drawing.Color.Gray;
            this.imgui_Btn.Iconcolor = System.Drawing.Color.Transparent;
            this.imgui_Btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("imgui_Btn.Iconimage")));
            this.imgui_Btn.Iconimage_right = null;
            this.imgui_Btn.Iconimage_right_Selected = null;
            this.imgui_Btn.Iconimage_Selected = null;
            this.imgui_Btn.IconMarginLeft = 0;
            this.imgui_Btn.IconMarginRight = 0;
            this.imgui_Btn.IconRightVisible = false;
            this.imgui_Btn.IconRightZoom = 0D;
            this.imgui_Btn.IconVisible = false;
            this.imgui_Btn.IconZoom = 90D;
            this.imgui_Btn.IsTab = false;
            this.imgui_Btn.Location = new System.Drawing.Point(120, 394);
            this.imgui_Btn.Name = "imgui_Btn";
            this.imgui_Btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.imgui_Btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.imgui_Btn.OnHoverTextColor = System.Drawing.Color.White;
            this.imgui_Btn.selected = false;
            this.imgui_Btn.Size = new System.Drawing.Size(102, 35);
            this.imgui_Btn.TabIndex = 13;
            this.imgui_Btn.Text = "Lua C";
            this.imgui_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.imgui_Btn.Textcolor = System.Drawing.Color.White;
            this.imgui_Btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imgui_Btn.Click += new System.EventHandler(this.imgui_Btn_Click);
            // 
            // TS_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.imgui_Btn);
            this.Controls.Add(this.api_DropDown);
            this.Controls.Add(this.top_Bar);
            this.Controls.Add(this.inject_Btn);
            this.Controls.Add(this.listScript_Box);
            this.Controls.Add(this.load_Btn);
            this.Controls.Add(this.clear_Btn);
            this.Controls.Add(this.exe_btn);
            this.Controls.Add(this.Script_Box);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TS_Form";
            this.Text = "TSploit";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Script_Box)).EndInit();
            this.top_Bar.ResumeLayout(false);
            this.top_Bar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.refresh_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSuper_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opt_Btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimize_Btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close_Btn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private FastColoredTextBoxNS.FastColoredTextBox Script_Box;
        private Bunifu.Framework.UI.BunifuFlatButton exe_btn;
        private Bunifu.Framework.UI.BunifuFlatButton clear_Btn;
        private Bunifu.Framework.UI.BunifuFlatButton load_Btn;
        private System.Windows.Forms.ListBox listScript_Box;
        private Bunifu.Framework.UI.BunifuFlatButton inject_Btn;
        private System.Windows.Forms.Panel top_Bar;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton close_Btn;
        private Bunifu.Framework.UI.BunifuImageButton minimize_Btn;
        private Bunifu.Framework.UI.BunifuImageButton opt_Btn;
        private System.Windows.Forms.Label Head;
        private Bunifu.Framework.UI.BunifuDropdown api_DropDown;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuFlatButton imgui_Btn;
        private System.Windows.Forms.PictureBox pictureSuper_Box;
        private Bunifu.Framework.UI.BunifuImageButton refresh_btn;
    }
}


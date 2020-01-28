namespace T_Sploit
{
    partial class optForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(optForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelOpt = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.scripthub_Btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.about_Btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.close_Btn = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.aboutForm1 = new T_Sploit.aboutForm();
            this.scripthub_form1 = new T_Sploit.scripthub_form();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_Btn)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.panel1.Controls.Add(this.close_Btn);
            this.panel1.Controls.Add(this.labelOpt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(537, 32);
            this.panel1.TabIndex = 0;
            // 
            // labelOpt
            // 
            this.labelOpt.AutoSize = true;
            this.labelOpt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOpt.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelOpt.Location = new System.Drawing.Point(238, 8);
            this.labelOpt.Name = "labelOpt";
            this.labelOpt.Size = new System.Drawing.Size(61, 16);
            this.labelOpt.TabIndex = 0;
            this.labelOpt.Text = "Options";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.panel2.Controls.Add(this.about_Btn);
            this.panel2.Controls.Add(this.scripthub_Btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(114, 332);
            this.panel2.TabIndex = 1;
            // 
            // scripthub_Btn
            // 
            this.scripthub_Btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.scripthub_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.scripthub_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.scripthub_Btn.BorderRadius = 0;
            this.scripthub_Btn.ButtonText = "Scriptbox";
            this.scripthub_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.scripthub_Btn.DisabledColor = System.Drawing.Color.Gray;
            this.scripthub_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scripthub_Btn.Iconcolor = System.Drawing.Color.Transparent;
            this.scripthub_Btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("scripthub_Btn.Iconimage")));
            this.scripthub_Btn.Iconimage_right = null;
            this.scripthub_Btn.Iconimage_right_Selected = null;
            this.scripthub_Btn.Iconimage_Selected = null;
            this.scripthub_Btn.IconMarginLeft = 0;
            this.scripthub_Btn.IconMarginRight = 0;
            this.scripthub_Btn.IconRightVisible = true;
            this.scripthub_Btn.IconRightZoom = 0D;
            this.scripthub_Btn.IconVisible = false;
            this.scripthub_Btn.IconZoom = 90D;
            this.scripthub_Btn.IsTab = false;
            this.scripthub_Btn.Location = new System.Drawing.Point(0, 6);
            this.scripthub_Btn.Name = "scripthub_Btn";
            this.scripthub_Btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.scripthub_Btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.scripthub_Btn.OnHoverTextColor = System.Drawing.Color.White;
            this.scripthub_Btn.selected = false;
            this.scripthub_Btn.Size = new System.Drawing.Size(114, 35);
            this.scripthub_Btn.TabIndex = 2;
            this.scripthub_Btn.Text = "Scriptbox";
            this.scripthub_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.scripthub_Btn.Textcolor = System.Drawing.Color.White;
            this.scripthub_Btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scripthub_Btn.Click += new System.EventHandler(this.scripthub_Btn_Click);
            // 
            // about_Btn
            // 
            this.about_Btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.about_Btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.about_Btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.about_Btn.BorderRadius = 0;
            this.about_Btn.ButtonText = "About";
            this.about_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.about_Btn.DisabledColor = System.Drawing.Color.Gray;
            this.about_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.about_Btn.Iconcolor = System.Drawing.Color.Transparent;
            this.about_Btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("about_Btn.Iconimage")));
            this.about_Btn.Iconimage_right = null;
            this.about_Btn.Iconimage_right_Selected = null;
            this.about_Btn.Iconimage_Selected = null;
            this.about_Btn.IconMarginLeft = 0;
            this.about_Btn.IconMarginRight = 0;
            this.about_Btn.IconRightVisible = true;
            this.about_Btn.IconRightZoom = 0D;
            this.about_Btn.IconVisible = false;
            this.about_Btn.IconZoom = 90D;
            this.about_Btn.IsTab = false;
            this.about_Btn.Location = new System.Drawing.Point(0, 47);
            this.about_Btn.Name = "about_Btn";
            this.about_Btn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.about_Btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.about_Btn.OnHoverTextColor = System.Drawing.Color.White;
            this.about_Btn.selected = false;
            this.about_Btn.Size = new System.Drawing.Size(114, 35);
            this.about_Btn.TabIndex = 3;
            this.about_Btn.Text = "About";
            this.about_Btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.about_Btn.Textcolor = System.Drawing.Color.White;
            this.about_Btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.about_Btn.Click += new System.EventHandler(this.about_Btn_Click);
            // 
            // close_Btn
            // 
            this.close_Btn.BackColor = System.Drawing.Color.Transparent;
            this.close_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close_Btn.Image = ((System.Drawing.Image)(resources.GetObject("close_Btn.Image")));
            this.close_Btn.ImageActive = null;
            this.close_Btn.Location = new System.Drawing.Point(510, 3);
            this.close_Btn.Name = "close_Btn";
            this.close_Btn.Size = new System.Drawing.Size(24, 24);
            this.close_Btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close_Btn.TabIndex = 4;
            this.close_Btn.TabStop = false;
            this.close_Btn.Zoom = 10;
            this.close_Btn.Click += new System.EventHandler(this.close_Btn_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.labelOpt;
            this.bunifuDragControl2.Vertical = true;
            // 
            // aboutForm1
            // 
            this.aboutForm1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.aboutForm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aboutForm1.Location = new System.Drawing.Point(114, 32);
            this.aboutForm1.Name = "aboutForm1";
            this.aboutForm1.Size = new System.Drawing.Size(423, 332);
            this.aboutForm1.TabIndex = 3;
            this.aboutForm1.Visible = false;
            // 
            // scripthub_form1
            // 
            this.scripthub_form1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.scripthub_form1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scripthub_form1.Location = new System.Drawing.Point(114, 32);
            this.scripthub_form1.Name = "scripthub_form1";
            this.scripthub_form1.Size = new System.Drawing.Size(423, 332);
            this.scripthub_form1.TabIndex = 2;
            // 
            // optForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(537, 364);
            this.Controls.Add(this.aboutForm1);
            this.Controls.Add(this.scripthub_form1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "optForm";
            this.Text = "optForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.close_Btn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelOpt;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton scripthub_Btn;
        private Bunifu.Framework.UI.BunifuFlatButton about_Btn;
        private Bunifu.Framework.UI.BunifuImageButton close_Btn;
        private scripthub_form scripthub_form1;
        private aboutForm aboutForm1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
    }
}
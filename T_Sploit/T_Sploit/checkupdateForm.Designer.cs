namespace T_Sploit
{
    partial class checkupdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(checkupdateForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CircleProgressbar = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.notification_label = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 32);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(144, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Checking";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CircleProgressbar
            // 
            this.CircleProgressbar.animated = false;
            this.CircleProgressbar.animationIterval = 5;
            this.CircleProgressbar.animationSpeed = 10;
            this.CircleProgressbar.BackColor = System.Drawing.Color.Transparent;
            this.CircleProgressbar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CircleProgressbar.BackgroundImage")));
            this.CircleProgressbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.CircleProgressbar.ForeColor = System.Drawing.Color.Honeydew;
            this.CircleProgressbar.LabelVisible = true;
            this.CircleProgressbar.LineProgressThickness = 8;
            this.CircleProgressbar.LineThickness = 5;
            this.CircleProgressbar.Location = new System.Drawing.Point(111, 78);
            this.CircleProgressbar.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.CircleProgressbar.MaxValue = 100;
            this.CircleProgressbar.Name = "CircleProgressbar";
            this.CircleProgressbar.ProgressBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.CircleProgressbar.ProgressColor = System.Drawing.Color.Lime;
            this.CircleProgressbar.Size = new System.Drawing.Size(130, 130);
            this.CircleProgressbar.TabIndex = 1;
            this.CircleProgressbar.Value = 0;
            // 
            // notification_label
            // 
            this.notification_label.AutoSize = true;
            this.notification_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notification_label.ForeColor = System.Drawing.SystemColors.Control;
            this.notification_label.Location = new System.Drawing.Point(97, 45);
            this.notification_label.Name = "notification_label";
            this.notification_label.Size = new System.Drawing.Size(167, 16);
            this.notification_label.TabIndex = 1;
            this.notification_label.Text = "Downloading Metadata";
            this.notification_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.bunifuDragControl2.TargetControl = this.label1;
            this.bunifuDragControl2.Vertical = true;
            // 
            // checkupdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(360, 216);
            this.Controls.Add(this.notification_label);
            this.Controls.Add(this.CircleProgressbar);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "checkupdateForm";
            this.Text = "checkupdateForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCircleProgressbar CircleProgressbar;
        private System.Windows.Forms.Label notification_label;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
    }
}

namespace Sliding_Application
{
    partial class SettingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuBarChart1 = new Bunifu.Charts.WinForms.ChartTypes.BunifuBarChart(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.theme_gb = new System.Windows.Forms.GroupBox();
            this.lightTeme_rb = new System.Windows.Forms.RadioButton();
            this.darkTheme_rb = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.m_w_rd = new System.Windows.Forms.RadioButton();
            this.c_w_rd = new System.Windows.Forms.RadioButton();
            this.b_w_rd = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.theme_gb.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuBarChart1
            // 
            this.bunifuBarChart1.BackgroundColor = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("bunifuBarChart1.BackgroundColor")));
            this.bunifuBarChart1.BorderColor = ((System.Collections.Generic.List<System.Drawing.Color>)(resources.GetObject("bunifuBarChart1.BorderColor")));
            this.bunifuBarChart1.BorderSkipped = null;
            this.bunifuBarChart1.BorderWidth = 0;
            this.bunifuBarChart1.Data = ((System.Collections.Generic.List<double>)(resources.GetObject("bunifuBarChart1.Data")));
            this.bunifuBarChart1.HoverBackgroundColor = System.Drawing.Color.Empty;
            this.bunifuBarChart1.HoverBorderColor = System.Drawing.Color.Empty;
            this.bunifuBarChart1.HoverBorderWidth = 0;
            this.bunifuBarChart1.Label = "Label here";
            this.bunifuBarChart1.TargetCanvas = null;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.theme_gb);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 628);
            this.panel1.TabIndex = 0;
            // 
            // theme_gb
            // 
            this.theme_gb.Controls.Add(this.lightTeme_rb);
            this.theme_gb.Controls.Add(this.darkTheme_rb);
            this.theme_gb.Location = new System.Drawing.Point(12, 23);
            this.theme_gb.Name = "theme_gb";
            this.theme_gb.Size = new System.Drawing.Size(259, 62);
            this.theme_gb.TabIndex = 2;
            this.theme_gb.TabStop = false;
            this.theme_gb.Text = "Theme:";
            this.theme_gb.Enter += new System.EventHandler(this.theme_gb_Enter);
            // 
            // lightTeme_rb
            // 
            this.lightTeme_rb.AutoSize = true;
            this.lightTeme_rb.Checked = true;
            this.lightTeme_rb.Location = new System.Drawing.Point(189, 21);
            this.lightTeme_rb.Name = "lightTeme_rb";
            this.lightTeme_rb.Size = new System.Drawing.Size(60, 21);
            this.lightTeme_rb.TabIndex = 1;
            this.lightTeme_rb.TabStop = true;
            this.lightTeme_rb.Text = "Light";
            this.lightTeme_rb.UseVisualStyleBackColor = true;
            this.lightTeme_rb.CheckedChanged += new System.EventHandler(this.lightTeme_rb_CheckedChanged);
            // 
            // darkTheme_rb
            // 
            this.darkTheme_rb.AutoSize = true;
            this.darkTheme_rb.Location = new System.Drawing.Point(3, 18);
            this.darkTheme_rb.Name = "darkTheme_rb";
            this.darkTheme_rb.Size = new System.Drawing.Size(59, 21);
            this.darkTheme_rb.TabIndex = 0;
            this.darkTheme_rb.Text = "Dark";
            this.darkTheme_rb.UseVisualStyleBackColor = true;
            this.darkTheme_rb.CheckedChanged += new System.EventHandler(this.darkTheme_rb_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.m_w_rd);
            this.groupBox2.Controls.Add(this.c_w_rd);
            this.groupBox2.Controls.Add(this.b_w_rd);
            this.groupBox2.Location = new System.Drawing.Point(398, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(590, 62);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Message Colore: ";
            // 
            // m_w_rd
            // 
            this.m_w_rd.AutoSize = true;
            this.m_w_rd.Location = new System.Drawing.Point(460, 21);
            this.m_w_rd.Name = "m_w_rd";
            this.m_w_rd.Size = new System.Drawing.Size(124, 21);
            this.m_w_rd.TabIndex = 2;
            this.m_w_rd.TabStop = true;
            this.m_w_rd.Text = "Magenta/White";
            this.m_w_rd.UseVisualStyleBackColor = true;
            this.m_w_rd.CheckedChanged += new System.EventHandler(this.m_w_rd_CheckedChanged);
            // 
            // c_w_rd
            // 
            this.c_w_rd.AutoSize = true;
            this.c_w_rd.Location = new System.Drawing.Point(212, 21);
            this.c_w_rd.Name = "c_w_rd";
            this.c_w_rd.Size = new System.Drawing.Size(131, 21);
            this.c_w_rd.TabIndex = 1;
            this.c_w_rd.TabStop = true;
            this.c_w_rd.Text = "DarkCyan/White";
            this.c_w_rd.UseVisualStyleBackColor = true;
            this.c_w_rd.CheckedChanged += new System.EventHandler(this.c_w_rd_CheckedChanged_1);
            // 
            // b_w_rd
            // 
            this.b_w_rd.AutoSize = true;
            this.b_w_rd.Checked = true;
            this.b_w_rd.Location = new System.Drawing.Point(6, 21);
            this.b_w_rd.Name = "b_w_rd";
            this.b_w_rd.Size = new System.Drawing.Size(97, 21);
            this.b_w_rd.TabIndex = 0;
            this.b_w_rd.TabStop = true;
            this.b_w_rd.Text = "Blue/White";
            this.b_w_rd.UseVisualStyleBackColor = true;
            this.b_w_rd.CheckedChanged += new System.EventHandler(this.b_w_rd_CheckedChanged_1);
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 628);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingForm";
            this.Text = "SettingForm";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.SettingForm_ControlAdded);
            this.panel1.ResumeLayout(false);
            this.theme_gb.ResumeLayout(false);
            this.theme_gb.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Charts.WinForms.ChartTypes.BunifuBarChart bunifuBarChart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox theme_gb;
        private System.Windows.Forms.RadioButton lightTeme_rb;
        private System.Windows.Forms.RadioButton darkTheme_rb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton m_w_rd;
        private System.Windows.Forms.RadioButton c_w_rd;
        private System.Windows.Forms.RadioButton b_w_rd;
    }
}
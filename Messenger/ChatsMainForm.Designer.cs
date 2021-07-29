
namespace Sliding_Application
{
    partial class ChatsMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatsMainForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.accountsName_pnl = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.write_msg = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.msg_txt = new System.Windows.Forms.RichTextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.send_btn = new System.Windows.Forms.PictureBox();
            this.statepanel = new System.Windows.Forms.Panel();
            this.userName_lbl = new System.Windows.Forms.Label();
            this.name_lbl = new System.Windows.Forms.Label();
            this.message_gb = new System.Windows.Forms.Panel();
            this.addContact = new System.Windows.Forms.Label();
            this.accountsName_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.write_msg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.send_btn)).BeginInit();
            this.statepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 30;
            this.bunifuElipse2.TargetControl = this;
            // 
            // accountsName_pnl
            // 
            this.accountsName_pnl.AutoScroll = true;
            this.accountsName_pnl.BackColor = System.Drawing.Color.Transparent;
            this.accountsName_pnl.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.accountsName_pnl.BorderRadius = 1;
            this.accountsName_pnl.BorderThickness = 1;
            this.accountsName_pnl.Controls.Add(this.pictureBox3);
            this.accountsName_pnl.Dock = System.Windows.Forms.DockStyle.Left;
            this.accountsName_pnl.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Gradient;
            this.accountsName_pnl.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.accountsName_pnl.Location = new System.Drawing.Point(0, 0);
            this.accountsName_pnl.Name = "accountsName_pnl";
            this.accountsName_pnl.PanelColor = System.Drawing.Color.WhiteSmoke;
            this.accountsName_pnl.PanelColor2 = System.Drawing.Color.WhiteSmoke;
            this.accountsName_pnl.ShadowColor = System.Drawing.Color.DarkGray;
            this.accountsName_pnl.ShadowDept = 2;
            this.accountsName_pnl.ShadowDepth = 5;
            this.accountsName_pnl.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.accountsName_pnl.ShadowTopLeftVisible = false;
            this.accountsName_pnl.Size = new System.Drawing.Size(354, 575);
            this.accountsName_pnl.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.accountsName_pnl.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 513);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(354, 62);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // write_msg
            // 
            this.write_msg.BackColor = System.Drawing.Color.Transparent;
            this.write_msg.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.write_msg.BorderRadius = 1;
            this.write_msg.BorderThickness = 1;
            this.write_msg.Controls.Add(this.msg_txt);
            this.write_msg.Controls.Add(this.pictureBox2);
            this.write_msg.Controls.Add(this.send_btn);
            this.write_msg.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.write_msg.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Gradient;
            this.write_msg.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.write_msg.Location = new System.Drawing.Point(354, 501);
            this.write_msg.Name = "write_msg";
            this.write_msg.PanelColor = System.Drawing.Color.WhiteSmoke;
            this.write_msg.PanelColor2 = System.Drawing.Color.WhiteSmoke;
            this.write_msg.ShadowColor = System.Drawing.Color.DarkGray;
            this.write_msg.ShadowDept = 2;
            this.write_msg.ShadowDepth = 5;
            this.write_msg.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.write_msg.ShadowTopLeftVisible = false;
            this.write_msg.Size = new System.Drawing.Size(823, 74);
            this.write_msg.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.write_msg.TabIndex = 4;
            // 
            // msg_txt
            // 
            this.msg_txt.BackColor = System.Drawing.Color.DarkSlateGray;
            this.msg_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.msg_txt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msg_txt.Font = new System.Drawing.Font("Microsoft JhengHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msg_txt.ForeColor = System.Drawing.Color.White;
            this.msg_txt.Location = new System.Drawing.Point(72, 0);
            this.msg_txt.Name = "msg_txt";
            this.msg_txt.Size = new System.Drawing.Size(690, 74);
            this.msg_txt.TabIndex = 8;
            this.msg_txt.Text = "";
            this.msg_txt.TextChanged += new System.EventHandler(this.msg_txt_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(72, 74);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // send_btn
            // 
            this.send_btn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.send_btn.Dock = System.Windows.Forms.DockStyle.Right;
            this.send_btn.Image = ((System.Drawing.Image)(resources.GetObject("send_btn.Image")));
            this.send_btn.Location = new System.Drawing.Point(762, 0);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(61, 74);
            this.send_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.send_btn.TabIndex = 7;
            this.send_btn.TabStop = false;
            this.send_btn.Click += new System.EventHandler(this.send_btn_Click);
            // 
            // statepanel
            // 
            this.statepanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.statepanel.Controls.Add(this.addContact);
            this.statepanel.Controls.Add(this.userName_lbl);
            this.statepanel.Controls.Add(this.name_lbl);
            this.statepanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.statepanel.Location = new System.Drawing.Point(354, 0);
            this.statepanel.Name = "statepanel";
            this.statepanel.Size = new System.Drawing.Size(823, 62);
            this.statepanel.TabIndex = 5;
            // 
            // userName_lbl
            // 
            this.userName_lbl.AutoSize = true;
            this.userName_lbl.Font = new System.Drawing.Font("Microsoft JhengHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName_lbl.Location = new System.Drawing.Point(6, 37);
            this.userName_lbl.Name = "userName_lbl";
            this.userName_lbl.Size = new System.Drawing.Size(0, 22);
            this.userName_lbl.TabIndex = 1;
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lbl.Location = new System.Drawing.Point(6, 9);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(0, 25);
            this.name_lbl.TabIndex = 0;
            // 
            // message_gb
            // 
            this.message_gb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.message_gb.Location = new System.Drawing.Point(354, 62);
            this.message_gb.Name = "message_gb";
            this.message_gb.Size = new System.Drawing.Size(823, 439);
            this.message_gb.TabIndex = 6;
            // 
            // addContact
            // 
            this.addContact.AutoSize = true;
            this.addContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addContact.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.addContact.Location = new System.Drawing.Point(690, 9);
            this.addContact.Name = "addContact";
            this.addContact.Size = new System.Drawing.Size(121, 25);
            this.addContact.TabIndex = 2;
            this.addContact.Text = "Add Contact";
            this.addContact.Visible = false;
            this.addContact.Click += new System.EventHandler(this.addContact_Click);
            // 
            // ChatsMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1177, 575);
            this.Controls.Add(this.message_gb);
            this.Controls.Add(this.statepanel);
            this.Controls.Add(this.write_msg);
            this.Controls.Add(this.accountsName_pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChatsMainForm";
            this.Text = "Chats";
            this.Load += new System.EventHandler(this.ChatsMainForm_Load);
            this.accountsName_pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.write_msg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.send_btn)).EndInit();
            this.statepanel.ResumeLayout(false);
            this.statepanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.UI.WinForms.BunifuShadowPanel accountsName_pnl;
        private Bunifu.UI.WinForms.BunifuShadowPanel write_msg;
        private System.Windows.Forms.RichTextBox msg_txt;
        private System.Windows.Forms.PictureBox send_btn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel statepanel;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Label userName_lbl;
        private System.Windows.Forms.Panel message_gb;
        private System.Windows.Forms.Label addContact;
    }
}
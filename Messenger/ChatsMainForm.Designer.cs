
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
            this.messages_pnl = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.accountsName_pnl = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.write_msg = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.write_msg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 0;
            this.bunifuElipse1.TargetControl = this;
            // 
            // messages_pnl
            // 
            this.messages_pnl.BackColor = System.Drawing.Color.Transparent;
            this.messages_pnl.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.messages_pnl.BorderRadius = 1;
            this.messages_pnl.BorderThickness = 1;
            this.messages_pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.messages_pnl.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.messages_pnl.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.messages_pnl.Location = new System.Drawing.Point(354, 0);
            this.messages_pnl.Name = "messages_pnl";
            this.messages_pnl.PanelColor = System.Drawing.Color.WhiteSmoke;
            this.messages_pnl.PanelColor2 = System.Drawing.Color.WhiteSmoke;
            this.messages_pnl.ShadowColor = System.Drawing.Color.DarkGray;
            this.messages_pnl.ShadowDept = 2;
            this.messages_pnl.ShadowDepth = 5;
            this.messages_pnl.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.messages_pnl.ShadowTopLeftVisible = false;
            this.messages_pnl.Size = new System.Drawing.Size(823, 501);
            this.messages_pnl.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.messages_pnl.TabIndex = 1;
            this.messages_pnl.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.messages_pnl_ControlAdded);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 30;
            this.bunifuElipse2.TargetControl = this;
            // 
            // accountsName_pnl
            // 
            this.accountsName_pnl.BackColor = System.Drawing.Color.Transparent;
            this.accountsName_pnl.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.accountsName_pnl.BorderRadius = 1;
            this.accountsName_pnl.BorderThickness = 1;
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
            // write_msg
            // 
            this.write_msg.BackColor = System.Drawing.Color.Transparent;
            this.write_msg.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.write_msg.BorderRadius = 1;
            this.write_msg.BorderThickness = 1;
            this.write_msg.Controls.Add(this.richTextBox1);
            this.write_msg.Controls.Add(this.pictureBox1);
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
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(765, 74);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(765, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // ChatsMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 575);
            this.Controls.Add(this.messages_pnl);
            this.Controls.Add(this.write_msg);
            this.Controls.Add(this.accountsName_pnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChatsMainForm";
            this.Text = "Chats";
            this.write_msg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuShadowPanel messages_pnl;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.UI.WinForms.BunifuShadowPanel accountsName_pnl;
        private Bunifu.UI.WinForms.BunifuShadowPanel write_msg;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
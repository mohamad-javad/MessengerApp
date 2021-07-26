namespace MessengerApp
{
    partial class ProfileForm
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
            this.family_txt = new Bunifu.Framework.BunifuCustomTextbox();
            this.name_txt = new Bunifu.Framework.BunifuCustomTextbox();
            this.usrName_lbl = new System.Windows.Forms.Label();
            this.exit_profile_btn = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // family_txt
            // 
            this.family_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.family_txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.family_txt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.family_txt.BorderColor = System.Drawing.Color.Transparent;
            this.family_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.family_txt.Font = new System.Drawing.Font("B Zar", 12F);
            this.family_txt.ForeColor = System.Drawing.Color.Gray;
            this.family_txt.Location = new System.Drawing.Point(584, 173);
            this.family_txt.Multiline = true;
            this.family_txt.Name = "family_txt";
            this.family_txt.Size = new System.Drawing.Size(313, 62);
            this.family_txt.TabIndex = 9;
            this.family_txt.Text = "Family";
            this.family_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // name_txt
            // 
            this.name_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.name_txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.name_txt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.name_txt.BorderColor = System.Drawing.Color.Transparent;
            this.name_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name_txt.Font = new System.Drawing.Font("B Zar", 12F);
            this.name_txt.ForeColor = System.Drawing.Color.Gray;
            this.name_txt.Location = new System.Drawing.Point(123, 173);
            this.name_txt.Multiline = true;
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(313, 62);
            this.name_txt.TabIndex = 10;
            this.name_txt.Text = "Name";
            this.name_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // usrName_lbl
            // 
            this.usrName_lbl.AutoSize = true;
            this.usrName_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usrName_lbl.Location = new System.Drawing.Point(117, 55);
            this.usrName_lbl.Name = "usrName_lbl";
            this.usrName_lbl.Size = new System.Drawing.Size(149, 32);
            this.usrName_lbl.TabIndex = 15;
            this.usrName_lbl.Text = "UserName";
            // 
            // exit_profile_btn
            // 
            this.exit_profile_btn.AutoSize = true;
            this.exit_profile_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_profile_btn.Location = new System.Drawing.Point(1005, 9);
            this.exit_profile_btn.Name = "exit_profile_btn";
            this.exit_profile_btn.Size = new System.Drawing.Size(31, 29);
            this.exit_profile_btn.TabIndex = 17;
            this.exit_profile_btn.Text = "X";
            this.exit_profile_btn.Click += new System.EventHandler(this.label1_Click);
            this.exit_profile_btn.MouseEnter += new System.EventHandler(this.label1_MouseEnter);
            this.exit_profile_btn.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(123, 282);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(313, 388);
            this.listBox1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "UserName";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(584, 282);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(313, 404);
            this.listBox2.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(580, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "UserName";
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1048, 702);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.exit_profile_btn);
            this.Controls.Add(this.usrName_lbl);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.family_txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProfileForm";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.BunifuCustomTextbox family_txt;
        private Bunifu.Framework.BunifuCustomTextbox name_txt;
        private System.Windows.Forms.Label usrName_lbl;
        private System.Windows.Forms.Label exit_profile_btn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label2;
    }
}
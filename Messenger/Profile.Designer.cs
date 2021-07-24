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
            this.age_txt = new Bunifu.Framework.BunifuCustomTextbox();
            this.usrName_lbl = new System.Windows.Forms.Label();
            this.phone_txt = new Bunifu.Framework.BunifuCustomTextbox();
            this.emai_txt = new Bunifu.Framework.BunifuCustomTextbox();
            this.button1 = new System.Windows.Forms.Button();
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
            // age_txt
            // 
            this.age_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.age_txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.age_txt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.age_txt.BorderColor = System.Drawing.Color.Transparent;
            this.age_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.age_txt.Font = new System.Drawing.Font("B Zar", 12F);
            this.age_txt.ForeColor = System.Drawing.Color.Gray;
            this.age_txt.Location = new System.Drawing.Point(123, 288);
            this.age_txt.Multiline = true;
            this.age_txt.Name = "age_txt";
            this.age_txt.Size = new System.Drawing.Size(313, 62);
            this.age_txt.TabIndex = 11;
            this.age_txt.Text = "Age";
            this.age_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // phone_txt
            // 
            this.phone_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.phone_txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.phone_txt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.phone_txt.BorderColor = System.Drawing.Color.Transparent;
            this.phone_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phone_txt.Font = new System.Drawing.Font("B Zar", 12F);
            this.phone_txt.ForeColor = System.Drawing.Color.Gray;
            this.phone_txt.Location = new System.Drawing.Point(584, 288);
            this.phone_txt.Multiline = true;
            this.phone_txt.Name = "phone_txt";
            this.phone_txt.Size = new System.Drawing.Size(313, 62);
            this.phone_txt.TabIndex = 12;
            this.phone_txt.Text = "Phone Number";
            this.phone_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // emai_txt
            // 
            this.emai_txt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.emai_txt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.AllSystemSources;
            this.emai_txt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.emai_txt.BorderColor = System.Drawing.Color.Transparent;
            this.emai_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emai_txt.Font = new System.Drawing.Font("B Zar", 12F);
            this.emai_txt.ForeColor = System.Drawing.Color.Gray;
            this.emai_txt.Location = new System.Drawing.Point(123, 409);
            this.emai_txt.Multiline = true;
            this.emai_txt.Name = "emai_txt";
            this.emai_txt.Size = new System.Drawing.Size(774, 62);
            this.emai_txt.TabIndex = 13;
            this.emai_txt.Text = "Email";
            this.emai_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(420, 548);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 61);
            this.button1.TabIndex = 16;
            this.button1.Text = "Apply Changes";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1048, 621);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.usrName_lbl);
            this.Controls.Add(this.emai_txt);
            this.Controls.Add(this.phone_txt);
            this.Controls.Add(this.age_txt);
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
        private Bunifu.Framework.BunifuCustomTextbox age_txt;
        private System.Windows.Forms.Label usrName_lbl;
        private Bunifu.Framework.BunifuCustomTextbox phone_txt;
        private Bunifu.Framework.BunifuCustomTextbox emai_txt;
        private System.Windows.Forms.Button button1;
    }
}
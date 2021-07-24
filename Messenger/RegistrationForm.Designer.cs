
namespace Sliding_Application
{
    partial class RegistrationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.name_txt = new System.Windows.Forms.TextBox();
            this.family_txt = new System.Windows.Forms.TextBox();
            this.userName_txt = new System.Windows.Forms.TextBox();
            this.pswd_txt = new System.Windows.Forms.TextBox();
            this.register_btn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Label();
            this.error_lbl = new System.Windows.Forms.Label();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register New User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "User Name: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Family: ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // name_txt
            // 
            this.name_txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name_txt.Location = new System.Drawing.Point(144, 156);
            this.name_txt.Name = "name_txt";
            this.name_txt.Size = new System.Drawing.Size(166, 22);
            this.name_txt.TabIndex = 5;
            // 
            // family_txt
            // 
            this.family_txt.Location = new System.Drawing.Point(144, 200);
            this.family_txt.Name = "family_txt";
            this.family_txt.Size = new System.Drawing.Size(166, 22);
            this.family_txt.TabIndex = 6;
            // 
            // userName_txt
            // 
            this.userName_txt.Location = new System.Drawing.Point(144, 246);
            this.userName_txt.Name = "userName_txt";
            this.userName_txt.Size = new System.Drawing.Size(166, 22);
            this.userName_txt.TabIndex = 7;
            // 
            // pswd_txt
            // 
            this.pswd_txt.Location = new System.Drawing.Point(144, 289);
            this.pswd_txt.Name = "pswd_txt";
            this.pswd_txt.Size = new System.Drawing.Size(166, 22);
            this.pswd_txt.TabIndex = 8;
            // 
            // register_btn
            // 
            this.register_btn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register_btn.Location = new System.Drawing.Point(102, 429);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(135, 42);
            this.register_btn.TabIndex = 9;
            this.register_btn.Text = "Register";
            this.register_btn.UseVisualStyleBackColor = true;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 489);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Already have an account?";
            // 
            // login_btn
            // 
            this.login_btn.AutoSize = true;
            this.login_btn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.Color.Blue;
            this.login_btn.Location = new System.Drawing.Point(243, 489);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(55, 22);
            this.login_btn.TabIndex = 11;
            this.login_btn.Text = "Login";
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // error_lbl
            // 
            this.error_lbl.AutoSize = true;
            this.error_lbl.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.error_lbl.Location = new System.Drawing.Point(12, 328);
            this.error_lbl.Name = "error_lbl";
            this.error_lbl.Size = new System.Drawing.Size(0, 18);
            this.error_lbl.TabIndex = 12;
            // 
            // Exit_btn
            // 
            this.Exit_btn.BackColor = System.Drawing.Color.Crimson;
            this.Exit_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_btn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Exit_btn.Location = new System.Drawing.Point(313, 12);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(26, 25);
            this.Exit_btn.TabIndex = 13;
            this.Exit_btn.Text = "X";
            this.Exit_btn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Exit_btn.UseVisualStyleBackColor = false;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(351, 516);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.error_lbl);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.register_btn);
            this.Controls.Add(this.pswd_txt);
            this.Controls.Add(this.userName_txt);
            this.Controls.Add(this.family_txt);
            this.Controls.Add(this.name_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration Form";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox name_txt;
        private System.Windows.Forms.TextBox family_txt;
        private System.Windows.Forms.TextBox userName_txt;
        private System.Windows.Forms.TextBox pswd_txt;
        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label login_btn;
        private System.Windows.Forms.Label error_lbl;
        private System.Windows.Forms.Button Exit_btn;
    }
}
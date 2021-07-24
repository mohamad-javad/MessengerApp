
namespace Sliding_Application
{
    partial class LoginForm
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
            this.usr_txt = new System.Windows.Forms.TextBox();
            this.pswd_txt = new System.Windows.Forms.TextBox();
            this.error_lbl = new System.Windows.Forms.Label();
            this.exit_lbl = new System.Windows.Forms.Label();
            this.login_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 30);
            this.label1.TabIndex = 0;
            this.label1.Tag = "";
            this.label1.Text = "Login User";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password: ";
            // 
            // usr_txt
            // 
            this.usr_txt.Location = new System.Drawing.Point(125, 142);
            this.usr_txt.Name = "usr_txt";
            this.usr_txt.Size = new System.Drawing.Size(194, 22);
            this.usr_txt.TabIndex = 3;
            this.usr_txt.TextChanged += new System.EventHandler(this.usr_txt_TextChanged);
            // 
            // pswd_txt
            // 
            this.pswd_txt.Location = new System.Drawing.Point(125, 197);
            this.pswd_txt.Name = "pswd_txt";
            this.pswd_txt.Size = new System.Drawing.Size(194, 22);
            this.pswd_txt.TabIndex = 4;
            // 
            // error_lbl
            // 
            this.error_lbl.AutoSize = true;
            this.error_lbl.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.error_lbl.Location = new System.Drawing.Point(12, 241);
            this.error_lbl.Name = "error_lbl";
            this.error_lbl.Size = new System.Drawing.Size(0, 18);
            this.error_lbl.TabIndex = 5;
            // 
            // exit_lbl
            // 
            this.exit_lbl.BackColor = System.Drawing.Color.Crimson;
            this.exit_lbl.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_lbl.Location = new System.Drawing.Point(297, 9);
            this.exit_lbl.Name = "exit_lbl";
            this.exit_lbl.Size = new System.Drawing.Size(24, 25);
            this.exit_lbl.TabIndex = 6;
            this.exit_lbl.Text = "X";
            this.exit_lbl.Click += new System.EventHandler(this.label4_Click);
            // 
            // login_btn
            // 
            this.login_btn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.Location = new System.Drawing.Point(108, 334);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(108, 40);
            this.login_btn.TabIndex = 7;
            this.login_btn.Text = "Login";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(333, 397);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.exit_lbl);
            this.Controls.Add(this.error_lbl);
            this.Controls.Add(this.pswd_txt);
            this.Controls.Add(this.usr_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usr_txt;
        private System.Windows.Forms.TextBox pswd_txt;
        private System.Windows.Forms.Label error_lbl;
        private System.Windows.Forms.Label exit_lbl;
        private System.Windows.Forms.Button login_btn;
    }
}
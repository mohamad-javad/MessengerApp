
namespace Sliding_Application
{
    partial class AddContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddContact));
            this.userName_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.search_btn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.search_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // userName_text
            // 
            this.userName_text.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName_text.Location = new System.Drawing.Point(12, 67);
            this.userName_text.Multiline = true;
            this.userName_text.Name = "userName_text";
            this.userName_text.Size = new System.Drawing.Size(306, 36);
            this.userName_text.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "User Name:";
            // 
            // search_btn
            // 
            this.search_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search_btn.Image = ((System.Drawing.Image)(resources.GetObject("search_btn.Image")));
            this.search_btn.Location = new System.Drawing.Point(427, 67);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(49, 44);
            this.search_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.search_btn.TabIndex = 2;
            this.search_btn.TabStop = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            this.search_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.search_btn_MouseDown);
            this.search_btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.search_btn_MouseUp);
            // 
            // AddContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(488, 115);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userName_text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddContact";
            this.Text = "AddContact";
            ((System.ComponentModel.ISupportInitialize)(this.search_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userName_text;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox search_btn;
    }
}

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
            this.defining_lbl = new System.Windows.Forms.Label();
            this.search_btn = new System.Windows.Forms.PictureBox();
            this.createNew_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.search_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // userName_text
            // 
            this.userName_text.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName_text.Location = new System.Drawing.Point(12, 67);
            this.userName_text.Multiline = true;
            this.userName_text.Name = "userName_text";
            this.userName_text.Size = new System.Drawing.Size(306, 43);
            this.userName_text.TabIndex = 0;
            // 
            // defining_lbl
            // 
            this.defining_lbl.AutoSize = true;
            this.defining_lbl.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.defining_lbl.Location = new System.Drawing.Point(12, 20);
            this.defining_lbl.Name = "defining_lbl";
            this.defining_lbl.Size = new System.Drawing.Size(122, 25);
            this.defining_lbl.TabIndex = 1;
            this.defining_lbl.Text = "User Name:";
            // 
            // search_btn
            // 
            this.search_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search_btn.Image = ((System.Drawing.Image)(resources.GetObject("search_btn.Image")));
            this.search_btn.Location = new System.Drawing.Point(353, 67);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(49, 43);
            this.search_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.search_btn.TabIndex = 2;
            this.search_btn.TabStop = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            this.search_btn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.search_btn_MouseDown);
            this.search_btn.MouseUp += new System.Windows.Forms.MouseEventHandler(this.search_btn_MouseUp);
            // 
            // createNew_btn
            // 
            this.createNew_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.createNew_btn.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNew_btn.Location = new System.Drawing.Point(151, 129);
            this.createNew_btn.Name = "createNew_btn";
            this.createNew_btn.Size = new System.Drawing.Size(112, 36);
            this.createNew_btn.TabIndex = 3;
            this.createNew_btn.Text = "Create New";
            this.createNew_btn.UseVisualStyleBackColor = false;
            this.createNew_btn.Visible = false;
            this.createNew_btn.Click += new System.EventHandler(this.createNew_btn_Click);
            // 
            // AddContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(414, 167);
            this.Controls.Add(this.createNew_btn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.defining_lbl);
            this.Controls.Add(this.userName_text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddContact";
            this.Text = "AddContact";
            this.Load += new System.EventHandler(this.AddContact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.search_btn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox userName_text;
        private System.Windows.Forms.Label defining_lbl;
        private System.Windows.Forms.PictureBox search_btn;
        private System.Windows.Forms.Button createNew_btn;
    }
}
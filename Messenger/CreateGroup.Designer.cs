
namespace Sliding_Application
{
    partial class CreateGroup
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
            this.gpName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gpUserName = new System.Windows.Forms.TextBox();
            this.create_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gpName
            // 
            this.gpName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gpName.Location = new System.Drawing.Point(153, 36);
            this.gpName.Name = "gpName";
            this.gpName.Size = new System.Drawing.Size(156, 22);
            this.gpName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Group Username: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(12, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Group Name:";
            // 
            // gpUserName
            // 
            this.gpUserName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gpUserName.Location = new System.Drawing.Point(153, 83);
            this.gpUserName.Name = "gpUserName";
            this.gpUserName.Size = new System.Drawing.Size(156, 22);
            this.gpUserName.TabIndex = 2;
            // 
            // create_btn
            // 
            this.create_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.create_btn.Location = new System.Drawing.Point(117, 144);
            this.create_btn.Name = "create_btn";
            this.create_btn.Size = new System.Drawing.Size(92, 28);
            this.create_btn.TabIndex = 0;
            this.create_btn.Text = "Create";
            this.create_btn.UseVisualStyleBackColor = true;
            this.create_btn.Click += new System.EventHandler(this.create_btn_Click);
            // 
            // CreateGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 184);
            this.Controls.Add(this.create_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gpUserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gpName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CreateGroup";
            this.ShowIcon = false;
            this.Text = "Create Group";
            this.Load += new System.EventHandler(this.CreateGroup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox gpName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox gpUserName;
        private System.Windows.Forms.Button create_btn;
    }
}
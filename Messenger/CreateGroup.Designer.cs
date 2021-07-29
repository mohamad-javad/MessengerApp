
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateGroup));
            this.gpName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gpUserName = new System.Windows.Forms.TextBox();
            this.create_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gpName
            // 
            resources.ApplyResources(this.gpName, "gpName");
            this.gpName.Name = "gpName";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // gpUserName
            // 
            resources.ApplyResources(this.gpUserName, "gpUserName");
            this.gpUserName.Name = "gpUserName";
            // 
            // create_btn
            // 
            resources.ApplyResources(this.create_btn, "create_btn");
            this.create_btn.Name = "create_btn";
            this.create_btn.UseVisualStyleBackColor = true;
            this.create_btn.Click += new System.EventHandler(this.create_btn_Click);
            // 
            // CreateGroup
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.create_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gpUserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gpName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "CreateGroup";
            this.ShowIcon = false;
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
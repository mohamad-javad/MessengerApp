namespace MessengerApp
{
    partial class MessengerMainForm
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation9 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation8 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation11 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation10 = new BunifuAnimatorNS.Animation();
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation7 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessengerMainForm));
            BunifuAnimatorNS.Animation animation12 = new BunifuAnimatorNS.Animation();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.Favorite_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ch_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.gp_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Profile_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pv_btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.PageName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.PanelUp = new System.Windows.Forms.Panel();
            this.Exit_btn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Menu_trns = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.Desktop = new System.Windows.Forms.Panel();
            this.Logo_trns = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.mbar_animate = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.BigLogo_trns = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.menue_btn_trns = new Bunifu.UI.WinForms.BunifuTransition(this.components);
            this.verticalTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.PanelMenu.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.PanelUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 50;
            this.bunifuElipse1.TargetControl = this;
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PanelMenu.Controls.Add(this.Favorite_btn);
            this.PanelMenu.Controls.Add(this.ch_btn);
            this.PanelMenu.Controls.Add(this.gp_btn);
            this.PanelMenu.Controls.Add(this.Profile_btn);
            this.PanelMenu.Controls.Add(this.pv_btn);
            this.verticalTransition.SetDecoration(this.PanelMenu, BunifuAnimatorNS.DecorationType.None);
            this.mbar_animate.SetDecoration(this.PanelMenu, BunifuAnimatorNS.DecorationType.None);
            this.BigLogo_trns.SetDecoration(this.PanelMenu, BunifuAnimatorNS.DecorationType.None);
            this.Menu_trns.SetDecoration(this.PanelMenu, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.menue_btn_trns.SetDecoration(this.PanelMenu, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Logo_trns.SetDecoration(this.PanelMenu, BunifuAnimatorNS.DecorationType.None);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 70);
            this.PanelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(66, 668);
            this.PanelMenu.TabIndex = 0;
            // 
            // Favorite_btn
            // 
            this.Favorite_btn.Active = false;
            this.Favorite_btn.Activecolor = System.Drawing.Color.Gray;
            this.Favorite_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Favorite_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Favorite_btn.BorderRadius = 0;
            this.Favorite_btn.ButtonText = "";
            this.Favorite_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menue_btn_trns.SetDecoration(this.Favorite_btn, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Logo_trns.SetDecoration(this.Favorite_btn, BunifuAnimatorNS.DecorationType.None);
            this.Menu_trns.SetDecoration(this.Favorite_btn, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.BigLogo_trns.SetDecoration(this.Favorite_btn, BunifuAnimatorNS.DecorationType.None);
            this.mbar_animate.SetDecoration(this.Favorite_btn, BunifuAnimatorNS.DecorationType.None);
            this.verticalTransition.SetDecoration(this.Favorite_btn, BunifuAnimatorNS.DecorationType.None);
            this.Favorite_btn.DisabledColor = System.Drawing.Color.Gray;
            this.Favorite_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.Favorite_btn.Font = new System.Drawing.Font("MRT_Abasan", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Favorite_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.Favorite_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("Favorite_btn.Iconimage")));
            this.Favorite_btn.Iconimage_right = null;
            this.Favorite_btn.Iconimage_right_Selected = null;
            this.Favorite_btn.Iconimage_Selected = null;
            this.Favorite_btn.IconMarginLeft = 0;
            this.Favorite_btn.IconMarginRight = 0;
            this.Favorite_btn.IconRightVisible = true;
            this.Favorite_btn.IconRightZoom = 0D;
            this.Favorite_btn.IconVisible = true;
            this.Favorite_btn.IconZoom = 70D;
            this.Favorite_btn.IsTab = false;
            this.Favorite_btn.Location = new System.Drawing.Point(0, 171);
            this.Favorite_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Favorite_btn.Name = "Favorite_btn";
            this.Favorite_btn.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.Favorite_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(105)))), ((int)(((byte)(246)))));
            this.Favorite_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.Favorite_btn.selected = false;
            this.Favorite_btn.Size = new System.Drawing.Size(66, 57);
            this.Favorite_btn.TabIndex = 6;
            this.Favorite_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Favorite_btn.Textcolor = System.Drawing.Color.Black;
            this.Favorite_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Favorite_btn.Click += new System.EventHandler(this.Favorite_btn_Click);
            // 
            // ch_btn
            // 
            this.ch_btn.Active = false;
            this.ch_btn.Activecolor = System.Drawing.Color.Gray;
            this.ch_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ch_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ch_btn.BorderRadius = 0;
            this.ch_btn.ButtonText = "";
            this.ch_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menue_btn_trns.SetDecoration(this.ch_btn, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Logo_trns.SetDecoration(this.ch_btn, BunifuAnimatorNS.DecorationType.None);
            this.Menu_trns.SetDecoration(this.ch_btn, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.BigLogo_trns.SetDecoration(this.ch_btn, BunifuAnimatorNS.DecorationType.None);
            this.mbar_animate.SetDecoration(this.ch_btn, BunifuAnimatorNS.DecorationType.None);
            this.verticalTransition.SetDecoration(this.ch_btn, BunifuAnimatorNS.DecorationType.None);
            this.ch_btn.DisabledColor = System.Drawing.Color.Gray;
            this.ch_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.ch_btn.Font = new System.Drawing.Font("MRT_Abasan", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.ch_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.ch_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("ch_btn.Iconimage")));
            this.ch_btn.Iconimage_right = null;
            this.ch_btn.Iconimage_right_Selected = null;
            this.ch_btn.Iconimage_Selected = null;
            this.ch_btn.IconMarginLeft = 0;
            this.ch_btn.IconMarginRight = 0;
            this.ch_btn.IconRightVisible = true;
            this.ch_btn.IconRightZoom = 0D;
            this.ch_btn.IconVisible = true;
            this.ch_btn.IconZoom = 80D;
            this.ch_btn.IsTab = false;
            this.ch_btn.Location = new System.Drawing.Point(0, 114);
            this.ch_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ch_btn.Name = "ch_btn";
            this.ch_btn.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.ch_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(105)))), ((int)(((byte)(246)))));
            this.ch_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.ch_btn.selected = false;
            this.ch_btn.Size = new System.Drawing.Size(66, 57);
            this.ch_btn.TabIndex = 5;
            this.ch_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ch_btn.Textcolor = System.Drawing.Color.Black;
            this.ch_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ch_btn.Click += new System.EventHandler(this.ch_btn_Click);
            // 
            // gp_btn
            // 
            this.gp_btn.Active = false;
            this.gp_btn.Activecolor = System.Drawing.Color.Gray;
            this.gp_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gp_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gp_btn.BorderRadius = 0;
            this.gp_btn.ButtonText = "";
            this.gp_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menue_btn_trns.SetDecoration(this.gp_btn, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Logo_trns.SetDecoration(this.gp_btn, BunifuAnimatorNS.DecorationType.None);
            this.Menu_trns.SetDecoration(this.gp_btn, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.BigLogo_trns.SetDecoration(this.gp_btn, BunifuAnimatorNS.DecorationType.None);
            this.mbar_animate.SetDecoration(this.gp_btn, BunifuAnimatorNS.DecorationType.None);
            this.verticalTransition.SetDecoration(this.gp_btn, BunifuAnimatorNS.DecorationType.None);
            this.gp_btn.DisabledColor = System.Drawing.Color.Gray;
            this.gp_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.gp_btn.Font = new System.Drawing.Font("MRT_Abasan", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.gp_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.gp_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("gp_btn.Iconimage")));
            this.gp_btn.Iconimage_right = null;
            this.gp_btn.Iconimage_right_Selected = null;
            this.gp_btn.Iconimage_Selected = null;
            this.gp_btn.IconMarginLeft = 0;
            this.gp_btn.IconMarginRight = 0;
            this.gp_btn.IconRightVisible = true;
            this.gp_btn.IconRightZoom = 0D;
            this.gp_btn.IconVisible = true;
            this.gp_btn.IconZoom = 80D;
            this.gp_btn.IsTab = false;
            this.gp_btn.Location = new System.Drawing.Point(0, 57);
            this.gp_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gp_btn.Name = "gp_btn";
            this.gp_btn.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.gp_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(105)))), ((int)(((byte)(246)))));
            this.gp_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.gp_btn.selected = false;
            this.gp_btn.Size = new System.Drawing.Size(66, 57);
            this.gp_btn.TabIndex = 4;
            this.gp_btn.Tag = "Hello";
            this.gp_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gp_btn.Textcolor = System.Drawing.Color.Black;
            this.gp_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_btn.Click += new System.EventHandler(this.People_btn_Click);
            // 
            // Profile_btn
            // 
            this.Profile_btn.Active = false;
            this.Profile_btn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(43)))), ((int)(((byte)(129)))));
            this.Profile_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Profile_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Profile_btn.BorderRadius = 0;
            this.Profile_btn.ButtonText = "";
            this.Profile_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menue_btn_trns.SetDecoration(this.Profile_btn, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Logo_trns.SetDecoration(this.Profile_btn, BunifuAnimatorNS.DecorationType.None);
            this.Menu_trns.SetDecoration(this.Profile_btn, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.BigLogo_trns.SetDecoration(this.Profile_btn, BunifuAnimatorNS.DecorationType.None);
            this.mbar_animate.SetDecoration(this.Profile_btn, BunifuAnimatorNS.DecorationType.None);
            this.verticalTransition.SetDecoration(this.Profile_btn, BunifuAnimatorNS.DecorationType.None);
            this.Profile_btn.DisabledColor = System.Drawing.Color.Gray;
            this.Profile_btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Profile_btn.Font = new System.Drawing.Font("MRT_Abasan", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Profile_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.Profile_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("Profile_btn.Iconimage")));
            this.Profile_btn.Iconimage_right = null;
            this.Profile_btn.Iconimage_right_Selected = null;
            this.Profile_btn.Iconimage_Selected = null;
            this.Profile_btn.IconMarginLeft = 0;
            this.Profile_btn.IconMarginRight = 0;
            this.Profile_btn.IconRightVisible = true;
            this.Profile_btn.IconRightZoom = 0D;
            this.Profile_btn.IconVisible = true;
            this.Profile_btn.IconZoom = 80D;
            this.Profile_btn.IsTab = false;
            this.Profile_btn.Location = new System.Drawing.Point(0, 607);
            this.Profile_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Profile_btn.Name = "Profile_btn";
            this.Profile_btn.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.Profile_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(105)))), ((int)(((byte)(246)))));
            this.Profile_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.Profile_btn.selected = false;
            this.Profile_btn.Size = new System.Drawing.Size(66, 61);
            this.Profile_btn.TabIndex = 8;
            this.Profile_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Profile_btn.Textcolor = System.Drawing.Color.Black;
            this.Profile_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Profile_btn.Click += new System.EventHandler(this.Profile_btn_Click);
            // 
            // pv_btn
            // 
            this.pv_btn.Active = false;
            this.pv_btn.Activecolor = System.Drawing.Color.Gray;
            this.pv_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pv_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pv_btn.BorderRadius = 0;
            this.pv_btn.ButtonText = "";
            this.pv_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.menue_btn_trns.SetDecoration(this.pv_btn, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Logo_trns.SetDecoration(this.pv_btn, BunifuAnimatorNS.DecorationType.None);
            this.Menu_trns.SetDecoration(this.pv_btn, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.BigLogo_trns.SetDecoration(this.pv_btn, BunifuAnimatorNS.DecorationType.None);
            this.mbar_animate.SetDecoration(this.pv_btn, BunifuAnimatorNS.DecorationType.None);
            this.verticalTransition.SetDecoration(this.pv_btn, BunifuAnimatorNS.DecorationType.None);
            this.pv_btn.DisabledColor = System.Drawing.Color.Gray;
            this.pv_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.pv_btn.Font = new System.Drawing.Font("MRT_Abasan", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.pv_btn.Iconcolor = System.Drawing.Color.Transparent;
            this.pv_btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("pv_btn.Iconimage")));
            this.pv_btn.Iconimage_right = null;
            this.pv_btn.Iconimage_right_Selected = null;
            this.pv_btn.Iconimage_Selected = ((System.Drawing.Image)(resources.GetObject("pv_btn.Iconimage_Selected")));
            this.pv_btn.IconMarginLeft = 0;
            this.pv_btn.IconMarginRight = 0;
            this.pv_btn.IconRightVisible = true;
            this.pv_btn.IconRightZoom = 0D;
            this.pv_btn.IconVisible = true;
            this.pv_btn.IconZoom = 70D;
            this.pv_btn.IsTab = false;
            this.pv_btn.Location = new System.Drawing.Point(0, 0);
            this.pv_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pv_btn.Name = "pv_btn";
            this.pv_btn.Normalcolor = System.Drawing.Color.WhiteSmoke;
            this.pv_btn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(105)))), ((int)(((byte)(246)))));
            this.pv_btn.OnHoverTextColor = System.Drawing.Color.White;
            this.pv_btn.selected = false;
            this.pv_btn.Size = new System.Drawing.Size(66, 57);
            this.pv_btn.TabIndex = 0;
            this.pv_btn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pv_btn.Textcolor = System.Drawing.Color.Black;
            this.pv_btn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pv_btn.Click += new System.EventHandler(this.BunifuFlatButton1_Click);
            // 
            // PageName
            // 
            this.PageName.AutoSize = true;
            this.verticalTransition.SetDecoration(this.PageName, BunifuAnimatorNS.DecorationType.None);
            this.Logo_trns.SetDecoration(this.PageName, BunifuAnimatorNS.DecorationType.None);
            this.Menu_trns.SetDecoration(this.PageName, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.BigLogo_trns.SetDecoration(this.PageName, BunifuAnimatorNS.DecorationType.None);
            this.mbar_animate.SetDecoration(this.PageName, BunifuAnimatorNS.DecorationType.None);
            this.menue_btn_trns.SetDecoration(this.PageName, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.PageName.Font = new System.Drawing.Font("MRT_Abasan", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.PageName.ForeColor = System.Drawing.Color.White;
            this.PageName.Location = new System.Drawing.Point(208, 24);
            this.PageName.Name = "PageName";
            this.PageName.Size = new System.Drawing.Size(0, 30);
            this.PageName.TabIndex = 4;
            this.PageName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.verticalTransition.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.Logo_trns.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.Menu_trns.SetDecoration(this.bunifuCustomLabel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.BigLogo_trns.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.mbar_animate.SetDecoration(this.bunifuCustomLabel1, BunifuAnimatorNS.DecorationType.None);
            this.menue_btn_trns.SetDecoration(this.bunifuCustomLabel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("MRT_Abasan", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(7, 14);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(185, 44);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "Messenger";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.bunifuGradientPanel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.PageName);
            this.menue_btn_trns.SetDecoration(this.bunifuGradientPanel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Logo_trns.SetDecoration(this.bunifuGradientPanel1, BunifuAnimatorNS.DecorationType.None);
            this.Menu_trns.SetDecoration(this.bunifuGradientPanel1, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.BigLogo_trns.SetDecoration(this.bunifuGradientPanel1, BunifuAnimatorNS.DecorationType.None);
            this.mbar_animate.SetDecoration(this.bunifuGradientPanel1, BunifuAnimatorNS.DecorationType.None);
            this.verticalTransition.SetDecoration(this.bunifuGradientPanel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(200)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Blue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Blue;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Cyan;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1333, 70);
            this.bunifuGradientPanel1.TabIndex = 10;
            this.bunifuGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            // 
            // PanelUp
            // 
            this.PanelUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(255)))));
            this.PanelUp.Controls.Add(this.bunifuCustomLabel1);
            this.PanelUp.Controls.Add(this.Exit_btn);
            this.PanelUp.Controls.Add(this.bunifuGradientPanel1);
            this.verticalTransition.SetDecoration(this.PanelUp, BunifuAnimatorNS.DecorationType.None);
            this.mbar_animate.SetDecoration(this.PanelUp, BunifuAnimatorNS.DecorationType.None);
            this.BigLogo_trns.SetDecoration(this.PanelUp, BunifuAnimatorNS.DecorationType.None);
            this.Menu_trns.SetDecoration(this.PanelUp, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.menue_btn_trns.SetDecoration(this.PanelUp, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Logo_trns.SetDecoration(this.PanelUp, BunifuAnimatorNS.DecorationType.None);
            this.PanelUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelUp.Location = new System.Drawing.Point(0, 0);
            this.PanelUp.Margin = new System.Windows.Forms.Padding(4);
            this.PanelUp.Name = "PanelUp";
            this.PanelUp.Size = new System.Drawing.Size(1333, 70);
            this.PanelUp.TabIndex = 1;
            // 
            // Exit_btn
            // 
            this.Exit_btn.BackColor = System.Drawing.Color.Transparent;
            this.Exit_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Exit_btn.BackgroundImage")));
            this.Exit_btn.ButtonText = "X";
            this.Exit_btn.ButtonTextMarginLeft = 0;
            this.Logo_trns.SetDecoration(this.Exit_btn, BunifuAnimatorNS.DecorationType.None);
            this.Menu_trns.SetDecoration(this.Exit_btn, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.BigLogo_trns.SetDecoration(this.Exit_btn, BunifuAnimatorNS.DecorationType.None);
            this.mbar_animate.SetDecoration(this.Exit_btn, BunifuAnimatorNS.DecorationType.None);
            this.verticalTransition.SetDecoration(this.Exit_btn, BunifuAnimatorNS.DecorationType.None);
            this.menue_btn_trns.SetDecoration(this.Exit_btn, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Exit_btn.DisabledBorderColor = System.Drawing.Color.White;
            this.Exit_btn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(43)))), ((int)(((byte)(129)))));
            this.Exit_btn.DisabledForecolor = System.Drawing.Color.White;
            this.Exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_btn.ForeColor = System.Drawing.Color.White;
            this.Exit_btn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Exit_btn.IconPadding = 10;
            this.Exit_btn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Exit_btn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(60)))), ((int)(((byte)(230)))));
            this.Exit_btn.IdleBorderRadius = 1;
            this.Exit_btn.IdleBorderThickness = 0;
            this.Exit_btn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(99)))), ((int)(((byte)(150)))));
            this.Exit_btn.IdleIconLeftImage = null;
            this.Exit_btn.IdleIconRightImage = null;
            this.Exit_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Exit_btn.Location = new System.Drawing.Point(1279, 23);
            this.Exit_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Exit_btn.Name = "Exit_btn";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(43)))), ((int)(((byte)(129)))));
            stateProperties2.BorderRadius = 1;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.Navy;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.Exit_btn.onHoverState = stateProperties2;
            this.Exit_btn.Size = new System.Drawing.Size(41, 31);
            this.Exit_btn.TabIndex = 2;
            this.Exit_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click_1);
            // 
            // Menu_trns
            // 
            this.Menu_trns.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.HorizSlide;
            this.Menu_trns.Cursor = null;
            animation9.AnimateOnlyDifferences = true;
            animation9.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.BlindCoeff")));
            animation9.LeafCoeff = 0F;
            animation9.MaxTime = 1F;
            animation9.MinTime = 0F;
            animation9.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.MosaicCoeff")));
            animation9.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation9.MosaicShift")));
            animation9.MosaicSize = 0;
            animation9.Padding = new System.Windows.Forms.Padding(0);
            animation9.RotateCoeff = 0F;
            animation9.RotateLimit = 0F;
            animation9.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.ScaleCoeff")));
            animation9.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation9.SlideCoeff")));
            animation9.TimeCoeff = 0F;
            animation9.TransparencyCoeff = 0F;
            this.Menu_trns.DefaultAnimation = animation9;
            // 
            // Desktop
            // 
            this.Desktop.AutoScroll = true;
            this.Desktop.AutoSize = true;
            this.verticalTransition.SetDecoration(this.Desktop, BunifuAnimatorNS.DecorationType.None);
            this.mbar_animate.SetDecoration(this.Desktop, BunifuAnimatorNS.DecorationType.None);
            this.BigLogo_trns.SetDecoration(this.Desktop, BunifuAnimatorNS.DecorationType.None);
            this.Menu_trns.SetDecoration(this.Desktop, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.menue_btn_trns.SetDecoration(this.Desktop, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Logo_trns.SetDecoration(this.Desktop, BunifuAnimatorNS.DecorationType.None);
            this.Desktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Desktop.Location = new System.Drawing.Point(66, 70);
            this.Desktop.Name = "Desktop";
            this.Desktop.Size = new System.Drawing.Size(1267, 668);
            this.Desktop.TabIndex = 2;
            this.Desktop.Paint += new System.Windows.Forms.PaintEventHandler(this.Desktop_Paint);
            // 
            // Logo_trns
            // 
            this.Logo_trns.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.Logo_trns.Cursor = null;
            animation8.AnimateOnlyDifferences = true;
            animation8.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.BlindCoeff")));
            animation8.LeafCoeff = 0F;
            animation8.MaxTime = 2F;
            animation8.MinTime = 0F;
            animation8.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.MosaicCoeff")));
            animation8.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation8.MosaicShift")));
            animation8.MosaicSize = 20;
            animation8.Padding = new System.Windows.Forms.Padding(30);
            animation8.RotateCoeff = 5F;
            animation8.RotateLimit = 10F;
            animation8.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.ScaleCoeff")));
            animation8.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation8.SlideCoeff")));
            animation8.TimeCoeff = 1F;
            animation8.TransparencyCoeff = 0F;
            this.Logo_trns.DefaultAnimation = animation8;
            this.Logo_trns.MaxAnimationTime = 3000;
            this.Logo_trns.TimeStep = 0.01F;
            // 
            // mbar_animate
            // 
            this.mbar_animate.AnimationType = BunifuAnimatorNS.AnimationType.HorizBlind;
            this.mbar_animate.Cursor = null;
            animation11.AnimateOnlyDifferences = true;
            animation11.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation11.BlindCoeff")));
            animation11.LeafCoeff = 0F;
            animation11.MaxTime = 1F;
            animation11.MinTime = 0F;
            animation11.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation11.MosaicCoeff")));
            animation11.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation11.MosaicShift")));
            animation11.MosaicSize = 0;
            animation11.Padding = new System.Windows.Forms.Padding(0);
            animation11.RotateCoeff = 0F;
            animation11.RotateLimit = 0F;
            animation11.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation11.ScaleCoeff")));
            animation11.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation11.SlideCoeff")));
            animation11.TimeCoeff = 0F;
            animation11.TransparencyCoeff = 0F;
            this.mbar_animate.DefaultAnimation = animation11;
            this.mbar_animate.TimeStep = 0.01F;
            // 
            // BigLogo_trns
            // 
            this.BigLogo_trns.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.BigLogo_trns.Cursor = null;
            animation10.AnimateOnlyDifferences = true;
            animation10.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation10.BlindCoeff")));
            animation10.LeafCoeff = 0F;
            animation10.MaxTime = 1F;
            animation10.MinTime = 0F;
            animation10.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation10.MosaicCoeff")));
            animation10.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation10.MosaicShift")));
            animation10.MosaicSize = 20;
            animation10.Padding = new System.Windows.Forms.Padding(30);
            animation10.RotateCoeff = 0F;
            animation10.RotateLimit = 0F;
            animation10.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation10.ScaleCoeff")));
            animation10.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation10.SlideCoeff")));
            animation10.TimeCoeff = 0F;
            animation10.TransparencyCoeff = 0F;
            this.BigLogo_trns.DefaultAnimation = animation10;
            this.BigLogo_trns.MaxAnimationTime = 3000;
            this.BigLogo_trns.TimeStep = 0.03F;
            // 
            // menue_btn_trns
            // 
            this.menue_btn_trns.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.HorizBlind;
            this.menue_btn_trns.Cursor = null;
            animation7.AnimateOnlyDifferences = true;
            animation7.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.BlindCoeff")));
            animation7.LeafCoeff = 0F;
            animation7.MaxTime = 1F;
            animation7.MinTime = 0F;
            animation7.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.MosaicCoeff")));
            animation7.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation7.MosaicShift")));
            animation7.MosaicSize = 0;
            animation7.Padding = new System.Windows.Forms.Padding(0);
            animation7.RotateCoeff = 0F;
            animation7.RotateLimit = 0F;
            animation7.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.ScaleCoeff")));
            animation7.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation7.SlideCoeff")));
            animation7.TimeCoeff = 0F;
            animation7.TransparencyCoeff = 0F;
            this.menue_btn_trns.DefaultAnimation = animation7;
            // 
            // verticalTransition
            // 
            this.verticalTransition.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.verticalTransition.Cursor = null;
            animation12.AnimateOnlyDifferences = true;
            animation12.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation12.BlindCoeff")));
            animation12.LeafCoeff = 0F;
            animation12.MaxTime = 1F;
            animation12.MinTime = 0F;
            animation12.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation12.MosaicCoeff")));
            animation12.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation12.MosaicShift")));
            animation12.MosaicSize = 0;
            animation12.Padding = new System.Windows.Forms.Padding(0);
            animation12.RotateCoeff = 0F;
            animation12.RotateLimit = 0F;
            animation12.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation12.ScaleCoeff")));
            animation12.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation12.SlideCoeff")));
            animation12.TimeCoeff = 0F;
            animation12.TransparencyCoeff = 0F;
            this.verticalTransition.DefaultAnimation = animation12;
            this.verticalTransition.MaxAnimationTime = 3000;
            this.verticalTransition.TimeStep = 0.01F;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 50;
            this.bunifuElipse2.TargetControl = this;
            // 
            // MessengerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1333, 738);
            this.Controls.Add(this.Desktop);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.PanelUp);
            this.menue_btn_trns.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.verticalTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.mbar_animate.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.BigLogo_trns.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Logo_trns.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Menu_trns.SetDecoration(this, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MessengerMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelMenu.ResumeLayout(false);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.PanelUp.ResumeLayout(false);
            this.PanelUp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel PanelMenu;
        private Bunifu.Framework.UI.BunifuFlatButton pv_btn;
        private Bunifu.Framework.UI.BunifuFlatButton gp_btn;
        private Bunifu.Framework.UI.BunifuFlatButton ch_btn;
        private Bunifu.Framework.UI.BunifuFlatButton Favorite_btn;
        private Bunifu.Framework.UI.BunifuFlatButton Profile_btn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.UI.WinForms.BunifuTransition Menu_trns;
        private BunifuAnimatorNS.BunifuTransition Logo_trns;
        private System.Windows.Forms.Panel Desktop;
        private BunifuAnimatorNS.BunifuTransition mbar_animate;
        private Bunifu.Framework.UI.BunifuCustomLabel PageName;
        private BunifuAnimatorNS.BunifuTransition BigLogo_trns;
        private Bunifu.UI.WinForms.BunifuTransition menue_btn_trns;
        private System.Windows.Forms.Panel PanelUp;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Exit_btn;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private BunifuAnimatorNS.BunifuTransition verticalTransition;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
    }
}


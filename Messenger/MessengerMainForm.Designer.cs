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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation3 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation2 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation5 = new BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation4 = new BunifuAnimatorNS.Animation();
            Bunifu.UI.WinForms.BunifuAnimatorNS.Animation animation6 = new Bunifu.UI.WinForms.BunifuAnimatorNS.Animation();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessengerMainForm));
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
            this.welcom_lbl = new System.Windows.Forms.Label();
            this.PanelMenu.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.PanelUp.SuspendLayout();
            this.Desktop.SuspendLayout();
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
            this.PanelMenu.Size = new System.Drawing.Size(59, 668);
            this.PanelMenu.TabIndex = 0;
            // 
            // Favorite_btn
            // 
            this.Favorite_btn.Active = false;
            this.Favorite_btn.Activecolor = System.Drawing.Color.Gray;
            this.Favorite_btn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Favorite_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Favorite_btn.BorderRadius = 0;
            this.Favorite_btn.ButtonText = "Favorite";
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
            this.Favorite_btn.Size = new System.Drawing.Size(59, 57);
            this.Favorite_btn.TabIndex = 6;
            this.Favorite_btn.Tag = "favorites";
            this.Favorite_btn.Text = "Favorite";
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
            this.ch_btn.ButtonText = "Channels";
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
            this.ch_btn.Size = new System.Drawing.Size(59, 57);
            this.ch_btn.TabIndex = 5;
            this.ch_btn.Tag = "channels";
            this.ch_btn.Text = "Channels";
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
            this.gp_btn.ButtonText = "Group";
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
            this.gp_btn.Size = new System.Drawing.Size(59, 57);
            this.gp_btn.TabIndex = 4;
            this.gp_btn.Tag = "Groups";
            this.gp_btn.Text = "Group";
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
            this.Profile_btn.Size = new System.Drawing.Size(59, 61);
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
            this.pv_btn.ButtonText = "Personal Caht";
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
            this.pv_btn.Size = new System.Drawing.Size(59, 57);
            this.pv_btn.TabIndex = 0;
            this.pv_btn.Tag = "Personal Caht";
            this.pv_btn.Text = "Personal Caht";
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
            this.Exit_btn.AllowAnimations = true;
            this.Exit_btn.AllowMouseEffects = true;
            this.Exit_btn.AllowToggling = false;
            this.Exit_btn.AnimationSpeed = 200;
            this.Exit_btn.AutoGenerateColors = false;
            this.Exit_btn.AutoRoundBorders = false;
            this.Exit_btn.AutoSizeLeftIcon = true;
            this.Exit_btn.AutoSizeRightIcon = true;
            this.Exit_btn.BackColor = System.Drawing.Color.Transparent;
            this.Exit_btn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(99)))), ((int)(((byte)(150)))));
            this.Exit_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Exit_btn.BackgroundImage")));
            this.Exit_btn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Exit_btn.ButtonText = "X";
            this.Exit_btn.ButtonTextMarginLeft = 0;
            this.Exit_btn.ColorContrastOnClick = 45;
            this.Exit_btn.ColorContrastOnHover = 45;
            this.Exit_btn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.Exit_btn.CustomizableEdges = borderEdges1;
            this.verticalTransition.SetDecoration(this.Exit_btn, BunifuAnimatorNS.DecorationType.None);
            this.Logo_trns.SetDecoration(this.Exit_btn, BunifuAnimatorNS.DecorationType.None);
            this.BigLogo_trns.SetDecoration(this.Exit_btn, BunifuAnimatorNS.DecorationType.None);
            this.mbar_animate.SetDecoration(this.Exit_btn, BunifuAnimatorNS.DecorationType.None);
            this.Menu_trns.SetDecoration(this.Exit_btn, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.menue_btn_trns.SetDecoration(this.Exit_btn, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Exit_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Exit_btn.DisabledBorderColor = System.Drawing.Color.White;
            this.Exit_btn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(43)))), ((int)(((byte)(129)))));
            this.Exit_btn.DisabledForecolor = System.Drawing.Color.White;
            this.Exit_btn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Exit_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_btn.ForeColor = System.Drawing.Color.White;
            this.Exit_btn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Exit_btn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Exit_btn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.Exit_btn.IconMarginLeft = 11;
            this.Exit_btn.IconPadding = 10;
            this.Exit_btn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Exit_btn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Exit_btn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Exit_btn.IconSize = 25;
            this.Exit_btn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(60)))), ((int)(((byte)(230)))));
            this.Exit_btn.IdleBorderRadius = 1;
            this.Exit_btn.IdleBorderThickness = 1;
            this.Exit_btn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(99)))), ((int)(((byte)(150)))));
            this.Exit_btn.IdleIconLeftImage = null;
            this.Exit_btn.IdleIconRightImage = null;
            this.Exit_btn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Exit_btn.IndicateFocus = false;
            this.Exit_btn.Location = new System.Drawing.Point(1279, 23);
            this.Exit_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.OnDisabledState.BorderColor = System.Drawing.Color.White;
            this.Exit_btn.OnDisabledState.BorderRadius = 1;
            this.Exit_btn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Exit_btn.OnDisabledState.BorderThickness = 1;
            this.Exit_btn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(43)))), ((int)(((byte)(129)))));
            this.Exit_btn.OnDisabledState.ForeColor = System.Drawing.Color.White;
            this.Exit_btn.OnDisabledState.IconLeftImage = null;
            this.Exit_btn.OnDisabledState.IconRightImage = null;
            this.Exit_btn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(43)))), ((int)(((byte)(129)))));
            this.Exit_btn.onHoverState.BorderRadius = 1;
            this.Exit_btn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Exit_btn.onHoverState.BorderThickness = 1;
            this.Exit_btn.onHoverState.FillColor = System.Drawing.Color.Navy;
            this.Exit_btn.onHoverState.ForeColor = System.Drawing.Color.Empty;
            this.Exit_btn.onHoverState.IconLeftImage = null;
            this.Exit_btn.onHoverState.IconRightImage = null;
            this.Exit_btn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(60)))), ((int)(((byte)(230)))));
            this.Exit_btn.OnIdleState.BorderRadius = 1;
            this.Exit_btn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Exit_btn.OnIdleState.BorderThickness = 1;
            this.Exit_btn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(99)))), ((int)(((byte)(150)))));
            this.Exit_btn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.Exit_btn.OnIdleState.IconLeftImage = null;
            this.Exit_btn.OnIdleState.IconRightImage = null;
            this.Exit_btn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.Exit_btn.OnPressedState.BorderRadius = 1;
            this.Exit_btn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Exit_btn.OnPressedState.BorderThickness = 1;
            this.Exit_btn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.Exit_btn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.Exit_btn.OnPressedState.IconLeftImage = null;
            this.Exit_btn.OnPressedState.IconRightImage = null;
            this.Exit_btn.Size = new System.Drawing.Size(41, 31);
            this.Exit_btn.TabIndex = 2;
            this.Exit_btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Exit_btn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Exit_btn.TextMarginLeft = 0;
            this.Exit_btn.TextPadding = new System.Windows.Forms.Padding(0);
            this.Exit_btn.UseDefaultRadiusAndThickness = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click_1);
            // 
            // Menu_trns
            // 
            this.Menu_trns.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.HorizSlide;
            this.Menu_trns.Cursor = null;
            animation3.AnimateOnlyDifferences = true;
            animation3.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.BlindCoeff")));
            animation3.LeafCoeff = 0F;
            animation3.MaxTime = 1F;
            animation3.MinTime = 0F;
            animation3.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicCoeff")));
            animation3.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation3.MosaicShift")));
            animation3.MosaicSize = 0;
            animation3.Padding = new System.Windows.Forms.Padding(0);
            animation3.RotateCoeff = 0F;
            animation3.RotateLimit = 0F;
            animation3.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.ScaleCoeff")));
            animation3.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation3.SlideCoeff")));
            animation3.TimeCoeff = 0F;
            animation3.TransparencyCoeff = 0F;
            this.Menu_trns.DefaultAnimation = animation3;
            // 
            // Desktop
            // 
            this.Desktop.AutoScroll = true;
            this.Desktop.AutoSize = true;
            this.Desktop.Controls.Add(this.welcom_lbl);
            this.verticalTransition.SetDecoration(this.Desktop, BunifuAnimatorNS.DecorationType.None);
            this.mbar_animate.SetDecoration(this.Desktop, BunifuAnimatorNS.DecorationType.None);
            this.BigLogo_trns.SetDecoration(this.Desktop, BunifuAnimatorNS.DecorationType.None);
            this.Menu_trns.SetDecoration(this.Desktop, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.menue_btn_trns.SetDecoration(this.Desktop, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.Logo_trns.SetDecoration(this.Desktop, BunifuAnimatorNS.DecorationType.None);
            this.Desktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Desktop.Location = new System.Drawing.Point(59, 70);
            this.Desktop.Name = "Desktop";
            this.Desktop.Size = new System.Drawing.Size(1274, 668);
            this.Desktop.TabIndex = 2;
            this.Desktop.Paint += new System.Windows.Forms.PaintEventHandler(this.Desktop_Paint);
            // 
            // Logo_trns
            // 
            this.Logo_trns.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.Logo_trns.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 2F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 20;
            animation2.Padding = new System.Windows.Forms.Padding(30);
            animation2.RotateCoeff = 5F;
            animation2.RotateLimit = 10F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 1F;
            animation2.TransparencyCoeff = 0F;
            this.Logo_trns.DefaultAnimation = animation2;
            this.Logo_trns.MaxAnimationTime = 3000;
            this.Logo_trns.TimeStep = 0.01F;
            // 
            // mbar_animate
            // 
            this.mbar_animate.AnimationType = BunifuAnimatorNS.AnimationType.HorizBlind;
            this.mbar_animate.Cursor = null;
            animation5.AnimateOnlyDifferences = true;
            animation5.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.BlindCoeff")));
            animation5.LeafCoeff = 0F;
            animation5.MaxTime = 1F;
            animation5.MinTime = 0F;
            animation5.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicCoeff")));
            animation5.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicShift")));
            animation5.MosaicSize = 0;
            animation5.Padding = new System.Windows.Forms.Padding(0);
            animation5.RotateCoeff = 0F;
            animation5.RotateLimit = 0F;
            animation5.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.ScaleCoeff")));
            animation5.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.SlideCoeff")));
            animation5.TimeCoeff = 0F;
            animation5.TransparencyCoeff = 0F;
            this.mbar_animate.DefaultAnimation = animation5;
            this.mbar_animate.TimeStep = 0.01F;
            // 
            // BigLogo_trns
            // 
            this.BigLogo_trns.AnimationType = BunifuAnimatorNS.AnimationType.Mosaic;
            this.BigLogo_trns.Cursor = null;
            animation4.AnimateOnlyDifferences = true;
            animation4.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.BlindCoeff")));
            animation4.LeafCoeff = 0F;
            animation4.MaxTime = 1F;
            animation4.MinTime = 0F;
            animation4.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicCoeff")));
            animation4.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation4.MosaicShift")));
            animation4.MosaicSize = 20;
            animation4.Padding = new System.Windows.Forms.Padding(30);
            animation4.RotateCoeff = 0F;
            animation4.RotateLimit = 0F;
            animation4.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.ScaleCoeff")));
            animation4.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation4.SlideCoeff")));
            animation4.TimeCoeff = 0F;
            animation4.TransparencyCoeff = 0F;
            this.BigLogo_trns.DefaultAnimation = animation4;
            this.BigLogo_trns.MaxAnimationTime = 3000;
            this.BigLogo_trns.TimeStep = 0.03F;
            // 
            // menue_btn_trns
            // 
            this.menue_btn_trns.AnimationType = Bunifu.UI.WinForms.BunifuAnimatorNS.AnimationType.HorizBlind;
            this.menue_btn_trns.Cursor = null;
            animation6.AnimateOnlyDifferences = true;
            animation6.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.BlindCoeff")));
            animation6.LeafCoeff = 0F;
            animation6.MaxTime = 1F;
            animation6.MinTime = 0F;
            animation6.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicCoeff")));
            animation6.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicShift")));
            animation6.MosaicSize = 0;
            animation6.Padding = new System.Windows.Forms.Padding(0);
            animation6.RotateCoeff = 0F;
            animation6.RotateLimit = 0F;
            animation6.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.ScaleCoeff")));
            animation6.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.SlideCoeff")));
            animation6.TimeCoeff = 0F;
            animation6.TransparencyCoeff = 0F;
            this.menue_btn_trns.DefaultAnimation = animation6;
            // 
            // verticalTransition
            // 
            this.verticalTransition.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.verticalTransition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.verticalTransition.DefaultAnimation = animation1;
            this.verticalTransition.MaxAnimationTime = 3000;
            this.verticalTransition.TimeStep = 0.01F;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 50;
            this.bunifuElipse2.TargetControl = this;
            // 
            // welcom_lbl
            // 
            this.welcom_lbl.AutoSize = true;
            this.verticalTransition.SetDecoration(this.welcom_lbl, BunifuAnimatorNS.DecorationType.None);
            this.Logo_trns.SetDecoration(this.welcom_lbl, BunifuAnimatorNS.DecorationType.None);
            this.Menu_trns.SetDecoration(this.welcom_lbl, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.BigLogo_trns.SetDecoration(this.welcom_lbl, BunifuAnimatorNS.DecorationType.None);
            this.mbar_animate.SetDecoration(this.welcom_lbl, BunifuAnimatorNS.DecorationType.None);
            this.menue_btn_trns.SetDecoration(this.welcom_lbl, Bunifu.UI.WinForms.BunifuTransition.DecorationType.None);
            this.welcom_lbl.Font = new System.Drawing.Font("Microsoft JhengHei UI", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcom_lbl.Location = new System.Drawing.Point(518, 141);
            this.welcom_lbl.Name = "welcom_lbl";
            this.welcom_lbl.Size = new System.Drawing.Size(87, 61);
            this.welcom_lbl.TabIndex = 0;
            this.welcom_lbl.Text = "Hi,\r\n";
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
            this.Load += new System.EventHandler(this.MessengerMainForm_Load);
            this.PanelMenu.ResumeLayout(false);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.PanelUp.ResumeLayout(false);
            this.PanelUp.PerformLayout();
            this.Desktop.ResumeLayout(false);
            this.Desktop.PerformLayout();
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
        private System.Windows.Forms.Label welcom_lbl;
    }
}


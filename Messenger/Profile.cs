using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Server;
using Sliding_Application;

namespace MessengerApp
{
    public partial class ProfileForm : Form
    {
        
        User profileUser;
        public ProfileForm(User user)
        {
            InitializeComponent();
            profileUser = user;
            family_txt.Text = profileUser.Family;
            name_txt.Text = profileUser.Name;
            usrName_lbl.Text = profileUser.UserName;
        }
        public ProfileForm(Group gp)
        {
            usrName_lbl.Text = "User Name: "+ gp.UserName;
            name_txt.Text = "Name: "+gp.Name;
            family_txt.Text = "Owner: "+gp.GroupOwner.UserName;
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            Color fcolor = MessengerGUI.ForColor;
            Color bcolor = MessengerGUI.ThemeColor;
           
            this.BackColor = bcolor;
            this.ForeColor = fcolor;


            usrName_lbl.ForeColor = fcolor;
            usrName_lbl.BackColor = bcolor;


            name_txt.ForeColor = fcolor;
            name_txt.BackColor = bcolor;
            name_txt.ReadOnly = true;

            family_txt.ForeColor = fcolor;
            family_txt.BackColor = bcolor;
            family_txt.ReadOnly = true;


            label1.ForeColor = fcolor;
            label1.BackColor = bcolor;

            label2.ForeColor = fcolor;
            label2.BackColor = bcolor;

            

        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            exit_profile_btn.BackColor = Color.Maroon;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            exit_profile_btn.BackColor = Color.Transparent;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void AddListBox1(List<string> items)
        {
            foreach (var item in items)
            {
                listBox1.Items.Add(item);
            }
        }
        public void AddListBox2(List<string> items)
        {
            foreach (var item in items)
            {
                listBox2.Items.Add(item);
            }
        }
        public void NameLabels(string lbl1, string lbl2)
        {
            label1.Text = lbl1;
            label2.Text = lbl2;
        }
    }
}

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
        Group proGp;
        User profileUser;
        public ProfileForm(User user)
        {
            InitializeComponent();
            profileUser = user;
            family_txt.Text ="Family: "+ profileUser.Family;
            name_txt.Text = "Name: " + profileUser.Name;
            usrName_lbl.Text = "User Name: " + profileUser.UserName;
        }
        public ProfileForm(Group gp)
        {
            proGp = gp;
            usrName_lbl.Text = "User Name: "+ proGp.UserName;
            name_txt.Text = "Name: "+proGp.Name;
            family_txt.Text = "Owner: "+proGp.GroupOwner.UserName;
           if(gp.GroupOwner.UserName == Manager.Owner.UserName)
            {
                adAdmin_btn.Visible = true;
                remoneAdmin_btn.Visible = true;
            }
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

        private void adAdmin_btn_Click(object sender, EventArgs e)
        {
            IClientManager manager = new Manager();
            Header h = new Header();
            h.Command = "add group admin";
            h.Sender = (string)listBox1.SelectedItem;
            Server.Message msg = new Server.Message(h);
            msg.MessageContent = usrName_lbl.Text;
            manager.ExecuteCommand(msg);
        }

        private void remoneAdmin_btn_Click(object sender, EventArgs e)
        {
            IClientManager manager = new Manager();
            Header h = new Header();
            h.Command = "remove group admin";
            h.Sender = (string)listBox2.SelectedItem;
            Server.Message msg = new Server.Message(h);
            msg.MessageContent = usrName_lbl.Text;
            manager.ExecuteCommand(msg);
        }
    }
}

using MessengerApp;
using Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;


namespace Sliding_Application
{
    public partial class ChatsMainForm : Form
    {
        Chat chat = new Chat();
        Server.ServerUser ownerUser;
        IChatsManager chatManager;
        public ChatsMainForm(ServerUser owner, IChatsManager chatmanager)
        {
            InitializeComponent();
           
            ownerUser = owner;
            chatManager = chatmanager;
            chatManager.ShowMembers(ownerUser, this);
        }

        private void messages_pnl_ControlAdded(object sender, ControlEventArgs e)
        {
            Label control = (Label)sender;

        }
        public void AddMember(BunifuFlatButton button)
        {
            
            button.Dock = DockStyle.Top;
            button.Click += MemberClicked;
            button.DoubleClick += ShowProfile;

            button.Normalcolor = MessengerGUI.ThemeColor;
            button.ForeColor = MessengerGUI.ForColor;
            accountsName_pnl.Controls.Add(button);
        }

        private void MemberClicked(object sender, EventArgs e)
        {
            chatManager.ShowMessages(ownerUser, ownerUser.UserName, ((BunifuFlatButton)sender).Name, this);
        }

        private void ShowProfile(object sender, EventArgs e)
        {
            chatManager.ShowProfile(ownerUser.FindUser(((BunifuFlatButton)sender).Name));
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}

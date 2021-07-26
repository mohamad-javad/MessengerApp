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
        string command;
        Server.ServerUser ownerUser;
        public ChatsMainForm(Server.Message message)
        {
            InitializeComponent();
            command = message["command"];
            ownerUser = (ServerUser)message.MessageContent;
            switch (command)
            {
                case "personal":
                    ShowContacts(ownerUser);
                    break;
                default:
                    break;
            }
           
        }

        private void messages_pnl_ControlAdded(object sender, ControlEventArgs e)
        {
            Label control = (Label)sender;

        }

        private void ShowContacts(ServerUser owner)
        {
            accountsName_pnl.Controls.Clear();
            if (owner != null)
            {
                foreach (var item in owner.contacts)
                {
                    BunifuFlatButton button = new BunifuFlatButton();
                    button.Name = owner.UserName;
                    button.Text = owner.Name;
                    button.Dock = DockStyle.Top;
                    button.BackColor = MessengerGUI.ThemeColor;
                    button.ForeColor = MessengerGUI.ForColor;

                    button.Click += ShowPersonalMessages;
                    button.DoubleClick += ShowProfile;
                    this.accountsName_pnl.Controls.Add(button);
                }
            }
        }

        private void ShowProfile(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ShowPersonalMessages(object sender, EventArgs e)
        {
            messages_pnl.Controls.Clear();
            BunifuFlatButton button = (BunifuFlatButton)sender;
            foreach (Server.Message msg in ownerUser.Messages)
            {
                Label label = new Label();
                label.Dock = DockStyle.Bottom;
                if (msg["sender"] == button.Name)
                {
                    label.Text = msg.ToString();

                    label.Location = new Point(0, messages_pnl.Height- label.Height);
                }
                if (msg["reciever"] == button.Name)
                {
                    label.Text = msg.ToString();

                    label.Location = new Point(messages_pnl.Width - label.Width, messages_pnl.Height - label.Height);
                }
                label.SendToBack();
                messages_pnl.Controls.Add(label);
                
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AddContact newContact = new AddContact(command);
            newContact.ShowDialog();


        }
    }
}

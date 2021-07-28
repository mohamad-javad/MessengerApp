using MessengerApp;
using Server;
using System;
using System.Windows.Forms;
using Bunifu.Framework.UI;
using System.Drawing;

namespace Sliding_Application
{
    public enum MessageSide { Left, Right };
    public partial class ChatsMainForm : Form
    {
        Chat chat = new Chat();
        Server.ServerUser ownerUser;
        IChatsManager chatManager;
        IClientManager manager;
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
            BunifuFlatButton btn = (BunifuFlatButton)sender;
            userName_lbl.Text = btn.Name;
            name_lbl.Text = btn.Text;
            statepanel.Click += ShowProfile;
            chatManager.ShowMessages(ownerUser, ownerUser.UserName, btn.Name, this);

            
        }

        private void ShowProfile(object sender, EventArgs e)
        {
            chatManager.ShowProfile((((BunifuFlatButton)sender).Name.MakeDisplayable(ownerUser)));
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void send_btn_Click(object sender, EventArgs e)
        {
            manager = new Manager();
            Header header = new Header() { Command = "add message", Sender = ownerUser.UserName, Reciever = userName_lbl.Text, TypeOfMessage ="text"};
            Server.Message message = new Server.Message(header);
            message.MessageContent = msg_txt.Text;
        }
        public void AddTextMessage(string message, MessageSide side)
        {
            Label label = new Label();
            label.Dock = DockStyle.Bottom;
            label.Text = message.ToString();
            label.ForeColor = MessengerGUI.MessageForeColor;
            label.BackColor = MessengerGUI.MessageBackColor;
            
            switch (side)
            {
                case MessageSide.Left:
                    label.Location = new Point(0, this.messages_pnl.Height - label.Height);
                    break;
                case MessageSide.Right:
                    label.Location = new Point(this.messages_pnl.Width - label.Width, this.messages_pnl.Height - label.Height);
                    break;
                default:
                    break;
            }
            label.SendToBack();
            messages_pnl.Controls.Add(label);
        }
    }
}

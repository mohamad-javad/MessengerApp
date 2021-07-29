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
        bool isMemberSelected;
        Server.ServerUser ownerUser;
        IChatsManager chatManager;
        IClientManager manager;
        public ChatsMainForm(IChatsManager chatmanager)
        {
            InitializeComponent();
            send_btn.Enabled = false;
            ownerUser = Manager.Owner;
            chatManager = chatmanager;
            
            msg_txt.TextChanged += EnableSendBtn;
            isMemberSelected = false;
            if(chatmanager is GroupChatManager)
            {
                addContact.Visible = true;
            }

        }

        private void EnableSendBtn(object sender, EventArgs e)
        {
            if (msg_txt.Text.Length == 0)
            {
                try
                {
                    send_btn.Enabled = false;

                }
                catch { }
            }
            else
            {
                send_btn.Enabled = true;
            }
        }

        private void messages_pnl_ControlAdded(object sender, ControlEventArgs e)
        {

        }
        public void AddMember(BunifuFlatButton button)
        {

            button.Dock = DockStyle.Top;
            button.Click += MemberClicked;


            BeginInvoke((Action)(() =>
            {

                button.Normalcolor = MessengerGUI.MessageBackColor;
                button.ForeColor = MessengerGUI.MessageForeColor;
            }));

            accountsName_pnl.Controls.Add(button);
            pictureBox3.SendToBack();
        }

        private void MemberClicked(object sender, EventArgs e)
        {
            message_gb.Controls.Clear();
            BunifuFlatButton btn = (BunifuFlatButton)sender;
            userName_lbl.Text = btn.Name;
            name_lbl.Text = btn.Text;
            statepanel.Click += ShowProfile;
            chatManager.ShowMessages(ownerUser, ownerUser.UserName, btn.Name, this);
            isMemberSelected = true;
            message_gb.AutoScroll = true;
        }

        private void ShowProfile(object sender, EventArgs e)
        {
            string userName = userName_lbl.Text;
            IDisplayable user = userName.MakeDisplayable(ownerUser);
            chatManager.ShowProfile(user);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            chatManager.AddMember(this);
        }

        private void send_btn_Click(object sender, EventArgs e)
        {
            manager = new Manager();
            Header header = new Header() { Command = "add message", Sender = ownerUser.UserName, Reciever = userName_lbl.Text, TypeOfMessage = "text" };
            Server.Message message = new Server.Message(header);
            message.MessageContent = msg_txt.Text;
            manager.ExecuteCommand(message);
            AddTextMessage(message, MessageSide.Left);
            msg_txt.Text = "";
        }
        public void AddTextMessage(Server.Message message, MessageSide side)
        {
            Label sender = MakeLabel("From:" + message["sender"]);
            sender.ForeColor = MessengerGUI.ForColor;
            sender.BackColor = MessengerGUI.ThemeColor;

            Label msg = MakeLabel(message.ToString());
            msg.ForeColor = MessengerGUI.MessageForeColor;
            msg.BackColor = MessengerGUI.MessageBackColor;

            Label t = MakeLabel(message.CreationDate.ToLongTimeString());
            sender.ForeColor = MessengerGUI.ForColor;
            sender.BackColor = MessengerGUI.ThemeColor;
            Label label = MakeLabel("\n");
            label.ForeColor = MessengerGUI.ForColor;
            label.BackColor = MessengerGUI.ThemeColor;
        }

        private Label MakeLabel(string message)
        {

            Label label = new Label();
            message_gb.Controls.Add(label);
            label.Dock = DockStyle.Bottom;
            label.Text = message;

            label.AutoSize = true;
            label.SendToBack();
            return label;
        }

        private void msg_txt_TextChanged(object sender, EventArgs e)
        {
            if (msg_txt.Text.Length == 0)
            {
                if (send_btn.Enabled || !isMemberSelected)
                    send_btn.Enabled = false;
                else
                {
                    if (!send_btn.Enabled)
                    {
                        send_btn.Enabled = true;
                    }
                }
            }
        }

        private void ChatsMainForm_Load(object sender, EventArgs e)
        {
            Color fore = MessengerGUI.ForColor;
            Color back = MessengerGUI.ThemeColor;
            BeginInvoke((Action)(() =>
            {
                addContact.ForeColor = fore;
                addContact.BackColor = back;
                accountsName_pnl.ForeColor = fore;
                accountsName_pnl.PanelColor2 = back;
                accountsName_pnl.PanelColor = back;
                message_gb.BackColor = back;
                message_gb.ForeColor = fore;
                statepanel.ForeColor = fore;
                statepanel.BackColor = back;
            }));
            chatManager.ShowMembers(ownerUser, this);
        }

        private void addContact_Click(object sender, EventArgs e)
        {
            if (isMemberSelected)
            {
                AddContact add = new AddContact("Add User to Group", "Username: ", "add contact");
                add.ShowDialog();
            }
        }
    }
}

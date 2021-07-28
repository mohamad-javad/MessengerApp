﻿using MessengerApp;
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
        Server.ServerUser ownerUser;
        IChatsManager chatManager;
        IClientManager manager;
        public ChatsMainForm(IChatsManager chatmanager)
        {
            InitializeComponent();
            send_btn.Enabled = false;
            ownerUser = Manager.Owner;
            chatManager = chatmanager;
            chatManager.ShowMembers(ownerUser, this);
            msg_txt.TextChanged += EnableSendBtn;
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
            Label control = (Label)sender;

        }
        public void AddMember(BunifuFlatButton button)
        {
            
            button.Dock = DockStyle.Top;
            button.Click += MemberClicked;


            button.Normalcolor = MessengerGUI.MessageBackColor;
            button.ForeColor = MessengerGUI.MessageForeColor;
            accountsName_pnl.Controls.Add(button);
            pictureBox3.SendToBack();
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
            chatManager.AddMember(this);
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

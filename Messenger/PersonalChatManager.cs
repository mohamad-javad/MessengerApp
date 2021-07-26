using Bunifu.Framework.UI;
using Server;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessengerApp;

namespace Sliding_Application
{
    class PersonalChatManager : IChatsManager
    {
        public void AddMember(ChatsMainForm chatsMainForm)
        {
            AddContact addmember = new AddContact("Add Existing User", "User Name:", "add contact");

            addmember.ShowDialog();

        }

        public void ShowMembers(ServerUser owner, ChatsMainForm chatsMainForm)
        {
            List<User> members = owner.contacts;
            if (members != null)
            {
                foreach (var member in members)
                {
                    BunifuFlatButton button = new BunifuFlatButton();
                    button.Name = member.UserName;
                    button.Text = member.Name;

                    chatsMainForm.AddMember(button);
                }
            }
        }

        public void ShowMessages(ServerUser user, string sender, string reviever, ChatsMainForm chatsMainForm)
        {
            chatsMainForm.Controls.Clear();
            List<Server.Message> messages = user.Messages;
            if (messages == null)
            {
                messages = new List<Server.Message>();
            }
            foreach (Server.Message msg in messages)
            {
                Label label = new Label();
                label.Dock = DockStyle.Bottom;
                if (msg["sender"] == reviever)
                {
                    label.Text = msg.ToString();

                    label.Location = new Point(0, chatsMainForm.messages_pnl.Height - label.Height);
                }
                if (msg["reciever"] == reviever)
                {
                    label.Text = msg.ToString();

                    label.Location = new Point(chatsMainForm.messages_pnl.Width - label.Width, chatsMainForm.messages_pnl.Height - label.Height);
                }
                label.SendToBack();
                chatsMainForm.messages_pnl.Controls.Add(label);
            }

        }

            public void ShowProfile(IDisplayable displayed)
            {
            User user = (User)displayed;
            ProfileForm profile = new ProfileForm(user);
            profile.NameLabels("Common Groups", "Common Channels");
            profile.AddListBox1(Manager.Owner.CommontGroups(user.UserName));
        }
        
    }
}
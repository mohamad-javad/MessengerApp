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
            AddContact addmember = new AddContact("Add Existing User", "Username:", "add contact");

            addmember.ShowDialog();

            chatsMainForm.Refresh();
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

        public void ShowMessages(ServerUser user, string sender, string reciever, ChatsMainForm chatsMainForm)
        {
            
            List<Server.Message> messages = user.Messages;
            if (messages == null)
            {
                messages = new List<Server.Message>();
            }
            foreach (Server.Message msg in messages)
            {
                if (msg.MessageHeader.TypeOfMessage == "text")
                {
                    if (msg["sender"] == sender)
                    {
                        chatsMainForm.AddTextMessage(msg, MessageSide.Left);
                    }
                    else if (msg["sender"] == reciever)
                    {
                        chatsMainForm.AddTextMessage(msg, MessageSide.Right);
                    }
                }
            }

        }

        public void ShowProfile(IDisplayable displayed)
        {
            User user = (User)displayed;
            ProfileForm profile = new ProfileForm(user);
            profile.NameLabels("Common Groups", "Common Channels");
            profile.AddListBox1(Manager.Owner.CommonGroups(user.UserName));
            profile.ShowDialog();
        }

    }
}
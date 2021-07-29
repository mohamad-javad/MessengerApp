﻿using Bunifu.Framework.UI;
using Server;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Sliding_Application
{
    public class GroupChatManager : IChatsManager
    {
        public void AddMember(ChatsMainForm chatsMainForm)
        {
            AddContact addGp = new AddContact("Add Existing Group", "Group Name", "add group");
            addGp.ShowDialog();
            chatsMainForm.Refresh();
        }

        public void ShowMembers(ServerUser owner, ChatsMainForm chatsMainForm)
        {
            List<Group> members = owner.Groups;
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
            Group gp = (Group)user.Groups.Select(n => n).Where(n => n.UserName == reciever).FirstOrDefault();
            List<Server.Message> messages = gp.Messages;
            if (messages == null)
            {
                messages = new List<Server.Message>();
            }
            foreach (Server.Message msg in messages)
            {
                if (msg["msgType"] == "text")
                {
                    if (msg["sender"] == sender)
                    {
                        chatsMainForm.AddTextMessage(msg, MessageSide.Left);
                        
                    }
                    else
                    {
                        chatsMainForm.AddTextMessage(msg, MessageSide.Right);

                        
                    }
                    
                }
            }
        }

        public void ShowProfile(IDisplayable displayed)
        {
            Group gp = (Group)displayed;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
namespace Server
{
    public class ServerManager
    {
        ServerUI sUI;
        List<ServerUser> users;
        DataManager dtManager;
        public ServerManager()
        {
            dtManager = new DataManager();
            users = new List<ServerUser>();
            users = dtManager.GetAllUsers();
            sUI = new ServerUI();
        }
        public MessageClass ExecuteCommand(MessageClass message)
        {
            MessageClass resMessage = new MessageClass(new Header());
            Header header = new Header() { Reciever = message.MessageHeader.Sender };
            switch (message["command"])
            {
                case "new user":
                    ServerUser usr= (ServerUser)message.MessageContent;
                    if (CreateUser(usr))
                    {
                        header.Sender = "Server";
                        header.Command = "register response";
                        header.MessageType = "ServerUser";
                        resMessage = new MessageClass(header);
                        resMessage.MessageContent = usr;
                        try
                        {
                            sUI.StatusChanged($"{usr.UserName} was created");
                        }
                        catch
                        {

                        }
                        
                    }
                    break;
                case "send message":
                    dtManager.AddMessage(message);
                    break; 
                case "give messages":
                    header.Command = "get all user messages";
                    header.Sender = "Server";
                    header.MessageType = "list of messages";
                    resMessage = new MessageClass(header);
                    resMessage.MessageContent = dtManager.GetUserMessages(message["sender"], message["reciever"]);
                    break;
                default:
                    break;
            }
            return resMessage;
        }
        public bool CreateUser(ServerUser user)
        {
            bool result = true;
            foreach (var usr in users)
            {
                if(usr.UserName == user.UserName)
                {
                    result = false;
                    break;
                }

            }
            if (!result)
            {
                return result;
            }
            user.Password = user.Password.Sha_256();
            return dtManager.AddUser(user);

        }


        public bool NewMessage(MessageClass msg)
        {
            return false;
        }
        
    }
}

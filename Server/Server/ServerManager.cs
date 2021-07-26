﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Driver.Linq;


namespace Server
{
    public interface IManager
    {
        Message ExecuteCommand(Message msg);
    }

    public class ServerManager : IManager
    {
        public static List<string> serverStatus;
        static ServerUI sUI;
        static List<ServerUser> users;
        DataManager dtManager;
        static ServerManager()
        {
            sUI = ServerUI.GetForm;
            users = new List<ServerUser>();
        }
        public ServerManager()
        {
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            
            dtManager = new DataManager();
            
            UpdateUsers();

        }
        public static string ServerStatus
        {
            set
            {
                if (serverStatus == null)
                {
                    serverStatus = new List<string>();
                }
                serverStatus.Add(value);
            }
        }
        void UpdateUsers()
        {
            users = dtManager.GetAllUsers();
        }
        public Message ExecuteCommand(Message message)
        {
            Message resmessage = new Message(new Header());
            Header header;
            UpdateUsers();
            switch (message["command"])
            {
                case "new user":
                    ServerUser usr = (ServerUser)(message.MessageContent);
                    header = new Header()
                    {
                        Command = "register user response",
                        Sender = "Server",
                        Reciever = usr.UserName,
                        TypeOfMessage = "ServerUser"
                    };
                    if (CreateUser(usr))
                    {
                        UpdateUsers();

                        resmessage = new Message(header);
                        resmessage.MessageContent = usr;

                        try
                        {
                            sUI.StatusChanged($"{usr.UserName} was created");
                        }
                        catch (System.Exception)
                        {


                        }

                    }
                    else
                    {
                        resmessage = new Message(header);
                        resmessage.MessageContent = "field";
                    }
                    break;


                case "send message":
                    dtManager.AddMessage(message);
                    break;

                case "add contact":
                    string userName = message["sender"];
                    string contactName = (string)message.MessageContent;
                    ServerUser su = dtManager.FindUserName(contactName);
                    if (su != null)
                    {
                        User contact = su.user;
                        UpdateUsers();
                        dtManager.AddContact(userName, contact);
                        header = new Header() { Sender = "Server", Reciever = message["sender"], Command = "add contact res" };
                        resmessage = new Message(header);
                        resmessage.MessageContent = contact;
                    }

                    break;


                case "create group":

                    break;


                case "login user":
                    ServerUser usr1 = (ServerUser)message.MessageContent;
                    header = new Header()
                    {
                        Sender = "Server",
                        Reciever = usr1.UserName,
                        Command = "login response",
                        TypeOfMessage = "ServerUser"
                    };
                    resmessage = new Message(header);
                    ServerUser usr3 = Login(usr1.UserName, usr1.Password);
                    if (usr3 != null)
                    {
                        resmessage.MessageContent = usr3;
                        try
                        {
                            sUI.StatusChanged($"{usr3.UserName} was logedin");
                        }
                        catch (System.Exception)
                        {


                        }
                    }
                    else
                    {
                        resmessage.MessageContent = "no user";
                    }
                    break;


                default:
                    break;
            }
            return resmessage;
        }
        public bool CreateUser(ServerUser user)
        {
            if (dtManager.FindUserName(user.UserName) == null)
                return dtManager.AddUser(user);
            else
                return false;
        }

        private ServerUser Login(string userName, string password)
        {
            ServerUser user = new ServerUser();
            user = dtManager.FindUserName(userName);
            if (user != null)
            {
                if (password == user.Password)
                {
                    return user;
                }
            }
            

            return null;
        }

    }
}

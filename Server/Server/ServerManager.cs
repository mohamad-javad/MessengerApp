using System.Collections.Generic;
using System.Linq;
using MongoDB.Driver;
using MongoDB.Driver.Linq;


namespace Server
{
    public interface IManager
    {
        Message ExecuteCommand(Message msg, string ipPort);
    }

    public class ServerManager : IManager
    {
        ServerConnectionManager svconnectioManager;
        ServerUI sUI;
        List<ServerUser> users;
        DataManager dtManager;
        public ServerManager()
        {
            sUI = new ServerUI();
            dtManager = new DataManager();
            users = new List<ServerUser>();
            UpdateUsers();

        }
        void UpdateUsers()
        {
            this.users = dtManager.GetAllUsers();
        }
        public Message ExecuteCommand(Message message, string ipPort)
        {
            Message resmessage;
            Header header;
            UpdateUsers();
            switch (message.MsgHeader.Command)
            {
                case "new user":
                    ServerUser usr = (ServerUser)(message.MsgContent);
                    
                    if (CreateUser(usr))
                    {
                        UpdateUsers();
                        header = new Header()
                        {
                            Command = "register was succesfull",
                            Sender = "Server",
                            Reciever = usr.UserName,
                            TypeOfMessage = "ServerUser"
                        };
                        resmessage = new Message(header);
                        resmessage.MsgContent = usr;

                        

                        sUI.StatusChanged($"{usr.UserName} was created");



                    }
                    break;

                case "send text message":

                    Message msg = new Message(new Header()
                    {
                        Sender = args[0],
                        Reciever = args[1],
                        TypeOfMessage = "string"
                    });

                    msg.MsgContent = args[2];
                    dtManager.AddMessage(msg);
                    break;


                case "get messages":
                    string messages = dtManager.GetUserMessages(args[0], args[1]);
                    return messages;

                case "add contact":
                    string userName = args[0];
                    string[] contact = args.Skip(1).ToArray();
                    dtManager.AddContact(userName, contact);
                    UpdateUsers();
                    break;


                case "get contacts":
                    string usrName = args[0];
                    string contacts = dtManager.GetUserContacts(usrName);
                    return contacts;


                case "create group":
                    break;

                case "login":
                    ServerUser usr1 = Login(args[0], args[1]);

                    if (usr1 != null)
                    {
                        string outMsg = $"loginres#success#{usr1._id}#{usr1.Name}#{usr1.Family}#{usr1.UserName}#{usr1.Password}";

                        return outMsg;
                    }

                    break;


                default:

                    break;
            }
            return "";

        }
        public bool CreateUser(ServerUser user)
        {
            UpdateUsers();
            bool result = true;
            foreach (var usr in users)
            {
                if (usr.UserName == user.UserName)
                {
                    result = false;
                    break;
                }

            }
            if (!result)
            {
                return result;
            }
            return dtManager.AddUser(user);

        }


        public bool NewMessage(Message msg)
        {
            return false;
        }

        private ServerUser Login(string userName, string password)
        {
            foreach (var user in users)
            {
                if (user.UserName == userName)
                {
                    if (password == user.Password)
                    {
                        return user;
                    }
                }
            }
            return null;
        }

        public object ExecuteCommand(string command, object args)
        {
            throw new System.NotImplementedException();
        }
    }
}

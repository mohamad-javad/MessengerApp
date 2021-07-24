using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Driver.Linq;


namespace Server
{
    public interface IManager
    {
        Task<Message> ExecuteCommand(Message msg);
    }

    public class ServerManager : IManager
    {
        ServerUI sUI;
        List<ServerUser> users;
        DataManager dtManager;
        public ServerManager()
        {
            sUI = ServerUI.GetForm;
            dtManager = new DataManager();
            users = new List<ServerUser>();
            UpdateUsers();

        }
        void UpdateUsers()
        {
            this.users = dtManager.GetAllUsers();
        }
        public async Task<Message> ExecuteCommand(Message message)
        {
            Message resmessage = new Message(new Header());
            Header header;
            UpdateUsers();
            switch (message.MsgHeader.Command)
            {
                case "new user":
                    ServerUser usr = (ServerUser)(message.MsgContent);
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
                        resmessage.MsgContent = usr;

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
                        resmessage.MsgContent = "field";
                    }
                    break;


                case "send message":
                    dtManager.AddMessage(message);
                    break;


                case "get messages":
                    string srcUserName = message.MsgHeader.Sender,
                        destUserName = message.MsgHeader.Reciever;

                    header = new Header()
                    {
                        Sender = srcUserName,
                        Reciever = destUserName,
                        Command = "all user messages",
                        TypeOfMessage = "list of messages"
                    };
                    resmessage = new Message(header);
                    Task<List<Message>> tskMsg = dtManager.GetUserMessages(srcUserName, destUserName);
                    List<Message> messages = await tskMsg;
                    resmessage.MsgContent = messages;
                    break;


                case "add contact":
                    string userName = message.MsgHeader.Sender;
                    List<string> contact = (List<string>)message.MsgContent;
                    dtManager.AddContact(userName, contact);
                    UpdateUsers();
                    break;


                case "get contacts":
                    string usrName = message.MsgHeader.Sender;
                    List<string> contacts = dtManager.GetUserContacts(usrName);

                    header = new Header()
                    {
                        Sender = "Server",
                        Command = "all user contacts",
                        Reciever = usrName
                    };
                    resmessage = new Message(header);
                    resmessage.MsgContent = contacts;
                    break;


                case "create group":

                    break;


                case "login user":
                    ServerUser usr1 = (ServerUser)message.MsgContent;
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
                        resmessage.MsgContent = usr3;
                    }
                    else
                    {
                        resmessage.MsgContent = "no user";
                    }
                    break;


                default:
                    break;
            }
            return resmessage;
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
    }
}

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


                case "get messages":
                    string srcUserName = message["sender"],
                        destUserName = message["reciever"];

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
                    resmessage.MessageContent = messages;
                    break;


                case "add contact":
                    string userName = message["sender"];
                    List<User> contact = (List<User>)message.MessageContent;
                    dtManager.AddContact(userName, contact);
                    UpdateUsers();
                    break;


                case "get contacts":
                    string usrName = message["sender"];
                    List<User> contacts = dtManager.GetUserContacts(usrName);

                    header = new Header()
                    {
                        Sender = "Server",
                        Command = "all user contacts",
                        Reciever = usrName
                    };
                    resmessage = new Message(header);
                    resmessage.MessageContent = contacts;
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

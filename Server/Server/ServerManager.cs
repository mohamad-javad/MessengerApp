using System.Collections.Generic;
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
        static List<Group> groups;
        static Dictionary<string, string> usernameCollection;
        DataManager dtManager;
        static ServerManager()
        {
            sUI = ServerUI.GetForm;
            users = new List<ServerUser>();
            groups = new List<Group>();
            usernameCollection = new Dictionary<string, string>();
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
            groups = dtManager.GetAllGroups();
            AddToUserColleciton();

        }
        void AddToUserColleciton()
        {
            usernameCollection = new Dictionary<string, string>();
            foreach (var user in users)
            {
                
                usernameCollection.Add(user.UserName, "user");

            }
            foreach (var gp in groups)
            {
                usernameCollection.Add(gp.UserName, "group");
            }
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
                    if(usernameCollection.ContainsKey(message["reciever"]))
                    {
                        switch (usernameCollection[message["reciever"]])
                        {
                            case "user":
                                dtManager.AddPersonalMessage(message);
                                User u = users.Select(n => n.user).Where(n => n.UserName == message["sender"]).FirstOrDefault();

                                dtManager.AddContact(message["reciever"], u);
                                break;
                            case "group":
                                dtManager.AddGroupMessage(message);
                                dtManager.AddGroup(message["reciever"], message["sender"]);
                                break;
                        }
                       
                    }
                    resmessage = RefreshUser(message["sender"]);
                    
                    break;

                case "add contact":
                    string userName = message["sender"];
                    string contactName = (string)message.MessageContent;
                    if (usernameCollection.ContainsKey(contactName))
                    {
                        switch (usernameCollection[contactName])
                        {
                            case "user":
                                ServerUser su = dtManager.FindUserName(contactName);
                                dtManager.AddContact(message["sender"], su.user);
                                break;
                            case "group":
                                dtManager.AddGroup(message["sender"], (string)message.MessageContent);
                                break;
                        }
                       
                    }
                    

                    resmessage = RefreshUser(message["sender"]);
                    break;


                case "create group":
                    dtManager.CreateGroup(message["sender"],(Group)message.MessageContent);
                    resmessage = RefreshUser(message["sender"]);
                    break;


                case "add group admin":
                    dtManager.AddGroupAdmin(message["sender"], (string)message.MessageContent);
                    resmessage = RefreshUser(message["sender"]);
                    break;

                case "remove group admin":
                    dtManager.RemoveGroupAdmin(message["sender"], (string)message.MessageContent);
                    resmessage = RefreshUser(message["sender"]);
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
                        usr3.Groups = dtManager.CollectGroups(usr3);
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

        Message RefreshUser(string username)
        {
            Message resmessage;
            Header header;
            UpdateUsers();
            header = new Header();
            header.Command = "refresh user";
            header.Reciever =username;
            header.Sender = "Server";
            resmessage = new Message(header);
            resmessage.MessageHeader = header;
            ServerUser user = dtManager.FindUserName(username);
            user.Groups = dtManager.CollectGroups(user);
            resmessage.MessageContent = user;

            return resmessage;
        }

    }
}

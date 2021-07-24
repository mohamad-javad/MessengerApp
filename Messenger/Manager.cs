using Server;
using Sliding_Application;


namespace MessengerApp
{
    public class Manager
    {
        public static ServerUser Owner { get; set; }
        public static Manager manager;
        static Manager()
        {
            manager = new Manager();
        }
        public void ExecuteCommand(Message message)
        {
            
            ServerUser usr;
            
            Header header;
            Message CMessage = new Message(header);

            switch (message["command"])
            {
                case "register user response":
                    if (message["msgType"] == "ServerUser")
                    {
                        Owner = (ServerUser)message.MessageContent;
                        manager.ShowMain();
                        LoginUser();
                    }
                    else
                    {
                        manager.ShowRegistratio();
                        manager.AddError("this user name exist", "register");

                    }

                    break;

                case "register user":
                    usr = (ServerUser)message.MessageContent;
                    header = new Header()
                    {
                        Sender = usr.UserName,
                        Reciever = "Server",
                        Command = "new user"
                    };
                    CMessage = new Message(header);
                    CMessage.MessageContent = usr;

                    break;


                case "get user messages":

                    break;


                case "all user messages":
                    break;


                case "get user Contacts":
                    break;


                case "all user contacts":
                    break;


                case "login user":
                    header = message.MessageHeader;
                    CMessage = new Message(header);
                    CMessage.MessageContent = message.MessageContent;

                    break;


                case "login response":
                    if (message["msgType"] == "ServerUser")
                    {
                        Owner = (ServerUser)message.MessageContent;
                        LoginUser();
                    }
                    else
                    {
                        manager.ShowLogin();
                        manager.AddError("user name or password are wrong!", "login");
                    }

                    break;

                case "register":
                    manager.ShowRegistratio();
                    break;
                case "login":
                    manager.ShowLogin();
                    break;
                case "upload forms":
                    manager.UploadForms((MessengerMainForm)message.MessageContent);
                    break;

                default:
                    break;
            }
            Client.SendToServer(CMessage);
        }

        private void LoginUser()
        {
            Owner.Name.SayHi();
            manager.ShowMain();
        }
    }
}

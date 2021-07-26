using Server;
using Sliding_Application;


namespace MessengerApp
{
    public class Manager
    {
        public static ServerUser Owner { get; private set; }
        

        public void ExecuteCommand(Message message)
        {

            Manager manager = new Manager();
            ServerUser usr;
            
            Header header;
            Message CMessage = new Message(header);

            switch (message["command"])
            {
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


                case "add contact":
                    header.Command = "add contact";
                    header.Sender = Owner.UserName;
                    header.Reciever = "Server";
                    CMessage = new Message(header);
                    CMessage.MessageContent = message.MessageContent;
                    break;


                case "login user":
                    header = message.MessageHeader;
                    CMessage = new Message(header);
                    CMessage.MessageContent = message.MessageContent;

                    break;

              

                default:
                    break;
            }
            Client.SendToServer(CMessage);
        }
        public void ExecuteAnswer(Message message)
        {
            Manager manager = new Manager();

            ServerUser usr;

            Header header;
            Message CMessage = new Message(header);

            switch (message["command"])
            {
                case "register user response":
                    if (message["msgType"] == "ServerUser")
                    {
                        LoginUser((ServerUser)message.MessageContent);
                        System.Windows.Forms.MessageBox.Show("showin mainform");
                    }
                    else
                    {
                        manager.ShowRegistration();
                        manager.AddError("this user name exist", "register");

                    }

                    break;

                case "login response":
                    manager.HideLogin();
                    if (message["msgType"] == "ServerUser")
                    {
                        LoginUser((ServerUser)message.MessageContent);
                    }
                    else
                    {
                        manager.ShowLogin();
                        manager.AddError("user name or password are wrong!", "login");
                    }

                    break;
            }
        }

        private void LoginUser(ServerUser user)
        {
            Manager manager = new Manager();

            Owner = user;
            manager.ShowMain();
            
            
            
        }
        public void ManageForms(Message message)
        {
            Manager manager = new Manager();

            switch (message["command"])
            {
                case "register":
                    manager.ShowRegistration();
                    break;
                case "login":
                    manager.ShowLogin();
                    break;

            }
        }
    }
}

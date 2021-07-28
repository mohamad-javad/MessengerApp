using Server;
using Sliding_Application;


namespace MessengerApp
{
    public interface IClientManager
    {
        void ExecuteCommand(Message message);
    }

    public class Manager:IClientManager
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


                case "add group":
                    header.Sender = Owner.UserName;
                    header.Reciever = "Server";
                    header.Command = "add group";
                    CMessage.MessageContent = message.MessageContent;
                    CMessage.MessageHeader = header;
                    break;


                case "add message":
                    header.Sender = Owner.UserName;
                    header.Reciever = message["reciever"];
                    header.Command = "send message";
                    header.TypeOfMessage = message["msgType"];
                    CMessage.MessageHeader = header;
                    CMessage.MessageContent = message.MessageContent;
                    break;


                case "create group":
                    header.Sender = Owner.UserName;
                    header.Reciever = "Server";
                    header.Command = "create group";
                    CMessage.MessageContent = message.MessageContent;
                    CMessage.MessageHeader = header;
                    break;

                case "add group admin":
                    header.Sender = Owner.UserName;
                    header.Reciever = "Server";
                    header.Command = "add group admin";
                    CMessage.MessageContent = message.MessageContent;
                    CMessage.MessageHeader = header;
                    break;

                case "remove group admin":
                    header.Sender = Owner.UserName;
                    header.Reciever = "Server";
                    header.Command = "remove group admin";
                    CMessage.MessageContent = message.MessageContent;
                    CMessage.MessageHeader = header;
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
                    manager.HideRegistration();
                    if (message.MessageContent is ServerUser)
                    {
                        LoginUser((ServerUser)message.MessageContent);
                       
                    }
                    else
                    {
                        manager.ShowRegistration();
                        manager.AddError("this user name exist", "register");

                    }

                    break;

                case "login response":
                    manager.HideLogin();
                    if (message.MessageContent is ServerUser)
                    {
                        LoginUser((ServerUser)message.MessageContent);
                    }
                    else
                    {
                        manager.ShowLogin();
                        manager.AddError("user name or password are wrong!", "login");
                    }
                    break;


                case "refresh user":
                    Owner = (ServerUser)message.MessageContent;
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

using Server;
using Sliding_Application;


namespace MessengerApp
{
    class Manager
    {
        public ServerUser Owner { get; set; }
        public static MessengerMainForm mainClientForm { get; set; }
        public static MessengerMainForm CurrentMessengerForm { get; set; }
        public static RegistrationForm registeratioForm { get; set; }
        public static LoginForm loginForm { get; set; }

        public void ExecuteCommand(Message message)
        {

            ServerUser usr;
            string command = message.MsgHeader.Command;
            Header header;
            Message CMessage = new Message(header);

            switch (command)
            {
                case "register user response":
                    if (message.MsgHeader.TypeOfMessage == "ServerUser")
                    {
                        Owner = (ServerUser)message.MsgContent;

                        LoginUser();
                    }
                    else
                    {
                        registeratioForm.Hide();
                        registeratioForm.ShowDialog(CurrentMessengerForm);
                        registeratioForm.AddError("this user name is existed");

                    }
                    break;

                case "register user":
                    usr = (ServerUser)message.MsgContent;
                    header = new Header()
                    {
                        Sender = usr.UserName,
                        Reciever = "Server",
                        Command = "new user"
                    };
                    CMessage = new Message(header);
                    CMessage.MsgContent = usr;

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
                    header = message.MsgHeader;
                    CMessage = new Message(header);
                    CMessage.MsgContent = message.MsgContent;

                    break;


                case "login response":
                    if (message.MsgHeader.TypeOfMessage == "ServerUser")
                    {
                        Owner = (ServerUser)message.MsgContent;
                        LoginUser();
                    }
                    else
                    {
                        loginForm.Hide();
                        loginForm.ShowDialog();
                        loginForm.AddError("user name or password are wrong!");

                    }
                    break;


                default:
                    break;
            }
            Client.SendToServer(CMessage);
        }

        private void LoginUser()
        {

            try
            {
                CurrentMessengerForm.SayHi(Owner.Name);
                CurrentMessengerForm.ShowDialog();
            }
            catch { }
            try
            {
                registeratioForm.Close();
            }
            catch { }

            try
            {
                loginForm.Close();
            }
            catch { }
        }
    }
}

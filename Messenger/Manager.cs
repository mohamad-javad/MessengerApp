using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server;
namespace MessengerApp
{
    class Manager
    {
        public ServerUser Owner { get; set; }
        public static MessengerMainForm mainClientForm { get; set; }
        Client client;

        public async void ExecuteCommand(Message message)
        {
            ServerUser usr;
            string command = message.MsgHeader.Command;
            Header header;
            Message CMessage = new Message(header);

            switch (command)
            {
                case "register user response":
                    if ((string)message.MsgContent == "successfull")
                    {
                        LoginUser();
                        
                    }
                    break;

                case "register user":
                    usr = (ServerUser)message.MsgContent;
                    Header hewader = new Header()
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
                    break;


                case "login response":
                    break;



                default:
                    break;
            }
            client = new Client();
            client.SendToServer(CMessage);
        }

        private void LoginUser()
        {

        }
    }
}

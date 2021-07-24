using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
namespace Server
{
    public class ServerManager
    {
        ServerUI sUI;
        List<ServerUser> users;
        DataManager dtManager;
        public ServerManager()
        {
            dtManager = new DataManager();
            users = new List<ServerUser>();
            users = dtManager.GetAllUsers();
            sUI = new ServerUI();
        }
        public string ExecuteCommand(MessageClass message)
        {
            switch (command)
            {
                case "new user":
                    ServerUser usr= new ServerUser();
                    usr.Name = args[0];
                    usr.Family = args[1];
                    usr.UserName = args[2];
                    usr.Password = args[3];
                    if (CreateUser(usr))
                    {
                        sUI.StatusChanged($"{usr.UserName} was created");
                    }
                    break;
                case "send message":
                    Message msg = new Message();
                    msg.Sender = args[0];
                    msg.Reciever = args[1];
                    msg.MsgText = args[2];
                    dtManager.AddMessage(msg);
                    break; 
                case "give messages":
                    return dtManager.GetUserMessages(args[0], args[1]);

                default:
                    break;
            }
            return "";
        }
        public bool CreateUser(ServerUser user)
        {
            bool result = true;
            foreach (var usr in users)
            {
                if(usr.UserName == user.UserName)
                {
                    result = false;
                    break;
                }

            }
            if (!result)
            {
                return result;
            }
            user.Password = user.Password.Sha_256();
            return dtManager.AddUser(user);

        }


        public bool NewMessage(Message msg)
        {
            return false;
        }
        
    }
}

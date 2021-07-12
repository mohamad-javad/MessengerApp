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
        List<ServerUser> users;
        DataManager dtManager;
        public ServerManager()
        {
            dtManager = new DataManager();
            users = new List<ServerUser>();
            UploadUsers();
        }

        public void UploadUsers()
        {
            users = dtManager.GetUsers();
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
        
    }
}

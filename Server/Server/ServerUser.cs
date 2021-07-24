using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    [Serializable]
    public class ServerUser
    {
        public ObjectId _id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public List<User> contacts;
    }


    [Serializable]
    public class User
    {
        public ObjectId _id { get; set; }
        public string  Name { get; set; }
        public string  Family { get; set; }
        public string  Username { get; set; }

    }
}

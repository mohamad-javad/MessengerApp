using MongoDB.Bson;
using Server;
using System;
using System.Collections.Generic;

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
        public List<User> contacts { get; set; }
        public List<Message> Messages { get; set; }
        public List<Group> Groups { get; set; }
        
    }


    [Serializable]
    public class User
    {
        public ObjectId _id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string Username { get; set; }

    }

}


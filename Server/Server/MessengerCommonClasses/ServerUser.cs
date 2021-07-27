using MongoDB.Bson;
using Server;
using System;
using System.Collections.Generic;


namespace Server
{
    [Serializable]
    public class ServerUser
    {
        public ServerUser()
        {
            user = new User();
            contacts = new List<User>();
            Messages = new List<Message>();
            Groups = new List<Group>();
            
        }
        public User user { get; }
        public ObjectId _id { get; set; }
        public string UserName {
            get
            {
               return user.UserName;
            }
            set 
            {
                user.UserName = value;
            } 
        }
        public string Password { get; set; }
        public string Name {
            get
            {
                return user.Name;
            }
            set
            {
                user.Name = value;
            }
        }
        public string Family {
            get
            {
                return user.Family;
            }
            set
            {
                user.Family = value;
            }
        }
        public List<User> contacts { get; set; }
        public List<Message> Messages { get; set; }
        public List<Group> Groups { get; set; }
        public List<string> groups { get; set; }
        
    }

}


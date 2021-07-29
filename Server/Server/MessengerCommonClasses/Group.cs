using MongoDB.Bson;
using System;
using System.Collections.Generic;


namespace Server
{
    [Serializable]
    public class Group:IDisplayable
    {
        public ObjectId _id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public User GroupOwner { get; set; }
        public DateTime DateOfCreation { get; private set; }
        public List<User> contacts { get; set; }
        public List<User> GroupAdmins { get; set; }
        public List<Message> Messages { get; set; }
        private bool IsDeleted = false;
        public Group()
        {
            DateOfCreation = DateTime.Now;
            contacts = new List<User>();
            Messages = new List<Message>();
            GroupAdmins = new List<User>();
        }

        public void DelelteGroup(User reqUser)
        {
            if (reqUser.UserName == GroupOwner.UserName)
            {
                if (!IsDeleted)
                {
                    IsDeleted = false;
                    //delete group from data base
                }
            }

        }

        public object GetSpecificatios()
        {
            return this;
        }
    }
}

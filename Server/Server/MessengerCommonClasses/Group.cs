using MongoDB.Bson;
using Server;
using System;
using System.Collections.Generic;


namespace Server
{
    public struct GroupMessage
    {
        string Sender;
        string message;
        DateTime date;
    }

    public class Group
    {
        public ObjectId _id { get; set; }
        public string GroupName { get; set; }
        public User GroupOwner { get; set; }
        public DateTime DateOfCreation { get; private set; }
        public List<User> GroupUsers { get; set; }
        List<User> GroupAdmins { get; set; }
        List<GroupMessage> GroupMessages { get; set; }
        private bool IsDeleted = false;
        public Group()
        {
            DateOfCreation = DateTime.Now;
        }

        public void DelelteGroup(User reqUser)
        {
            if (reqUser.Username == GroupOwner.Username)
            {
                if (!IsDeleted)
                {
                    IsDeleted = false;
                    //add to database
                }
            }

        }
    }
}

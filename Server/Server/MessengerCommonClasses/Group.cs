using MongoDB.Bson;
using System;
using System.Collections.Generic;

namespace MessengerApp
{
    struct GroupMessage
    {
        string Sender;
        string message;
        DateTime date;
    }
    
    class Group
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
            if(reqUser.UserName == GroupOwner.UserName)
            {
                if (!IsDeleted)
                {
                    IsDeleted = false;
                    //add to database
                }
            }
           
        }

    }
    public class User
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public string UserName { get; set; }
    }
}

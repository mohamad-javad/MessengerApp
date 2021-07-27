using System;
using System.Collections.Generic;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Builders;
using System.Threading.Tasks;

namespace Server
{
    public class DataManager
    {
        MongoClient mongoClient;
        MongoServer mongoServer;
        MongoDatabase dB;
        MongoCollection<ServerUser> UsersCollection;
        MongoCollection<Group> groupCollection;

        [Obsolete]
        public DataManager()
        {
            mongoClient = new MongoClient("mongodb://localhost");
            mongoServer = mongoClient.GetServer();
            dB = mongoServer.GetDatabase("MessengerDB");
            UsersCollection = dB.GetCollection<ServerUser>("Users");
            groupCollection = dB.GetCollection<Group>("Groups");

        }

        public List<ServerUser> GetAllUsers()
        {
            List<ServerUser> users = new List<ServerUser>();
            foreach (var user in UsersCollection.FindAll())
            {
                users.Add(user);
            }

            return users;
        }
        public List<Group> GetAllGroups()
        { 
            List<Group> gps = new List<Group>();
            foreach (var user in groupCollection.FindAll())
            {
                gps.Add(user);
            }

            return gps;
        }

        public void AddPersonalMessage(Message msg)
        {
            List<Message> messages1 = new List<Message>();
            List<Message> messages2 = new List<Message>();

            var query1 = Query<ServerUser>.EQ(u => u.UserName, msg["sender"]);
            var query2 = Query<ServerUser>.EQ(u => u.UserName, msg["reciever"]);
            ServerUser user1 = UsersCollection.FindOne(query1);
            ServerUser user2 = UsersCollection.FindOne(query2);
            messages1 = user1.Messages == null ? new List<Message>() : user1.Messages;
            messages2 = user2.Messages == null ? new List<Message>() : user2.Messages;

            messages1.Add(msg);
            messages2.Add(msg);

            var update1 = Update<ServerUser>.Set(u => u.Messages, messages1);
            var update2 = Update<ServerUser>.Set(u => u.Messages, messages2);
            UsersCollection.Update(query1, update1);
            UsersCollection.Update(query2, update2);
        }
        public ServerUser FindUserName(string userName)
        {
            var query = Query<ServerUser>.EQ(n => n.UserName, userName);
            ServerUser user = UsersCollection.FindOne(query);
            return user;
        }
        public bool AddUser(ServerUser user)
        {
            bool res = false;
            WriteConcernResult result = UsersCollection.Insert<ServerUser>(user);
            res = !result.HasLastErrorMessage;

            return res;
        }
        public void AddContact(string username, User contact)
        {
            List<User> ct = new List<User>();
            var query = Query<ServerUser>.EQ(u => u.UserName, username);
            ServerUser user = UsersCollection.FindOne(query);

            ct = user.contacts;
            if (ct == null)
                ct = new List<User>();
            ct.Add(contact);
            var update = Update<ServerUser>.Set(u => u.contacts, ct);
            UsersCollection.Update(query, update);
        }
        public void AddGroup(string userName, Group group)
        {
            List<Group> groups = new List<Group>();
            var query = Query<ServerUser>.EQ(u => u.UserName, userName);
            ServerUser user = UsersCollection.FindOne(query);
            groups = user.Groups;
            if (groups == null)
            {
                groups = new List<Group>();
            }
            groups.Add(group);
            var update = Update<ServerUser>.Set(u => u.Groups, groups);
            UsersCollection.Update(query, update);
        }

    }
}

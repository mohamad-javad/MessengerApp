using System;
using System.Collections.Generic;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Builders;
using System.Threading.Tasks;
using System.Linq;

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
        public void AddGroupMessage(Message msg)
        {
            List<Message> messages1 = new List<Message>();

            var query = Query<Group>.EQ(u => u.UserName, msg["reciever"]);
            Group gp = groupCollection.FindOne(query);

            messages1 = gp.Messages == null ? new List<Message>() : gp.Messages;

            messages1.Add(msg);


            var update = Update<Group>.Set(u => u.Messages, messages1);
            UsersCollection.Update(query, update);

        }
        public ServerUser FindUserName(string userName)
        {
            var query = Query<ServerUser>.EQ(n => n.UserName, userName);
            ServerUser user = UsersCollection.FindOne(query);
            return user;
        }
        public Group FindGroup(string groupUserName)
        {
            var query = Query<Group>.EQ(n => n.UserName, groupUserName);
            Group gp = groupCollection.FindOne(query);
            return gp;
        }
        public List<Group> CollectGroups(ServerUser user)
        {
            List<Group> groups = new List<Group>();
            if (user.groups != null)
            {
                foreach (var gp in user.groups)
                {
                    groups.Add(FindGroup(gp));
                }
                user.Groups = groups;
            }

            return groups;
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
            if (contact != null)
            {
                List<User> ct = new List<User>();
                var query = Query<ServerUser>.EQ(u => u.UserName, username);
                ServerUser user = UsersCollection.FindOne(query);

                ct = user.contacts;
                if (ct == null)
                    ct = new List<User>();
                if (!ct.Any(n => n.UserName == contact.UserName))
                {
                    ct.Add(contact);
                    var update = Update<ServerUser>.Set(u => u.contacts, ct);
                    UsersCollection.Update(query, update);
                }
            }


        }
        public void AddGroup(string userName, string groupUserName)
        {
            AddGroupToUserGroups(userName, groupUserName);
            AddUserToGroupUsers(userName, groupUserName);
        }
        public void CreateGroup(string owner, Group gp)
        {
            groupCollection.Insert<Group>(gp);

            AddGroup(owner, gp.UserName);
        }

        private void AddGroupToUserGroups(string userName, string groupUserName)
        {
            List<string> groups = new List<string>();
            var query = Query<ServerUser>.EQ(u => u.UserName, userName);

            ServerUser user = UsersCollection.FindOne(query);
            groups = user.groups;
            if (groups == null)
            {
                groups = new List<string>();
            }
            groups.Add(groupUserName);
            var update = Update<ServerUser>.Set(u => u.groups, groups);
            UsersCollection.Update(query, update);
        }
        private void AddUserToGroupUsers(string userName, string gpName)
        {
            List<User> users;
            var query = Query<Group>.EQ(g => g.UserName, gpName);
            Group gp = groupCollection.FindOne(query);
            users = gp.contacts;
            if (users == null)
            {
                users = new List<User>();
            }
            users.Add(FindUserName(userName).user);

            var update = Update<Group>.Set(u => u.contacts, users);
            groupCollection.Update(query, update);
        }
        public void AddGroupAdmin(string userName, string gpName)
        {
            List<User> admins;
            var query = Query<Group>.EQ(g => g.UserName, gpName);
            Group gp = groupCollection.FindOne(query);
            admins = gp.GroupAdmins;
            if (admins == null)
            {
                admins = new List<User>();
            }
            admins.Add(FindUserName(userName).user);

            var update = Update<Group>.Set(u => u.GroupAdmins, admins);
            groupCollection.Update(query, update);
        }
        public void RemoveGroupAdmin(string userName, string gpName)
        {
            List<User> admins;
            var query = Query<Group>.EQ(g => g.UserName, gpName);
            Group gp = groupCollection.FindOne(query);
            admins = gp.GroupAdmins;
            if (admins != null && userName != gp.GroupOwner.UserName)
            {
                admins.Remove(FindUserName(userName).user);

                var update = Update<Group>.Set(u => u.GroupAdmins, admins);
                groupCollection.Update(query, update);
            }

        }
    }
}

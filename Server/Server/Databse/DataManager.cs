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

        [Obsolete]
        public DataManager()
        {
            mongoClient = new MongoClient("mongodb://localhost");
            mongoServer = mongoClient.GetServer();
            dB = mongoServer.GetDatabase("MessengerDB");
            UsersCollection = dB.GetCollection<ServerUser>("Users");
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

        public void AddMessage(Message msg)
        {
            MongoCollection<Message> usr1Messages = dB.GetCollection<Message>(msg.MessageHeader.Sender);
            usr1Messages.Insert<Message>(msg);
            MongoCollection<Message> usr2Messages = dB.GetCollection<Message>(msg.MessageHeader.Reciever);
            usr2Messages.Insert<Message>(msg);
        }
        public string FindUserName(string userName)
        {
            MongoUser user = dB.FindUser(userName);
            return user.Username;
        }
        public bool AddUser(ServerUser user)
        {
            bool res = false;

            BsonDocument bsonUser = new BsonDocument() {
                { "Name",user.Name}, { "Family", user.Family },
                {"UserName",user.UserName },{"Password",user.Password}
            };
            WriteConcernResult result = UsersCollection.Insert(bsonUser);
            res = !result.HasLastErrorMessage;

            return res;
        }
        public async Task<List<Message>> GetUserMessages(string srcUserName, string userName)
        {
            List<Message> msgs = new List<Message>();
            MongoCollection<Message> msgCollection = dB.GetCollection<Message>(srcUserName);
            
            foreach (var msg in msgCollection.FindAll())
            {
                if (msg["sender"] == userName || msg["reciever"] == userName)
                {
                    msgs.Add(msg);
                }
            }

            return msgs;
        }
        public void AddContact(string username, List<User> contact)
        {
            List<User> ct = new List<User>();
            var query = Query<ServerUser>.EQ(u => u.UserName, username);
            ServerUser user = UsersCollection.FindOne(query);

            ct = user.contacts;
            foreach (var item in contact)
            {
                ct.Add(item);
            }
            var update = Update<ServerUser>.Set(u => u.contacts, ct);
            UsersCollection.Update(query, update);
        }
        public List<User> GetUserContacts(string userName)
        {
            List<User> cntct = new List<User>();
            var query = Query<ServerUser>.EQ(u => u.UserName, userName);
            ServerUser user = UsersCollection.FindOne(query);
            cntct = user.contacts;

            return cntct;
        }

    }
}

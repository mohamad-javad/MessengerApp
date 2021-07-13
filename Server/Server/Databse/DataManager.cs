using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Driver;
using MongoDB.Bson;
using MongoDB.Driver.Core;
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

        public DataManager()
        {
            StartDatabase();
        }

        public void StartDatabase()
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
            MongoCollection<Message> usr1Messages = dB.GetCollection<Message>(msg.Sender);
            usr1Messages.Insert<Message>(msg);
            MongoCollection<Message> usr2Messages = dB.GetCollection<Message>(msg.Reciever);
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
        public string GetUserMessages(string srcUserName, string userName)
        {
            string output = "";
            MongoCollection<Message> msgCollection = dB.GetCollection<Message>(srcUserName);
            foreach (var msg in msgCollection.FindAll())
            {
                if (msg.Reciever == userName)
                {
                    output += "#**#" + msg._id + ":left" + ":" + msg.Sender + ":" + msg.MsgText + ":" + msg.Date;
                }
                else if (msg.Sender == userName)
                {
                    output += "#**#" + msg._id + ":right" + ":" + msg.Reciever + ":" + msg.MsgText + ":" + msg.Date;
                }
            }

            return output;
        }

    }
}

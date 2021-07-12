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
        public void StartDatabase()
        {
            mongoClient = new MongoClient("mongodb://localhost");
            mongoServer = mongoClient.GetServer();
            dB = mongoServer.GetDatabase("MessengerDB");

        }

        public bool CreateTable(string dbName)
        {
            CommandResult result = dB.CreateCollection(dbName);
            return result.Ok;
        }
        public string FindUserName(string userName)
        {
            MongoUser user = dB.FindUser(userName);
            return user.Username;
        }
        public bool AddUser(ServerUser user)
        {
            return true;
        }

        public List<ServerUser> GetUsers()
        {
            MongoUser[] userCollection = dB.FindAllUsers();
            List<ServerUser> users = new List<ServerUser>();
            foreach (var user in userCollection)
            {
                BsonDocument bsonUser = user.ToBsonDocument();

                ServerUser usr = new ServerUser(bsonUser[1][1].ToString(), bsonUser[2][1].ToString(), bsonUser[3][1].ToString(),bsonUser[4][1].ToString());
                usr.Id = bsonUser[0][1].ToString();
                users.Add(usr);
            }


            return users;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Libmongocrypt;
using MongoDB.Driver.Core;
using System.Threading.Tasks;

namespace Server.DataBase
{
    public class DataManager
    {
        MongoClient mClient;
        MongoServer mongoServer;
        MongoDatabase db;
        MongoCollection<BsonDocument> collection;


        public void StartDataBase()
        {
            mClient = new MongoClient("mongodb://localhost");
            mongoServer = mClient.GetServer();
            db = mongoServer.GetDatabase("Messenger");
            

        }
        public void GetContactList()
        {

        } 
        public bool CreateNewTable(string tableName)
        {
           CommandResult result = db.CreateCollection(tableName);
            if (result.Ok)
                return true;

            return false;
        }
    }
}

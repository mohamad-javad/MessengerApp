using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    [Serializable]
    public struct Header
    {
        public string Command { get; set; }
        public string Sender { get; set; }
        public string Reciever { get; set; }
        public string TypeOfMessage { get; set; }

    }

    [Serializable]
    public class Message
    {
        public ObjectId _id { get; set; }
        public Header MsgHeader { get; set; }
        public object MsgContent { get; set; }
        public DateTime Date { get; set; }
        public Message(Header header)
        {

            MsgHeader = header;
            Date = DateTime.Now;
        }
        public override string ToString()
        {
            return $"{MsgHeader.Sender}:{MsgHeader.Reciever}:{MsgContent}:{Date.ToString("HH:mm:ss")}";
        }
    }
}

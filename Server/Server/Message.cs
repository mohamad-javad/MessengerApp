using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class Message
    {
        public ObjectId _id { get; set; }
        public string Sender { get; set; }
        public string Reciever { get; set; }
        public string MsgText { get; set; }
        public DateTime Date { get; set; }
        public Message()
        {
            Date = DateTime.Now;
        }
        public override string ToString()
        {
            return $"{Sender}:{Reciever}:{MsgText}:{Date.ToString("HH:mm:ss")}";
        }

    }
}

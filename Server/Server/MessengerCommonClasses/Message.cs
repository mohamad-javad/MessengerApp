using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    [Serializable]
    public class Header
    {
        public ObjectId _id { get; set; }
        public string Command { get; set; }
        public string Sender { get; set; }
        public string Reciever { get; set; }
        public string TypeOfMessage { get; set; }

    }

    [Serializable]
    public class Message
    {
        public ObjectId _id { get; set; }
        public object MessageContent { get; set; }
        public DateTime CreationDate { get; private set; }
        public Header MessageHeader { get; set; }
        
        public Message(Header header)
        {

            MessageHeader = header;
            CreationDate = DateTime.Now;
        }
        public override string ToString()
        {
            if(MessageContent is string)
            return $"{MessageHeader.Sender}:\n{MessageContent}:\n{CreationDate.ToString("HH:mm:ss")}";
            else{
                return $"{MessageHeader.Sender}:\nSent an object:\n{CreationDate.ToString("HH:mm:ss")}";
            }
        }

        public string this[string input]
        {
            get
            {
                string returnValue = "";
                switch (input)
                {
                    case "sender":
                        returnValue = MessageHeader.Sender;
                        break;
                    case "reciever":
                        returnValue = MessageHeader.Reciever;
                        break;
                    case "msgType":
                        returnValue = MessageHeader.TypeOfMessage;
                        break;
                    case "create":
                        returnValue = CreationDate.ToString("G");
                        break;
                    case "command":
                        returnValue = MessageHeader.Command;
                        break;
                    default:
                        throw new Exception("the index not found!!!");
                }

                return returnValue;
            }
        }
    }
}

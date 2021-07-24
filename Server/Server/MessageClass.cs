using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public struct Header
    {
        public string Sender { get; set; }
        public string Reciever { get; set; }
        public string Command { get; set; }
        public string MessageType { get; set; }

    }
    public class MessageClass
    {
        public object MessageContent { get; set; }
        public DateTime CreationDate { get; private set; }
        public Header MessageHeader { get; set; }
        public MessageClass(Header header)
        {
            MessageHeader = header;
            CreationDate = DateTime.Now;
        }

        public string this[string input]
        {
            get
            {
                string output = "";
                switch (input)
                {
                    case "command":
                        output = MessageHeader.Command;
                        break;
                    case "sender":
                        output = MessageHeader.Sender;
                        break;
                    case "reciever":
                        output = MessageHeader.Reciever;
                        break;
                    default:
                        throw new Exception("the index not found!!!");
                }
                return output;
            }
        }

    }
}

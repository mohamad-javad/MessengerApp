using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Message
    {
        string _sender;
        string _reciever;
        string _mText;
        DateTime date;
        public Message()
        {
            date = DateTime.Now;
        }
        public override string ToString()
        {
            return $"{_sender}:{_reciever}:{_mText}:{date.ToString("HH:mm:ss")}";
        }

    }
}

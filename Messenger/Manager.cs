using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server;
namespace MessengerApp
{
    class Manager
    {
        public ServerUser Owner { get; set; }
        public static MessengerMainForm mainClientForm { get; set; }


        public void ExecuteCommand(Message message)
        {
            throw new NotImplementedException();
        }
    }
}

using Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sliding_Application
{
    public interface IChatsManager
    {
        void ShowMembers(ServerUser owner, ChatsMainForm chatsMainForm);
        void ShowMessages(ServerUser user, string sender,string reviever, ChatsMainForm chatsMainForm);
        void ShowProfile(IDisplayable user);
        void AddMember(ChatsMainForm chatsMainForm);
    }

}

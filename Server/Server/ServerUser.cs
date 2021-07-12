using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class ServerUser
    {
        string _name;
        string _family;
        string _userNmae;
        string _password;
        string _id;
        public ServerUser()
        {

        }
        public ServerUser(string name, string family, string userNmae, string password)
        {
            _name = name;
            _family = family;
            _userNmae = userNmae;
            _password = password;

        }
        public string Id { get { return _id; } set { _id = value; } }
        public string UserName
        {
            get
            {
                return _userNmae;
            }
            set
            {
                _userNmae = value;
            }
        }
        public string Password { get { return _password; } set { _password = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Family { get { return _family; } set { _family = value; } }
    }
}

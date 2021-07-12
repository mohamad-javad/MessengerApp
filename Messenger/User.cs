using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessengerApp
{
    public class User
    {
        string _id;
        string _name;
        string _family;
        string _password;

        public User(string id, string name, string family, string password)
        {
            this._id = id;
            this._name = name;
            this._family = family;
            this._password = password;
        }
    }
}

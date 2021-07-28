using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace Server
{
    public static class MyExtentions
    {
        public static string Sha_256(this string inputString)
        {
            var crypt = new System.Security.Cryptography.SHA256Managed();
            var hash = new StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(inputString));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();
        }

        public static Message ConvertMessageFromByte(this byte[] msgByte)
        {
            MemoryStream memStream = new MemoryStream();
            BinaryFormatter binForm = new BinaryFormatter();
            memStream.Write(msgByte, 0, msgByte.Length);
            memStream.Seek(0, SeekOrigin.Begin);
            Message msg = (Message)binForm.Deserialize(memStream);

            return msg;
        }

        public static byte[] ConvertMessageToByte(this Message msg)
        {
            if (msg == null)
                return null;

            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            bf.Serialize(ms, msg);

            return ms.ToArray();
        }

        public static bool IsIn(this char chr, string str)
        {
            foreach (var c in str)
            {
                if (c == chr)
                {
                    return true;
                }
            }
            return false;
        }


        public static User FindUser(this ServerUser serverUser, string username)
        {
            User user = serverUser.contacts.Select(n => n).Where(n => n.UserName == username).FirstOrDefault();
            return user;
        }

        public static List<string> CommonGroups(this ServerUser owner, string userName)
        {
            List<string> commons = new List<string>();
            foreach (var item in owner.Groups)
            {
                if (item.contacts.Any(n => n.UserName == userName))
                {
                    commons.Add(item.Name);
                }
            }

            return commons;
        }
        public static IDisplayable MakeDisplayable(this string username, ServerUser serverUser)
        {
            List<Group> gp = serverUser.Groups;
            List<User> usrs = serverUser.contacts;
            if (gp.Any(n => n.UserName == username))
            {
                Group group = (Group)gp.Select(n => n).Where(n => n.UserName == username);
                return group;
            }
            else if (usrs.Any(n => n.UserName == username))
            {
                User user = (User)usrs.Select(n => n).Where(n => n.UserName == username);
                return user;
            }
            return null;
        }
    }

}

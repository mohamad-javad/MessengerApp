using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

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

    }

}

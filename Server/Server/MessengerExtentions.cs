using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using Server;

namespace Server
{
    public static class MessengerExtentions
    {
        public static string Sha_256(this string inputString)
        {
            var crypt = new System.Security.Cryptography.SHA256Managed();
            var hash = new System.Text.StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(inputString));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();
        }


        public static byte[] ConvertMessageToByte(this MessageClass message)
        {
            BinaryFormatter bf = new BinaryFormatter();
            using (var ms = new MemoryStream())
            {
                bf.Serialize(ms, message);
                return ms.ToArray();
            }
        }

        public static MessageClass ConvertToMessageFromByte(this byte[] bytes)
        {
            using (var memStream = new MemoryStream())
            {
                var binForm = new BinaryFormatter();
                memStream.Write(bytes, 0, bytes.Length);
                memStream.Seek(0, SeekOrigin.Begin);
                MessageClass message = (MessageClass)binForm.Deserialize(memStream);
                return message;
            }
        }
    }
}

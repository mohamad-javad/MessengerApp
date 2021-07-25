using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleTcp;
using System.Windows.Forms;


namespace Server
{
    public class ServerConnectionManager
    {
        static ServerConnectionManager scm;
        private static string _serverIpAddress;
        private static SimpleTcpServer server;
        public static ServerConnectionManager ServerConnectionGetForm { get
            {
                if (scm == null)
                {
                    scm = new ServerConnectionManager();
                }
                return scm;
            } }
        private ServerConnectionManager()
        {
            _serverIpAddress = "127.0.0.1:9000";
            server = new SimpleTcpServer(_serverIpAddress);
            server.Events.DataReceived += DataRecieved;
            server.Events.ClientConnected += ClientConnected;
            server.Events.ClientDisconnected += ClientDisconnected;
        }
       
        public string ServerAddress
        {
            get
            {
                return _serverIpAddress;

            }
            set
            {
                _serverIpAddress = value;
            }
        }

        public static void StartServer()
        {
            server.Start();
        }
        public static void StopServer()
        {
            server.Stop();
        }

        private static void ClientDisconnected(object sender, ClientDisconnectedEventArgs e)
        {

            ServerUI.GetForm.StatusChanged(e.IpPort + " is disconnected.", "red");
            ServerUI.GetForm.AD_UserList(e.IpPort, false);
        }

        private static void ClientConnected(object sender, ClientConnectedEventArgs e)
        {
            ServerUI.GetForm.StatusChanged(e.IpPort + " is connected.", "cyan");
            ServerUI.GetForm.AD_UserList(e.IpPort, true);
        }
        private static async void DataRecieved(object sender, DataReceivedEventArgs e)
        {
            Message msg = e.Data.ConvertMessageFromByte();
            
            ServerManager svManager = new ServerManager();
            Task<Message> response = svManager.ExecuteCommand(msg);
            Message message = await response;

           await server.SendAsync(e.IpPort, message.ConvertMessageToByte());

        }


    }
}

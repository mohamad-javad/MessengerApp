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
        private static string ServerIpAddress = "127.0.0.1:9000";
        private static SimpleTcpServer server;
        private static ServerUI serverUI;
        public static List<string> serverStatus;
        IManager svManager;

        public ServerConnectionManager()
        {
            server = new SimpleTcpServer(ServerIpAddress);
            serverStatus = new List<string>();
            server.Events.DataReceived += DataRecieved;
            server.Events.ClientConnected += ClientConnected;
            server.Events.ClientDisconnected += ClientDisconnected;
        }

        public static ServerUI DefServerUi
        {
            set
            {
                serverUI = value;
            }
        }

        public static string ServerStatus
        {
            set
            {
                serverStatus.Add(value);
            }
        }
        public static string ServerAddress
        {
            get
            {
                return ServerIpAddress;

            }
            set
            {
                ServerIpAddress = value;
                serverStatus.Add(value);
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

        private void ClientDisconnected(object sender, ClientDisconnectedEventArgs e)
        {
            serverUI.StatusChanged(e.IpPort + " is disconnected.", "red");
            serverUI.AD_UserList(e.IpPort, false);
        }

        private void ClientConnected(object sender, ClientConnectedEventArgs e)
        {
            serverUI.StatusChanged(e.IpPort + " is connected.", "cyan");
            serverUI.AD_UserList(e.IpPort, true);
        }
        private void DataRecieved(object sender, DataReceivedEventArgs e)
        {
            Message msg = e.Data.ConvertMessageFromByte();

            svManager = new ServerManager();
            svManager.ExecuteCommand(msg, e.IpPort);

        }
        public void SendToClient(Message resMsg, string ipPort)
        {
            byte[] byteMsg = resMsg.ConvertMessageToByte();
            server.Send(ipPort, byteMsg);

        }

    }
}

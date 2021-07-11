using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleTcp;
using System.Windows.Forms;


namespace Server
{
    public static class ServerManager
    {
        private static string ServerIpAddress = "127.0.0.1:9000";
        private static SimpleTcpServer server;
        private static ServerUI serverUI;
        public static List<string> serverStatus;
        
        static ServerManager()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
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

        private static void ClientDisconnected(object sender, ClientDisconnectedEventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            serverUI.StatusChanged(e.IpPort + " is disconnected.","red");
            serverUI.AD_UserList(e.IpPort, false);
        }

        private static void ClientConnected(object sender, ClientConnectedEventArgs e)
        {
            // System.Windows.Forms.MessageBox.Show("client connected");
            Control.CheckForIllegalCrossThreadCalls = false;

            serverUI.StatusChanged(" is connected.");
            serverUI.AD_UserList(e.IpPort, true);
        }
        private static void DataRecieved(object sender, DataReceivedEventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;

            string msg = Encoding.UTF8.GetString(e.Data);
            serverUI.StatusChanged(e.IpPort + " sent a message.");
        }

    }
}

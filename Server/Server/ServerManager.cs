using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleTcp;
using System.Windows.Forms;


namespace Server
{
    public partial class ServerUI : Form, IServer
    {
        private static string ServerIpAddress = "127.0.0.1:9000";
        
        private SimpleTcpServer server;
        private static ServerUI serverUI;
        public static List<string> serverStatus;
        static ServerUI()
        {
            serverStatus = new List<string>();

        }

        private void ServerUI_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer(ServerIpAddress);
            server.Events.ClientConnected += ClientConnected;
            server.Events.ClientDisconnected += ClientDisConnected;
            server.Events.DataReceived += DataRecived;

            isIpChanged = false;
            isPortChanged = false;
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
            
        public void StartServer()
        {
            server.Start();
        }
        public void StopServer()
        {
            server.Stop();
        }

        private void DataRecived(object sender, DataReceivedEventArgs e)
        {
           
            string msg = Encoding.UTF8.GetString(e.Data);
            StatusChanged(e.IpPort + " sent a message.");
            //Message message = 
        }

        private void ClientDisConnected(object sender, ClientDisconnectedEventArgs e)
        {
            StatusChanged(e.IpPort + " is disconnected.","red");
            AD_UserList(e.IpPort, false);
        }

        private void ClientConnected(object sender, ClientConnectedEventArgs e)
        {
           // System.Windows.Forms.MessageBox.Show("client connected");

            StatusChanged(" is connected.");
            AD_UserList(e.IpPort, true);
        }
        
    }
}

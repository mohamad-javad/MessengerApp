using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server;
using SimpleTcp;


namespace Sliding_Application
{
    class Client
    {
        SimpleTcpClient client;

        public Client()
        {
            client = new SimpleTcpClient(ServerManager.ServerAddress);
            client.Events.Connected += ConnectClient;
            client.Events.Disconnected += DisconnectClient;
            client.Events.DataReceived += ReciveData;
        }

        public void ClientSetUp()
        {

            try
            {
                client.Connect();
            }
            catch
            {

            }
            
        }

        private void ReciveData(object sender, DataReceivedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DisconnectClient(object sender, ClientDisconnectedEventArgs e)
        {
            //System.Windows.Forms.MessageBox.Show("you are dissconnected");

        }

        private void ConnectClient(object sender, ClientConnectedEventArgs e)
        {
            //System.Windows.Forms.MessageBox.Show("you are connected");
        }
    }
}

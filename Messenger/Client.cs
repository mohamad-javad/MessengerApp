using System;
using SimpleTcp;



namespace MessengerApp
{
    class Client
    {
        SimpleTcpClient client;

        public Client()
        {
            client = new SimpleTcpClient("127.0.0.1:9000");
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

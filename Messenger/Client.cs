﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Server;
using SimpleTcp;


namespace MessengerApp
{
    static class Client
    {
        static SimpleTcpClient client;
        static Manager mngr;

        static Client()
        {
            client = new SimpleTcpClient("127.0.0.1:9000");
            client.Events.Connected += ConnectClient;
            client.Events.Disconnected += DisconnectClient;
            client.Events.DataReceived += ReciveData;
        }

        public static void ClientSetUp()
        {

            try
            {
                client.Connect();
            }
            catch
            {

            }

        }

        private static void ReciveData(object sender, DataReceivedEventArgs e)
        {

            mngr = new Manager();
            Message msg = e.Data.ConvertMessageFromByte();
            mngr.ExecuteCommand(msg);

        }

        private static void DisconnectClient(object sender, ClientDisconnectedEventArgs e)
        {
            //System.Windows.Forms.MessageBox.Show("you are dissconnected");

        }

        private static void ConnectClient(object sender, ClientConnectedEventArgs e)
        {
            //System.Windows.Forms.MessageBox.Show("you are connected");
        }

        public static void SendToServer(Message msg)
        {
            try
            {
                client.Send(msg.ConvertMessageToByte());
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("connection error", "", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);

            }
        }

        public static async void ConnectToServer()
        {


            await Task.Run(() =>
            {
                while (!client.IsConnected)
                {
                    try
                    {
                        client.Connect();
                    }
                    catch (Exception)
                    {


                    }


                }
                string a = "connecting to server";
            });

        }
    }
}

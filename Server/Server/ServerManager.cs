﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleTcp;
namespace Server
{
    public class ServerManager :IServer
    {
        private static string ServerIpAddress = "127.0.0.1:9000";
        private static SimpleTcpServer server;
        private static ServerUI serverUI;
        public static List<string> serverStatus;
        static ServerManager()
        {
            serverStatus = new List<string>();
        }
        public ServerManager()
        {
            server = new SimpleTcpServer(ServerIpAddress);
            server.Events.ClientConnected += ClientConnected;
            server.Events.ClientDisconnected += ClientDisConnected;
            server.Events.DataReceived += DataRecived;
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
                serverUI.StatusChanged($"Server Address Change to < {value} >");
            }
        }
            
        public void StartServer()
        {
            serverUI = new ServerUI();
            server.Start();
        }
        public void StopServer()
        {
            server.Stop();
        }

        private void DataRecived(object sender, DataReceivedEventArgs e)
        {
           
            string msg = Encoding.UTF8.GetString(e.Data);
            serverUI.StatusChanged(e.IpPort + " sent a message.");
            //Message message = 
        }

        private void ClientDisConnected(object sender, ClientDisconnectedEventArgs e)
        {
            serverUI.StatusChanged(e.IpPort + " is disconnected.","red");
            serverUI.AD_UserList(e.IpPort, false);
        }

        private void ClientConnected(object sender, ClientConnectedEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("client connected");

            serverUI.StatusChanged(e.IpPort + " is connected.", "cyan");
            serverUI.AD_UserList(e.IpPort, true);
        }
    }
}

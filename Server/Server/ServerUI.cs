﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleTcp;

namespace Server
{
    public partial class ServerUI : Form
    {
        Label status;
        static bool isPortChanged;
        static bool isIpChanged;
        
        public ServerUI()
        {
            InitializeComponent();
        }
        private void ServerUI_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            isIpChanged = false;
            isPortChanged = false;
            ServerManager.DefServerUi = this;
        }


        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            //server.StopServer();
            Application.Exit();
        }

        private void bunifuGroupBox1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (isIpChanged == true && isPortChanged == true)
                {
                    ServerManager.ServerAddress = $"{ip_tb.Text}:{port_tb.Text}";
                    ServerManager.StartServer();
                    MessageBox.Show("SetUP was successfull.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                else
                    ServerManager.StartServer();


                StatusChanged($@"Server started on    <<<   {ServerManager.ServerAddress}   >>>", "green");
                startServer_btn.Enabled = false;
                stopServer_btn.Enabled = true;
            }
            catch
            {
                StatusChanged($"Server field to start on    <<<   {ServerManager.ServerAddress}   >>>", "red");
                MessageBox.Show("please enter a valid ip and port", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        public  void StatusChanged(string msg, string color = "black")
        {

            status = new Label();
            CheckForIllegalCrossThreadCalls = false;
            switch (color)
            {
                case "black":
                    status.ForeColor = Color.Black;
                    break;
                case "green":
                    status.ForeColor = Color.Green;
                    break;
                case "red":
                    status.ForeColor = Color.Red;
                    break;
                case "cyan":
                    status.ForeColor = Color.DarkCyan;
                    break;
            }
            status.Text += msg + $",      {DateTime.Now.ToString("HH:MM:ss")}";
            status.Dock = DockStyle.Top;
            status.TextAlign = ContentAlignment.MiddleLeft;
          
            ServerManager.ServerStatus = msg;
            this.BeginInvoke((Action)(() =>
            {
                statusBar_gp.Controls.Add(status);
            }));
        }

        private void ip_tb_TextChange(object sender, EventArgs e)
        {
            isIpChanged = true;
        }

        private void port_tb_TextChange(object sender, EventArgs e)
        {
            isPortChanged = true;
        }

        public void AD_UserList(string user, bool add)
        {
            CheckForIllegalCrossThreadCalls = false;

            if (add)
            {
                Users.Items.Add(user);
            }
            else
            {
                Users.Items.Remove(user);
            }
        }

        private void stopServer_btn_Click(object sender, EventArgs e)
        {
            ServerManager.StopServer();
            stopServer_btn.Enabled = false;
            startServer_btn.Enabled = true;
            StatusChanged("Server stoped", "red");
        }


    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleTcp;
using System.IO;

namespace Server
{
    public partial class ServerUI : Form
    {
        Label status;
        static bool isPortChanged;
        static bool isIpChanged;
        static ServerUI serverUi;
        ServerConnectionManager serverConnection;
        public static ServerUI GetForm {
            get
            {
                if (serverUi == null)
                {
                    serverUi = new ServerUI();
                }
                return serverUi;
            }
        }
        private ServerUI()
        {
            InitializeComponent();
        }
        private void ServerUI_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            isIpChanged = false;
            isPortChanged = false;
            stopServer_btn.Enabled = false;
            serverConnection = ServerConnectionManager.ServerConnectionGetForm;
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

                    serverConnection.ServerAddress = $"{ip_tb.Text}:{port_tb.Text}";
                    ServerConnectionManager.StartServer();
                    MessageBox.Show("Setting UP address was successfull.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                else
                    ServerConnectionManager.StartServer();


                StatusChanged($@"Server started on    <<<   {serverConnection.ServerAddress}   >>>", "green");
                startServer_btn.Enabled = false;
                stopServer_btn.Enabled = true;
            }
            catch
            {
                StatusChanged($"Server field to start on    <<<   {serverConnection.ServerAddress}    >>>", "red");
               

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
            string serverStatus = msg + $",      {DateTime.Now.ToString("HH:MM:ss")}";
            status.Text = serverStatus;
            status.Dock = DockStyle.Top;
            status.TextAlign = ContentAlignment.MiddleLeft;
            
            ServerManager.ServerStatus = serverStatus;
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
                this.BeginInvoke((Action)(() =>
                {
                    Users.Items.Add(user);
                }));
               
            }
            else
            {
                this.BeginInvoke((Action)(() =>
                {
                    Users.Items.Remove(user);
                }));

            }
        }

        private void stopServer_btn_Click(object sender, EventArgs e)
        {
            ServerConnectionManager.StopServer();
            stopServer_btn.Enabled = false;
            startServer_btn.Enabled = true;
            StatusChanged("Server stoped", "red");
        }


    }

}

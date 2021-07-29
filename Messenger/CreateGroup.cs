using MessengerApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sliding_Application
{
    
    public partial class CreateGroup : Form
    {
        IClientManager manager;
        public CreateGroup()
        {
            InitializeComponent();
        }

        private void CreateGroup_Load(object sender, EventArgs e)
        {
            BeginInvoke((Action)(() =>
            {
                foreach (Control item in this.Controls)
                {
                    item.ForeColor = MessengerGUI.ForColor;
                    item.BackColor = MessengerGUI.ThemeColor;
                }
            }));

        }

        private void create_btn_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(gpName.Text)&& !string.IsNullOrEmpty(gpUserName.Text))
            {
                manager = new Manager();
                Server.Header header = new Server.Header();
                header.Sender = Manager.Owner.UserName;
                header.Reciever = "Server";
                header.Command = "create group";
                Server.Message msg = new Server.Message(header);
                Server.Group gp = new Server.Group();
                gp.Name = gpName.Text;
                gp.UserName = gpUserName.Text;
                gp.GroupOwner = Manager.Owner.user;
                msg.MessageContent = gp;

                manager.ExecuteCommand(msg);

                this.Close();
            }
        }
    }
}

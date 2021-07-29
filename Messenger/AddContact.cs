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
    public partial class AddContact : Form
    {
        private event Action closeform;
        string _command;
        public AddContact(string topOfPage, string deffinition, string command)
        {
            InitializeComponent();
            this.Text = topOfPage;
            this.defining_lbl.Text = deffinition;
            _command = command;
            if (topOfPage == "Add Existing Group")
            {
                createNew_btn.Visible = true;
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            MessengerApp.Manager manager = new MessengerApp.Manager();
            Server.Message message = new Server.Message(new Server.Header() { Command = _command });
            message.MessageContent = userName_text.Text;
            manager.ExecuteCommand(message);


        }

        private void search_btn_MouseDown(object sender, MouseEventArgs e)
        {
            search_btn.BorderStyle = BorderStyle.Fixed3D;
        }

        private void search_btn_MouseUp(object sender, MouseEventArgs e)
        {
            search_btn.BorderStyle = BorderStyle.None;
        }

        private void AddContact_Load(object sender, EventArgs e)
        {
            this.BackColor = MessengerGUI.ThemeColor;
            this.ForeColor = MessengerGUI.ForColor;
            defining_lbl.BackColor = MessengerGUI.ThemeColor;
            defining_lbl.ForeColor = MessengerGUI.ForColor;

        }

        private void createNew_btn_Click(object sender, EventArgs e)
        {

        }
    }
}

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
        string member_type;
        public AddContact(string command)
        {
            InitializeComponent();
            member_type = command;
        }

        private void Closeform()
        {
            this.Close();

        }

        private async void search_btn_Click(object sender, EventArgs e)
        {
            MessengerApp.Manager manager = new MessengerApp.Manager();
            Server.Message message = new Server.Message(new Server.Header() { Command = "add contact" });
            message.MessageContent = userName_text.Text;
            switch (member_type)
            {
                case "personal":
                    manager.ExecuteCommand(message);
                    break;
                default:
                    break;
            }

            closeform += Closeform;

        }

        private void search_btn_MouseDown(object sender, MouseEventArgs e)
        {
            search_btn.BorderStyle = BorderStyle.Fixed3D;
        }

        private void search_btn_MouseUp(object sender, MouseEventArgs e)
        {
            search_btn.BorderStyle = BorderStyle.None;
        }
    }
}

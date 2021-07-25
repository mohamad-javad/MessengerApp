using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessengerApp
{
    public partial class ChatsMainForm : Form
    {
        Chat chat = new Chat();
        Server.Message command;
        public ChatsMainForm(Server.Message message)
        {
            InitializeComponent();

        }

        private void messages_pnl_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Windows.Forms;
using Server;
using MessengerApp;
namespace Sliding_Application
{
    public partial class LoginForm : Form
    {
        static LoginForm loginForm;
        public static LoginForm GetFrom
        {
            get
            {
                if (loginForm == null)
                {
                    loginForm = new LoginForm();
                }
                return loginForm;
            }
        }
        private LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Server.Message msg = new Server.Message(new Header()
            {
                Sender = usr_txt.Text,
                Reciever = "Server",
                Command = "login user"
            });
            if (!string.IsNullOrEmpty(usr_txt.Text) && 
                !string.IsNullOrEmpty(pswd_txt.Text))
            {
                ServerUser user = new ServerUser();
                user.UserName = usr_txt.Text;
                user.Password = pswd_txt.Text;
                msg.MessageContent = user;

                new Manager().ExecuteCommand(msg);
            }
            else
            {
                AddError("please fill the blanks.");
            }
        }
        public void AddError(string error)
        {
            error_lbl.Text = "";
            error_lbl.Text += error;
        }

        private void usr_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void exit_lbl_Click(object sender, EventArgs e)
        {
            Manager manager = new Manager();
            Header header = new Header() { Command = "register" };

            Server.Message message = new Server.Message(header);
            manager.ManageForms(message);
        }
    }
}

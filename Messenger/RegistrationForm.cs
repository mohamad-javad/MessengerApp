using System;
using System.Linq;
using System.Windows.Forms;
using Server;
using MessengerApp;
using System.Threading.Tasks;

namespace Sliding_Application
{
    public partial class RegistrationForm : Form
    {
        static RegistrationForm rgstrForm;
        public static RegistrationForm GetForm
        {
            get
            {
                if (rgstrForm == null)
                {
                    rgstrForm = new RegistrationForm();
                }
                return rgstrForm;
            }
        }
        private RegistrationForm()
        {
            InitializeComponent();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            Header header = new Header()
            {
                Command = "register user",
                Sender = userName_txt.Text,
                Reciever = "Server",
                TypeOfMessage = "ServerUser"
            };
            Server.Message rgstrMsg = new Server.Message(header);
            if (IsValidateFields())
            {
                ServerUser usr = new ServerUser();
                usr.Name = name_txt.Text;
                usr.Family = family_txt.Text;
                usr.UserName = userName_txt.Text;
                usr.Password = pswd_txt.Text.Sha_256();

                rgstrMsg.MessageContent = usr;
                new Manager().ExecuteCommand(rgstrMsg);
            }
        }

        private bool IsValidateFields()
        {
            error_lbl.Text = "";
            bool flag = true;
            if (!string.IsNullOrEmpty(name_txt.Text) &&
               !string.IsNullOrEmpty(family_txt.Text) &&
               !string.IsNullOrEmpty(userName_txt.Text) &&
               !string.IsNullOrEmpty(pswd_txt.Text))
            {
                if (name_txt.Text.Any(n => Char.IsNumber(n)) && family_txt.Text.Any(n => char.IsNumber(n)))
                {
                    error_lbl.Text += "name and family must not contain a number\n";
                    flag = false;
                }
                if (userName_txt.Text[0].IsIn("!@#$%^&*()_+>?>,./[]<}{") &&
                    Char.IsNumber(userName_txt.Text[0]) &&
                    Char.IsSymbol(userName_txt.Text[0]))
                {
                    error_lbl.Text += "first charactor of user name most not start with symbols and numbers\n";
                    flag = false;
                }
                if (!pswd_txt.Text.Any(n => n.IsIn(@"!@#$%^&*()_+=-`~/.,}{[]';:")) &&
                !pswd_txt.Text.Any(u => char.IsNumber(u)))
                {
                    error_lbl.Text += "password must contain at least a number and a symbol\n";
                    flag = false;
                }
                if (pswd_txt.Text.Length < 8)
                {
                    error_lbl.Text += "the password lenght must be more than 8 chars\n";
                    flag = false;
                }
                return flag;
            }
            else
            {
                error_lbl.Text += "please fill the blancks\n";
                return false;
            }
            return false;
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            CheckConnection_timer.Start();
        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            Manager manager = new Manager();
            Header header = new Header() { Command = "login" };

            Server.Message message = new Server.Message(header);
            manager.ManageForms(message);
        }
        public void AddError(string error)
        {
            error_lbl.Text += error;
        }

        private async void CheckConnection_timer_Tick(object sender, EventArgs e)
        {
            await Task.Run((Action)(() =>
            {
                Client.ConnectToServer();
            }));
        }
    }
}

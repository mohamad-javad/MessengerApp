using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Server;
using Sliding_Application;

namespace MessengerApp
{
    public partial class MessengerMainForm : Form
    {
        Form currentForm;
        Manager manager;
        static MessengerMainForm mainForm;
        public static MessengerMainForm GetForm { 
            get
            {
                if (mainForm == null)
                {
                    mainForm = new MessengerMainForm();
                }
                return mainForm;
            } 
        }

        private MessengerMainForm()
        {
            InitializeComponent();
            
            
        }
        private void MessengerMainForm_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            ckeckClientConnection_timer.Start();

            //testing messenger
            SayHi();
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Header header = new Header() { Command = "personal" };
            Server.Message message = new Server.Message(header);
            message.MessageContent = Manager.Owner;
            FormManager(new ChatsMainForm(message));
        }
        private void Desktop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormManager(Form form)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            welcom_lbl.Visible = false;
            currentForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            Desktop.Controls.Add(form);
            Desktop.Tag = form;
            form.BringToFront();
            form.Show();
            PageName.Text = $"({form.Text})";
        }

        private void Profile_btn_Click(object sender, EventArgs e)
        {
            FormManager(new ProfileForm());
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Favorite_btn_Click(object sender, EventArgs e)
        {

        }
        private void People_btn_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ch_btn_Click(object sender, EventArgs e)
        {
        }
        public void SayHi(string name = "Mohammad")
        {
            BeginInvoke((Action)(() =>
            {
                welcom_lbl.Text += "\n" + name.ToUpper();
            }));
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            exit_btn.BackColor = Color.Maroon;
        }

        private void exit_btn_MouseLeave(object sender, EventArgs e)
        {
            exit_btn.BackColor = Color.Transparent;
        }

        private void exit_btn_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void ckeckClientConnection_timer_Tick(object sender, EventArgs e)
        {
            await Task.Run((Action)(() =>
            {
                Client.ConnectToServer();
            }));
        }
    }
}

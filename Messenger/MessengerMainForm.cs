using System;
using System.Drawing;
using System.Windows.Forms;
using Server;
using Sliding_Application;

namespace MessengerApp
{
    public partial class MessengerMainForm : Form
    {
        Form currentForm;
        Manager manager;
        public MessengerMainForm()
        {
            InitializeComponent();
            
            
        }
        private void MessengerMainForm_Load(object sender, EventArgs e)
        {
            Client.ConnectToServer();
            manager = new Manager();
            Header header = new Header() { Command = "upload forms" };
            Server.Message msg = new Server.Message(header);
            msg.MessageContent = this;
            manager.ExecuteCommand(msg);
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            FormManager(new ChatsMainForm());
        }

        private void FlowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Exit_btn_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void BunifuPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Exit_btn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Fill_menu_btn_Click(object sender, EventArgs e)
        {

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
        public void HideForm()
        {
            
            this.Hide();
            this.Visible = false;
            
        }
        public void SayHi(string name)
        {
            BeginInvoke((Action)(() =>
            {
                welcom_lbl.Text += "\n" + name;
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
    }
}

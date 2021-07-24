using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessengerApp;

namespace MessengerApp
{
    public partial class MessengerMainForm : Form
    {
        private Form currentForm;
        public MessengerMainForm()
        {
            InitializeComponent();
            
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

        private void PictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Logo_Click(object sender, EventArgs e)
        {

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

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            
        }

        private void Submenu(string nameOfSubPanel, bool visiblity=false)
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
            Client client = new Client();
            client.ClientSetUp();
        }

        private void Exit_btn_MouseHover(object sender, EventArgs e)
        {
            Exit_btn.BackColor = Color.Maroon;
        }

        private void Exit_btn_MouseLeave(object sender, EventArgs e)
        {
            Exit_btn.BackColor = Color.Transparent;
        }

        private void Exit_btn_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

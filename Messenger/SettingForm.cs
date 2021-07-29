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
    public partial class SettingForm : Form
    {
        static SettingForm st;
        public static SettingForm GetForm { get
            {
                if(st == null)
                {
                    st = new SettingForm();
                }
                return st;
            } }
        private SettingForm()
        {
            InitializeComponent();
        }
        private void SettingForm_Load(object sender, EventArgs e)
        {
            SetColor();
        }

        private void SetColor()
        {
            BeginInvoke((Action)(() =>
            {
                panel1.ForeColor = MessengerGUI.ForColor;
                panel1.BackColor = MessengerGUI.ThemeColor;
                foreach (Control item in this.Controls)
                {
                    item.ForeColor = MessengerGUI.ForColor;
                    item.BackColor = MessengerGUI.ThemeColor;
                }
            }));
        }
        private void SettingForm_ControlAdded(object sender, ControlEventArgs e)
        {


        }

        private void darkTheme_rb_CheckedChanged(object sender, EventArgs e)
        {
            if (lightTeme_rb.Checked)
                MessengerGUI.ChangeTheme(Theme.Light);
            else
            {
                MessengerGUI.ChangeTheme(Theme.Dark);

            }
            SetColor();
        }

        private void theme_gb_Enter(object sender, EventArgs e)
        {

        }

        private void c_w_rd_CheckedChanged_1(object sender, EventArgs e)
        {
            if (b_w_rd.Checked)
            {
                MessengerGUI.ChangeMessageColor(MessageColor.DodgerBlue);
            }
            else if (c_w_rd.Checked)
            {
                MessengerGUI.ChangeMessageColor(MessageColor.DarkCyan);
            }
            else if (m_w_rd.Checked)
            {
                MessengerGUI.ChangeMessageColor(MessageColor.Magenta);
            }
        }

        private void b_w_rd_CheckedChanged_1(object sender, EventArgs e)
        {
            if (b_w_rd.Checked)
            {
                MessengerGUI.ChangeMessageColor(MessageColor.DodgerBlue);
            }
            else if (c_w_rd.Checked)
            {
                MessengerGUI.ChangeMessageColor(MessageColor.DarkCyan);
            }
            else if (m_w_rd.Checked)
            {
                MessengerGUI.ChangeMessageColor(MessageColor.Magenta);
            }
        }

        private void m_w_rd_CheckedChanged(object sender, EventArgs e)
        {
            if (b_w_rd.Checked)
            {
                MessengerGUI.ChangeMessageColor(MessageColor.DodgerBlue);
            }
            else if (c_w_rd.Checked)
            {
                MessengerGUI.ChangeMessageColor(MessageColor.DarkCyan);
            }
            else if (m_w_rd.Checked)
            {
                MessengerGUI.ChangeMessageColor(MessageColor.Magenta);
            }
        }

        private void lightTeme_rb_CheckedChanged(object sender, EventArgs e)
        {
            if (lightTeme_rb.Checked)
            {
                MessengerGUI.ChangeTheme(Theme.Light);
            }
            else
            {
                MessengerGUI.ChangeTheme(Theme.Dark);
            }
        }
    }
}

﻿using System;
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
    public partial class ChatsMainForm : Form
    {
        Chat chat = new Chat();
        public ChatsMainForm()
        {
            InitializeComponent();
        }

        private void messages_pnl_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            chat.ShowRecivedMessage(messages_pnl, " به همگی سلام.");
           //chat.ShowRecivedMessage(messages_pnl, " همچنین سلام به شما عزیزم شمنبتیسمنبتشمبنتلبکشمنلبتیسمبنلتشیسبملنتسشلمنشتسلشمنستلب" +
              //  "شسمتمشتبمشسمنتیبشمکبمشبتشتبشنتبشمیسبشسمتبسشمکب" +
              //  "مسشبتشمسبتشسبنمشبمنسشتبمشتبمشتبمسشنبمکنسشتبشمتبسمنب");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

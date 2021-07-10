using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sliding_Application
{
    class Chat
    {
        Bunifu.Framework.UI.BunifuElipse elips = new Bunifu.Framework.UI.BunifuElipse();
        public void ShowRecivedMessage(Bunifu.UI.WinForms.BunifuShadowPanel panel, string text)
        {
            Label recivedText = new Label();
            recivedText.Dock = DockStyle.Bottom;
            recivedText.BackColor = System.Drawing.Color.DodgerBlue;
            recivedText.Anchor = AnchorStyles.None;
            SetMessageBox(panel, text, recivedText);

            

        }

        private void SetMessageBox(Bunifu.UI.WinForms.BunifuShadowPanel panel, string text, Label label)
        {
            label.AutoSize = false;
            elips.ApplyElipse(label, 10);
            label.Size = new System.Drawing.Size(300, 100);
            label.Location = new System.Drawing.Point(10, panel.Height - 50);
            label.Text = text;
            label.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            label.SendToBack();
            panel.Controls.Add(label); 
        }
        
    }
}

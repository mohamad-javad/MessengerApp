using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessengerApp
{
    interface IShowSendRecive
    {
        void ShowSend(Bunifu.UI.WinForms.BunifuShadowPanel panel);
        void ShowRecive();
    }
}

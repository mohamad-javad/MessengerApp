using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Sliding_Application
{
    public enum Theme { Dark, Light };
    public enum MessageColor { DarkCyan, Magenta, DodgerBlue };
    public static class MessengerGUI
    {

        public static System.Drawing.Color MessageBackColor
        {
            get;
            set;
            
        }

        public static System.Drawing.Color MessageForeColor
        {
            get;
            set;
        }
            


        public static System.Drawing.Color ThemeColor 
            {
            get;
            set;
            }

        public static Color ForColor
        {
            get;
            set;
        }



        public static void ChangeTheme(Theme theme)
        {
            switch (theme)
            {
                case Theme.Dark:
                    ThemeColor = System.Drawing.Color.DarkSlateGray;
                    ForColor = System.Drawing.Color.White;
                    break;
                case Theme.Light:
                    ThemeColor = System.Drawing.Color.WhiteSmoke;
                    ForColor = System.Drawing.Color.Black;
                    break;
                default:
                    break;
            }
        }

        public static void ChangeMessageColor(MessageColor color)
        {
            switch (color)
            {
                case MessageColor.DarkCyan:
                    MessageForeColor = Color.White;
                    MessageBackColor = Color.DarkCyan;
                    break;
                case MessageColor.Magenta:
                    MessageForeColor = Color.White;
                    MessageBackColor = Color.Magenta;
                    break;
                case MessageColor.DodgerBlue:
                    MessageForeColor = Color.White;
                    MessageBackColor = Color.DodgerBlue;
                    break;
                default:
                    break;
            }
        }

    }
}

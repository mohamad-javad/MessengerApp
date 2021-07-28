using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Sliding_Application
{
    public enum Theme { Dark, Light };
    public enum MessageColor { DarkCyan, Magenta, DarkBlue };
    public static class MessengerGUI
    {
        static System.Drawing.Color _themeColor = System.Drawing.Color.WhiteSmoke;
        private static System.Drawing.Color _messageForeColor;
        private static System.Drawing.Color _messageBackColor;

        public static System.Drawing.Color MessageBackColor
        {
            get { return _messageBackColor; }
            set { _messageBackColor = value; }
        }

        public static System.Drawing.Color MessageForeColor
        {
            get { return _messageForeColor; }
            set { _messageForeColor = value; }
        }
            


        public static System.Drawing.Color ThemeColor { 
            get
            {
                return _themeColor;
            }
            
        }
        static System.Drawing.Color _forColor = System.Drawing.Color.Black;
        public static System.Drawing.Color ForColor
        {
            get
            {
                return _forColor;
            }

        }



        public static void ChangeTheme(Theme theme)
        {
            switch (theme)
            {
                case Theme.Dark:
                    _themeColor = System.Drawing.Color.BlueViolet;
                    _forColor = System.Drawing.Color.White;
                    break;
                case Theme.Light:
                    _themeColor = System.Drawing.Color.WhiteSmoke;
                    _forColor = System.Drawing.Color.Black;
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
                    MesageForeColor = Color.White;
                    MessageBackColor = Color.DarkCyan;
                    break;
                case MessageColor.Magenta:
                    MesageForeColor = Color.White;
                    MessageBackColor = Color.Magenta;
                    break;
                case MessageColor.DarkBlue:
                    MesageForeColor = Color.White;
                    MessageBackColor = Color.DarkBlue;
                    break;
                default:
                    break;
            }
        }

    }
}

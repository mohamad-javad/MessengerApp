using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sliding_Application
{
    public enum Theme { Dark, Light };
    public static class MessengerGUI
    {
        static System.Drawing.Color _themeColor = System.Drawing.Color.WhiteSmoke;
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

        

    }
}

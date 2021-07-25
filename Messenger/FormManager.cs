using MessengerApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sliding_Application
{
    public static class FormManager
    {
        
        public static MessengerMainForm MainForm { get; private set; }
        public static RegistrationForm Registration { get; private set; }
        public static LoginForm Login { get; private set; }
        static FormManager()
        {
            MainForm = MessengerMainForm.GetForm;
            Registration = RegistrationForm.GetForm;
            Login = LoginForm.GetFrom;
            
        }

        public static void ShowMain(this Manager manager)
        {
            try { MainForm.ShowDialog(); } catch { }
        }
        public static void HideLogin(this Manager manager)
        {
            if (Login.Visible)
            {
                Login.Visible = false;
                Login.Hide();
            }
        }
        public static void HideRegistration(this Manager manager)
        {
            if (Registration.Visible)
            {
                Registration.Visible = false;
                Registration.Hide();
            }
        }
        public static void ShowRegistration(this Manager manager)
        {
            manager.HideLogin();

            try { Registration.ShowDialog(); } catch { }
        }

        public static void ShowLogin(this Manager manager)
        {


            try
            {
                Login.Show();
            }
            catch { }
            manager.HideRegistration();

        }
        public static void AddError(this Manager manager, string error, string form)
        {
            switch (form)
            {
                case "login":
                    Login.AddError(error);
                    break;
                case "register":
                    Registration.AddError(error);
                    break;
                default:
                    break;
            }
        }
        public static void SayHi(this string name)
        {
            MainForm.SayHi(name.ToUpper());
        }


    }

}

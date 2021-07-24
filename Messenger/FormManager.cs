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

        public static void UploadForms(MessengerMainForm mainForm)
        {
            MainForm = mainForm;
            Registration = RegistrationForm.GetForm;
            Login = LoginForm.GetFrom;
        }
        public static void HideAll(this Manager manager)
        {
            try { MainForm.Hide(); } catch { }
            try{ Registration.Hide(); } catch{}
            try { Login.Hide(); } catch { }
        }
        public static void ShowMain(this Manager manager)
        {
            try { MainForm.ShowDialog(); } catch { }
            try { Registration.Hide(); } catch { }
            try { Login.Hide(); } catch { }
        }
        public static void ShowRegistratio(this Manager manager)
        {
            try { MainForm.Hide(); } catch { }
            try { Registration.ShowDialog(); } catch { }
            try { Login.Hide(); } catch { }
        }

        public static void ShowLogin(this Manager manager)
        {
            try { MainForm.Hide(); } catch { }
            try { Registration.Hide(); } catch { }
            try { Login.ShowDialog(); } catch { }
        }
        


    }
}

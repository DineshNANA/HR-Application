using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HR_Application
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
            //Login  fLogin = new Login ();
            //if (fLogin.ShowDialog() == DialogResult.OK)
            //{
            //    Application.Run(new AdminPanel());
            //}
            //else
            //{
            //    Application.Exit();
            //}
        }
    }
}

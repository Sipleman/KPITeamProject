using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EP
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //AuthorizationsForm auth = new AuthorizationsForm();
            //Application.Run(auth);
            //Application.Run(new AuthorizationsForm());
            Screensaver first = new Screensaver();
            //AuthorizationsForm AuthForm = new AuthorizationsForm();
            DateTime end = DateTime.Now + TimeSpan.FromSeconds(5);
            first.Show();
            while (end > DateTime.Now)
            {
                Application.DoEvents();
            }
            first.Close();
            first.Dispose();

            Application.Run(new AuthorizationsForm());
        }
    }
}

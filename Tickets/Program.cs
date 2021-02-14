using System;
using System.Windows.Forms;
using Tickets.Views;

namespace Tickets
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

            var view = new MainView();
            Application.Run(view);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Проект_2
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

            Load load = new Load();
            DateTime end = DateTime.Now + TimeSpan.FromSeconds(5);
            load.Show();
            while(end>DateTime.Now)
            {
                Application.DoEvents();
            }
            load.Close();
            load.Dispose();
            Application.Run(new Main());
        }
    }
}

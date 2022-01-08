using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie3
{
    internal static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            LoginForm loginForm = new LoginForm();
            ProductionLineForm productionLineForm = new ProductionLineForm();
            IsPresentForm isPresentForm = new IsPresentForm();
            Application.Run(new LoginForm());
            if (loginForm.loginOK)
            {
                Application.Run(productionLineForm);
            }
            if (isPresentForm.tickEnd)
            {
                productionLineForm.Close();
                Application.Exit();
            }
            

        }
       
    }
}

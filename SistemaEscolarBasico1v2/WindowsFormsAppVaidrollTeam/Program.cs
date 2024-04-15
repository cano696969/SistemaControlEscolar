using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppVaidrollTeam
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// Youtube/VaidrollTeam
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}

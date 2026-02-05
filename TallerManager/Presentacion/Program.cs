using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FrmLogin loginForm = new FrmLogin();
            DialogResult result = loginForm.ShowDialog();
            if(result == DialogResult.OK)
            {
                Application.Run(new FrmHome());
            }
            else
            {
                Application.Exit();
            }

                
        }
    }
}

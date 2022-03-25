using AppRepaso.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRepaso
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //importante sacarlo fuera del run
            //sino no funciona
            FormularioBienvenida form = new FormularioBienvenida();
            form.ShowDialog();
            Application.Run();
        }
    }
}

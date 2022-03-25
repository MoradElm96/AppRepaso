using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRepaso.Controladores
{
    public class ControladorFormBienvenida
    {

        public static string  leerArchivo() 
        {
            string color;
            string texto;
            string imagen;

            try
            {
                string[] lineas = System.IO.File.ReadAllLines(@"Resources/parametros.txt");
                if (lineas.Length > 0)
                {
                     color = lineas[0];
                     texto = lineas[1];
                     imagen = lineas[2];


                }
            }

            catch (Exception e)
            {
                Console.WriteLine("Error al leer fichero " + e.Message);
            }
        
        }
    }
}

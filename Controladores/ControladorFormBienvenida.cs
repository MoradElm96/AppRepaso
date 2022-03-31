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

        public static List<string>  leerArchivo() 
        {
          

            List<string> listaParametros = new List<string>();


            try
            {
                //lee el fichero texto
               
                string[] lineas = System.IO.File.ReadAllLines("../../Resources/parametros.txt");
                if (lineas.Length > 0)
                {
                    listaParametros.Add(lineas[0]);
                    listaParametros.Add(lineas[1]);
                    listaParametros.Add(lineas[2]);
                }
            }

            catch (Exception e)
            {
                Console.WriteLine("Error al leer fichero " + e.Message);
            }

            return listaParametros;
        
        }


    }
}

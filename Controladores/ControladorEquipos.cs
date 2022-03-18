using AppRepaso.Clases;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRepaso.Controladores
{
    public class ControladorEquipos
    {
       
        public static List<Equipo> GetEquipos()
        {
            List<Equipo> listaDeEquipos = new List<Equipo>();
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;

                MySqlConnection cnn = new MySqlConnection(connectionString);
                cnn.Open();
                MySqlCommand comando = cnn.CreateCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM equipos";
                MySqlDataReader dataReader = comando.ExecuteReader();
                while (dataReader.Read())
                {
                    int idEquipo = dataReader.GetInt32("idEquipo");
                    string nombre = dataReader.GetString("nombre");
                    string logo= dataReader.GetString("logo");
                    string deporte = dataReader.GetString("deporte");

                     listaDeEquipos.Add(new Equipo(idEquipo, nombre, logo, deporte));
                }
                dataReader.Close();
                comando.Dispose();
                cnn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en la conexión " + e.Message);
            }
            return listaDeEquipos;
        }

    }
}

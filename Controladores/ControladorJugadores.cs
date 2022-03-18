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
   public  class ControladorJugadores
    {

        public static List<Jugador> GetJugadores(int idEquipo)
        {
            List<Jugador> listaDeJugadores = new List<Jugador>();
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;

                MySqlConnection cnn = new MySqlConnection(connectionString);
                cnn.Open();
                MySqlCommand comando = cnn.CreateCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM jugadores WHERE idEquipo = @idEquipo";
                comando.Parameters.AddWithValue("@idEquipo",idEquipo);
                comando.Prepare();
                MySqlDataReader dataReader = comando.ExecuteReader();
                while (dataReader.Read())
                {
                  //  int idEquipoo = dataReader.GetInt32("idEquipo");

                    string dni = dataReader.GetString("dni");
                    string nombre = dataReader.GetString("nombre");
                    string apellidos = dataReader.GetString("apellidos");
                    string foto = dataReader.GetString("foto");
                    DateTime fechaNacimiento = dataReader.GetDateTime("fechaNacimiento");
                    DateTime fechaContratacion = dataReader.GetDateTime("fechaContratacion");
                    double sueldo = dataReader.GetDouble("sueldo");
                    

                    listaDeJugadores.Add(new Jugador( dni, nombre, apellidos,  foto,  fechaNacimiento,  fechaContratacion,  sueldo));
                }
                dataReader.Close();
                comando.Dispose();
                cnn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error en la conexión " + e.Message);
            }
            return listaDeJugadores;
        }


    }
}

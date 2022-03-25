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
    public class ControladorJugadores
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
                comando.Parameters.AddWithValue("@idEquipo", idEquipo);
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


                    listaDeJugadores.Add(new Jugador(dni, nombre, apellidos, foto, fechaNacimiento, fechaContratacion, sueldo));
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

        public static bool IncrementarSueldo(string dni)
        {
            //actualiza el sueldo sumandole 1000euros
            //se necesita el string dni del jugador que lo obtenemos del datagrid como campo selecionado
            bool resultado = true;
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;

                MySqlConnection cnn = new MySqlConnection(connectionString);
                cnn.Open();
                MySqlCommand comando = cnn.CreateCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "update jugadores set sueldo=sueldo+1000  WHERE dni = @dni";
                comando.Parameters.AddWithValue("@dni", dni);
                comando.Prepare();

                MySqlDataAdapter adaptador = new MySqlDataAdapter();
                adaptador.UpdateCommand = comando;
                if (adaptador.UpdateCommand.ExecuteNonQuery() == 0)
                {
                    resultado = false;
                }
                adaptador.Dispose();
                comando.Dispose();
            
        } catch (Exception e) {
                  Console.WriteLine("Error al actualizar " + e.Message);
                  resultado = false;
        }
        return resultado;

            //update salaries set salary=salary*1.1 where emp_no in (select emp_no from emp_bonus);


        }

        public static bool borrarjugadores(string dni)
        {
            bool resultado = true;
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
                MySqlConnection cnn = new MySqlConnection(connectionString);
                cnn.Open();
                MySqlCommand comando = cnn.CreateCommand();
                comando.CommandType = CommandType.Text;

                comando.CommandText = "DELETE from jugadores WHERE dni=@dni";
                comando.Parameters.AddWithValue("@dni", dni);
                comando.Prepare();

                MySqlDataAdapter adaptador = new MySqlDataAdapter();
                    adaptador.DeleteCommand = comando;
                    if (adaptador.DeleteCommand.ExecuteNonQuery() == 0)
                    {
                        resultado = false;
                    }
                    adaptador.Dispose();
                    comando.Dispose();
                    
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error al eliminar " + e.Message);
                    resultado = false;
                }
                return resultado;
            }

        public static string sumarSueldos()
        {
            string resultado = "Suma 0 contador 0";
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;
                MySqlConnection cnn = new MySqlConnection(connectionString);
                cnn.Open();
                MySqlCommand comando = cnn.CreateCommand();
                comando.CommandType = CommandType.Text;

                comando.CommandText = "select sum(sueldo) , count(*) from jugadores";
                MySqlDataReader dataReader = comando.ExecuteReader();
                if (dataReader.Read())
                {
                    double sueldo = dataReader.GetDouble(0);
                    long contador = dataReader.GetInt64(1);
                    resultado = "Suma " + sueldo + " contador " + contador;
                 } 
                dataReader.Close();
                comando.Dispose();
                cnn.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error al leer sueldos " + e.Message);
            }
            return resultado;
        }


    }
}
    

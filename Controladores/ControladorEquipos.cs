using AppRepaso.Clases;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

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


        public static bool guardarXml(List<Equipo> lista, String ruta)
        {
            try
            {
                using (var writer = new StreamWriter(ruta))
                {
                    // Do this to avoid the serializer inserting default XML namespaces.
                    var namespaces = new XmlSerializerNamespaces();
                    namespaces.Add(string.Empty, string.Empty);

                    var serializer = new XmlSerializer(lista.GetType());
                    serializer.Serialize(writer, lista, namespaces);
                }
            }
            catch (Exception e) { }

            return true;


        }

        public static List<Equipo> leerXml(String ruta)
        {
            List<Equipo> listaLeidos = new List<Equipo>();
            try
            {
                string xml = File.ReadAllText(ruta);
                using (var reader = new StringReader(xml))
                {
                    XmlSerializer serializer = new XmlSerializer(listaLeidos.GetType());
                    listaLeidos = (List<Equipo>)serializer.Deserialize(reader);
                }
                    
            }
            catch (Exception e)
            {
                Console.WriteLine("Error leyendo xml " + e.Message);
            }

            return listaLeidos;


        }


        public bool insertarEquipo(Equipo equipo)
        {
            bool respuesta = true;
            try
            {
               string connectionString = ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString;

                MySqlConnection cnn = new MySqlConnection(connectionString);
                cnn.Open();
                MySqlCommand comando = cnn.CreateCommand();
                comando.CommandType = CommandType.Text;
                comando.CommandText = "INSERT INTO equipos (idEquipo,nombre,logo,deporte) Values (@idEquipo,@nombre,@logo,@deporte)";
                comando.Parameters.AddWithValue("@idEquipo", equipo.idEquipo);
                comando.Parameters.AddWithValue("@nombre", equipo.nombre);
                comando.Parameters.AddWithValue("@logo", equipo.logo);
                comando.Parameters.AddWithValue("@deporte", equipo.deporte);
                comando.Prepare();
                MySqlDataAdapter adaptador = new MySqlDataAdapter();
                adaptador.InsertCommand = comando;
                if (adaptador.InsertCommand.ExecuteNonQuery() == 0)
                {
                    respuesta = false;
                    MessageBox.Show("no hay equipos que insertar, revise el xml");
                }

                comando.Dispose();
                cnn.Close();
            }
            catch (Exception en)
            {
                Console.WriteLine("Error al insertar" + en.Message);
                respuesta = false;
            }
            return respuesta;

        }
           
        }


    }




    


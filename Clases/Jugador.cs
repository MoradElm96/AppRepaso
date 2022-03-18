using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRepaso.Clases
{
    public class Jugador
    {
        public string dni { set; get; }
        public string  nombre { set; get; }
        public string  apellidos { set; get; }
        public string  foto { set; get; }
        public DateTime fechaNacimiento { set; get; }
        public DateTime fechaContratacion { set; get; }
        public double sueldo { set; get; }
        public int idEquipo { set; get; }

        public Jugador(string dni, string nombre, string apellidos, string foto, DateTime fechaNacimiento, DateTime fechaContratacion, double sueldo, int idEquipo)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.foto = foto;
            this.fechaNacimiento = fechaNacimiento;
            this.fechaContratacion = fechaContratacion;
            this.sueldo = sueldo;
            this.idEquipo = idEquipo;
        }

        public Jugador(string dni, string nombre, string apellidos, string foto, DateTime fechaNacimiento, DateTime fechaContratacion, double sueldo)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.foto = foto;
            this.fechaNacimiento = fechaNacimiento;
            this.fechaContratacion = fechaContratacion;
            this.sueldo = sueldo;
            
        }

        public Jugador()
        {

        }
    }
}

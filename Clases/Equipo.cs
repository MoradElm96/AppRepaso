using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRepaso.Clases
{
    public class Equipo
    {
        public int idEquipo { set; get; }
        public string nombre {set; get;}

        public string logo { set; get; }

        public string deporte { set; get; }

        public Equipo(int idEquipo, string nombre, string logo, string deporte)
        {
            this.idEquipo = idEquipo;
            this.nombre = nombre;
            this.logo = logo;
            this.deporte = deporte;
        }

        public Equipo()
        {
        }
    }
}

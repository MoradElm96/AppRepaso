using AppRepaso.Clases;
using AppRepaso.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRepaso.Vistas
{
    public partial class FrmNuevoJugador : Form
    {
        public FrmNuevoJugador()
        {
            InitializeComponent();
            cargarIdEquipos();
        }


        List<Equipo> lista;

        private void btnAnadir_Click(object sender, EventArgs e)
        {

            string dni = textBoxDni.Text;
            string nombre = textBoxNombre.Text;
            string apellidos = textBoxApellidos.Text;
            string foto = pictureBox1Foto.Name;
            DateTime fechaNacimiento = dateTimePicker1Nacimiento.Value;
            DateTime fechaContratacion = dateTimePicker2Contratacion.Value;
            double sueldo = double.Parse(numericUpDown1Sueldo.Value.ToString());
            int idEquipo = (int)listBox1IdEquipo.SelectedValue;

            Regex rxDni = new Regex(@"/^[0-9]{8}[A-Z]$/i");//problema al validar dni

            if (!rxDni.IsMatch(dni))
            {
                MessageBox.Show("dni incorrecto");
            }
            else
            {

                Jugador jugador = new Jugador(dni, nombre, apellidos, foto, fechaNacimiento, fechaContratacion, sueldo, idEquipo);

                if (new Controladores.ControladorJugadores().insertarJugadores(jugador))
            {
                MessageBox.Show("jugador contratado");
                }
                else { MessageBox.Show("error al insertar jugador"); }


            }

           
          
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1IdEquipo_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }



        public void cargarIdEquipos()
        {
            lista = ControladorEquipos.GetEquipos();

            listBox1IdEquipo.DataSource = lista;
            listBox1IdEquipo.DisplayMember = "nombre";
            listBox1IdEquipo.ValueMember = "idEquipo";
            //añadir evento, poner poraqui mejor, 
            this.listBox1IdEquipo.SelectedIndexChanged += listBox1IdEquipo_SelectedIndexChanged;
            //preguntar como no hacerque se seleccione por defecto

        }

    }


}

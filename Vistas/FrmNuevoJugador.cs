using AppRepaso.Clases;
using AppRepaso.Controladores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            string foto = "fotodefecto.png";
            if (pictureBox1Foto.Tag!=null) {
                pictureBox1Foto.Tag.ToString();//duda como guardar ruta
            }
            DateTime fechaNacimiento = dateTimePicker1Nacimiento.Value;
            DateTime fechaContratacion = dateTimePicker2Contratacion.Value;
            double sueldo = double.Parse(numericUpDown1Sueldo.Value.ToString());
            int idEquipo = (int)listBox1IdEquipo.SelectedValue;






            Regex rxDni = new Regex(@"^(([A-Z]{1}\d{8})|(\d{8}[A-Z]{1}))$");//problema al validar dni

            if (!rxDni.IsMatch(dni.ToString()))
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
                else
                {
                    MessageBox.Show("error al insertar jugador");
                }

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

        public void button1_Click(object sender, EventArgs e)
        {
            var rutaArchivo = string.Empty;


            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "img files (*.png)|*.png|(*.jpg)|*.jpg|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    rutaArchivo = openFileDialog.FileName;
                    pictureBox1Foto.Image = Image.FromFile(rutaArchivo);
                    pictureBox1Foto.Tag = rutaArchivo; 


                }
            }
        }

    }
}

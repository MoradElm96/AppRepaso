using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRepaso.Vistas
{
    public partial class FormularioBienvenida : Form
    {
        public FormularioBienvenida()
        {
            InitializeComponent();
        }

        //show dialog te bloquea y show a secas no
        private void button1_Click(object sender, EventArgs e)
        {
            FormularioPrincipal formularioPrincipal = new FormularioPrincipal();
            formularioPrincipal.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void FormularioBienvenida_Load(object sender, EventArgs e)
        {
            List<String> parametros = Controladores.ControladorFormBienvenida.leerArchivo();
            //carga la imagen desde la url de la lista leida obtenida a traves del fichero texto

            
            int finalColor = parametros[0].Length;//22
         
            int finalTexto = parametros[1].Length;//89
            
            int finalImagen = parametros[2].Length;//37
           
            //para saber longitud final de la cadena

            
            string urlimagen = parametros[2].Substring(7);
            
            pictureBox1.Load(urlimagen);
            //como usar image from file
           
            //sub string se puede poner solo el primer caracter hasta el final, tiene un constructor no hace falta indicarle el otro parametro

            label1.Text = parametros[1].Substring(6); 
           
           
            this.BackColor = (Color)new ColorConverter().ConvertFromString(parametros[0].Substring(6));


        }
    }
}

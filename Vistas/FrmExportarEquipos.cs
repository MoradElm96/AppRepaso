using AppRepaso.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRepaso.Vistas
{
    public partial class FrmExportarEquipos : Form
    {
        public FrmExportarEquipos()
        {
            InitializeComponent();
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            {
                //var rutaAArchivo = string.Empty;
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.InitialDirectory = "c:\\";
                saveFileDialog1.Title = "Save xml Files";
                saveFileDialog1.CheckPathExists = true;
                saveFileDialog1.DefaultExt = "xml";
                saveFileDialog1.Filter= "Xml files (*.xml)|*.xml|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    textBox2.Text = saveFileDialog1.FileName;//duda como poner el nombre en vez de rutaa                   

                }



            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            string ruta = textBox2.Text;

            List<Equipo> listaEquipos =  Controladores.ControladorEquipos.GetEquipos();

            if (listaEquipos == null)
            {
                MessageBox.Show("No se ha selecionado ningun equipo");//duda
            } else { Controladores.ControladorEquipos.guardarXml(listaEquipos, ruta);

                MessageBox.Show("La operacion se ha realizado existosamente");

            }
           
            

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}

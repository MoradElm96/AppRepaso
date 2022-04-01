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
                var rutaAArchivo = string.Empty;
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.InitialDirectory = "c:\\";
                saveFileDialog1.Title = "Save text Files";
                saveFileDialog1.CheckPathExists = true;
                saveFileDialog1.DefaultExt = "xml";
                saveFileDialog1.Filter= "Xml files (*.xml)|*.xml|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog()== DialogResult.OK)
                {
                    textBox1.Text = saveFileDialog1.FileName;                   

                }



            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            string ruta = textBox1.Text;

            List<Equipo> listaEquipos =  Controladores.ControladorEquipos.GetEquipos();

            Controladores.ControladorEquipos.guardarXml(listaEquipos, ruta);
            

        }
    }
}

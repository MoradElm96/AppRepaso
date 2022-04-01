using AppRepaso.Controladores;
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
    public partial class FormularioPrincipal : Form
    {
        public FormularioPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripLabel6_Click(object sender, EventArgs e)
        {
            FrmJugadores form1 = new FrmJugadores();
            form1.Show();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {

            FrmJugadores form1;


            if (!ControladorFormularios.EstaFormularioAbierto(typeof(FrmJugadores)))
            {
                form1 = new FrmJugadores();
                form1.MdiParent = this;
                //para maximizar
                form1.WindowState = FormWindowState.Maximized;
                form1.Show();
            }
            else
            {
                form1 = (FrmJugadores)ControladorFormularios.RecuperarFormulario(typeof(FrmJugadores));
                if (form1.WindowState == FormWindowState.Minimized)
                {
                    form1.WindowState = FormWindowState.Normal;
                }
                form1.Show();
                form1.Focus();
            }
            
            //Si se pulsa la opción Jugadores se debe mostrar el formulario del DIA 1 maximizado. Si el formulario ya estaba abierto no se debe abrir uno nuevo
        }

        private void exportarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExportarEquipos frmExportarEquipos;

            if (!ControladorFormularios.EstaFormularioAbierto(typeof(FrmExportarEquipos)))
            {
                frmExportarEquipos = new FrmExportarEquipos();
                frmExportarEquipos.MdiParent = this;
                //para maximizar
                frmExportarEquipos.WindowState = FormWindowState.Maximized;
                frmExportarEquipos.Show();
            }
            else
            {
                frmExportarEquipos = (FrmExportarEquipos)ControladorFormularios.RecuperarFormulario(typeof(FrmExportarEquipos));
                if (frmExportarEquipos.WindowState == FormWindowState.Minimized)
                {
                    frmExportarEquipos.WindowState = FormWindowState.Normal;
                }
                frmExportarEquipos.Show();
                frmExportarEquipos.Focus();
            }
        }
    }
}

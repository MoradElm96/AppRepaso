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

        private void importarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmImportarEquipos frmImportarEquipos;
            if (!ControladorFormularios.EstaFormularioAbierto(typeof(FrmImportarEquipos)))
            {
                frmImportarEquipos = new FrmImportarEquipos();
                frmImportarEquipos.MdiParent = this;
                frmImportarEquipos.Show();

            }
            else
            {  //para si esta minimizado volver a maximizarlo
                frmImportarEquipos = (FrmImportarEquipos)ControladorFormularios.RecuperarFormulario(typeof(FrmImportarEquipos));
                if(frmImportarEquipos.WindowState == FormWindowState.Minimized)
                {
                    frmImportarEquipos.WindowState = FormWindowState.Normal;
                }
                frmImportarEquipos.Show();
                frmImportarEquipos.Focus();
            }
        }

        private void toolStripLabel4_ButtonClick(object sender, EventArgs e)
        {

        }

        private void nuevoJugadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNuevoJugador frmNuevoJugador;
            if (!ControladorFormularios.EstaFormularioAbierto(typeof(FrmNuevoJugador)))
            {
                frmNuevoJugador = new FrmNuevoJugador();
                frmNuevoJugador.MdiParent = this;
                frmNuevoJugador.WindowState = FormWindowState.Maximized;
                frmNuevoJugador.Show();

            }
            else
            {  //para si esta minimizado volver a maximizarlo
                frmNuevoJugador = (FrmNuevoJugador)ControladorFormularios.RecuperarFormulario(typeof(FrmNuevoJugador));
                if (frmNuevoJugador.WindowState == FormWindowState.Minimized)
                {
                    frmNuevoJugador.WindowState = FormWindowState.Normal;
                }
                frmNuevoJugador.Show();
                frmNuevoJugador.Focus();
            }
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel3_ButtonClick(object sender, EventArgs e)
        {

        }

        private void gestionarJugadoresToolStripMenuItem_Click(object sender, EventArgs e)
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
    }
}

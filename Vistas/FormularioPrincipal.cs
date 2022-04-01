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


            if (!EstaFormularioAbierto(typeof(FrmJugadores)))
            {
                form1 = new FrmJugadores();
                form1.MdiParent = this;
                //para maximizar
                form1.WindowState = FormWindowState.Maximized;
                form1.Show();
            }
            else
            {
                form1 = (FrmJugadores)RecuperarFormulario(typeof(FrmJugadores));
                if (form1.WindowState == FormWindowState.Minimized)
                {
                    form1.WindowState = FormWindowState.Normal;
                }
                form1.Show();
                form1.Focus();
            }
            
            //Si se pulsa la opción Jugadores se debe mostrar el formulario del DIA 1 maximizado. Si el formulario ya estaba abierto no se debe abrir uno nuevo
        }

        public static bool EstaFormularioAbierto(Type tipo)
        {
            foreach (Form frm in Application.OpenForms)//lista 
            {
                if (frm.GetType() == tipo)
                {
                    return true;
                }
            }
            return false;
        }
        public static Form RecuperarFormulario(Type tipo)
        {
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.GetType() == tipo)
                {
                    return frm;
                }
            }
            return null;
        }
    }
}

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
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            /*
            Usuarios usuarios;
            if (!Globales.EstaFormularioAbierto(typeof(Usuarios)))
            {
                usuarios = new Usuarios();
                usuarios.MdiParent = this;
                usuarios.Show();
            }
            else
            {
                usuarios = (Usuarios)Globales.RecuperarFormulario(typeof(Usuarios));
                if (usuarios.WindowState == FormWindowState.Minimized)
                {
                    usuarios.WindowState = FormWindowState.Normal;
                }
                usuarios.Show();
                usuarios.Focus();
            }
            */
            //Si se pulsa la opción Jugadores se debe mostrar el formulario del DIA 1 maximizado. Si el formulario ya estaba abierto no se debe abrir uno nuevo
        }

        public static bool EstaFormularioAbierto(Type tipo)
        {
            foreach (Form frm in Application.OpenForms)
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

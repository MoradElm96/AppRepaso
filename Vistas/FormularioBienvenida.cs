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
    }
}

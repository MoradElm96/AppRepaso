using AppRepaso.Clases;
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

namespace AppRepaso
{
    public partial class Form1 : Form
    {
        List<Equipo> lista;
        List<Jugador> listaJugadores;

        public Form1()
        {
            InitializeComponent();
            
        }

        public void cargarEquipos()
        {
            lista =  ControladorEquipos.GetEquipos();

            listBox1.DataSource = lista;
            listBox1.DisplayMember = "nombre";
            listBox1.ValueMember = "idEquipo";
            this.listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;


        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idEquipo = (int)listBox1.SelectedValue;
            //convertir a int porque es un string, siempre coger el value
            //selected item es todo entero el equipo entero, hay qye convertir a objeto equipo y luego coger el .idEquipo

            //datasource, lista de textos, pero tambien puede ser una lista de objetos
            //si tengo lista de objetos , displaymember  es lo que yo veo en la pantalla y value member el valor que quiero quedarme para trabajar.
            //selected index, la posicion, si admite coger varios es items  
            dataGridView1.DataSource = ControladorJugadores.GetJugadores(idEquipo);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarEquipos();
            
        }

        public void cargarDataGrid()
        {
          
        }
        
    }
}

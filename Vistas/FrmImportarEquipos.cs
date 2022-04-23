﻿using AppRepaso.Clases;
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
    public partial class FrmImportarEquipos : Form
    {
        public FrmImportarEquipos()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            {
               // var rutaAArchivo = string.Empty;

                OpenFileDialog openFileDialog = new OpenFileDialog();

               

                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Title = "Open xml Files";
                openFileDialog.CheckPathExists = true;
                openFileDialog.DefaultExt = "xml";
                openFileDialog.Filter = "All files (*.*)|*.*|Xml files (*.xml)|*.xml";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = openFileDialog.FileName;  //SafeFileName;//para solo el nombre del archivo
                    //si no pongo file no me deja cojer la ruta

                }



            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {

            string ruta =    textBox1.Text;

            List<Equipo> listaleidos = Controladores.ControladorEquipos.leerXml(ruta);
            
            if (listaleidos == null)
            {
                MessageBox.Show("No se ha encontrado nigun  equipo");//duda
            }
            else
            {
                foreach (var equipos in listaleidos) {
                    Console.WriteLine(equipos.idEquipo);
                    Console.WriteLine(equipos.nombre);
                    Console.WriteLine(equipos.logo);
                    Console.WriteLine(equipos.deporte);
                    //preguntar por que el id sale cero todo el rato y si en hay que saber la estructura del xml
                }

                

                MessageBox.Show("La operacion se ha realizado existosamente");
                

            }
        }
    }
}
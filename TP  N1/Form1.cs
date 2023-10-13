using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP__N1_Ejercicio_01
{
    public partial class Form1 : Form
        
    {
        Estudiante alumno = new Estudiante();
         
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtEdad.Text == "" || txtClasificacion.Text == "")
            {
                MessageBox.Show("Debe llenar todos los campos para poder Guardar");
            }
            else
            {
                alumno.Nombre = txtNombre.Text;
                alumno.Edad = txtEdad.Text;
                alumno.Clasificacion = txtClasificacion.Text;
                alumno.Guardar();
                dgv.Rows.Add(alumno.Nombre, alumno.Edad, alumno.Clasificacion);
                txtNombre.Text = "";
                txtEdad.Text = "";
                txtClasificacion.Text = "";
            }
           
        }
    }
}

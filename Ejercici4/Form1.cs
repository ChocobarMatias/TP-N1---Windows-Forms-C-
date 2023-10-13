using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercici4
{
    public partial class Form1 : Form
    {
        Empleado empleado = new Empleado();
        Salario salario = new Salario();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtEdad.Text == "" || txtSueldoxDia.Text == "" || txtDiasTrabajados.Text == "")
            {
                MessageBox.Show(" Es olbligatorio llenar todos los Campos");
            }
            else
            {
                salario.Nombre = txtNombre.Text;
                salario.Apellido = txtApellido.Text;
                salario.Edad = txtEdad.Text;
                salario.SueldoxDia = Int32.Parse(txtSueldoxDia.Text);
                salario.DiasTrabajados = Int32.Parse(txtDiasTrabajados.Text);
                salario.SueldoMensual();
                txtSueldoxMes.Text = $"${salario.SalarioxMes}";
                dataGridView1.Rows.Add(salario.Nombre,salario.Apellido,salario.Edad,$"${salario.SueldoxDia}",$"{salario.DiasTrabajados}",$"${salario.SalarioxMes}");

            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEdad.Text = "";
            txtSueldoxDia.Text = "";
            txtDiasTrabajados.Text = "";
            txtSueldoxMes.Text = "";
        }
    }
}

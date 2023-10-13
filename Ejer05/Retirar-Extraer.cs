using Ejercicio_05;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejer05
{
    public partial class Retirar : Form
    {
        public static double sacar;
        CuentaBancaria retiro = new CuentaBancaria();
        public Retirar()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Form Cuenta = new Form1();
            Cuenta.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            sacar = Int32.Parse(txtRetirar.Text);
            if (sacar > retiro.Saldo)
            {
                MessageBox.Show(" SALDO INSUFICIENTE");
            }
            else
            {
                lblSalInicial.Text = "$"+retiro.Saldo.ToString();
                retiro.Retirar(sacar);
                lblsacar.Text = "$"+sacar.ToString();
                lblfinal.Text = "$"+retiro.Saldo.ToString();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            sacar = 0;
            txtRetirar.Text = "";
            lblsacar.Text = "";
            lblfinal.Text = "";
            lblSalInicial.Text = "";
        }

        private void lblRetiro_Click(object sender, EventArgs e)
        {

        }

        private void Retirar_Load(object sender, EventArgs e)
        {

        }

        private void btnTICKET_Click(object sender, EventArgs e)
        {
            Form ticket = new Tickect();

            ticket.Show();
            this.Hide();
        }
    }
}

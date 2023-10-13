using Ejer05;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_05
{
    public partial class Form1 : Form
    {
        double deposito;
        double retiro;
        CuentaBancaria cuenta = new CuentaBancaria();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaldo_Click(object sender, EventArgs e)
        {
            MessageBox.Show($" Saldo Actual = ${cuenta.Saldo}");
        }

        private void btnDeposito_Click(object sender, EventArgs e)
        {
           Form Depositos = new Form2();
            Depositos.Show();
            this.Hide();
        }

        private void btnRetiro_Click(object sender, EventArgs e)
        {
            Form Retiro = new Retirar();
            Retiro.Show();
            this.Hide();
        }
    }
}

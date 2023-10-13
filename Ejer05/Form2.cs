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
    public partial class Form2 : Form
    {
        double deposito;
        
        CuentaBancaria cuenta = new CuentaBancaria();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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
            deposito = double.Parse(txtDepositar.Text);
            if (deposito > 15000)
            {
                MessageBox.Show(" Sobrepaso el monto permitido diario");
            }
            else
            {
                
                lblSalInicial.Text = "$" + cuenta.Saldo.ToString();
                cuenta.Depositar(deposito);
                lbldepo.Text = "$" + deposito.ToString();
                lblfinal.Text = "$" + cuenta.Saldo.ToString();
            }
       
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            deposito = 0;
            lblSalInicial.Text = "";
            txtDepositar.Text = "";
            lbldepo.Text = "";
            lblfinal.Text = "";
        }
    }

        
    }


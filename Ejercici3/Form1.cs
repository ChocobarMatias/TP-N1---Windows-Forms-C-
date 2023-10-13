using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercici3
{
    public partial class Form1 : Form
    {
        Coche auto1 = new Coche();
        Coche auto2 = new Coche();
        Coche auto3 = new Coche();
        Motor auto1M = new Motor();
        Motor auto2M = new Motor();
        Motor auto3M = new Motor();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void rdoFiat_CheckedChanged(object sender, EventArgs e)
        {
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtColor.Text = "";
            txtCilindrada.Text = "";
            txtPotencia.Text = "";
            txtConsumo.Text = "";

            auto1.Marca = "Fiat";
            auto1.Modelo = "Cronos";
            auto1.Color = "Rojo";
            auto1M.Cilindrada ="1332 [C.C.]";
            auto1M.Potencia ="99 [cv]";
            auto1M.Consumo ="6,3 [L/100 km]";
            picAuto1.LoadAsync(@"C:\Users\Matia\OneDrive\Escritorio\Tecnicatura en Programacion\2° Cuatrimestre - 1° Año\Laboratorio de Programacion 2\Trabajos Practicos Laboratorio 2\TP  N1\Ejercici3\cronos1.jpeg");
            picAuto2.LoadAsync(@"C:\Users\Matia\OneDrive\Escritorio\Tecnicatura en Programacion\2° Cuatrimestre - 1° Año\Laboratorio de Programacion 2\Trabajos Practicos Laboratorio 2\TP  N1\Ejercici3\cronos2.jpeg");
        }
        private void rdoAuto2_CheckedChanged(object sender, EventArgs e)
        {
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtColor.Text = "";
            txtCilindrada.Text = "";
            txtPotencia.Text = "";
            txtConsumo.Text = "";

            auto2.Marca = "Nissan";
            auto2.Modelo = "Sentra";
            auto2.Color = "Negro";
            auto2M.Cilindrada = "2.0 [L]";
            auto2M.Potencia = "147 [cv]";
            auto2M.Consumo = "5,1 - 5,8 [L/100 km]";
            picAuto1.LoadAsync(@"C:\Users\Matia\OneDrive\Escritorio\Tecnicatura en Programacion\2° Cuatrimestre - 1° Año\Laboratorio de Programacion 2\Trabajos Practicos Laboratorio 2\TP  N1\Ejercici3\sentra1.jpeg");
            picAuto2.LoadAsync(@"C:\Users\Matia\OneDrive\Escritorio\Tecnicatura en Programacion\2° Cuatrimestre - 1° Año\Laboratorio de Programacion 2\Trabajos Practicos Laboratorio 2\TP  N1\Ejercici3\sentra2.jpeg");
        }

        private void rdoAuto3_CheckedChanged(object sender, EventArgs e)
        {
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtColor.Text = "";
            txtCilindrada.Text = "";
            txtPotencia.Text = "";
            txtConsumo.Text = "";

            auto3.Marca = "Chevrolet";
            auto3.Modelo = "Cobalt 1.8";
            auto3.Color = "Gris";
            auto3M.Cilindrada = "1796 [C.C.]";
            auto3M.Potencia = "105 [cv]";
            auto3M.Consumo = "6,6 [L/100 km]";
            picAuto1.LoadAsync(@"C:\Users\Matia\OneDrive\Escritorio\Tecnicatura en Programacion\2° Cuatrimestre - 1° Año\Laboratorio de Programacion 2\Trabajos Practicos Laboratorio 2\TP  N1\Ejercici3\cobalt1.jpeg");
            picAuto2.LoadAsync(@"C:\Users\Matia\OneDrive\Escritorio\Tecnicatura en Programacion\2° Cuatrimestre - 1° Año\Laboratorio de Programacion 2\Trabajos Practicos Laboratorio 2\TP  N1\Ejercici3\cobalt2.jpeg");
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void btnArrancar_Click(object sender, EventArgs e)
        {
            if (rdoFiat.Checked==true)
            {
                auto1.Arranque();
            }
            if (rdoAuto2.Checked==true)
            {
                auto2.Arranque();
            }
            if (rdoAuto3.Checked==true)
            {
                auto3.Arranque();
            }
            
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (rdoFiat.Checked==true)
            {
                auto1.Apague();
            }
            if (rdoAuto2.Checked==true)
            {
                auto2.Apague();
            }
            if (rdoAuto3.Checked==true)
            {
                auto3.Apague();
            }
            
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            if (rdoFiat.Checked==true)
            {
                txtMarca.Text = auto1.Marca;
                txtModelo.Text = auto1.Modelo;
                txtColor.Text = auto1.Color;
            }
            if (rdoAuto2.Checked == true)
            {
                txtMarca.Text = auto2.Marca;
                txtModelo.Text = auto2.Modelo;
                txtColor.Text = auto2.Color;
            }
            if (rdoAuto3.Checked == true)
            {
                txtMarca.Text = auto3.Marca;
                txtModelo.Text = auto3.Modelo;
                txtColor.Text = auto3.Color;
            }
        }

        private void btnMotor_Click(object sender, EventArgs e)
        {
            if (rdoFiat.Checked == true)
            {
                txtCilindrada.Text = auto1M.Cilindrada;
                txtPotencia.Text = auto1M.Potencia;
                txtConsumo.Text = auto1M.Consumo;
            }
            if (rdoAuto2.Checked == true)
            {
                txtCilindrada.Text = auto2M.Cilindrada;
                txtPotencia.Text = auto2M.Potencia;
                txtConsumo.Text = auto2M.Consumo;
            }
            if (rdoAuto3.Checked == true)
            {
                txtCilindrada.Text = auto3M.Cilindrada;
                txtPotencia.Text = auto3M.Potencia;
                txtConsumo.Text = auto3M.Consumo;
            }
        }

        
    }
    
}

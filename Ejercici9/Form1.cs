using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercici9
{
    public partial class Form1 : Form
    {
        Voladora v1 = new Voladora();
        NoVoladora noV1 = new NoVoladora();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void rdoVoladora_CheckedChanged(object sender, EventArgs e)
        {
            v1.Nombre = "Aguila";
            v1.Edad = "5";
            btnAccion.Text = "Volar";
            picAve.LoadAsync(@"C:\Users\Matia\OneDrive\Escritorio\Tecnicatura en Programacion\2° Cuatrimestre - 1° Año\Laboratorio de Programacion 2\Trabajos Practicos Laboratorio 2\TP  N1\Ejercici9\aguila2.jpeg");
            grpDetalles.Text = $" Detalles de {v1.Nombre}";
            lblTipo.Text = v1.Nombre;
            lblEdad2.Text = v1.Edad;
            lblAccion2.Text ="Vuela";
            lblcomer.Text = "Carnivoro";
        }

        private void rdoNoVoladora_CheckedChanged(object sender, EventArgs e)
        {
            noV1.Nombre = "Avestruz";
            noV1.Edad = "8";
            btnAccion.Text = "Caminar";
            picAve.LoadAsync(@"C:\Users\Matia\OneDrive\Escritorio\Tecnicatura en Programacion\2° Cuatrimestre - 1° Año\Laboratorio de Programacion 2\Trabajos Practicos Laboratorio 2\TP  N1\Ejercici9\avestruz.jpeg");
            grpDetalles.Text = $" Detalles de {noV1.Nombre}";
            lblTipo.Text = noV1.Nombre;
            lblEdad2.Text = noV1.Edad;
            lblAccion2.Text = "Camina";
            lblcomer.Text = "herbívoro";
        }

        private void btnDormir_Click(object sender, EventArgs e)
        {
            if (rdoVoladora.Checked==true)
            {
                picAve.LoadAsync(@"C:\Users\Matia\OneDrive\Escritorio\Tecnicatura en Programacion\2° Cuatrimestre - 1° Año\Laboratorio de Programacion 2\Trabajos Practicos Laboratorio 2\TP  N1\Ejercici9\aguila4.jpeg");
                v1.Nombre="Aguila";
                v1.Dormir();
                
            }
            if (rdoNoVoladora.Checked == true)
            {
                picAve.LoadAsync(@"C:\Users\Matia\OneDrive\Escritorio\Tecnicatura en Programacion\2° Cuatrimestre - 1° Año\Laboratorio de Programacion 2\Trabajos Practicos Laboratorio 2\TP  N1\Ejercici9\avestruz2.jpeg");
                v1.Nombre = "Avestruz";
                v1.Dormir();
               
            }
        }

        private void btnComunicar_Click(object sender, EventArgs e)
        {
            if (rdoNoVoladora.Checked==true)
            {
                picAve.LoadAsync(@"C:\Users\Matia\OneDrive\Escritorio\Tecnicatura en Programacion\2° Cuatrimestre - 1° Año\Laboratorio de Programacion 2\Trabajos Practicos Laboratorio 2\TP  N1\Ejercici9\avestruz3.jpeg");
                v1.Nombre = "Avestruz";
                v1.Comunicarse();
                
            }
            if (rdoVoladora.Checked == true)
            {
                picAve.LoadAsync(@"C:\Users\Matia\OneDrive\Escritorio\Tecnicatura en Programacion\2° Cuatrimestre - 1° Año\Laboratorio de Programacion 2\Trabajos Practicos Laboratorio 2\TP  N1\Ejercici9\aguila3.jpeg");
                v1.Nombre = "Aguila";
                v1.Comunicarse();

            }
        }

        private void btnAccion_Click(object sender, EventArgs e)
        {
            if (rdoVoladora.Checked==true)
            {
               
                picAve.LoadAsync(@"C:\Users\Matia\OneDrive\Escritorio\Tecnicatura en Programacion\2° Cuatrimestre - 1° Año\Laboratorio de Programacion 2\Trabajos Practicos Laboratorio 2\TP  N1\Ejercici9\aguila.jpeg");
                v1.Volar();
            }
            if (rdoNoVoladora.Checked==true)
            {
                
                picAve.LoadAsync(@"C:\Users\Matia\OneDrive\Escritorio\Tecnicatura en Programacion\2° Cuatrimestre - 1° Año\Laboratorio de Programacion 2\Trabajos Practicos Laboratorio 2\TP  N1\Ejercici9\avestruz.jpeg");
                noV1.Caminar();
            }
            
            
        }
    }
}

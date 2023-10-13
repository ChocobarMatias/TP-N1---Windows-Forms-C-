using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercici2
{
    public partial class Form1 : Form
    {
        public int comer;
        public int jugar;
        Caballo cab1 = new Caballo();
        Conejo co1 = new Conejo();
        Perro p1 = new Perro();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (rdoConejo.Checked==true)
            {
                if (txtNombre.Text == "" || txtEdad.Text == "" || txtRaza.Text == "")
                {
                    MessageBox.Show("Debe llenar todos los campos para poder Guardar");
                }
                else
                {
                    co1.Nombre = txtNombre.Text;
                    co1.Edad = txtEdad.Text;
                    co1.Raza = txtRaza.Text;
                    dgvMascotas.Rows.Add(co1.Nombre, co1.Raza, co1.Edad);
                    txtNombre.Text = "";
                    txtEdad.Text = "";
                    txtRaza.Text = "";
                }
            }
            if (rdoCaballo.Checked == true)
            {
                if (txtNombre.Text == "" || txtEdad.Text == "" || txtRaza.Text == "")
                {
                    MessageBox.Show("Debe llenar todos los campos para poder Guardar");
                }
                else
                {
                    cab1.Nombre = txtNombre.Text;
                    cab1.Edad = txtEdad.Text;
                    cab1.Raza = txtRaza.Text;
                    dgvMascotas.Rows.Add(cab1.Nombre, cab1.Raza, cab1.Edad);
                    txtNombre.Text = "";
                    txtEdad.Text = "";
                    txtRaza.Text = "";
                }
            }
            if (rdoPerro.Checked == true)
            {
                if (txtNombre.Text == "" || txtEdad.Text == "" || txtRaza.Text == "")
                {
                    MessageBox.Show("Debe llenar todos los campos para poder Guardar");
                }
                else
                {
                    p1.Nombre = txtNombre.Text;
                    p1.Edad = txtEdad.Text;
                    p1.Raza = txtRaza.Text;
                    dgvMascotas.Rows.Add(p1.Nombre, p1.Raza, p1.Edad);
                    txtNombre.Text = "";
                    txtEdad.Text = "";
                    txtRaza.Text = "";
                }
            }
        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            if (rdoPerro.Checked==true)
            {
                pic.LoadAsync(@"C:\Users\Matia\OneDrive\Escritorio\Tecnicatura en Programacion\2° Cuatrimestre - 1° Año\Laboratorio de Programacion 2\Trabajos Practicos Laboratorio 2\TP  N1\Ejercici2\perro1.jpeg");
                p1.Detalles();
            }
            if (rdoConejo.Checked == true)
            {
                pic.LoadAsync(@"C:\Users\Matia\OneDrive\Escritorio\Tecnicatura en Programacion\2° Cuatrimestre - 1° Año\Laboratorio de Programacion 2\Trabajos Practicos Laboratorio 2\TP  N1\Ejercici2\conejo1.jpeg");
                co1.Detalles();
            }
            if (rdoCaballo.Checked == true)
            {
                pic.LoadAsync(@"C:\Users\Matia\OneDrive\Escritorio\Tecnicatura en Programacion\2° Cuatrimestre - 1° Año\Laboratorio de Programacion 2\Trabajos Practicos Laboratorio 2\TP  N1\Ejercici2\caballo1.jpeg");
                cab1.Detalles();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnAlimentar_Click(object sender, EventArgs e)
        {
            if (rdoPerro.Checked==true)
            {
                pic.LoadAsync(@"C:\Users\Matia\OneDrive\Escritorio\Tecnicatura en Programacion\2° Cuatrimestre - 1° Año\Laboratorio de Programacion 2\Trabajos Practicos Laboratorio 2\TP  N1\Ejercici2\perro2.jpeg");
                
                if (comer >= 0 && comer <= 90)
                {
                    comer += 20;
                    pgrAlimentar.Value = comer;
                   p1.Alimentar();
                }

            }
            if (rdoCaballo.Checked == true)
            {
                pic.LoadAsync(@"C:\Users\Matia\OneDrive\Escritorio\Tecnicatura en Programacion\2° Cuatrimestre - 1° Año\Laboratorio de Programacion 2\Trabajos Practicos Laboratorio 2\TP  N1\Ejercici2\caballo2.jpg");
                if (comer >= 0 && comer <= 90)
                {
                    comer += 20;
                    pgrAlimentar.Value = comer;
                    cab1.Alimentar();
                }
               
            }
            if (rdoConejo.Checked == true)
            {
                pic.LoadAsync(@"C:\Users\Matia\OneDrive\Escritorio\Tecnicatura en Programacion\2° Cuatrimestre - 1° Año\Laboratorio de Programacion 2\Trabajos Practicos Laboratorio 2\TP  N1\Ejercici2\conejo2.jpg");
                if (comer >= 0 && comer <= 90)
                {
                    comer += 20;
                    pgrAlimentar.Value = comer;
                    co1.Alimentar();
                }
               
            }
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            if (rdoPerro.Checked == true)
            {
                pic.LoadAsync(@"C:\Users\Matia\OneDrive\Escritorio\Tecnicatura en Programacion\2° Cuatrimestre - 1° Año\Laboratorio de Programacion 2\Trabajos Practicos Laboratorio 2\TP  N1\Ejercici2\perro3.jpeg");
                if (jugar >= 0 && jugar <= 90)
                {
                    jugar += 20;
                    pgrJugar.Value = jugar;
                    p1.Jugar();
                }
            }
            if (rdoCaballo.Checked == true)
            {
                pic.LoadAsync(@"C:\Users\Matia\OneDrive\Escritorio\Tecnicatura en Programacion\2° Cuatrimestre - 1° Año\Laboratorio de Programacion 2\Trabajos Practicos Laboratorio 2\TP  N1\Ejercici2\caballo3.jpeg");
                if (jugar >= 0 && jugar <= 90)
                {
                    jugar += 20;
                    pgrJugar.Value = jugar;
                    cab1.Jugar();
                }
                
            }
            if (rdoConejo.Checked == true)
            {
                pic.LoadAsync(@"C:\Users\Matia\OneDrive\Escritorio\Tecnicatura en Programacion\2° Cuatrimestre - 1° Año\Laboratorio de Programacion 2\Trabajos Practicos Laboratorio 2\TP  N1\Ejercici2\conejo3.jpg");
                if (jugar >= 0 && jugar <= 90)
                {
                    jugar += 20;
                    pgrJugar.Value = jugar;
                    co1.Jugar();
                }
               
            }
        }

        private void rdoPerro_CheckedChanged(object sender, EventArgs e)
        {
            
            pic.LoadAsync(@"C:\Users\Matia\OneDrive\Escritorio\Tecnicatura en Programacion\2° Cuatrimestre - 1° Año\Laboratorio de Programacion 2\Trabajos Practicos Laboratorio 2\TP  N1\Ejercici2\perro1.jpeg");
        }

        private void rdoCaballo_CheckedChanged(object sender, EventArgs e)
        {
            
            pic.LoadAsync(@"C:\Users\Matia\OneDrive\Escritorio\Tecnicatura en Programacion\2° Cuatrimestre - 1° Año\Laboratorio de Programacion 2\Trabajos Practicos Laboratorio 2\TP  N1\Ejercici2\caballo1.jpeg");
        }

        private void rdoConejo_CheckedChanged(object sender, EventArgs e)
        {
           
            pic.LoadAsync(@"C:\Users\Matia\OneDrive\Escritorio\Tecnicatura en Programacion\2° Cuatrimestre - 1° Año\Laboratorio de Programacion 2\Trabajos Practicos Laboratorio 2\TP  N1\Ejercici2\conejo1.jpeg");
        }
    }
}

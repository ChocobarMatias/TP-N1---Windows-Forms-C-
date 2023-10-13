using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercic7
{
    public partial class Form1 : Form
    {

        Triangulo triang1 = new Triangulo();
        Cuadrado cuad = new Cuadrado();
        Circulo circ = new Circulo();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            
        }

        private void rdotriangulo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoArea.Checked==true)
            {
                triang1.Triang = true;
                lblDato1.Text = "BASE";
                lblDato2.Text = "ALTURA";
                txtDato1.Text = "";
                txtDato2.Text = "";
            }
            if (rdoPerimetro.Checked==true)
            {
                lblDato1.Text = "LADO 1";
                lblDato2.Text = "LADO 2";
                lblDato3.Text = "LADO 3";
                txtDato1.Text = "";
                txtDato2.Text = "";
                txtDato3.Text = "";
                lblDato3.Visible = false;
                txtDato3.Visible = false;
            }
            
        }

        private void rdocuadrado_CheckedChanged(object sender, EventArgs e)
        {
            cuad.Cuadrad = true;
            lblDato1.Text = "LADO 1";
            lblDato2.Text = "LADO 2";
            txtDato1.Text = "";
            txtDato2.Text = "";
            
        }

        private void rdocirculo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoArea.Checked==true)
            {
                circ.Circul = true;

                lblDato1.Text = "RADIO";
                lblDato2.Text = "Nro PI";
                txtDato2.Text = circ.PI.ToString();
            }
            if (rdoPerimetro.Checked==true)
            {
                lblDato1.Text = "DIAMETRO";
                lblDato2.Text = "Nro PI";
                txtDato2.Text = circ.PI.ToString();
            }
           
           
        }

        private void btnarea_Click(object sender, EventArgs e)
        {
            if (rdoArea.Checked == true)
            {
                if (rdocirculo.Checked == true)
                {
                    if (txtDato1.Text =="" || txtDato2.Text =="")
                { MessageBox.Show(" Es Obligatorio llenar todos los campos"); }
                else
                {
                    
                        circ.Dato1 = Int32.Parse(txtDato1.Text);
                        circ.Circul = true;
                        circ.CalculoArea();
                        txtArea.Text = circ.Area.ToString();
                        lblCalculo.Text = $" Area = π x Radio²";
                        txtDato1.Text = "";
                        txtDato2.Text = "";
                        picTriangulo.Visible = false;
                        picCuadrado.Visible = false;
                        picCirculo.Visible = true;
                    }
                }
                if (rdocuadrado.Checked == true)
                {
                    if (txtDato1.Text == "" || txtDato2.Text == "")

                { MessageBox.Show(" Es Obligatorio llenar todos los campos"); }
                else
                {
                    
                        cuad.Cuadrad = true;
                        cuad.Dato1 = Int32.Parse(txtDato1.Text);
                        cuad.Dato2 = Int32.Parse(txtDato2.Text);
                        cuad.CalculoArea();
                        txtArea.Text = cuad.Area.ToString();
                        txtDato1.Text = "";
                        txtDato2.Text = "";
                        picTriangulo.Visible = false;
                        picCirculo.Visible = false;
                        picCuadrado.Visible = true;
                        lblCalculo.Text = " Area = Lado x Lado";
                    }
                }
                if (rdotriangulo.Checked == true)
                {
                    if (txtDato1.Text == "" || txtDato2.Text == "")
                    
                { MessageBox.Show(" Es Obligatorio llenar todos los campos"); }
                else
                {
                    
                        triang1.Triang = true;
                        triang1.Dato1 = Int32.Parse(txtDato1.Text);
                        triang1.Dato2 = Int32.Parse(txtDato2.Text);
                        triang1.CalculoArea();
                        txtArea.Text = triang1.Area.ToString();
                        txtDato1.Text = "";
                        txtDato2.Text = "";
                        picCirculo.Visible = false;
                        picCuadrado.Visible = false;
                        picTriangulo.Visible = true;
                        lblCalculo.Text = " Area = (Base x Altura) / 2";
                    }
                }
            }
            if (rdoPerimetro.Checked == true)
            {
                if (rdocirculo.Checked == true)
                {
                    if (txtDato1.Text == "" || txtDato2.Text == "")
                    
                { MessageBox.Show(" Es Obligatorio llenar todos los campos"); }
                else
                {
                    
                        circ.Diametro = Int32.Parse(txtDato1.Text);
                        lblCalculo.Text = " Perimetro = 2 x π x Radio";
                        circ.PerimetroCirculo();
                        txtArea.Text = circ.PerCirculo.ToString();
                        txtDato1.Text = "";
                        txtDato2.Text = "";
                        picCuadrado.Visible = false;
                        picTriangulo.Visible = false;
                        picCirculo.Visible = true;
                    }
                }
                if (rdocuadrado.Checked == true)
                {
                    if (txtDato1.Text == "" || txtDato2.Text == "")
                    
                { MessageBox.Show(" Es Obligatorio llenar todos los campos"); }
                else
                {
                    
                        cuad.Dato1 = Int32.Parse(txtDato1.Text);
                        cuad.Dato2 = Int32.Parse(txtDato2.Text);
                        cuad.CalculoPerimetro();
                        txtArea.Text = cuad.PerimetroCuadrado.ToString();
                        txtDato1.Text = "";
                        txtDato2.Text = "";
                        picTriangulo.Visible = false;
                        picCirculo.Visible = false;
                        picCuadrado.Visible = true;
                        lblCalculo.Text = " Perimetro = 4 x Lado";
                    }
                }
                if (rdotriangulo.Checked == true)
                {
                    if (txtDato1.Text == "" || txtDato2.Text == ""||txtDato3.Text=="")
                    
                { MessageBox.Show(" Es Obligatorio llenar todos los campos"); }
                else
                {
                    
                        triang1.Dato1 = Int32.Parse(txtDato1.Text);
                        triang1.Dato2 = Int32.Parse(txtDato2.Text);
                        triang1.Dato3 = Int32.Parse(txtDato3.Text);
                        triang1.PerimetroTriangulo();
                        txtArea.Text = triang1.Perimetro.ToString();
                        txtDato1.Text = "";
                        txtDato2.Text = "";
                        txtDato3.Text = "";
                        picCuadrado.Visible = false;
                        picCirculo.Visible = false;
                        picTriangulo.Visible = true;
                        lblCalculo.Text = " Perimetro = 3 x Lado";
                    }
                }
            }
        }

        private void picimagenes_Click(object sender, EventArgs e)
        {

        }

        private void rdoArea_CheckedChanged(object sender, EventArgs e)
        {
            lblDato1.Text = "BASE";
            lblDato2.Text = "ALTURA";
            btnarea.Text = "Calcular el Area";
            lblDato3.Visible = false;
            txtDato3.Visible = false;
        }

        private void rdoPerimetro_CheckedChanged(object sender, EventArgs e)
        {
            lblArea.Text = "Perimetro";
            btnarea.Text = "Calcular el Perimetro";
            lblDato1.Text = "LADO 1";
            lblDato2.Text = "LADO 2";
            lblDato3.Text = "LADO 3";
            if (rdotriangulo.Checked == true)
            {
                lblDato3.Visible = true;
                txtDato3.Visible = true;
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

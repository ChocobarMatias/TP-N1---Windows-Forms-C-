using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_10
{
   



    public partial class Form1 : Form
    {
        //Instanciamos las Clases
        Vehiculo Vehiculo1 = new Vehiculo();
        Automovil Automovil1 = new Automovil();
        AutoDeportivo AutoDep = new AutoDeportivo();  //Consultar
       

        public Form1()
        {
            InitializeComponent();
        }

        //Evento del BtnGuardar el cual toma los valores ingresados por los TextBoxs y luego los almacena en 
        //los todos los parametros.

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string marca = txtMarca.Text;
            string modelo = txtModelo.Text;
            string color = txtColor.Text;
            string cilindrada = txtCilindrada.Text;
            string consumo = txtConsumo.Text;
            string traccion = txtTraccion.Text;
            string aceleracion = txtAceleracion.Text;
            string velocidad = txtVelocidad.Text;
            string potencia = txtPotencia.Text;

            //Aqui instanciamos nuevamente la clase AutoDeportivo, para pasarle los valores por parametros

            AutoDeportivo Auto1 = new AutoDeportivo(marca, modelo, color, cilindrada, consumo, traccion, aceleracion, velocidad, potencia);

            //Mostramos el metodo inicial de la clase base 

            MessageBox.Show(Auto1.Detalles());

            //opcion fallida. prueba y error
            //MessageBox.Show($"- Marca : {Auto1.Marca}\n - Modelo: {Auto1.Modelo}\n - Color: {Auto1.Color}\n - Cilindrada: {Auto1.Cilindrada}\n - Consumo: {Auto1.Consumo}\n - Tracción: {Auto1.Traccion}\n - Aceleración {Auto1.Aceleracion}\n - Velocidad Maxima: {Auto1.VelocidadMaxima}\n - Potencia Maxima: {Auto1.PotenciaMaxima}\n");
        }


        //Evento del button TestDrive para hacer visible el groupBox de los metodos de cada clase.

        private void btnTestDrive_Click(object sender, EventArgs e)
        {
            grpTestDrive.Visible = true;
        }


        //Evento de cada button mostrando los respectivos metodos.

        private void btnArrancar_Click(object sender, EventArgs e)
        {
            AutoDep.arrancar();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            AutoDep.apagar();
        }

        private void btnAcelerar_Click(object sender, EventArgs e)
        {
            AutoDep.Acelerar();
        }

        private void btnFrenar_Click(object sender, EventArgs e)
        {
            AutoDep.Frenar();
        }

        private void btnDerrapar_Click(object sender, EventArgs e)
        {
            AutoDep.Derrapar();
        }

        private void btnConvertible_Click(object sender, EventArgs e)
        {
            AutoDep.Convertible();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_10
{
    public class AutoDeportivo : Automovil
    {
        //Porpiedades + Forma autoimplementada
        public string Aceleracion   { get; set; }
        public string VelocidadMaxima { get; set; }
        public string PotenciaMaxima { get; set; }


        //SuperConstructor,  recibiendo los parametros de la clase base + de su clase padre + sus nuevos parametros 
        public AutoDeportivo(string modelo, string marca, string color, string cilindrada, string traccion, string consumo, string aceleracion, string potencia, string velocidad)
            :base(modelo,marca,color,cilindrada,traccion,consumo)
        {
            Aceleracion = aceleracion ;
            VelocidadMaxima = velocidad;
            PotenciaMaxima = potencia;
        }
        //Constructor vacio. A CONSULTAR. (Nos daba error en el Form1 al instanciarlo)

        public AutoDeportivo()
        {
        }

        // Sobrecarga del metodo inicial de la clase base.
        public override string Detalles()
        {
            return base.Detalles()+$"- La aceleracion total es de {Aceleracion}\n -Su Velocidad Maxima es de {VelocidadMaxima}\n - Su Potencia es de {PotenciaMaxima}\n";
        }

        // Metodos individuales de cada clase.

        public void Derrapar()
        {
            MessageBox.Show(" tokioooo driftttt ");
        }

        public void Convertible()
        {
            MessageBox.Show(" Techo.... AFUERAAAAA  VLLC");
        }

    }
}

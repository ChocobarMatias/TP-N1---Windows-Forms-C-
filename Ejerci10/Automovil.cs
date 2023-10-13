using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_10
{
    public class Automovil : Vehiculo
    
    {
        //Propiedades de la clase Automovil + Forma autoimplementada

        public string Cilindrada { get; set; }
        public string Consumo { get; set; }
        public string Traccion { get; set; }


        //Constructor de la clase Automovil, recibiendo los parametros de la clase base + sus nuevos parametros 

        public Automovil(string modelo , string marca, string color, string cilindrada, string traccion, string consumo)
            :base(modelo, marca, color)
        {
            Cilindrada = cilindrada;
            Consumo = consumo;
            Traccion = traccion;
        }

        //Constructor vacio. A CONSULTAR. (Nos daba error en el Form1 al instanciarlo)

        public Automovil()
        {
        }

        // Sobrecarga del metodo inicial de la clase base.
        public override string AutomovilDetalles(string modelo, string marca, string color, string cilindrada, string traccion, string consumo)
        {
            return base.Detalles(marca,modelo,color) + $" \n -Este auto tiene una Cilindrada de {Cilindrada}\n - Consumo total de {Consumo}\n - Una Traccion de{Traccion}\n ";
        }


        // Metodos individuales de cada clase.

        public void Acelerar()
        {
            MessageBox.Show(" fiiiuuuuummmmmmmm ");
           
        }

        public void Frenar()
        {
            MessageBox.Show(" iiiiighhhhhg ");
        }

    }

   

}

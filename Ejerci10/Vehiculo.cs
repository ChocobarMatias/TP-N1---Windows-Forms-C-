using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_10
{
    public class Vehiculo
    {

        //propiedades de la clase Vehiculo + Forma autoimplementada

        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }


        //Constructos de la clase base

        public Vehiculo(string marca, string modelo, string color)
        {
            Marca = marca;
            Modelo = modelo;
            Color = color;
        }

        //Constructor vacio. A CONSULTAR. (Nos daba error en el Form1 al instanciarlo)

        public Vehiculo()
        {


        }


        //Sobrecarga del metodo inicial de la clase base.

        public virtual string Detalles()
        {
            return $"-La marca del vehiculo es {Marca}\n - Modelo {Modelo}\n - Su color es {Color}";
        }

        // Metodos individuales de cada clase.


        public virtual void arrancar()
        {
            MessageBox.Show(" PRUM PRUM PRUM PRUM PRUM ");
        }

        public virtual void apagar()
        {
            MessageBox.Show(" zzzzzzzz ");
        }
    }
}

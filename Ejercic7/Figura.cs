using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercic7
{
    class Figura
    {
        public double Dato1 { get; set; }
        public double Dato2 { get; set; }
        public double Area { get; set; }
        public bool Triang { get; set; }
        public bool Cuadrad { get; set; }
        public bool Circul { get; set; }
        public double PI { get; set; }

        public Figura()
        {
            Dato1 = Dato1;
            Dato2 = Dato2;
            Area = Area;
            PI = 3.14;
            Triang = false;
            Cuadrad = false;
            Circul = false;
        }
        //cuadrado LxL
        //Circulo pixR 2
        public virtual void CalculoArea()
        {
            if (Triang == true)
            {
                Area = (Dato1 * Dato2) / 2;
            }
            if (Cuadrad==true)
            {
                Area = Dato1 * Dato2;
            }
            if (Circul == true)
            {
                Area = PI * (Math.Pow(Dato1, 2));
            }
        }
    }
}

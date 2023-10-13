using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercic7
{
    class Triangulo : Figura
    {
        public double Perimetro { get; set; }
        public int Dato3 { get; set; }
        //Constructor del triangulo
        public Triangulo()
        {
            Dato3 = Dato3;
        }

        public override void CalculoArea()
        {
            base.CalculoArea();
        }

        public void PerimetroTriangulo()
        {
            Perimetro = Dato1 + Dato2 + Dato3;
        }



    }
}

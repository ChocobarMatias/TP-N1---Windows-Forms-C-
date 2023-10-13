using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercic7
{
    class Circulo : Figura
    {

        public double Diametro { get; set; }
        public double PerCirculo { get; set; }

        public Circulo()
        {
            Diametro = Diametro;
        }
        public override void CalculoArea()
        {
            base.CalculoArea();
        }

        public void PerimetroCirculo()
        {
            PerCirculo = PI * Diametro;
        }
    }
}

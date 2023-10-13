using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Ejercici3
{
    class Motor : Coche
    {
        public string Cilindrada { get; set; }
        public string Potencia { get; set; }
        public string Consumo { get; set; }

        public Motor()
        {
            Cilindrada = "";
            Potencia = "";
            Consumo = "";
                
        }
    }
}

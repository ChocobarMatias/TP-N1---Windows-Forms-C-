using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Ejercici9
{
    class Ave
    {
        public string Nombre { get; set; }
        public string Edad { get; set; }

        public Ave()
        {
            Nombre = "";
            Edad = "";
        }

        public virtual void Comunicarse()
        {
            MessageBox.Show($" El ave {Nombre} canta PioPioPio");
        }

        public virtual void Dormir()
        {
            MessageBox.Show($" El ave {Nombre} esta durmiendo: zzzzzzzzzzz");
        }

    }
}

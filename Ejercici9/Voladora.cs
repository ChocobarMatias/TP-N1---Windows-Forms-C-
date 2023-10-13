using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Ejercici9
{
    class Voladora : Ave
    {
        public override void Comunicarse()
        {
            base.Comunicarse();
        }
        public override void Dormir()
        {
            base.Dormir();
        }
        public void Volar()
            {
            MessageBox.Show($" El ave {Nombre} esta volando");
            }

    }
}

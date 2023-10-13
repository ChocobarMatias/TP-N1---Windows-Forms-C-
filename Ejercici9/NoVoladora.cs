using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Ejercici9
{
    class NoVoladora : Ave
    {
        public override void Comunicarse()
        {
            base.Comunicarse();
        }
        public override void Dormir()
        {
            base.Dormir();
        }
        public void Caminar()
        {
            MessageBox.Show($" El ave {Nombre} camina");
        }

    }
}

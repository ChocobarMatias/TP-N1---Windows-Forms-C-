using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Ejercici3
{
    class Coche
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }

        public Coche()
        {
            Marca = "";
            Modelo = "";
            Color = "";
        }

        public virtual void Arranque()
        {
            MessageBox.Show($" El auto {Marca} {Modelo} esta encendido ");
        }

        public virtual void Apague()
        {
            MessageBox.Show($" Se apago el auto {Marca} \n{Modelo}");
        }
    }
}

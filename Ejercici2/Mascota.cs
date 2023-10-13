using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Ejercici2
{
    class Mascota
    {
        private string nombre;
        private string edad;
        private string raza;

        public string Nombre { get; set; }
        public string Edad { get; set; }
        public string Raza { get; set; }

        public Mascota()
        {
            Nombre = "";
            Edad = "";
            Raza = "";
        }

        public virtual void Alimentar()
        {
            MessageBox.Show($" Mi mascota {Nombre} se esta alimentando");
        }

        public virtual void Jugar()
        {
            MessageBox.Show($" Mi mascota {Nombre} esta jugando");
        }

        public virtual void Detalles()

       { MessageBox.Show($" Detalle de la Mascota:\n\n Nombre = {Nombre}\n Edad = {Edad}\n Raza = {Raza}"); }

    }
}

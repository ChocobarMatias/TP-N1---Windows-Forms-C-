using Ejercicio_05;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer05
{
    class Persona : CuentaBancaria
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string DNI { get; set; }
        public string LugarTrabajo { get; set; }

        public Persona()
        {
            Nombre = "Matias";
            Apellido = "Chocobar";
            DNI = "4.043.050";
            LugarTrabajo = "Maipu 22";
        }

        public override void Retirar(double sacar)
        {
            base.Retirar(sacar);
        }
    }
}

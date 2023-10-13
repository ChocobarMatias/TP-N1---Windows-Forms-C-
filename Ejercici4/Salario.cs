using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Ejercici4
{
    class Salario : Empleado
    {
        public double DiasTrabajados { get; set; }
        public double SalarioxMes { get; set; }

        public Salario()
        {
            DiasTrabajados = DiasTrabajados;
            SalarioxMes = SalarioxMes;
        }

        public void SueldoMensual()
        {
            SalarioxMes = DiasTrabajados * SueldoxDia;
            MessageBox.Show($" Sueldo Total = ${SalarioxMes}");
        }
    }
}

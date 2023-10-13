using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Ejercicio_05
{
    class CuentaBancaria
    {
        public double Saldo { get; set; }

        public CuentaBancaria()
        {
            Saldo = 10000; 

        }

        public void Depositar(double deposito)
        {
            Saldo += deposito;
            //MessageBox.Show($" Deposito exitoso \n Su nuevo Saldo es = ${Saldo}");
        }

        public virtual void Retirar(double retiro)
        {
            Saldo -= retiro;
            //MessageBox.Show($" Retiro exitoso \n Su nuevo Saldo es = ${Saldo}");
        }
    }
}

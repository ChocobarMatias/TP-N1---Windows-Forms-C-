using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejer05
{
    public partial class Tickect : Form
    {
        public static double sacar;
        Persona cliente = new Persona();
        public Tickect()
        {
            InitializeComponent();
        }

        private void Tickect_Load(object sender, EventArgs e)
        {
            cliente.Retirar(sacar);
            lblImpor.Text = Retirar.sacar.ToString();
           
            lblnombre.Text = cliente.Nombre+" "+cliente.Apellido;
            lblLugartrabajo.Text = cliente.LugarTrabajo;
            lblsal.Text = cliente.Saldo.ToString();
            cliente.Retirar(Retirar.sacar);
            lblDisp.Text = cliente.Saldo.ToString();
            lblnrodni.Text = cliente.DNI;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace TP__N1_Ejercicio_01
{
    class Estudiante
    {
        /*private string nombre;
        private string edad;
        private string clasificacion;*/
        //Propiedades
        public string Nombre { get; set; }
        public string Edad { get; set; }
        public string Clasificacion { get; set; }
        //Metodo constructor
        public Estudiante()
        {
            Nombre = "";
            Edad = "";
            Clasificacion = "";
        }
        public void Guardar()
        {
            MessageBox.Show($" Datos del alumno {Nombre} se guardaron correctamente");
        }

    }
}

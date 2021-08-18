using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_10_Herencia
{
    class Profesor : Persona
    {
        private string noEmpleado;
        private double sueldo;

        public string NoEmpleado { get => noEmpleado; set => noEmpleado = value; }
        public double Sueldo { get => sueldo; set => sueldo = value; }
    }
}

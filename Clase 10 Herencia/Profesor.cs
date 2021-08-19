using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_10_Herencia
{
    class Profesor : Persona
    {
        private string idEmpleado;
        private double sueldo;

        
        public double Sueldo { get => sueldo; set => sueldo = value; }
        public string IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
    }
}

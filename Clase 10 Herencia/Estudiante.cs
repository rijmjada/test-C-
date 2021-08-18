using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_10_Herencia
{
    class Estudiante : Persona
    {
        private string matricula;
        private string grado;
        private string grupo;

        public string Matricula { get => matricula; set => matricula = value; }
        public string Grado { get => grado; set => grado = value; }
        public string Grupo { get => grupo; set => grupo = value; }
    }
}

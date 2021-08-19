using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_10_Herencia
{
    class Persona
    {
        private string nombre;
        private string apellido;
        private int edad;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int Edad { get => edad; set => edad = value; }



        // Constructur por 'defecto', inicializa campos con valores: 0, NULL, false (dependiendo del caso).
        public Persona()
        {
            
        }

        // Constructor parametrizado y aplicando SobreCarga de metodos
        public Persona(string _nombre)
        {
             this.nombre = _nombre;
        }

        public Persona(string _nombre, string _apellido) : this ( _nombre )
        {
            this.apellido = _apellido;
        }

        public Persona(string _nombre, string _apellido, int _edad) : this( _nombre , _apellido )
        {
            this.edad = _edad;
        }

        // Metodo 'CrearPersona'

        public void CrearPersona(string _nombre, string _apellido, int _edad)
        {
            this.nombre = _nombre;
            this.apellido = _apellido;
            this.edad = _edad;
        }
    }
}

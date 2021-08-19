using System;
using System.IO;

namespace Clase_10_Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciar objeto 'Estudiante' que hereda de la Clase 'Persona'
            Estudiante unEstudiante = new Estudiante();


            // Solicitar y Guardar Datos del Estudiante
            Console.Write("\n Ingrese Datos del Estudiante.\n");

            Console.Write(" Ingrese Nombre : ");
            unEstudiante.Nombre = Console.ReadLine();

            Console.Write(" Ingrese Apellido : ");
            unEstudiante.Apellido = Console.ReadLine();

            Console.Write(" Ingrese Edad : ");
            unEstudiante.Edad = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Ingrese Matricula : ");
            unEstudiante.Matricula = Console.ReadLine();

            Console.Write(" Ingrese Grado : ");
            unEstudiante.Grado = Console.ReadLine();

            Console.Write(" Ingrese Grupo : ");
            unEstudiante.Grupo = Console.ReadLine();


            // Imprimir Datos del Objeto 'Estudiante'
            Console.WriteLine("\n Datos del Objeto 'Estudiante':");
            Console.WriteLine(" Nombre : " + unEstudiante.Nombre +
                              "\n Apellido: " + unEstudiante.Apellido +
                              "\n Edad: " + unEstudiante.Edad +
                              "\n Matricula:  " + unEstudiante.Matricula +
                              "\n Grado: " + unEstudiante.Grado +
                              "\n Grupo: " + unEstudiante.Grupo ) ;



            // Instanciar objeto 'Profesor' que hereda de la Clase 'Persona'
            Profesor unProfesor = new Profesor();

            // Setear Datos del Profesor
            unProfesor.CrearPersona("Jorge", "Miranda", 32);
            unProfesor.IdEmpleado = "0001";
            unProfesor.Sueldo = 97000;

            // Imprimir Datos del Objeto 'Profesor'
            Console.WriteLine("\n Datos del Objeto 'Profesor':");
            Console.WriteLine(" Nombre : " + unProfesor.Nombre +
                              "\n Apellido: " + unProfesor.Apellido +
                              "\n Edad: " + unProfesor.Edad +
                              "\n IdEmpleado:  " + unProfesor.IdEmpleado +
                              "\n Sueldo: $" + unProfesor.Sueldo );

            Console.ReadKey();
        }
    }
}

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

            Console.Write("Ingrese Nombre: ");
            unEstudiante.Nombre = Console.ReadLine();

            Console.Write("Ingrese Apellido: ");
            unEstudiante.Apellido = Console.ReadLine();

            Console.Write("Ingrese Edad: ");
            unEstudiante.Edad = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese Matricula: ");
            unEstudiante.Matricula = Console.ReadLine();

            Console.Write("Ingrese Grado: ");
            unEstudiante.Grado = Console.ReadLine();

            Console.Write("Ingrese Grupo: ");
            unEstudiante.Grupo = Console.ReadLine();


            // Imprimir Datos del Objeto 'Estudiante'
            Console.WriteLine("\n\n");
            Console.WriteLine("Nombre : " + unEstudiante.Nombre +
                              "\nApellido: " + unEstudiante.Apellido +
                              "\nEdad: " + unEstudiante.Edad +
                              "\nMatricula:  " + unEstudiante.Matricula +
                              "\nGrado: " + unEstudiante.Grado +
                              "\nGrupo: " + unEstudiante.Grupo ) ;



            Console.ReadKey();
        }
    }
}

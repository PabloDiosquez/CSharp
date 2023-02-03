using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que permita ingresar el año actual y el año de la fecha de
            // nacimiento de una persona y luego calcule y emita por pantalla su edad.
            // Nota: no hay que tener en cuenta si la persona cumplió años o no,
            // simplemente calcular.
            
            // Declarar las variables.
            int actual, nacimiento, edad;

            // Entrada de datos.
            Console.WriteLine("Ingrese el año actual: ");
            actual = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el año de nacimiento: ");
            nacimiento = int.Parse(Console.ReadLine());

            // Cálculo de la edad.
            edad = actual - nacimiento;

            // Salida de información.
            Console.WriteLine("La edad de la persona es: " + edad);
        }
    }
}

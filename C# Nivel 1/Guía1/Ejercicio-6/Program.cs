using System;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa para ingresar por teclado las tres notas de exámenes de un
            // alumno y luego calcule y emita por pantalla el promedio final.

            int nota1, nota2, nota3, promedio;

            Console.WriteLine("Ingrese nota: ");
            nota1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese nota: ");
            nota2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese nota: ");
            nota3 = int.Parse(Console.ReadLine()); 

            promedio = (nota1 + nota2 + nota3) / 3;

            Console.WriteLine("El promedio de las notas ingresadas es: " + promedio); 

        }
    }
}

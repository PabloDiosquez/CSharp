using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que solicite el ingreso de las notas del primer parcial y del
            // segundo parcial de una alumna de programación. El programa deberá analizar
            // las notas y emitir la situación de la alumna según la siguiente escala:
            // a. Si tiene 8 o más en ambos parciales, emitir “aprobación directa”.
            // b. Si no tiene 8 o más en ambos pero tiene aprobados ambos parciales (se
            // aprueba con 6 o más), emitir “rinde examen final”.
            // c. Si tiene menos de 6 en alguno de los dos parciales, emitir “debe
            // recuperar”.
            // El programa debe emitir solo un cartel, el que corresponda.

            int nota1, nota2;

            Console.WriteLine("Ingrese la nota del primer parcial: ");
            nota1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la nota del segundo parcial: ");
            nota2 = int.Parse(Console.ReadLine());

            if(nota1 > 8 & nota2 > 8)
                Console.WriteLine("\nAprobación directa");
            else{
                if(nota1 > 6 & nota2 > 6)
                    Console.WriteLine("\nRinde examen final");
                else
                    Console.WriteLine("\nDebe recuperar");
            }
        }
    }
}

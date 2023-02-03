using System;

namespace Ejercicio_20
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dado un número entero positivo, mostrar su factorial. El factorial de un número se obtiene multiplicando todos los números
            // enteros positivos que hay entre el 1 y ese número.

            int num, factorial = 1;

            Console.WriteLine("Ingrese un número natural:");
            num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num ; i++)
            {
                factorial *= i;
            }

            Console.WriteLine($"El factorial de {num} es: {factorial}");
        }
    }
}

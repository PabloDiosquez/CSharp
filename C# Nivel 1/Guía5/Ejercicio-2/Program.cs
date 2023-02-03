using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa para mostrar los números del 10 al 1. No se debe realizar
            // ningún pedido de datos. USANDO WHILE.

            int num = 10;

            Console.WriteLine("Los números del 10 al 1: ");
            while (num > 0)
            {
                Console.WriteLine(num);
                num--;
            }

            Console.WriteLine("\nFin del programa.");
        }
    }
}

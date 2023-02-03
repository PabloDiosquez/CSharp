using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa para mostrar los números del 1 al 10. No se debe realizar
            // ningún pedido de datos. USANDO WHILE.

            int num = 1;
            Console.WriteLine("Los números del 1 al 10: ");
            while(num < 11)
            {
                Console.WriteLine(num);
                num++;
            }
            Console.WriteLine("\nFin del programa.");
        }
    }
}

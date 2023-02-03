using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que muestre los números del 0 al 100 de 5 en 5. Ejemplo:
            // 0, 5, 10, 15, 20.... 100. Usando While.

            int num = 0;

            Console.WriteLine("Los números del 0 al 100 de 5 en 5: +");
            while(num < 101)
            {
                Console.WriteLine(num);
                num += 5; // num = num + 5;
            }

            Console.WriteLine("\nPrograma terminado");
        }
    }
}

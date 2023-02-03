using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que muestre los números del 0 al 100 de 5 en 5. Ejemplo:
            // 0, 5, 10, 15, 20.... 100.

            Console.WriteLine("Los números del 0 al 100 de 5 en 5.");
            for(int i = 0; i <= 100; i = i + 5){ // También se puede escribir: i += 5
                Console.WriteLine(i);
            }
        }
    }
}

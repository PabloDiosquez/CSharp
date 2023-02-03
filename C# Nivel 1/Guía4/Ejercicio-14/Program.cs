using System;

namespace Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Imprimir los números entre el 5 y el 20, saltando de tres en tres.

            Console.WriteLine("Números entre el 5 y el 20, saltando de tres en tres:\n");
            for(int i = 5; i <= 20; i += 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}

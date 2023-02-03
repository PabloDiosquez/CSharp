using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa para mostrar los números del 10 al 1. No se debe realizar
            // ningún pedido de datos.

            Console.WriteLine("Los números del 10 al 1.");
            for(int i = 10; i > 0; i--){
                Console.WriteLine(i);
            }
            Console.WriteLine("\nPrograma terminado.");
        }
    }
}

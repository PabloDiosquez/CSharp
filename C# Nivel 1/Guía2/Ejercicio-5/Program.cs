using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa para ingresar un número y mostrar por pantalla un cartel
            // aclaratorio si el mismo es PAR o IMPAR.

            int num;
            bool var;

            Console.WriteLine("Ingrese un número: ");
            num = int.Parse(Console.ReadLine());

            // if(num % 2 == 0)
            //     Console.WriteLine("PAR");
            // else
            //     Console.WriteLine("IMPAR");

            var = num % 2 == 0;

            if(var)
                Console.WriteLine("PAR");
            else
                Console.WriteLine("IMPAR"); 
        }
    }
}

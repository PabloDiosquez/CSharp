using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que solicite el ingreso de un número y que luego emita un
            // cartel por pantalla aclarando si el mismo es múltiplo de 5.

            int num;

            Console.WriteLine("Ingrese un número:  ");
            num = int.Parse(Console.ReadLine());

            if(num % 5 == 0)
                Console.WriteLine("\nEs múltiplo de 5");
            else
                Console.WriteLine("\nNO es múltiplo de 5");
        }
    }
}

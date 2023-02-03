using System;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa para ingresar 4 números. Luego analizar e informar por
            // pantalla si los mismos se encuentran ordenados de forma decreciente.

            int num1, num2, num3, num4;

            Console.WriteLine("Ingrese un número: ");
            num1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingrese un número: ");
            num2 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingrese un número: ");
            num3 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingrese un número: ");
            num4 = int.Parse(Console.ReadLine());

            if(num1 > num2 & num2 > num3 & num3 > num4)
                Console.WriteLine("Los números están ordenados de forma decreciente");
            else
                Console.WriteLine("Los números NO están ordenados de forma decreciente");
        }
    }
}

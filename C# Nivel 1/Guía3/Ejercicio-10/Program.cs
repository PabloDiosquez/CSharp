using System;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que solicite cuatro números y emitir un cartel aclaratorio si
            // son todos iguales entre sí, caso contrario, no emitir nada.

            int num1, num2, num3, num4;

            Console.WriteLine("Ingrese un número: ");
            num1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingrese un número: ");
            num2 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingrese un número: ");
            num3 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingrese un número: ");
            num4 = int.Parse(Console.ReadLine());

            if(num1 == num2 & num2 == num3 & num3 == num4)
                Console.WriteLine("Son todos iguales entre sí");
            
            Console.WriteLine("\nPrograma terminado");
        }
    }
}

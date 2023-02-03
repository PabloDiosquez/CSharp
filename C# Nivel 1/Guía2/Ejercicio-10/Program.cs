using System;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
        // Hacer un programa para ingresar cuatro números y luego mostrar por pantalla
        // cuáles son mayores a 100.

        int num1, num2, num3, num4;

        Console.WriteLine("Ingrese un número: ");
        num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese un número: ");
        num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese un número: ");
        num3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese un número: ");
        num4 = int.Parse(Console.ReadLine());

        Console.WriteLine("\nLos números ingresados mayores a 100 son: ");

        if(num1 > 100)
            Console.WriteLine(num1);
        if(num2 > 100)
            Console.WriteLine(num2);
        if(num3 > 100)
            Console.WriteLine(num3);
        if(num4 > 100)
            Console.WriteLine(num4);
        }
    }
}

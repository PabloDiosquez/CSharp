using System;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa para ingresar cuatro números y luego mostrar por pantalla
            // cuántos son menores a 100.

            int num1, num2, num3, num4, cont = 0;

            Console.WriteLine("Ingrese un número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un número: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un número: ");
            num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un número: ");
            num4 = int.Parse(Console.ReadLine());

            if(num1 > 100)
                cont++;
            if(num2 > 100)
                cont++;
            if(num3 > 100)
                cont++;
            if(num4 > 100)
                cont++;
            Console.WriteLine("\nLa cantidad de números mayores a 100 es: " + cont); 

        }
    }
}

using System;

namespace Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa para ingresar cuatro números distintos y luego mostrar por
            // pantalla el menor de ellos.

            int num1, num2, num3, num4, menor;

            Console.WriteLine("Ingrese un número: ");
            num1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingrese un número: ");
            num2 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingrese un número: ");
            num3 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingrese un número: ");
            num4 = int.Parse(Console.ReadLine());

            if(num1 < num2)
                menor = num1;
            else
                menor = num2;

            if(num3 < menor)
                menor = num3;
            
            if(num4 < menor)
                menor = num4;
            
            Console.WriteLine("\nEl menor de los números ingresados es: " + menor);
        }
    }
}

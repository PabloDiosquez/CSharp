using System;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa para ingresar cuatro números distintos y luego mostrar por
            // pantalla el mayor de ellos.

            int num1, num2, num3, num4, mayor;

            Console.WriteLine("Ingrese un número: ");
            num1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingrese un número: ");
            num2 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingrese un número: ");
            num3 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingrese un número: ");
            num4 = int.Parse(Console.ReadLine());

            if(num1 > num2)
                mayor = num1;
            else
                mayor = num2;
            
            if(num3 > mayor)
                mayor = num3;
            
            if(num4 > mayor)
                mayor = num4;
            
            Console.WriteLine("\nEl mayor de los números ingresados es: " + mayor);
        }
    }
}

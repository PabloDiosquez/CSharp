using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa para ingresar dos números distintos y luego se muestre por
            // pantalla el menor de ellos.
            // Nota: no te olvides del ambiente ideal.

            int num1, num2;

            Console.WriteLine("Ingrese un número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro número: ");
            num2 = int.Parse(Console.ReadLine());

            if(num1 < num2)
                Console.WriteLine("\nEl menor de los números ingresados es " + num1);
            else
                Console.WriteLine("\nEl menor de los números ingresados es " + num2);
        }
    }
}

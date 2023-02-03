using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa para ingresar dos números y que luego emita por pantalla
            // el mayor de ellos o un cartel aclaratorio “Son iguales” en el caso de que así sea.
            // Nota: los números pueden ser iguales.

            int num1, num2;

            Console.WriteLine("Ingrese un número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un número: ");
            num2 = int.Parse(Console.ReadLine());

            if(num1 > num2)
                Console.WriteLine("El mayor es " + num1);
            else{
                if(num2 > num1)
                    Console.WriteLine("El mayor es " + num2);
                else
                    Console.WriteLine("Son iguales");
            }
        }
    }
}

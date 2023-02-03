using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer una función llamada “mayor” que reciba dos números enteros y
            // devuelva el mayor de ellos o cero si son iguales.

            int num1, num2;

            Console.WriteLine("Ingrese un número:");
            num1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingrese un número:");
            num2 = int.Parse(Console.ReadLine());

            int var = mayor(num1, num2);

            if( var != 0)
                Console.WriteLine("\nEl mayor de los números ingresados es " + var);
            else
                Console.WriteLine("\nLos números son iguales");

        }

        static int mayor(int num1, int num2)
        {
            if(num1 > num2)
                return num1;
            else
            {
                if(num2 > num1)
                    return num2;
                else
                    return 0;
            }            
        }
    }
}

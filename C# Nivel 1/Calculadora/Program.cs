using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declarar las variables.
            int num1, num2, suma;

            // Pedir los valores.
            Console.WriteLine("Ingrese un número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese otro número: ");
            num2 = int.Parse(Console.ReadLine());

            // Realizar el cálculo.
            suma = num1 + num2;

            // Mostrar el resultado por pantalla.
            Console.WriteLine("La suma de los números ingresados es: " + suma);
        }
    }
}

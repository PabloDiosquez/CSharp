using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa para solicitar por teclado un número y luego devolver su valor elevado al cubo.

            // Declarar las variables.
            int num, cubo;

            // Pedir el ingreso de datos.
            Console.WriteLine("Ingrese un número: ");
            num = int.Parse(Console.ReadLine());

            // Realizar el cálculo.
            cubo = num*num*num;

            // Mostrar el resultado en pantalla.
            Console.WriteLine("El resultado de elevar al cubo el número ingresado es: " + cubo);
        }
    }
}

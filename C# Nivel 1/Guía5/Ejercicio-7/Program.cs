using System;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que solicite una lista de números que corta cuando se
            // ingresa un cero y luego mostrar por pantalla el máximo de ellos y la posición
            // en la que fue ingresado.

            int num, maximo, posMaximo;

            Console.WriteLine("Ingrese un número: ");
            num = int.Parse(Console.ReadLine());

            maximo = num;
            posMaximo = 1;

            int pos = 1; // Variable auxiliar.
            while (num != 0)
            {
                if(num > maximo)
                {
                    maximo = num;
                    posMaximo = pos;
                }

                Console.WriteLine("Ingrese un número: ");
                num = int.Parse(Console.ReadLine());
                pos++;
            }

            Console.WriteLine("\nEl máximo de los números ingresados es " + maximo);
            Console.WriteLine("Fue ingresado en la posición número: " + posMaximo);
        }
    }
}

using System;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que solicite UN número y luego calcule y emita un cartel
            // aclaratorio si el mismo es primo o no es primo.

            int num, contDiv = 0;

            Console.WriteLine("Ingrese un número: ");
            num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                if(num % i == 0)
                    contDiv++;
            }

            if(contDiv == 2)
                Console.WriteLine("Es PRIMO");
            else
                Console.WriteLine("NO es PRIMO");
        }
    }
}

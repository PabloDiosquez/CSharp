using System;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que solicite UN número y luego calcule y emita un cartel
            // aclaratorio si el mismo es primo o no es primo.

            int num;
            int div = 1, cont = 0;

            Console.WriteLine("Ingrese un número: ");
            num = int.Parse(Console.ReadLine());

            while(div <= num)
            {
                if(num % div == 0)
                    cont++;
                div++;
            }

            if(cont == 2)
                Console.WriteLine("ES PRIMO.");
            else
                Console.WriteLine("NO ES PRIMO");
        }
    }
}

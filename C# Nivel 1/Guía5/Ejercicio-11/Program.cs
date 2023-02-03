using System;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa para ingresar una lista de números que corta cuando se
            // ingresa un cero y luego mostrar: la cantidad de números primos, la cantidad de
            // números pares, la cantidad de positivos y la cantidad de negativos.

            int num;
            int div, contDivisores, contPrimos = 0;
            int contPares = 0;
            int contPos = 0, contNeg = 0;

            Console.WriteLine("Ingrese un número: ");
            num = int.Parse(Console.ReadLine());

            while(num != 0)
            {
                div = 1;
                contDivisores = 0;
                while(div <= num)
                {
                    if(num % div == 0)
                        contDivisores++;
                    div++;
                }
                //¿Es primo?
                if(contDivisores == 2)
                    contPrimos++;

                // Cantidad de números pares.
                if(num % 2 == 0)
                    contPares++;

                // Positivos y negativos.
                if(num > 0)
                    contPos++;
                else
                    contNeg++;
                

                Console.WriteLine("Ingrese un número: ");
                num = int.Parse(Console.ReadLine());
            }

            // Cantidad de primos.
            if(contPrimos != 0)
                Console.WriteLine("\nLa cantidad de números primos de la lista es: " + contPrimos);
            else
                Console.WriteLine("\nNo se ingresaron números primos");
            // Cantidad de números pares.
            if(contPares != 0)
                Console.WriteLine("La cantidad de números pares de la lista es: " + contPares);
            else
                Console.WriteLine("No se ingresaron números pares");
            // Cantidad de números postivos y negativos.
            if(contPos != 0)
                Console.WriteLine("La cantidad de números positivos de la lista es: " + contPos);
            else
                Console.WriteLine("No se ingresaron números positivos");
            if(contNeg != 0)
                Console.WriteLine("La cantidad de números negativos de la lista es: " + contNeg);
            else
                Console.WriteLine("No se ingresaron números negativos");
            Console.WriteLine("\nFin del programa.");
        }
    }
}

using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer una función llamada “par” que reciba un número entero y devuelva 1 si
            // es par o cero si no lo es. Hacer un programa para ingresar 20 números y
            // mostrar por pantalla cuántos son pares.

            int num, contPares = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un número: ");
                num = int.Parse(Console.ReadLine());

                if(par(num) == 1)
                    contPares++;
            }

            if(contPares != 0)
                Console.WriteLine("\nLa cantidad de números pares ingresados es " + contPares);
            else
                Console.WriteLine("\nNo se ingresaron números pares");

        }

        static int par(int num)
        {
            if(num % 2 == 0) 
                return 1;
            else
                return 0;
        }
    }
}

using System;

namespace Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que permita ingresar una lista de números que corta
            // cuando se ingresa un cero. A partir de dichos datos informar:
            // a. El mayor de los números pares.
            // b. La cantidad de números impares.
            // c. El menor de los números primos.
            // Hacer uso de las funciones anteriormente desarrolladas.

            int num;
            bool bandPar = true, bandPrimo = true;
            int mayorPar = 0, contImpares = 0, menorPrimo = 0;

            Console.WriteLine("Ingrese un número:");
            num = int.Parse(Console.ReadLine());

            while (num != 0)
            {
                //a. El mayor de los números pares.

                if(num % 2 == 0)
                {
                    if(bandPar)
                    {
                        mayorPar = num;
                        bandPar = false;
                    }
                    else
                    {
                        if(num > mayorPar)
                            mayorPar = num;
                    }
                }
                else //b. La cantidad de números impares.
                {
                    contImpares++;
                }

                //c. El menor de los números primos.

                if(esPrimo(num))
                {
                    if(bandPrimo)
                    {
                        menorPrimo = num;
                        bandPrimo = false;
                    }
                    else
                    {
                        menorPrimo = menor(num, menorPrimo);
                    }
                }
                     
                Console.WriteLine("Ingrese un número:");
                num = int.Parse(Console.ReadLine());               
            }
            if(!bandPar)
                Console.WriteLine("\nEl mayor de los números pares es " + mayorPar);
            else
                Console.WriteLine("\nNO se ingresaron números pares");
            Console.WriteLine("La cantidad de números impares ingresados es: " + contImpares);
            if(!bandPrimo)
                Console.WriteLine("El menor de los números primos ingresados es: " + menorPrimo);
            else
                Console.WriteLine("NO se ingresaron primos");
        }

        static bool esPrimo(int num)
        {
            int div = 1, contDiv = 0;
            while(div <= num)
            {
                if(num % div == 0)
                    contDiv++;
                div++;
            }
            if(contDiv == 2)
                return true;
            else
                return false;
        }

        static int menor(int num1, int num2)
        {
            if(num1 <= num2)
                return num1;
            else
                return num2;
        }
    }
}

using System;

namespace TPFinal_Diosquez
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero. 
            //A partir de dichos datos informar:

            // a. El mayor de los números pares.
            // b. La cantidad de números impares.
            // c. El menor de los números primos.

            // Nota: evaluar el uso de una función que analice si un número dado es primo o no y que devuelva true o false según corresponda.

            int num, mayorPar = 0, contImpares = 0, menorPrimo = 0;
            bool bandPar = true, bandPrimo = true;

            Console.WriteLine("Ingrese un número:");
            num = int.Parse(Console.ReadLine());

            while (num != 0)
            {
                // a. El mayor de los números pares.
                if(num % 2 == 0)
                {
                    if(bandPar) //¿Es el primer número par de la lista? -- Sí.
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
                else    
                {
                    // b. La cantidad de números impares.
                    contImpares++;
                }

                // c. El menor de los números primos.
                if(esPrimo(num))
                {
                    if(bandPrimo) //¿Es el primer primo de la lista?
                    {
                        menorPrimo = num;
                        bandPrimo = false;
                    }
                    else
                    {
                        if(num < menorPrimo)
                            menorPrimo = num;
                    }
                }
                
                Console.WriteLine("Ingrese un número:");
                num = int.Parse(Console.ReadLine());               
            }

            if(!bandPar)
                Console.WriteLine("\nEl mayor de los números pares de la lista es: " + mayorPar);
            else
                Console.WriteLine("\nNO se ingresaron números pares");
            Console.WriteLine("La cantidad de números impares de la lista es: " + contImpares);
            if(!bandPrimo)
                Console.WriteLine("El menor de los números primos de la lista es: " + menorPrimo);
            else
                Console.WriteLine("NO se ingresaron números primos");

        }

        static bool esPrimo(int num)
        {
            int div = 1, contDivisores = 0;
            while(div <= num)
            {
                if(num % div == 0)
                    contDivisores++;
                div++;
            }
            //Cantidad de divisores -- Un número es primo si tiene exactamente dos divisores naturales.
            if(contDivisores == 2)
                return true;
            else
                return false;
        }
    }
}

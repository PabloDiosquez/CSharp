using System;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa para ingresar 10 números y luego calcule y emita el mayor
            // de los primos de la lista. En caso de no haber ningún número primo, deberá
            // aclararlo con un cartel.

            int num, mayorPrimo = 0, cont;
            bool bandPrimo = true;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un número: ");
                num = int.Parse(Console.ReadLine());

                cont = 0;
                for (int x = 1; x <= num; x++)
                {
                    if(num % x == 0)
                        cont++;
                }

                if(cont == 2){
                    if(bandPrimo){
                        mayorPrimo = num;
                        bandPrimo = false;
                    }
                    else{
                        if(num > mayorPrimo)
                            mayorPrimo = num;
                    }
                }
            }
            
            if(!bandPrimo)
                Console.WriteLine("El mayor primo es " + mayorPrimo);
            else
                Console.WriteLine("NO se ingresaron primos");
        }
    }
}

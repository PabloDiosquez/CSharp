using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
        //    Hacer una función llamada “primo” que reciba un número entero y devuelva 1
        //     si el número es primo o cero si no lo es. Hacer un programa para ingresar
        //     números. El lote corta cuando se ingresa un número cero. Informar el
        //     promedio teniendo en cuenta sólo los números primos.

            int num, cont = 0, acum = 0;
            float promedio;

            Console.WriteLine("Ingrese un número: ");
            num = int.Parse(Console.ReadLine());

            while (num != 0)
            {
                if(primo(num) == 1)
                {
                    acum += num;
                    cont++; 
                }
                
                Console.WriteLine("Ingrese un número: ");
                num = int.Parse(Console.ReadLine());
            }

            if(cont != 0)
            {
                promedio = (float)acum / cont;
                Console.WriteLine("\nEl promedio teniendo en cuenta sólo los números primos es: " + promedio);
            }
            else
                Console.WriteLine("\nNo se ingresaron primos");
        }

        static int primo(int num)
        {
            int div = 1, cont = 0;

            while(div <= num)
            {
                if(num % div == 0)
                    cont++;
                div++;
            }
            //¿Cuántos divisores tiene?
            if(cont == 2)
                return 1;
            else
                return 0;
        }
    }
}

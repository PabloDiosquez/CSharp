using System;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que solicite una lista de números que corta cuando se
            // ingresa un cero y luego emitir por pantalla el máximo de los números
            // negativos y el mínimo de los números positivos.

            int num, maximoNeg = 0, minimoPos = 0;
            bool band1 = true, band2 = true;

            Console.WriteLine("Ingrese un número: ");
            num = int.Parse(Console.ReadLine());

            while (num != 0)
            {
                if(num < 0)
                {
                    if(band1)
                    {
                        maximoNeg = num;
                        band1 = false;
                    }
                    else
                    {
                        if(num > maximoNeg)
                        {
                            maximoNeg = num;
                        }
                    }
                }
                else
                {
                    if(band2)
                    {
                        minimoPos = num;
                        band2 = false;
                    }
                    else
                    {
                        if(num < minimoPos)
                        {
                            minimoPos = num;
                        }
                    }
                }
                
                Console.WriteLine("Ingrese un número: ");
                num = int.Parse(Console.ReadLine());
            }

            if(!band1)
                Console.WriteLine("\nEl máximo de los números negativos de la lista es " + maximoNeg);
            else   
                Console.WriteLine("\nNo se ingresaron números negativos");

            if(!band2)
                Console.WriteLine("\nEl mínimo de los números positivos de la lista es " + minimoPos);
            else   
                Console.WriteLine("\nNo se ingresaron números positivos");

        }
    }
}

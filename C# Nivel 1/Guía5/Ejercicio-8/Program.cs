using System;

namespace Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que solicite una lista de números que corta cuando se
            // ingresa un cero y luego mostrar por pantalla el menor y el segundo menor.

            int num, menor = 0, segundoMenor = 0;
            bool band1 = true, band2 = true;

            Console.WriteLine("Ingrese un número: ");
            num = int.Parse(Console.ReadLine());

            while(num != 0)
            {
                if(band1)
                {
                    menor = num;
                    band1 = false;
                }
                else{
                    if(num < menor)
                    {  
                        segundoMenor = menor;
                        menor = num;
                    }
                    else
                    {
                        if(band2)
                        {
                            segundoMenor = num;
                            band2 = false;
                        }
                        else
                        {
                            if(num < segundoMenor)
                            {
                                segundoMenor = num;
                            }
                        }
                    }
                }

                Console.WriteLine("Ingrese un número: ");
                num = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nEl menor de los números ingresados es " + menor);
            Console.WriteLine("El segundo menor es " + segundoMenor);
        }
    }
}

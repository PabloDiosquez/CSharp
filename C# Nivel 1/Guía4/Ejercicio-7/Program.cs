using System;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que solicite 10 números y luego mostrar por pantalla el
            // máximo de ellos y la posición en la que fue ingresado.

            int num, maximo = 0, posMax = 0;
            bool band = true;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un número: ");
                num = int.Parse(Console.ReadLine());

                if(band)
                {
                    maximo = num;
                    posMax = 1;
                    band = false;
                }
                else
                {
                    if(num > maximo)
                    {
                        maximo = num;
                        posMax = i + 1;
                    }
                }
            }

            Console.WriteLine("\nEl máximo de los números ingresados es " + maximo);
            Console.WriteLine("Fue ingresado en la posición número " + posMax);

        }
    }
}

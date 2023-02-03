using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dada una lista de 10 números enteros, cargarlos en un vector. Luego,
            // determinar e informar si el vector está ordenado en forma creciente. Por
            // ejemplo el vector con los valores 1, 3, 5, 7 y 9 está ordenado; el vector 1, 5, 3, 7
            // y 9 no lo está.

            int[] vNum = new int[10];
            bool bandRep = true; //Asume que los vectores están ordenados de forma creciente.

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un número:");
                vNum[i] = int.Parse(Console.ReadLine());
            }

            for(int i = 0; i < 10; i++)
            {
                for(int j = i; j < 10; j++)
                {
                    if(vNum[i] > vNum[j])
                        bandRep = false; //No están odenados de forma creciente.
                }
            }

            if(bandRep)
                Console.WriteLine("Los elementos del vector están ordenados de forma creciente");
            else
                 Console.WriteLine("Los elementos del vector NO están ordenados de forma creciente");
        }
    }
}

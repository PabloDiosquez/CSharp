using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que solicite 10 números enteros y los guarde en un vector.
            // Luego recorrer todos los elementos del vector y determinar cuál es el valor
            // máximo y su posición dentro del vector.

            int[] vNum = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un número:");
                vNum[i] = int.Parse(Console.ReadLine());
            }

            int maximo = vNum[0];

            for (int i = 0; i < 10; i++)
            {
                if(vNum[i] > maximo)
                    maximo = vNum[i];
            }

            Console.WriteLine("\nEl valor máximo de los elementos del vector es " + maximo);
        }
    }
}

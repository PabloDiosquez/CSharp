using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que solicite 10 números enteros y los guarde en un
            // vector. Luego recorrer ese vector para calcular el promedio. Mostrar por
            // pantalla los valores del vector que son mayores al promedio calculado.

            int[] vNum = new int[10];
            int acum = 0, promedio;
            

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un número:");
                vNum[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                acum += vNum[i];
            }

            promedio = acum / 10;
            Console.WriteLine("Promedio de los valores del vector: " + promedio);

            Console.WriteLine("\nLos valores del vector mayores al promedio son:");
            for (int i = 0; i < 10; i++)
            {
                if(vNum[i] > promedio)
                    Console.WriteLine(vNum[i]);
            }

        }
    }
}

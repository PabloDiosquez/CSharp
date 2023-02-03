using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que solicite 10 números enteros y los guarde en un vector.
            // Luego recorrer el vector y determinar e informar cuál es la suma de los valores
            // del mismo.

            int[] vNum = new int[10];
            int suma = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un número: ");
                vNum[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                suma += vNum[i];
            }

            Console.WriteLine("\nLa suma de los valores del vector es " + suma);

        }
    }
}

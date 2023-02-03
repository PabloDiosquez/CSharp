using System;

namespace Ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
            // Escribir un programa que solicite al usuario una cantidad y luego itere la cantidad de veces dada. En cada iteración,
            // solicitar al usuario que ingrese un número. Al finalizar, mostrar la suma de todos los números ingresados.

            int cantidad;
            int num, suma = 0;

            Console.WriteLine("Ingrese cantidad de iteraciones:");
            cantidad = int.Parse(Console.ReadLine());
            
            for(int i = 0; i < cantidad; i ++)
            {
                Console.WriteLine("Ingrese un número:");
                num = int.Parse(Console.ReadLine());
                suma += num;
            }

            Console.WriteLine($"\nLa suma total de los números ingresados por consola es {suma}");
            Console.WriteLine("Programa terminado.");
        }
    }
}

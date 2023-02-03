using System;

namespace Ejercicio_18
{
    class Program
    {
        static void Main(string[] args)
        {
            // Escribir un programa que muestre la sumatoria de todos los números entre el 0 y un número ingresado por el usuario.

            int num, suma = 0;

            Console.WriteLine("Ingrese un número:");
            num = int.Parse(Console.ReadLine());

            for(int i = 0; i <= num; i++)
            {
                suma += i;
            }

            Console.WriteLine($"La sumatoria de todos los números enteros entre el 0 y {num} es {suma}"); 

        }
    }
}

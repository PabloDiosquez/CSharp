using System;

namespace Ejercicio_19
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escribir un programa que muestre la sumatoria de todos los múltiplos de 3
            //encontrados entre el 0 y un número ingresado por el usuario.

            int num, suma = 0;

            Console.WriteLine("Ingrese un número natural:");
            num = int.Parse(Console.ReadLine());

            for(int i = 0; i <= num; i++)
            {
                if(i % 3 == 0)
                    suma += i;
            }

            Console.WriteLine($"La sumatoria de todos los múltiplos de 3 entre el 0 y {num} es: {suma}");
        }
    }
}

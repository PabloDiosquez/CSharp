using System;

namespace Ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            // Requerir al usuario que ingrese un número entero positivo e imprimir todos los números correlativos entre el ingresado
            // por el usuario y uno menos del doble del mismo.

            int num, doble;

            Console.WriteLine("Ingrese un número entero positivo:");
            num = int.Parse(Console.ReadLine());

            doble = 2*num;
            Console.WriteLine($"Números correlativos entre {num} y uno menos que {doble}:\n" );
            for(int i = num; i < doble; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}

using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que solicite 20 números y calcule y emita por pantalla
            // cuántos son positivos (mayores a cero). Se debe mostrar un solo valor: el
            // conteo final.

            int num, cont = 0;

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Ingrese un número: ");
                num = int.Parse(Console.ReadLine());

                if(num > 0)
                    cont++;
            }
            
            if(cont > 0)
                Console.WriteLine("\nLa cantidad de números positivos ingresados es " + cont);
            else
                Console.WriteLine("\nNO se ingresaron números positivos");
        }
    }
}

using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que solicite la edad de un grupo de personas. El programa
            // deberá pedir edades hasta que se ingrese una edad menor a 18 años. Deberá
            // mostrar por pantalla cuántas personas mayores se registraron.

            int edad, cont = 0;

            Console.WriteLine("Ingrese edad: ");
            edad = int.Parse(Console.ReadLine());

            while(edad >= 18)
            {
                cont++;
                Console.WriteLine("Ingrese edad: ");
                edad = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nSe registraron un total de " + cont + " personas mayores de edad.");
        }
    }
}

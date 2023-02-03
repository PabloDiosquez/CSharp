using System;

namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que solicite 20 edades y luego calcule el promedio de edad
            // de aquellas personas mayores a 18 años.

            int edad, acumEdades = 0, contEdades = 0;
            int promedio;

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Ingrese edad: ");
                edad = int.Parse(Console.ReadLine());

                if(edad > 18){
                    acumEdades += edad;
                    contEdades++;
                }
            }

            promedio = acumEdades / contEdades;
            Console.WriteLine("El promedio de edad de aquellas personas mayores a 18 años ingresadas en el sistema es: " + promedio);
        }
    }
}

using System;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa para ingresar por teclado la longitud de los tres lados de un
            // triángulo y que luego determine e informe con un cartel aclaratorio a qué tipo
            // de triángulo corresponde:
                // a. Equilátero: cuando los tres lados sean iguales.
                // b. Isósceles: cuando dos de los tres lados sean iguales.
                // c. Escaleno: cuando todos los lados sean distintos.

            float longitud1, longitud2, longitud3;

            Console.WriteLine("Ingrese longitud del lado: ");
            longitud1 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingrese longitud del lado: ");
            longitud2 = float.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingrese longitud del lado: ");
            longitud3 = float.Parse(Console.ReadLine());

            if(longitud1 == longitud2 & longitud2 == longitud3)
                Console.WriteLine("\nEquilátero");
            else{
                if((longitud1 == longitud2) | (longitud1 == longitud3) | (longitud2 == longitud3))
                    Console.WriteLine("\nIsósceles");
                else
                    Console.WriteLine("\nEscaleno");
            }
        }
    }
}

using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Diseñar una función que valide el ingreso de una cadena de caracteres para
            // que esté formada por una sola palabra, devolviendo el valor 1 si es válida y 0
            // en caso de no serlo.

            Console.WriteLine("Cadena:");
            string cadena = Console.ReadLine();

            if (validarCadena(cadena) == 1)
            {
                Console.WriteLine($"La cadena '{cadena}' está formada por una sola palabra.");
            }
            else
            {
                Console.WriteLine($"La cadena '{cadena}' NO está formada por una sola palabra.");
            }

            Console.WriteLine("\nPrograma terminado 🖖🏼");
        }

        public static int validarCadena(string cadena)
        {
            foreach (char carac in cadena)
            {
                if (carac == ' ' || carac == '\n')
                {
                    return 0;
                }
            }

            return 1;
        }
    }
}

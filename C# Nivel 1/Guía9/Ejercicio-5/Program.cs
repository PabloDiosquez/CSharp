using System;
using Ejercicio_3;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
        //     Diseñar una función que devuelva la cantidad de veces que un carácter dado
        //     está contenido en una palabra también dada. La cadena de caracteres debe
        //     estar validada para que contenga sólo una palabra.

            Console.WriteLine("Palabra:");
            string palabra = Console.ReadLine();

            if (Ejercicio_3.Program.validarCadena(palabra))
            {
                Console.WriteLine("Caracter:");
                char caracter = Console.ReadLine();

                Console.WriteLine($"La cantidad de veces que {caracter} aparece en {palabra} es: {apariciones(palabra, caracter)}");
            }
            else
            {
                Console.WriteLine("La cadena debe contener una sola palabra 😕");
            }

        }

        public static int apariciones(string palabra, char carac)
        {
            int cant = 0;

            foreach (char letra in palabra)
            {
                if (letra == carac)
                {
                    cant++;
                }
            }

            return cant;
        }
    }
}

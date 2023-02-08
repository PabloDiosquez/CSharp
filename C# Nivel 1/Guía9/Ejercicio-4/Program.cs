using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Diseñar una función que invierta una cadena de caracteres de una palabra. La
            // cadena debe estar validada para que contenga una sola palabra.  


            Console.WriteLine(invertir("hola como estas"));

        }

        public static string invertir(string cadena)
        {
            string res = "";

            for (int i = cadena.Length - 1; i > -1; i--)
            {
                res += cadena[i];
            }

            return res;
        }
    }
}

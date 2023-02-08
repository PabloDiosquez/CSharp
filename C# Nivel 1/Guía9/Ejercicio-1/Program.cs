using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa para ingresar por teclado una palabra y luego contar
            // cuántas veces aparece el carácter “a” en la misma.

            Console.WriteLine("Palabra:");
            string palabra = Console.ReadLine();

            int cant = contadorDeLetras(palabra, 'a');

            Console.WriteLine($"Cantidad de apariciones de la letra 'a': {cant}");
        }

        public static int contadorDeLetras(string palabra, char letra)
        {
            int cant = 0;

            foreach (char carac in palabra)
            {
                if (carac == letra)
                {
                    cant++;
                }
            }

            return cant;
        }
    }
}

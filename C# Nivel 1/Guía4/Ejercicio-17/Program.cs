using System;

namespace Ejercicio_17
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicitar al usuario que ingrese una frase y luego imprimir un listado de las vocales que aparecen en esa frase (sin repetirlas).

            string frase;
            int contVocales = 0;

            Console.WriteLine("Ingrese una frase:");
            frase = Console.ReadLine();

            foreach (var item in frase.ToLower())
            {
                if(item == 'a' || item == 'e' || item == 'i' || item == 'o' || item == 'u')
                    contVocales++;
            }

            Console.WriteLine($"La cantidad de veces que aparece una vocal en la frase ingresada es {contVocales}");
        }
    }
}

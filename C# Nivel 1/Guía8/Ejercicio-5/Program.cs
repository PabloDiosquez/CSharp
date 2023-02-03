using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
        //    Hacer un programa que solicite una serie de valores de tipo char (caracteres).
        //     Se entiende por carácter a cada elemento que se obtiene de presionar una
        //     tecla. Por ejemplo el valor “25” tiene dos caracteres (si quisiéramos guardarlo
        //     en variables enteras nos alcanza con una, pero si queremos guardarlo en
        //     variables char, necesitaremos dos); la frase “maxi programa” tiene 13 (se
        //     incluye el espacio como un carácter).
        //     La cantidad de valores será como máximo 50, pero el programa puede cortar
        //     antes si se ingresa el carácter “.” (punto). Una vez cargado el vector de char,
        //     recorrerlo y reemplazar todas las apariciones de la letra “a” por la letra “e”,
        //     por ejemplo:
            //     Vector char original: “Hola muchachada cómo están”.
            //     Vector char modificado: “Hole muchechede cómo esten”
        //     Finalmente, mostrar el resultado en pantalla.

            char[] vChar = new char[50];
            char caracter;
            int i = 0;

            Console.WriteLine("Ingrese un caracter:");
            caracter = char.Parse(Console.ReadLine());


            while(caracter != '.' & i < 50)
            {
                vChar[i] = caracter;

                Console.WriteLine("Ingrese un caracter:");
                caracter = char.Parse(Console.ReadLine());
                i++;
            }

            vChar[i + 1] = '.';

            i = 0;
            while(vChar[i] != '.')
            {
                if(vChar[i] == 'a')
                    vChar[i] = 'e';
                i++;
            }

            Console.WriteLine("Vector modificado:");
            i = 0;
            while(vChar[i] != '.')
            {
                Console.WriteLine(vChar[i]);
                i++;
            }
        }
    }
}

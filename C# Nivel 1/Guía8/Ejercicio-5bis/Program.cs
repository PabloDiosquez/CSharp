using System;

namespace Ejercicio_5bis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos). 
            // El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido 
            // reemplazadas por el segundo. Mostrar el resultado en pantalla. Ejemplo:
            // CADENA FUENTE: “La mar estaba serena"
            // CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
            // CADENA RESULTADO: “Li mir estibi sereni"

            char[] cadena = new char[50];
            char carac, carac1, carac2;

            Console.WriteLine("Ingrese un caracter:");
            carac = char.Parse(Console.ReadLine());

            int i = 0;
            while(carac != '.' & i < 49)
            {
                cadena[i] = carac;

                Console.WriteLine("Ingrese un caracter:");
                carac = char.Parse(Console.ReadLine());
                i++;
            }

            cadena[i] = '\0';

            Console.WriteLine("Ingrese caracter 1:");
            carac1 = char.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese caracter 2:");
            carac2 = char.Parse(Console.ReadLine());

            Console.WriteLine("\nCadena fuente:");
            i = 0;
            while (cadena[i] != '\0')
            {
                Console.Write(cadena[i]);
                i++;
            }

            i = 0;
            while (cadena[i] != '\0')
            {
                if(cadena[i] == carac1)
                    cadena[i] = carac2;
                i++;
            }

            Console.WriteLine("\nCadena resultado:");
            i = 0;
            while (cadena[i] != '\0')
            {
                Console.Write(cadena[i]);
                i++;
            }
        }
    }
}

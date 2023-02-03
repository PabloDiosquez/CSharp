using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa para ingresar dos números. Si el segundo es distinto de
            // cero, calcular la división del primero por el segundo y mostrar el resultado por
            // pantalla; caso contrario, emitir un cartel aclarando que no se puede dividir por
            // cero.

            int num1, num2;

            Console.WriteLine("Ingrese un número: ");
            num1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingrese un número: ");
            num2 = int.Parse(Console.ReadLine());

            if(num2 != 0)
                Console.WriteLine("El resultado de la división entera entre " + num1 + " y " + num2 + " es " + num1/num2);
            else 
                Console.WriteLine("NO se puede dividir por 0");
        }
    }
}

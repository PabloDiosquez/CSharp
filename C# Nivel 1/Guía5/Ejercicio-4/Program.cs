using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que solicite dos números y luego muestre los números
            // entre el menor y el mayor de ellos. Acordate, usando While.

            int num1, num2, menor, mayor;
            int num;

            Console.WriteLine("Ingrese un número: ");
            num1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Ingrese un número: ");
            num2 = int.Parse(Console.ReadLine());

            if(num1 >= num2)
            {
                mayor = num1;
                menor = num2;
            }
            else
            {
                mayor = num2;
                menor = num1;
            }

            num = menor + 1;

            Console.WriteLine("\nLos números entre " + menor + " y " + mayor + " son: ");
            while(num < mayor)
            {
                Console.WriteLine(num);
                num++;
            }

            Console.WriteLine("\nFin del programa.");
        }
    }
}

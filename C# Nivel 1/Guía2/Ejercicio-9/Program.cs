using System;

namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
        // Hacer un programa para ingresar cinco números distintos y luego mostrar por
        // pantalla el mayor y el menor de ellos.

        int num1, num2, num3 , num4, num5, mayor, menor;

        Console.WriteLine("Ingrese un número: ");
        num1 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Ingrese un número: ");
        num2 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Ingrese un número: ");
        num3 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Ingrese un número: ");
        num4 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Ingrese un número: ");
        num5 = int.Parse(Console.ReadLine());

        if(num1 > num2){
            mayor = num1;
            menor = num2;
        }
        else{
            mayor = num2;
            menor = num1;
        }

        if(num3 > mayor)
            mayor = num3;
        else{
            if(num3 < menor)
                menor = num3;
        }

        if(num4 > mayor)
            mayor = num4;
        else{
            if(num4 < menor)
                menor = num4;
        }

        if(num5 > mayor)
            mayor = num5;
        else{
            if(num5 < menor)
                menor = num5;
        }

        Console.WriteLine("\nEl mayor de los números ingresados es: " + mayor);
        Console.WriteLine("El menor de los números ingresados es: " + menor);
        }
    }
}

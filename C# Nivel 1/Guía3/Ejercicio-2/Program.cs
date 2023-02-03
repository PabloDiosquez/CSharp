using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que solicite el ingreso de dos números y luego calcular:
            // a. La resta si el primero es mayor que el segundo.
            // b. La suma si son iguales.
            // c. El producto si el primero es menor.
            // Se deberá emitir un cartel por pantalla con el resultado correspondiente.

            int num1, num2, resultado;

            Console.WriteLine("Ingrese un número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un número: ");
            num2 = int.Parse(Console.ReadLine());

            if(num1 > num2)
                resultado = num1 - num2;
            else{
                if(num1 == num2)
                    resultado = num1 + num2;
                else
                    resultado = num1 * num2;
            }
            
            Console.WriteLine("El resultado de la operación indicada es " + resultado);
            
        }
    }
}

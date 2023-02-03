using System;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer una función que se llame “sumaResta” que reciba dos números y que
            // devuelva la suma Y la resta del primer número con el segundo.
            // Nota: recordemos que una función solo puede devolver UN valor por return.
            // Cómo podríamos hacer para tener ambos resultados en el main?

            int num1, num2;
            
            Console.WriteLine("Ingrese un número: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese un número: ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nLa suma de los números ingresados es " + sumaResta(num1, ref num2));
            Console.WriteLine("La resta del primero con el segundo es " + num2);
        }

        static int sumaResta(int num1, ref int num2)
        {
            int suma = num1 + num2;
            num2 = num1 - num2;

            return suma;
        }
    }
}

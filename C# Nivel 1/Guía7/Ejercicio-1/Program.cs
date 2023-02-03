using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer una función llamada “producto” que reciba dos números enteros y que
            // devuelva el producto de ambos. Luego hacer un programa que pida el precio
            // de un artículo y la cantidad vendida y muestre por pantalla el monto total a
            // pagar. Usar la función.

            float precioArticulo, monto;
            int cantidad;

            Console.WriteLine("Ingrese el precio del artículo: ARS ");
            precioArticulo = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad vendida: ");
            cantidad = int.Parse(Console.ReadLine());

            monto = producto(precioArticulo,cantidad);

            Console.WriteLine("\nEl monto total a pagar es: ARS " + monto);

        }

        static float producto(float num1, float num2)
        {
            float prod;
            prod = num1*num2;
            return prod;
        }
    }
}

using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer una función llamada “pagos” que reciba un monto (float) y una cantidad
            // de pagos (entero) y devuelva el monto de cada pago. Hacer un programa para
            // ingresar 10 ventas. Para cada venta se conoce el monto y la cantidad de pagos.
            // El programa deberá mostrar la cantidad de pagos y el monto del pago para
            // cada una de las ventas.

            float monto;
            int cantidad;

            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("\nVenta N° " + i);
                Console.WriteLine("Ingrese monto: ");
                monto = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad de pagos: ");
                cantidad = int.Parse(Console.ReadLine());

                Console.WriteLine("\nLa cantidad de pagos es: " + cantidad);
                Console.WriteLine("El monto de cada pago es: ARS " + pagos(monto,cantidad));
            }
        }

        static float pagos(float monto, int cantidad)
        {
            return monto / cantidad;
        }
    }
}

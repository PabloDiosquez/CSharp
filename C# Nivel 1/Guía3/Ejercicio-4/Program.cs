using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Un importante negocio de desinfectante líquido realiza descuentos
            //     dependiendo de la cantidad de litros vendidos según la siguiente escala:
            //     a. Si vende menos de 100 litros, no hay descuento.
            //     b. Si vende entre 101 y 300 litros, el descuento es del 10%.
            //     c. Si vende entre 301 y 500 litros, el descuento es del 15%.
            //     d. Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
            // Hacer un programa que solicite el ingreso del importe total de la venta y la
            // cantidad de litros vendidos y calcule y emita el importe con el descuento
            // aplicado.

            float importe, litros;
            const float descuento1 = 0.9F;
            const float descuento2 = 0.85F;
            const float descuento3 = 0.75F;

            Console.WriteLine("Ingrese el importe de venta: ");
            importe = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de litros vendida: ");
            litros = float.Parse(Console.ReadLine());

            if(litros > 500)
                importe = descuento3*importe;
            else{
                if(litros > 300)
                    importe = descuento2*importe;
                else{
                    if(litros > 100)
                        importe = descuento1*importe;
                }
            }
            
            Console.WriteLine("\nEl importe final de venta es: ARS " + importe);
            
        }
    }
}

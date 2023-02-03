using System;

namespace Ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Una casa de videojuegos otorga un descuento dependiendo del importe de la
            // compra realizada según los siguientes valores:
            //     • Si el importe es menor a ARS 1000, no hay descuento.
            //     • Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un
            // descuento del 10%.
            //     • Si el importe es ARS 5000 o más, aplica un descuento del 18%.
            // Hacer un programa para ingresar un importe de venta y luego muestre por
            // pantalla el importe final con el descuento que corresponda.

            float importe;
            const float descuento1 = 0.82F;
            const float descuento2 = 0.9F;
            bool descuento = true;

            Console.WriteLine("Ingrese importe de venta (en ARS): ");
            importe = float.Parse(Console.ReadLine());

            if(importe > 5000)
                importe = descuento1*importe;
            else{
                if(importe > 1000)
                    importe = descuento2*importe;
                else
                    descuento = false;
            }
            
            if(descuento){
                Console.WriteLine("\nSe aplicó un descuento.");
                Console.WriteLine("El importe final de venta es: ARS " + importe);
            }
            else{
                Console.WriteLine("\nNo se aplicó descuento.");
                Console.WriteLine("El importe final de venta es: ARS " + importe);
            }
            


        }
    }
}

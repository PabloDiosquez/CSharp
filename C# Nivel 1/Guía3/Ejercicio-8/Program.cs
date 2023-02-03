using System;

namespace Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // El negocio de desinfectante antes mencionado vende además detergente
            // suelto, y los precios se aplican según la siguiente escala:
            // a. 25 ARS por litro los primeros 50 litros.
            // b. 20 ARS por litro si la venta es de 51 a 200 litros.
            // c. 15 ARS por litro si la venta es de 201 a 500 litros.
            // d. 10 ARS por litro si la venta es de más de 500 litros.
            // Además, si paga en efectivo, tiene un adicional del 10% sobre el importe final.
            // Hacer un programa que solicite la cantidad de litros vendidos y el tipo de pago
            // (ingresará 1 si paga en efectivo y 0 con cualquier otro medio de pago) y calcule
            // y emita por pantalla el monto final a abonar por el cliente.

            float litros, importe;
            int efectivo;

            Console.WriteLine("Ingrese la cantidad de litros vendidos: ");
            litros = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tipo de pago: -- Ingresará 1 si paga en efectivo y 0 con cualquier otro medio de pago --");
            efectivo = int.Parse(Console.ReadLine());

            if(litros > 500)
                importe = 10F*litros;
            else{
                if(litros > 200)
                    importe = 15F*litros;
                else{
                    if(litros > 50)
                        importe = 20F*litros;
                    else
                        importe = 25F*litros;
                }
            }
            //¿Paga en efectivo?
            if(efectivo == 1){
                importe = 0.9F*importe;
                Console.WriteLine("\nPaga en efectivo");
            }
            else
                Console.WriteLine("\nOtro medio de pago");

            Console.WriteLine("El importe final de la compra es: " + importe);
        }
    }
}

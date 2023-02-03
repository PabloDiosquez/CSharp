using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa para ingresar los valores de los pesos de distintas
            // encomiendas que se deben enviar a distintos clientes y que finaliza cuando se
            // ingresa un peso negativo. Se deben agrupar las encomiendas en camiones que
            // pueden transportar hasta 200 kilos en total.
            // Por ejemplo:
            // 10, 20, 140, 70, 100, 40, 10, 50, 80, 90, 30, 40, 50, -10.
            // Camión 1. Camión 2 Camión 3 Camión 4 Camión 5
            // Se pide determinar e informar:
            // a. El número de camión y peso total de encomiendas (Camión 1: 170kg,
            // Camión 2: 170kg, etc.).
            // b. El número de camión que transporta mayor cantidad de encomiendas
            // (en el ejemplo anterior sería el camión 3 con 4 encomiendas).
            // c. La cantidad de camiones que se terminaron cargando.

            int encomienda;
            int pesoEncomienda, camion = 1;
            int cont;
            int mayor = 0, camionMayor = 0;

            Console.WriteLine("Ingrese encomienda: ");
            encomienda = int.Parse(Console.ReadLine());
            
            while(encomienda >= 0)
            {
                pesoEncomienda = 0;
                cont = 0;   
                
                while((encomienda + pesoEncomienda < 200) && encomienda >= 0)
                {
                    pesoEncomienda += encomienda;
                    cont++;

                    Console.WriteLine("Ingrese encomienda: ");
                    encomienda = int.Parse(Console.ReadLine());

                }

                if(camion == 1)
                {
                    mayor = pesoEncomienda;
                    camionMayor = camion;
                }
                else
                {
                    if(pesoEncomienda > mayor)
                        camionMayor = camion;
                }

                //a.
                Console.WriteLine("Camión " + camion + ": " + pesoEncomienda + "kg");
                camion++;
            }
            //b.
            Console.WriteLine("\nEl mayor número de encomiendas lo trasporta el camión número: " + camionMayor);
            Console.WriteLine("La cantidad de camiones que se terminaron entregando es: " + (camion - 1));
        }
    }
}

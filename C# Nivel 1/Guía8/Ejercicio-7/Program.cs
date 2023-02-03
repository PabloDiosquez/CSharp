using System;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Una empresa comercializa 15 tipos de artículos y por cada venta realizada
            // genera un registro con los siguientes datos:
            // • Número de artículo (1 a 15).
            // • Cantidad vendida.
            // Puede haber varios registros para el mismo artículo y el último se indica
            // número de artículo igual a cero.
            // Se pide determinar e informar:
            // a. El número de artículo que más se vendió en total.
            // b. Los números de artículos que no registraron ventas.
            // c. La cantidad de unidades vendidas para el artículo número 10.

            int articulo, cantidad;

            int[] articulos = new int[15];

            for(int i = 0; i < 15; i++)
            {
                articulos[i] = 0;
            }

            Console.WriteLine("Ingrese número de articulo:");
            articulo = int.Parse(Console.ReadLine()); 

            Console.WriteLine("Ingrese cantidad vendida:");
            cantidad = int.Parse(Console.ReadLine());

            while(articulo != 0)
            {
                articulos[articulo - 1] += cantidad;

                Console.WriteLine("Ingrese número de articulo:");
                articulo = int.Parse(Console.ReadLine()); 

                Console.WriteLine("Ingrese cantidad vendida:");
                cantidad = int.Parse(Console.ReadLine());
            }  

            //a. El número de artículo que más se vendió en total.

            int maximo = articulos[0];
            int articuloMax = 1;

            for(int i = 0; i < 15; i++)
            {
                if(articulos[i] > maximo)
                {
                    maximo = articulos[i];
                    articuloMax = i + 1;
                }
            }

            Console.WriteLine("\nEl número de artículo que más se vendió es: " + articuloMax);
            Console.WriteLine("Cantidad vendida: " + maximo);

            // b. Los números de artículos que no registraron ventas.

            Console.WriteLine("\nLos artículos que no registraron ventas son: ");
            for (int i = 0; i < 15; i++)
            {
                if(articulos[i] == 0)
                    Console.WriteLine(i + 1);                
            }

            // c. La cantidad de unidades vendidas para el artículo número 10.    

            Console.WriteLine("\nLa cantidad de unidaes vendidas para el artículo número 10 es: " + articulos[9]);
            
        }
    }
}

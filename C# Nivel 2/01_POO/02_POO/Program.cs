using System;

namespace _02_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Botella botella1 = new Botella("Plástico", "Negro");

            botella1.CapacidadActual = 20;

            Console.WriteLine($"Capacidad actual: {botella1.CapacidadActual}");

            Console.WriteLine("Recargando...\n");

            double monto = botella1.Recargarse(80);

            Console.WriteLine($"Monto de la recarga: ARS {monto}");

            Console.WriteLine($"Capacidad actual, luego de la recarga: {botella1.CapacidadActual}");
        }
    }
}

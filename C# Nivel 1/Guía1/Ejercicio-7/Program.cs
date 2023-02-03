using System;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa para ingresar por teclado los metros cuadrados totales de
            // un predio y los metros cuadrados cubiertos; luego calcular y mostrar por
            // pantalla el porcentaje de metros cuadrados cubiertos y el porcentaje de
            // metros cuadrados descubiertos.

            float total, cubiertos, porCubierto, porDescubierto;

            Console.WriteLine("Ingrese los metros cuadrados totales: ");
            total = float.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese los metros cuadrados cubiertos: ");
            cubiertos = float.Parse(Console.ReadLine());

            porCubierto = 100F*(cubiertos/total);
            porDescubierto = 100F*((total - cubiertos)/total);

            Console.WriteLine("\nEl porcentaje de metros cuadrados cubiertos es: " + porCubierto + "%");
            
            Console.WriteLine("El porcentaje de metros cuadrados descubiertos es: " + porDescubierto + "%"); 
        }
    }
}

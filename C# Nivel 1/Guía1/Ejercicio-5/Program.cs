using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Una casa de computación paga a sus empleados un sueldo fijo de ARS15000
            // más una comisión del 5% sobre el total facturado por cada empleado. Hacer un
            // programa para ingresar el total facturado por un empleado y que luego calcule
            // y emita por pantalla el sueldo total a cobrar por el mismo.

            const float sueldoFijo = 15000F;
            const float comision = 0.05F;
            float totalFact, sueldo;

            Console.WriteLine("Ingrese el total facturado por el empleado (ARS): ");
            totalFact = float.Parse(Console.ReadLine());

            sueldo = sueldoFijo + comision*totalFact;

            Console.WriteLine("El sueldo total a cobrar por el empleado es: ARS " + sueldo);
        }
    }

}

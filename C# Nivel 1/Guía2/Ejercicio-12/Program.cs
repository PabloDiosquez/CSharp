using System;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa para ingresar un valor que estará expresado en minutos. Si
            // los minutos superan los 60, pasar el valor a horas, de lo contrario dejarlo en
            // minutos. Mostrar el resultado en pantalla aclarando si se muestran minutos u
            // horas.

            int minutos;
            float horas = 0;
            bool band = true; //Asume que se ingresa una cantidad de minutos menor a 60.

            Console.WriteLine("Ingrese un valor expresado en minutos: ");
            minutos = int.Parse(Console.ReadLine());

            if(minutos > 60)
                band = false;
                horas = minutos / 60F;
    
            if(band == true)
                Console.WriteLine("Se muestran minutos: " + minutos);
            else
                Console.WriteLine("Se muestran horas: " + horas);         
        }
    }
}

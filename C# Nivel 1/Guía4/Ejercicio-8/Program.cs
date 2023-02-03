using System;

namespace Ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que solicite 20 números y luego mostrar por pantalla el
            // menor de ellos y la posición en la que fue encontrado.

            int num, menor = 0, posMenor = 0;
            bool band = true;

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Ingrese un número: ");
                num = int.Parse(Console.ReadLine());

                if(band){
                    menor = num;
                    posMenor = 1;
                    band = false;
                }
                else{
                    if(num < menor){
                        menor = num;
                        posMenor = i + 1;
                    }
                }
            }

            Console.WriteLine("\nEl menor de los números ingresados es " + menor);
            Console.WriteLine("Fue ingresado en la posición número " + posMenor);
        }
    }
}

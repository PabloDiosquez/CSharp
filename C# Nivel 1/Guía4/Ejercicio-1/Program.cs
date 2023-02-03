using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que solicite el ingreso de 10 números y que muestre el
            // mayor de ellos por pantalla. Solo se debe emitir UN valor por pantalla.

            int num, mayor = 0;
            bool band = true;
            for(int i = 0; i < 10; i++){
                Console.WriteLine("Ingrese un número: ");
                num = int.Parse(Console.ReadLine());

                if(band){
                    mayor = num;
                    band = false;
                }
                else{
                    if(num > mayor)
                        mayor = num;
                }
            }

            Console.WriteLine("\nEl mayor de los números ingresados es " + mayor);
        }
    }
}

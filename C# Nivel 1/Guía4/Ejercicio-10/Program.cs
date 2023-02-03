using System;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que solicite 20 números y luego emitir por pantalla el
            // máximo de los números pares y el mínimo de los números impares.

            int num, maximoPar = 0, minimoImpar = 1;
            bool bandPar = true, bandImpar = true;

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Ingrese un número: ");
                num = int.Parse(Console.ReadLine());

                if(num % 2 == 0){
                    if(bandPar){
                        maximoPar = num;
                        bandPar = false;
                    }
                    else{
                        if(num > maximoPar){
                            maximoPar = num;
                        }
                    }
                }
                else{
                    if(bandImpar){
                        minimoImpar = num;
                        bandImpar = false;
                    }
                    else{
                        if(num < minimoImpar){
                            minimoImpar = num;
                        }
                    }
                }
            }

            if(!bandPar)
                Console.WriteLine("\nEl máximo de los números pares es " + maximoPar);
            else
                Console.WriteLine("\nNO se ingresaron números pares.");
            
            if(!bandImpar)
                Console.WriteLine("El mínimo de los números impares es " + minimoImpar);
            else
                Console.WriteLine("NO se ingresaron números impares.");
        }
    }
}

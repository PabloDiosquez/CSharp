using System;

namespace Ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer un programa que solicite una lista de números que corta cuando se
            // ingresa un cero y luego mostrar por pantalla el menor y el segundo menor.
            
            // Realizar el nuevamente el ejercicio 8 pero ahora debe devolver además la
            // posición en la que fue encontrado cada uno de los mínimos.

            // int num, menor = 0, segundoMenor = 0, posMenor = 0 , posSegMenor = 0;
            // bool band1 = true, band2 = true;
            // int pos = 1;

            // Console.WriteLine("Ingrese un número: ");
            // num = int.Parse(Console.ReadLine());

            // while (num != 0)
            // {
            //     if(band1)
            //     {
            //         menor = num;
            //         posMenor = pos;
            //         band1 = false;
            //     }
            //     else
            //     {
            //         if(num < menor)
            //         {
            //             segundoMenor = menor;
            //             menor = num;
            //             posSegMenor = posMenor;
            //             posMenor = pos;
            //         }
            //         else
            //         {
            //             if(band2)
            //             {
            //                 segundoMenor = num;
            //                 posSegMenor = pos;
            //                 band2 = false;
            //             }
            //             else
            //             {
            //                 if(num < segundoMenor)
            //                 {
            //                     segundoMenor = num;
            //                     posSegMenor = pos;
            //                 }
            //             }
            //         }
            //     }


            //     Console.WriteLine("Ingrese un número: ");
            //     num = int.Parse(Console.ReadLine());
            //     pos++;

            // }

            //     Console.WriteLine("\nEl menor de los números ingresados es " + menor + " y fue ingresado en la posición número "+ posMenor);
            //     Console.WriteLine("El  segundo menor de los números ingresados es " + segundoMenor + " y fue ingresado en la posición número "+ posSegMenor);


               int num, menor, segundoMenor = 0;
               bool band = false; // ¿Ya tenés un segundo menor cargado? ¿Hay alguien con quien comparar?
               int pos = 1, posMenor, posSegMenor = 0;
               
                Console.WriteLine("Ingrese un número: ");
                num = int.Parse(Console.ReadLine());

                menor = num;
                posMenor = pos;

                while (num != 0)
                {
                    if(num < menor)
                    {
                        segundoMenor = menor;
                        menor = num;
                        posSegMenor = posMenor;
                        posMenor = pos;
                    }
                    else
                    {
                        if(!band)
                        {
                            segundoMenor = num;
                            posSegMenor = pos;
                            band = true; // ¿Ya tenés un segundo menor? Sí.
                        }
                        else
                        {
                            if(num < segundoMenor)
                            {
                                segundoMenor = num;
                                posSegMenor = pos;
                            }
                        }
                    }

                    pos++;
                    Console.WriteLine("Ingrese un número: ");
                    num = int.Parse(Console.ReadLine());                  
                }

                Console.WriteLine("\nEl menor de los números ingresados es: " + menor);
                Console.WriteLine("Posición menor número: " + posMenor);
                Console.WriteLine("El segundo menor es: " + segundoMenor);
                Console.WriteLine("Posición segundo menor número: " + posSegMenor);
        }
    }
}

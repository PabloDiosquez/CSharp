using System;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dada una lista de 10 números, cargarlos en un vector. Luego detectar si en el
            // vector hay algún elemento repetido. De haberlo, indicarlo con un cartel aclaratorio 
            // “Hay repetidos”, de lo contrario indicar “No hay repetidos”.
            // Pista: usar ciclos combinados.

            int[] vNum = new int[10];
            int cont = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un número:");
                vNum[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if(vNum[i] == vNum[j])
                        cont++;
                }
            }

            if(cont > 10)
                Console.WriteLine("Hay elementos repetidos");
            else
                Console.WriteLine("NO hay elementos repetidos");
        }
    }
}

using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Se dispone de una lista de 10 grupos de números enteros separados entre ellos
            // por ceros. Se pide determinar e informar:
            // a. El número de grupo con mayor porcentaje de números impares
            // positivos respecto al total de números que forman el grupo.
            // b. Para cada grupo, el último número primo y en qué orden apareció en
            // ese grupo. Si en un grupo no hubiera números primos, informarlo con
            // un cartel aclaratorio.
            // c. Informar cuántos grupos están formados por todos números ordenados
            // de mayor a menor.

            int num, grupo, contImpares, total;
            float porcImpares, porcImparesMax = 0;
            int grupoMax = 0;
            int div, contDiv, pos, ultimoPrimo, posUltimoPrimo;
            int contOrdenados = 0;
            bool band, bandOrdenados;
            int mayor;

            for(int i = 0; i < 4; i++)
            {
                //a.
                grupo = i + 1;
                contImpares = 0;
                total = 0;
                //b.
                pos = 0;
                ultimoPrimo = 0;
                posUltimoPrimo = 0;
                //c.
                band = true; //¿Es el primer números que ingresa?
                bandOrdenados = true; // Asume que están ordenados.
                mayor = 0;

                Console.WriteLine("Lista N° " + grupo);

                Console.WriteLine("Ingrese un número:");
                num = int.Parse(Console.ReadLine());

                while(num != 0)
                {
                    // a. El número de grupo con mayor porcentaje de números impares
                    // positivos respecto al total de números que forman el grupo.

                    pos++;
                    total++;
                    if(num % 2 != 0 && num > 0)
                        contImpares++;

                    //b. ¿Es primo?
                    div = 1;
                    contDiv = 0;
                    while(div <= num)
                    {
                        if(num % div == 0)
                            contDiv++;
                        div++;
                    }
                    if(contDiv == 2)
                    {
                        ultimoPrimo = num;
                        posUltimoPrimo = pos;
                    }
                    //c.
                    if(band)
                    {
                        mayor = num;
                        band = false;
                    }
                    else
                    {
                        if(num > mayor)
                            bandOrdenados = false;
                        else
                            mayor = num;
                    }
                    
                    Console.WriteLine("Ingrese un número:");
                    num = int.Parse(Console.ReadLine());
                }

                porcImpares = (100F*contImpares)/total;
                Console.WriteLine("El porcentaje de números impares de este grupo es: " + porcImpares + "%");
                if(grupo == 1)
                {
                    porcImparesMax = porcImpares;
                    grupoMax = grupo;
                }
                else
                {
                    if(porcImpares > porcImparesMax)
                    {    
                        porcImparesMax = porcImpares;
                        grupoMax = grupo;
                    }
                }

                if(posUltimoPrimo > 0)
                    Console.WriteLine("\nEl último primo de este grupo es " + ultimoPrimo + " y fue ingresado en la posición número " + posUltimoPrimo);
                else
                    Console.WriteLine("\nNO se ingresaron primos en este grupo");

                if(bandOrdenados)
                    contOrdenados++;
            }

            Console.WriteLine("\nEl número de grupo con mayor porcentaje de impares positivos respecto al total de números del grupo es: " + grupoMax);
            Console.WriteLine("Cantidad de grupos ORDENADOS de MAYOR a MENOR: " + contOrdenados);
        }
    }
}

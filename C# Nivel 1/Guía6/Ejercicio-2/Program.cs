using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Una compañía de electricidad necesita calcular anualmente el consumo que ha
            // registrado cada uno de sus usuarios y el monto pagado por cada uno de ellos.
            // Para ello tiene un lote de registros por cada uno de los usuarios con los
            // siguientes datos:
            // • Zona (numérico entero).
            // • Número de cliente (número de cuatro dígitos no correlativos).
            // • Cantidad de kilovatios consumidos en el periodo.
            // El lote se encuentra agrupado (no ordenado) por zona y finaliza con un registro
            // con zona igual a cero.
            // Se pide generar un listado con el siguiente formato:
                // Zona: XX
                // Cantidad de usuarios de la zona: XX
                // Total facturado en la zona: XX

                // Zona: XX
                // Cantidad de usuarios de la zona: XX
                // Total facturado en la zona: XX

            // El precio es escalonado según la siguiente escala:
            // • $ 0.10 por kv por los primeros 100 kv de consumo.
            // • $ 0.12 por kv por el consumo de 101 a 200 kvs.
            // • $ 0.15 por kv por el consumo de 201 kvs en adelante.

            int zona, cliente;
            float kilovatios;
            int zonaAct;
            int usuarios; 
            float monto, totalFacturado;

            Console.WriteLine("Ingrese zona:");
            zona = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese número de cliente:");
            cliente = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad de kilovatios consumidos en el período");
            kilovatios = float.Parse(Console.ReadLine());

            while(zona != 0)
            {
                zonaAct = zona;
                usuarios = 0;
                totalFacturado = 0;
                while(zona == zonaAct)
                {
                    usuarios++;
                    if(kilovatios > 200)
                        monto = 0.15F*kilovatios;
                    else
                    {
                        if(kilovatios > 100)
                            monto = 0.12F*kilovatios;
                        else
                            monto = 0.1F*kilovatios;
                    }
                    totalFacturado += monto;

                    Console.WriteLine("Ingrese zona:");
                    zona = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese número de cliente:");
                    cliente = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese la cantidad de kilovatios consumidos en el período");
                    kilovatios = float.Parse(Console.ReadLine());
                }

                Console.WriteLine("\nZona: " + zonaAct);
                Console.WriteLine("Cantidad de usuarios: " + usuarios);
                Console.WriteLine("Total facturado en la zona: " + totalFacturado);
                
            }

            Console.WriteLine("\nFin del programa.");

            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_POO
{
    internal class Articulo
    {
        public int CodArticulo { get; set; }

        public double Precio { get; set; }

        private int codMarca;

        public int CodMarca
        {
            get { return codMarca; }
            set
            {
                if (value >= 1 && value <= 10)
                {
                    codMarca = value;
                }
                else 
                {
                    codMarca = -1;
                }
            }
        }

        private string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("### Datos del artículo ###");
            sb.AppendLine($"Código: {CodArticulo}");
            sb.AppendLine($"Precio: {Precio}");
            sb.AppendLine($"Código de marca: {codMarca}");

            return sb.ToString();
        }

        public static Articulo[] CargarArticulos()
        {
            Articulo[] articulos = new Articulo[5];

            for (int i = 0; i < articulos.Length; i++)
            {
                articulos[i] = new Articulo();

                Console.WriteLine($"Artículo {i + 1}");
                Console.WriteLine("Código artículo:");
                articulos[i].CodArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Precio:");
                double precio = double.Parse(Console.ReadLine());
                articulos[i].Precio = precio;
                Console.WriteLine("Código de marca (1 a 10):");
                articulos[i].CodMarca = int.Parse(Console.ReadLine());
                Console.WriteLine("Artículo cargado.\n");
            }

            return articulos;
        }

        public static void LeerArticulos(Articulo[] articulos)
        {
            foreach (Articulo articulo in articulos)
            {
                Console.WriteLine(articulo.MostrarDatos());
            }
        } 
    }
}

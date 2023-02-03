using System;

namespace _01_POO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Articulo[] articulos;

            articulos = Articulo.CargarArticulos(); // 👉🏼 vector de 5 artículos.

            Articulo.LeerArticulos(articulos);

        }
    }
}

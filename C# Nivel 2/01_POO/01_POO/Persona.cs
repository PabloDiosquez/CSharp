using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_POO
{
    internal class Persona
    {
        private string nombre;

        private int edad;

        private double sueldo;

        public string ObtenerNombre() 
        {
            return nombre;
        }

        public void AsignarNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public int ObtenerEdad() 
        {
            return edad;
        }

        public void AsignarEdad(int edad)
        {
            this.edad = edad;
        }

        public double ObtenerSueldo()
        {
            return sueldo;
        }

        public void AsignarSueldo(double sueldo)
        {
            this.sueldo = sueldo;
        }

        // Métodos 🖖🏼

        public void Saludar()
        {
            Console.WriteLine($"Hola, soy {nombre}");
        }

        public void Saludar(string nombre)
        {
            Console.WriteLine($"Hola {nombre}, soy {this.nombre}");
        }
    }
}

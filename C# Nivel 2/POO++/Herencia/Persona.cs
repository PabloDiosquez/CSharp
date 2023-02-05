using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal abstract class Persona
    {

        //    public string Nombre { get; set; }

        //    public string Apellido { get; set; }

        //    public int Legajo { get; set; }

        private string nombre;

        private string apellido;

        private int legajo;

        public Persona(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;

            this.apellido = apellido;

            this.legajo = legajo;
        }

        public string Nombre
        {
            get { return nombre; }

        }
    }
}

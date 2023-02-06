using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Lider: Persona
    {
        public Lider(string nombre, string apellido, int legajo) : base(nombre, apellido, legajo)
        {

        }

        public override string Saludar()
        {
            return "Hola! Soy el líder...";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafío_1
{
    internal class Telefono
    {
        private string modelo;

        private string marca;

        private string numeroTelefonico;

        private int codigoOperador;

        public string Modelo
        {
            get { return modelo; }
        }

        public string Marca 
        {
            get { return marca; }
        }

        public string NumeroTelefonico
        {
            get { return numeroTelefonico; }
            set { numeroTelefonico = value; }
        }

        public int CodigoOperador 
        {
            get { return codigoOperador; }
            set
            {
                codigoOperador = 0;

                if (value >= 1 && value <= 3)
                {
                    codigoOperador = value;
                }
            }
        }

        public Telefono(string modelo, string marca)
        {
            this.modelo = modelo;
            
            this.marca = marca; 
        }

        public string Llamar()
        {
            return "Realizando llamada...";
        }

        public string Llamar(string contacto)
        {
            return $"Llamando a {contacto}";
        }

        public string MostrarDatos() 
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("### Datos del teléfono ###");
            sb.AppendLine($"Modelo: {modelo}");
            sb.AppendLine($"Marca: {marca}");
            sb.AppendLine($"Número telefónico: {numeroTelefonico}");
            sb.AppendLine($"Código operador: {codigoOperador}");

            return sb.ToString();
        }

    }
}

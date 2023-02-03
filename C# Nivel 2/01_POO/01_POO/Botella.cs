using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_POO
{
    internal class Botella
    {
        private string material;

        private string color;

        private double capacidad;

        public string Material
        {
            get { return material; }
            set { material = value; }
        }

        public string Color 
        {
            get { return color; }
            set { color = value; }
        }

        public double Capacidad
        {
            get { return capacidad; }
            set 
            {
                if (value >= 0)
                {
                    capacidad = value;
                }
                else
                {
                    capacidad = 0;
                }
            }
        }

    }
}

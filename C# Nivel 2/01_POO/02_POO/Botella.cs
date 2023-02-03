using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_POO
{
    internal class Botella
    {
        private string material;

        private string color;

        public double Capacidad { get; }

        //private double capacidadActual;

        public double CapacidadActual { get; set; }

        // Constructores de la Clase 👷🏼‍♂️

        public Botella() { }

        public Botella(string material, string color)
        {
            this.material = material;

            this.color = color;

            Capacidad = 100;

            CapacidadActual = 0;
        }

        public string Material
        {
            get { return material; }
        }

        public string Color
        {
            get { return color; }
        }

        //public double CapacidadActual 
        //{
        //    get { return capacidadActual; }
        //    set { capacidadActual = value; }
        //}

        public double Recargarse()
        {
            double diferencia = Capacidad - CapacidadActual;

            double monto = 50;

            if (diferencia > 0)
            {
                monto =  (diferencia * 50) / Capacidad;
            }

            CapacidadActual = Capacidad;

            return monto;
        }


        public double Recargarse(double cantidad)
        {
            double total = CapacidadActual + cantidad;

            double monto;

            if (total <= Capacidad)
            {
                monto = (cantidad * 50) / Capacidad;

                CapacidadActual = total;
            }
            else
            {
                double exceso = total - Capacidad;

                monto = ((cantidad - exceso) * 50) / Capacidad;

                CapacidadActual = Capacidad;
            }

            return monto;
        };
    }
}

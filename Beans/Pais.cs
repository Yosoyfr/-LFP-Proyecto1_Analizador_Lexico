using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _LFP_Proyecto1.Beans
{
    class Pais
    {
        /*
        * Atributos del objeto
        */

        private String nombre, bandera;
        private int poblacion, saturacion;

        /*
         * Constructor del objeto 
         */

        public Pais(String nombre, int poblacion, int saturacion, String bandera)
        {
            this.nombre = nombre;
            this.poblacion = poblacion;
            this.saturacion = saturacion;
            this.bandera = bandera;
        }

        /*
         * Accesores y modificadores de todos los atributos
         */


        public String NombrePais
        {
            set { this.nombre = value; }
            get { return this.nombre; }
        }

        public String Bandera
        {
            set { this.bandera = value; }
            get { return this.bandera; }
        }

        public int Poblacion
        {
            set { this.poblacion = value; }
            get { return this.poblacion; }
        }

        public int Saturacion
        {
            set { this.saturacion = value; }
            get { return this.saturacion; }
        }

        public String ObtenerDot()
        {
            return this.NombrePais.Replace(" ", "") + " [shape=record label=\"{" + this.NombrePais + "|" + this.Saturacion + "}\" style=filled fillcolor=" + CalcularColor() + "];\n";
        }
        public String CalcularColor()
        {
            String color = "";
            if (Saturacion >= 0 && Saturacion <= 15)
            {
                color = "white";
            }
            else if (Saturacion > 15 && Saturacion <= 30)
            {
                color = "blue";
            }
            else if (Saturacion > 30 && Saturacion <= 45)
            {
                color = "green";
            }
            else if (Saturacion > 45 && Saturacion <= 60)
            {
                color = "yellow";
            }
            else if (Saturacion > 61 && Saturacion <= 75)
            {
                color = "orange";
            }
            else
            {
                color = "red";
            }
            return color;
        }
    }
}

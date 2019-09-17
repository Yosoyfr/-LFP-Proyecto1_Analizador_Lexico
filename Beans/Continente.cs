using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _LFP_Proyecto1.Beans
{
    class Continente
    {
        /*
        * Atributos del objeto
        */

        private String nombre;
        private ArrayList listaPaises = new ArrayList();

        /*
         * Constructor del objeto 
         */

        public Continente(String nombre)
        {
            this.nombre = nombre;
        }

        /*
         * Accesores y modificadores de todos los atributos
         */
        public String NombreContinente
        {
            set { this.nombre = value; }
            get { return this.nombre; }
        }

        public void AgregarPais(Pais pais)
        {
            this.listaPaises.Add(pais);
        }

        public void Imprimir()
        {
            Console.WriteLine(">>>>>>> " + this.NombreContinente + " <<<<<<<<<<");
            foreach (Pais obj in listaPaises)
            {
                Console.WriteLine(obj.NombrePais + ", " + obj.Poblacion + ", " + obj.Saturacion);
            }
        }

        public String ObtenerDot()
        {
            String cadenGraphviz = "";
            cadenGraphviz += this.NombreContinente.Replace(" ", "") + " [shape=record label=\"{" + this.NombreContinente + "|" + CalcularSaturacion() + "} \" style=filled fillcolor=" + CalcularColor() + "];\n";
            //Se relaciona el continente con los paises 
            foreach (Pais obj in this.listaPaises)
            {
                cadenGraphviz += this.NombreContinente + " -> " + obj.NombrePais.Replace(" ", "") + ";\n";
            }
            //-- Se obtiene el codigo de cada pais ----
            foreach (Pais obj in listaPaises)
            {
                cadenGraphviz += obj.ObtenerDot();
            }
            //-------------------------------------------
            return cadenGraphviz;
        }

        public int CalcularSaturacion()
        {
            int suma = 0;
            int contador = 0;
            foreach (Pais obj in listaPaises)
            {
                suma = suma + obj.Saturacion;
                contador++;
            }
            return suma/contador;
        }
        public String CalcularColor()
        {
            int saturacion = CalcularSaturacion();
            String color = "";
            if (saturacion >= 0 && saturacion <= 15)
            {
                color = "white";
            }
            else if (saturacion > 15 && saturacion <= 30)
            {
                color = "blue";
            }
            else if (saturacion > 30 && saturacion <= 45)
            {
                color = "green";
            }
            else if (saturacion > 45 && saturacion <= 60)
            {
                color = "yellow";
            }
            else if (saturacion > 61 && saturacion <= 75)
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

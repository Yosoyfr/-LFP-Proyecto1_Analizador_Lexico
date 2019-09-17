using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _LFP_Proyecto1.Beans
{
    class Grafica
    {
        /*
       * Atributos del objeto
       */

        private String nombre;
        ArrayList listaContinentes = new ArrayList();

        /*
         * Constructor del objeto 
         */

        public Grafica(String nombre)
        {
            this.nombre = nombre;
        }

        /*
         * Accesores y modificadores de todos los atributos
         */


        public String NombreGrafica
        {
            set { this.nombre = value; }
            get { return this.nombre; }
        }

        public void agregarContinente(Continente continente)
        {
            this.listaContinentes.Add(continente);
        }

        public void Imprimir()
        {
            Console.WriteLine(">>>>>>> " + this.NombreGrafica + " <<<<<<<<<<");
            foreach (Continente obj in listaContinentes)
            {
                Console.WriteLine(obj.NombreContinente);
            }
        }

        public String ObtenerDot()
        {
            String cadenGraphviz = "";
            cadenGraphviz += " digraph G {\n";
            cadenGraphviz += "  start [shape=Mdiamond label=\"" + this.NombreGrafica + "\"];\n";
            //Se relaciona la raiz con los continentes 
            foreach (Continente obj in listaContinentes)
            {
                cadenGraphviz += "  start -> " + obj.NombreContinente + ";\n";
            }
            //----------------------------------------------
            //-- Se obtiene el codigo de cada continente ----
            foreach (Continente obj in listaContinentes)
            {
                cadenGraphviz += obj.ObtenerDot();
            }
            //-------------------------------------------

            cadenGraphviz += "}";
            //-------------------------------------------
            return cadenGraphviz;
        }

        public void creacionGrafica() {
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = false;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();

            cmd.StandardInput.WriteLine("dot -Tpng grafica.dot -o grafica_dot.png");
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();
        }

    }
}

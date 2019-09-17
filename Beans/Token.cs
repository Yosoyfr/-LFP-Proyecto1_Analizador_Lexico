using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _LFP_Proyecto1.Beans
{
    class Token
    {
        /*
         * Lista de Tokens permitidos para esta practica
         */
        public enum Tipo
        {
            Reservada_Grafica,
            Reservada_Nombre,
            Reservada_Continente,
            Reservada_Pais,
            Reservada_Poblacion,
            Reservada_Saturacion,
            Reservada_Bandera,
            Signo_Llaves_Dech,
            Signo_Llaves_Izq,
            Signo_Dos_Puntos,
            Signo_Punto_y_Coma,
            Signo_Porcentaje,
            Cadena,
            Numero,
            Desconocido,
            Reservada_No_Encontrada
        }

        /*
         * Atributos del token
         */

        private Tipo tipoToken;
        private String valor;
        private int linea;
        private int columna;

        /*
         * Constructor del Token, esperando el tipo de la lista anterior y el valor que va a tomar
         */

        public Token(Tipo tipoToken, String valor, int linea, int columna)
        {
            this.tipoToken = tipoToken;
            this.valor = valor;
            this.linea = linea;
            this.columna = columna;
        }

        /*
         * Accesores de los atributos del objeto Token
         */
        public String GetValor
        {
            get { return this.valor; }
        }

        public int GetLinea
        {
            get { return this.linea; }
        }

        public int GetColumna
        {
            get { return this.columna; }
        }

        /*
         * Dependiendo del contexto que se el tipo del token
         * devolvera el valor deseado
         */

        public String GetTipo
        {
            get
            {
                switch (tipoToken)
                {
                    case Tipo.Reservada_Grafica:
                        return "Reservada Grafica";
                    case Tipo.Reservada_Continente:
                        return "Reservada Continente";
                    case Tipo.Reservada_Nombre:
                        return "Reservada Nombre";
                    case Tipo.Reservada_Bandera:
                        return "Reservada Bandera";
                    case Tipo.Reservada_Pais:
                        return "Reservada Pais";
                    case Tipo.Reservada_Poblacion:
                        return "Reservada Poblacion";
                    case Tipo.Reservada_Saturacion:
                        return "Reservada Saturacion";
                    case Tipo.Signo_Dos_Puntos:
                        return "Dos Puntos";
                    case Tipo.Signo_Punto_y_Coma:
                        return "Punto y Coma";
                    case Tipo.Signo_Llaves_Dech:
                        return "Llave Derecha";
                    case Tipo.Signo_Llaves_Izq:
                        return "Llave Izquierda";
                    case Tipo.Signo_Porcentaje:
                        return "Porcentaje";
                    case Tipo.Cadena:
                        return "Cadena";
                    case Tipo.Numero:
                        return "Numero";
                    case Tipo.Reservada_No_Encontrada:
                        return "Identificador desconocido";
                    default:
                        return "Desconocido";
                }
            }
        }

        public String GetID
        {
            get
            {
                switch (tipoToken)
                {
                    case Tipo.Reservada_Grafica:
                        return "1";
                    case Tipo.Reservada_Continente:
                        return "2";
                    case Tipo.Reservada_Nombre:
                        return "3";
                    case Tipo.Reservada_Bandera:
                        return "4";
                    case Tipo.Reservada_Pais:
                        return "5";
                    case Tipo.Reservada_Poblacion:
                        return "6";
                    case Tipo.Reservada_Saturacion:
                        return "7";
                    case Tipo.Signo_Dos_Puntos:
                        return "8";
                    case Tipo.Signo_Punto_y_Coma:
                        return "9";
                    case Tipo.Signo_Llaves_Dech:
                        return "10";
                    case Tipo.Signo_Llaves_Izq:
                        return "11";
                    case Tipo.Cadena:
                        return "12";
                    case Tipo.Numero:
                        return "13";
                    case Tipo.Signo_Porcentaje:
                        return "14";
                    default:
                        return "Desconocido";
                }
            }
        }
    }
}

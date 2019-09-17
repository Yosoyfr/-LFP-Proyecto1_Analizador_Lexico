using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _LFP_Proyecto1.Beans
{
    class Analizador_Lexico
    {
        /*
         * Patron Singleton
         */
        public static Analizador_Lexico instance = null;
        public static Analizador_Lexico Singleton
        {
            get
            {
                if (instance == null)
                {
                    instance = new Analizador_Lexico();
                }
                return instance;
            }
        }

        /*
         * Termina el Singleton
         */

        /*
         * Variable que representa la lista de tokens
         */
        private List<Token> Lista_de_Tokens;

        /*
        * Variable que representa la lista de tokens
        */
        private List<Token> Lista_de_Errores;


        /*
         * Variable booleana que me da lugar a crear el dot
         */

        private Boolean pasoLibre;

        public Analizador_Lexico()
        {
            pasoLibre = true;
        }

        public Boolean stepHTML() {
            if (pasoLibre)
            {
                return true;
            }
            else {
                return false;
            }
        }

        Continente pruebaContinente = new Continente("cont");
        String nombrePais = "";
        String bandera = "";
        int satura = 0;
        int pobla = 0;
        public void crearGrafico()
        {
            Grafica pruebaGrafo = new Grafica(Lista_de_Tokens[5].GetValor.Trim(new Char[] { '"' }));
            
            try
            {
                int estado = 0;
                if (pasoLibre)
                {
                    for (int i = 0; i < Lista_de_Tokens.Count; i++)
                    {
                        switch (estado)
                        {
                            case 0:
                                /*
                                 * Verificamos si es un continente
                                 */
                                if (Lista_de_Tokens[i].GetValor.Equals("Continente"))
                                {
                                    pruebaContinente = new Continente(Lista_de_Tokens[i + 5].GetValor.Trim(new Char[] {'"'}));
                                    
                                    estado = 1;
                                    /*
                                     *pasamos a los paises del continente
                                     */
                                }
                                break;
                            case 1:
                                /*
                                 * Verificamos los paises que tenga ese continente
                                 */
                                if (Lista_de_Tokens[i].GetValor.Equals("Pais"))
                                {
                                    estado = 2;
                                    /*
                                     * despues de encontrar un pais, verificamos sus atriubutos
                                     */
                                }
                                else if (Lista_de_Tokens[i].GetValor.Equals("}"))
                                {
                                    /*
                                     * SI ya no hay mas paises, regresamor a ver si existe otro continente
                                     */
                                    pruebaGrafo.agregarContinente(pruebaContinente);
                                    estado = 0;
                                }
                                break;
                            case 2:
                                /*
                                 * Verificamos todos los atributos que contengan el pais
                                 */
                                if (Lista_de_Tokens[i].GetValor.Equals("Nombre"))
                                {
                                    nombrePais = Lista_de_Tokens[i + 2].GetValor.Trim(new Char[] { '"' });
                                    estado = 2;
                                }
                                else if (Lista_de_Tokens[i].GetValor.Equals("Poblacion"))
                                {
                                    pobla = int.Parse(Lista_de_Tokens[i + 2].GetValor);
                                    estado = 2;
                                }
                                else if (Lista_de_Tokens[i].GetValor.Equals("Saturacion"))
                                {
                                    satura = int.Parse(Lista_de_Tokens[i + 2].GetValor);
                                    estado = 2;
                                }
                                else if (Lista_de_Tokens[i].GetValor.Equals("Bandera"))
                                {
                                    bandera = Lista_de_Tokens[i + 2].GetValor.Trim(new Char[] { '"' });
                                    estado = 2;
                                }
                                else if (Lista_de_Tokens[i].GetValor.Equals("}"))
                                {
                                    /*
                                     * si ya no hay mas atributos, ingresamos el pais al continente
                                     * y regresamos a ver si hay mas continentes
                                     */
                                    pruebaContinente.AgregarPais(new Pais(nombrePais, pobla, satura, bandera));
                                    estado = 1;
                                }
                                break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("\n Algo salio mal en el analisis");
                }

                /*
                 * Seteamos los valores de los atributos del pais a un estado neutral
                 */
                nombrePais = "";
                bandera = "";
                satura = 0;
                pobla = 0;


                /*
                 * Escribimos el archivo .dot
                 */
                File.WriteAllText(Application.StartupPath + '\\' + "grafica.dot", pruebaGrafo.ObtenerDot());

                /*
                 * Creamos el grafo a partir del archivo .dot escrito
                 */
                pruebaGrafo.creacionGrafica();

            }

            catch { }
            
        }
        /*
         * Metodo para añadir token a la lista de tokens
         */

        public void addToken(Token.Tipo token, String lexema, int linea, int columna)
        {
            Token nuevoToken = new Token(token, lexema, linea, columna);
            Lista_de_Tokens.Add(nuevoToken);
        }

        /*
         * Metodo para añadir error a la lista de tokens errorenos
         */

        public void addTokenErroneo(Token.Tipo token, String lexema, int linea, int columna)
        {
            Token nuevoToken = new Token(token, lexema, linea, columna);
            Lista_de_Errores.Add(nuevoToken);
        }

        public void analizador(String entrada)
        {
            Lista_de_Tokens = new List<Token>();
            Lista_de_Errores = new List<Token>();
            int estado = 0;
            int columna = 0;
            int fila = 1;
            String lexema = "";
            Char c;
            entrada = entrada + " ";
            pasoLibre = true;

            for (int i = 0; i < entrada.Length; i++)
            {
                c = entrada[i];
                columna++;
                switch (estado)
                {
                    case 0:
                        /*
                         * Revisara si puede ser una palabra reservada
                         */
                        if (Char.IsLetter(c))
                        {
                            estado = 1;
                            lexema += c;
                        }
                        /*
                         * Revisara si puede ser un numero
                         */
                        else if (Char.IsDigit(c))
                        {
                            estado = 2;
                            lexema += c;
                        }
                        /*
                         * Revisara si puede ser una cadena
                         */
                        else if (c == '"')
                        {
                            estado = 4;
                            i--;
                            columna--;
                        }
                        /*
                         * Revisara si puede ser un espacio en blanco
                         */
                        else if (c == ' ')
                        {
                            estado = 0;
                        }
                        /*
                         * Revisara si puede ser un enter, para cambiar de linea
                         */
                        else if (c == '\n')
                        {
                            columna = 0;
                            fila++;
                            estado = 0;
                        }

                        /*
                         * Lista de Tokens ya establecidos que son todos los simbolos admitidos
                         */
                        else if (c.CompareTo('{') == 0)
                        {
                            lexema += c;
                            addToken(Token.Tipo.Signo_Llaves_Izq, lexema, fila, columna);
                            lexema = "";
                        }
                        else if (c.CompareTo('}') == 0)
                        {
                            lexema += c;
                            addToken(Token.Tipo.Signo_Llaves_Dech, lexema, fila, columna);
                            lexema = "";
                        }
                        else if (c.CompareTo(':') == 0)
                        {
                            lexema += c;
                            addToken(Token.Tipo.Signo_Dos_Puntos, lexema, fila, columna);
                            lexema = "";
                        }
                        else if (c.CompareTo(';') == 0)
                        {
                            lexema += c;
                            addToken(Token.Tipo.Signo_Punto_y_Coma, lexema, fila, columna);
                            lexema = "";
                        }
                        else if (c.CompareTo('%') == 0)
                        {
                            lexema += c;
                            addToken(Token.Tipo.Signo_Porcentaje, lexema, fila, columna);
                            lexema = "";
                        }

                        /*
                         * Si no es ninguno de la lista de tokens, nos devuelve un error
                         */

                        else
                        {
                            estado = -1;
                            i--;
                            columna--;
                        }
                        break;

                    case 1:
                        /*
                         * Buscara que palabra reservada es
                         */
                        /*
                         * Buscara que palabra reservada es
                         */
                        if (lexema.Equals("Grafica"))
                        {
                            addToken(Token.Tipo.Reservada_Grafica, lexema, fila, columna);
                            lexema = "";
                            i--;
                            columna--;
                            estado = 0;
                        }
                        else if (lexema.Equals("Nombre"))
                        {
                            addToken(Token.Tipo.Reservada_Nombre, lexema, fila, columna);
                            lexema = "";
                            i--;
                            columna--;
                            estado = 0;
                        }
                        else if (lexema.Equals("Continente"))
                        {
                            addToken(Token.Tipo.Reservada_Continente, lexema, fila, columna);
                            lexema = "";
                            i--;
                            columna--;
                            estado = 0;
                        }
                        else if (lexema.Equals("Pais"))
                        {
                            addToken(Token.Tipo.Reservada_Pais, lexema, fila, columna);
                            lexema = "";
                            i--;
                            columna--;
                            estado = 0;
                        }
                        else if (lexema.Equals("Poblacion"))
                        {
                            addToken(Token.Tipo.Reservada_Poblacion, lexema, fila, columna);
                            lexema = "";
                            i--;
                            columna--;
                            estado = 0;
                        }
                        else if (lexema.Equals("Saturacion"))
                        {
                            addToken(Token.Tipo.Reservada_Saturacion, lexema, fila, columna);
                            lexema = "";
                            i--;
                            columna--;
                            estado = 0;
                        }
                        else if (lexema.Equals("Bandera"))
                        {
                            addToken(Token.Tipo.Reservada_Bandera, lexema, fila, columna);
                            lexema = "";
                            i--;
                            columna--;
                            estado = 0;
                        }
                        else if (Char.IsLetterOrDigit(c) || c == '_')
                        {
                            lexema += c;
                            estado = 1;
                        }

                        /*
                         * Si no encuentra resultados, esta palabra no existe en el lenguaje
                         */

                        else
                        {
                            estado = 0;
                            i--;
                            columna--;
                            Console.WriteLine("Este identificador no existe en el lenguaje: " + lexema);
                            addTokenErroneo(Token.Tipo.Reservada_No_Encontrada, lexema, fila, columna);
                            lexema = "";
                            pasoLibre = false;

                        }
                        break;
                    case 2:
                        /*
                         * Revisara el numero
                         */
                        if (Char.IsDigit(c))
                        {
                            lexema += c;
                            estado = 2;
                        }
                        else
                        {
                            addToken(Token.Tipo.Numero, lexema, fila, columna);
                            lexema = "";
                            i--;
                            columna--;
                            estado = 0;
                        }
                        break;
                    case 4:
                        /*
                         * Comprueba que es una cadena
                         */
                        if (c == '"')
                        {
                            lexema += c;
                            estado = 5;
                        }
                        break;
                    case 5:
                        /*
                         * Comprobara todos los datos que contendra la cadena,
                         * hasta encontrar otro (") para cerrar la cadena
                         */
                        if (c == '\n')
                        {
                            columna = 0;
                            fila++;
                            estado = 5;
                        }
                        else if (c != '"')
                        {
                            lexema += c;
                            estado = 5;
                        }
                        else
                        {
                            estado = 6;
                            i--;
                            columna--;
                        }
                        break;
                    case 6:
                        /*
                         * Aqui cierra la cadena al encontrar (")
                         */
                        if (c == '"')
                        {
                            lexema += c;
                            addToken(Token.Tipo.Cadena, lexema, fila, columna);
                            estado = 0;
                            lexema = "";
                        }

                        break;

                    /*
                     * Si no se cumple con ninguno de estos tipos 
                     * de tokens, devuelve un error exceptuado 
                     * saltos de linea, espacios o tabulaciones
                     */
                    case -1:
                        lexema += c;
                        if (c.CompareTo('\n') == 0 || c.CompareTo('\\') == 0 || c.CompareTo('\t') == 0 || c.CompareTo(' ') == 0 || c == 13)
                        {
                            estado = 0;
                            lexema = "";
                        }
                        else
                        {
                            Console.WriteLine("Error lexico con: " + c);
                            addTokenErroneo(Token.Tipo.Desconocido, c.ToString(), fila, columna);
                            estado = 0;
                            lexema = "";
                            pasoLibre = false;
                        }
                        break;
                }

            }
        }

        /*
         * Metodo que imprime en HTML la lista de tokens encontrada en el texto de la
         * pestaña en focus
         */

        

        public void imprimirListaToken()
        {
            try
            {
                /*
                 * Creacion del html
                */
                String Lista_de_Tokens_HTML = "<html>" +
                    "<head>" +
                    "<meta charset='utf-8'>" +
                    "<title>\n" +
                    "		Reporte de Tokens\n" +
                    "	</title>\n" +
                    "	<link rel=\"stylesheet\" type=\"text/css\" href=\"css/bootstrap.min.css\">\n" +
                    "	<script type=\"text/javascript\" src=\"js/bootstrap.min.js\"></script>\n" +
                    "	<script type=\"text/javascript\" src=\"js/jquery-3.4.1.min.js\"></script></head><body>\n" +
                    "<div class=\"shadow-lg p-3 mb-5 rounded bg-dark text-white\">\n" +
                    "		<center><h1>Reporte de Tokens \n" +
                    "  <small class=\"text-muted bg-white\">Lista de Tokens</small></h1> </center> \n" +
                    "		</div>\n" +
                    "	<div class=\"container\">\n" +
                    "		<table class=\"table table-hover table-light text-center\">\n" +
                    " 			 <thead class=\"thead-dark\">   					 <tr>\n" +
                    "				      <th scope=\"col\">    #   </th>\n" +
                    "				      <th scope=\"col\">   ID TOKEN  </th>\n" +
                    "				      <th scope=\"col\">    LINEA    </th>\n" +
                    "				      <th scope=\"col\" style=\"width: 450px\">LEXEMA</th>\n" +
                    "				      <th scope=\"col\" style=\"width: 400px\">         TOKEN         </th>\n" +
                    "				    </tr>\n" +
                    "				  </thead><tbody>";

                /*
                 * Enlistado del vector de tokens encontrado en el analisis
                 */
                for (int i = 0; i < Lista_de_Tokens.Count; i++)
                {
                    if (Lista_de_Tokens[i] != null)
                    {
                        Lista_de_Tokens_HTML = Lista_de_Tokens_HTML +
                            "<tr>\n"
                         + "				      <th scope=\"row\">" + (i + 1) + "</th>\n"
                         + "				      <td>" + Lista_de_Tokens[i].GetID + "</td>\n"
                         + "				      <td>" + Lista_de_Tokens[i].GetLinea + "</td>\n"
                         + "				      <td style=\"width: 450px\" >" + Lista_de_Tokens[i].GetValor + "</td>\n"
                         + "				      <td style=\"width: 400px\">" + Lista_de_Tokens[i].GetTipo + "</td>\n"
                         + "				    </tr>";
                    }
                }
                /*
                 * Finalizacion del archivo HTML
                 */
                Lista_de_Tokens_HTML = Lista_de_Tokens_HTML +
                    "</tbody>\n"
                                + "				</table>\n"
                                + "\n"
                                + "			</div>\n"
                                + "		\n"
                                + "</body>\n"
                                + "</html>";

                /*
                 * Proceso de guardado del archivo html
                 */
                File.WriteAllText(Application.StartupPath + "\\Archivos HTMLS\\Reporte de Tokens.html", Lista_de_Tokens_HTML);
                
            }
            catch { }

        }

        /*
         * Metodo que imprime en HTML la lista de errores encontrados en el texto de la
         * pestaña en focus
         */

        public void imprimirListaErrores()
        {
            try
            {
                if (!pasoLibre)
                {
                    /*
                     * Creacion del html
                    */
                    
                    String Lista_de_Errores_HTML = "<html>" +
                        "<head>" +
                        "<meta charset='utf-8'>" +
                        "<title>\n" +
                        "		Reporte de Tokens\n" +
                        "	</title>\n" +
                        "	<link rel=\"stylesheet\" type=\"text/css\" href=\"css/bootstrap.min.css\">\n" +
                        "	<script type=\"text/javascript\" src=\"js/bootstrap.min.js\"></script>\n" +
                        "	<script type=\"text/javascript\" src=\"js/jquery-3.4.1.min.js\"></script></head><body>\n" +
                        "<div class=\"shadow-lg p-3 mb-5 rounded bg-dark text-white\">\n" +
                        "		<center><h1>Reporte de Errores \n" +
                        "  <small class=\"text-muted bg-white\">Lista de Errores</small></h1> </center> \n" +
                        "		</div>\n" +
                        "	<div class=\"container\">\n" +
                        "		<table class=\"table table-hover table-light text-center\">\n" +
                        " 			 <thead class=\"thead-dark\">   					 <tr>\n" +
                        "				      <th scope=\"col\">    #   </th>\n" +
                        "				      <th scope=\"col\">   FILA  </th>\n" +
                        "				      <th scope=\"col\">    COLUMNA    </th>\n" +
                        "				      <th scope=\"col\" style=\"width: 400px\">CARACTER</th>\n" +
                        "				      <th scope=\"col\" style=\"width: 450px\">         DESCRIPCION         </th>\n" +
                        "				    </tr>\n" +
                        "				  </thead><tbody>";

                    /*
                     * Enlistado del vector de errrores encontrados en el analisis
                     */

                    for (int i = 0; i < Lista_de_Errores.Count; i++)
                    {
                        if (Lista_de_Errores[i] != null)
                        {
                            Lista_de_Errores_HTML = Lista_de_Errores_HTML +
                                "<tr>\n"
                             + "				      <th scope=\"row\">" + (i + 1) + "</th>\n"
                             + "				      <td>" + Lista_de_Errores[i].GetLinea + "</td>\n"
                             + "				      <td>" + Lista_de_Errores[i].GetColumna + "</td>\n"
                             + "				      <td style=\"width: 450px\" >" + Lista_de_Errores[i].GetValor + "</td>\n"
                             + "				      <td style=\"width: 400px\">" + Lista_de_Errores[i].GetTipo + "</td>\n"
                             + "				    </tr>";
                        }
                    }

                    /*
                     * Finalizacion del archivo HTML
                     */

                    Lista_de_Errores_HTML = Lista_de_Errores_HTML +
                        "</tbody>\n"
                                    + "				</table>\n"
                                    + "\n"
                                    + "			</div>\n"
                                    + "		\n"
                                    + "</body>\n"
                                    + "</html>";

                    /*
                     * Proceso de guardado del archivo html
                     */

                    File.WriteAllText(Application.StartupPath + "\\Archivos HTMLS\\Reporte de Errores.html", Lista_de_Errores_HTML);

                }
            }
            catch { }
        }

        
        public void abrirHTMLTokens() {

            /*
            *Proceso de inicir el archivo html generado 
            */
            Process.Start(Application.StartupPath + "\\Archivos HTMLS\\Reporte de Tokens.html");
        }

        public void abrirHTMLErrores()
        {

            /*
             *Proceso de inicir el archivo html generado 
             */
            Process.Start(Application.StartupPath + "\\Archivos HTMLS\\Reporte de Errores.html");
        }

    }
}

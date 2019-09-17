using _LFP_Proyecto1.Beans;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _LFP_Proyecto1
{
    public partial class Form1 : Form
    {

        /*
         * Patron Singleton
         */

        public static Form1 instance = null;

        public static Form1 Singleton
        {
            get
            {
                if (instance == null)
                {
                    instance = new Form1();

                }
                return instance;
            }
        }

        /*
         * Termina el Singleton
         */

        public Form1()
        {
            InitializeComponent();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Restaurar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            Restaurar.Visible = false;
            Maximizar.Visible = true;
        }

        private void Maximizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            Maximizar.Visible = false;
            Restaurar.Visible = true;
        }

        private void Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuSidebar_Click(object sender, EventArgs e)
        {
            Console.WriteLine(btnOpenImage.Location);
            if (Sidebar.Width == 270)
            {
                closeSideBar();
            }
            else
            {
                openSideBar();
            }
        }

        public void closeSideBar() {
            Sidebar.Visible = false;
            Sidebar.Width = 62;
            SidebarWrapper.Width = 90;
            LineaSidebar.Width = 50;
            LineaSidebar2.Width = 50;
            areaGrafica.Width = 619;
            areaGrafica.Height = 300;
            AnimacionSidebar.Show(Sidebar);
            areaSeleccionPais.Location = new Point(770, 467);
            btnOpenImage.Location = new Point(853, 28);
            label2.Visible = false;
            lblAcercaDe.Visible = false;
            lblErrores.Height = 0;
            lblErrores.Width = 0;
        }

        public void openSideBar() {
            Sidebar.Visible = false;
            Sidebar.Width = 270;
            SidebarWrapper.Width = 300;
            LineaSidebar.Width = 252;
            LineaSidebar2.Width = 252;
            areaGrafica.Width = 409;
            areaGrafica.Height = 230;
            AnimacionSidebarBack.Show(Sidebar);
            areaSeleccionPais.Location = new Point(542, 334);
            btnOpenImage.Location = new Point(555, 590);
            label2.Visible = true;
        }

        private void LblPaisSeleccion_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BunifuFlatButton6_Click(object sender, EventArgs e)
        {
            if (Sidebar.Width != 270)
            {
                openSideBar();
            }
            if (lblAcercaDe.Visible == true) {
                lblAcercaDe.Visible = false;
            }
            else {
                AnimacionSidebarBack.Show(lblAcercaDe);
            }
        }

        /*
         * Metodo para el tipo de rutas
         */

        static RutasArchivos[] arrayRutas = new RutasArchivos[100];

        public void nuevaRuta(String nombreArchivo, String rutaArchibo)
        {
            for (int i = 0; i < arrayRutas.Length; i++)
            {
                if (arrayRutas[i] == null)
                {
                    RutasArchivos nuevoArchivo = new RutasArchivos(i + 1 + " - " + nombreArchivo, rutaArchibo);
                    arrayRutas[i] = nuevoArchivo;
                    textualTabControl1.SelectedTab.Text = nuevoArchivo.NombreArchivo;
                    break;
                }
            }
        }

        /*
         * Metodo para crear nuevas Pestañas
         */
        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
            String title = "Pestaña " + (textualTabControl1.TabCount + 1).ToString();
            TabPage myTabPage = new TabPage(title);
            textualTabControl1.TabPages.Add(myTabPage);
            textualTabControl1.SelectedTab = myTabPage;
        }

        /*
        * Metodo de cargar archivo desde algun directorio en la PC
        */

        private void BtnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog Archivo = new OpenFileDialog();
            Archivo.Filter = "Archivo ORG |*.ORG";
            Archivo.InitialDirectory = @"C:\Users\Francisco Suarez\Desktop";

            if (Archivo.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    textualTabControl1.SelectedTab.Controls[0].Text = File.ReadAllText(Archivo.FileName);
                    nuevaRuta(Archivo.SafeFileName, Archivo.FileName);
                }
                catch (ArgumentNullException)
                {
                    Console.WriteLine("Hubo un error");
                }
            }
        }

        private void BtnSaveAs_Click(object sender, EventArgs e)
        {
          /*
           * Creacion del contenido archivo.ORG
           */
            String Contenido_Archivo_ORG = "";
            try
            {
                /*
                * Obtenemos el contenido del textBox de la pestaña
                */
                Contenido_Archivo_ORG = textualTabControl1.SelectedTab.Controls[0].Text;
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Hubo un error");
            }

            /*
             * Proceso de guardado del archivo.ly
             */

            SaveFileDialog archivoORG = new SaveFileDialog();
            archivoORG.Filter = "Archivo ORG |*.ORG";
            archivoORG.InitialDirectory = @"C:\Users\Francisco Suarez\Desktop";
            archivoORG.FileName = textualTabControl1.SelectedTab.Text.Trim(new Char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '-', ' ' });
            if (archivoORG.ShowDialog() == DialogResult.OK && archivoORG.FileName != null)
            {
                File.WriteAllText(archivoORG.FileName, Contenido_Archivo_ORG);
            }
        }

        Boolean stepSave = true;
        String rutaPrevia = "";

        private void BtnSave_Click(object sender, EventArgs e)
        {
            /*
           * Creacion del contenido archivo.ORG
           */
            String Contenido_Archivo_ORG = "";
            try
            {
                /*
                * Obtenemos el contenido del textBox de la pestaña
                */
                Contenido_Archivo_ORG = textualTabControl1.SelectedTab.Controls[0].Text;
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("Hubo un error");
            }

            for (int i = 0; i < arrayRutas.Length; i++)
            {
                if (arrayRutas[i] != null && arrayRutas[i].NombreArchivo == textualTabControl1.SelectedTab.Text)
                {
                    stepSave = false;
                    rutaPrevia = arrayRutas[i].RutaArchivo;
                }
            }

            SaveFileDialog archivoORG = new SaveFileDialog();
            archivoORG.Filter = "Archivo ORG |*.ORG";
            archivoORG.InitialDirectory = @"C:\Users\Francisco Suarez\Desktop";
            if (stepSave)
            {
                archivoORG.FileName = "Archivo";
                
                if (archivoORG.ShowDialog() == DialogResult.OK && archivoORG.FileName != null)
                {
                    File.WriteAllText(archivoORG.FileName, Contenido_Archivo_ORG);
                    nuevaRuta(Path.GetFileName(archivoORG.FileName), archivoORG.FileName);
                }
            }
            else {
                Console.WriteLine("Ya se guardo");
                File.WriteAllText(rutaPrevia, Contenido_Archivo_ORG);
            }
            stepSave = true;
            rutaPrevia = "";
        }

        private void BtnOpenPDF_Click(object sender, EventArgs e)
        {
            if (Sidebar.Width != 270)
            {
                openSideBar();
            }
            if (lblErrores.Height == 0)
            {
                lblErrores.Height = 150;
                lblErrores.Width = 270;
                lblErrores.Visible = false;
                AnimacionSidebarBack.Show(lblErrores);
            }
            else
            {
                lblErrores.Height = 0;
                lblErrores.Width = 0;
            }
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void BtnAnalizar_Click(object sender, EventArgs e)
        {
            correrAnalisis();
            
        }

        private void BunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            Analizador_Lexico.Singleton.abrirHTMLTokens();
        }

        private void BunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Analizador_Lexico.Singleton.abrirHTMLErrores();
        }

        public void correrAnalisis() {
            String entrada = textualTabControl1.SelectedTab.Controls[0].Text;
            if (entrada != "")
            {
                /*
                 * Proceso de análisis léxico
                 */
                Analizador_Lexico.Singleton.analizador(entrada);
                /*
                * Luego del analisis léxico obtenemos como salida una lista de tokens,
                * ahora procedemos a imprimirla para mostrar en consola su contenido.
                */
                Analizador_Lexico.Singleton.imprimirListaToken();
                Analizador_Lexico.Singleton.imprimirListaErrores();
                Analizador_Lexico.Singleton.crearGrafico();
                areaGrafica.ImageLocation = null;
                if (Analizador_Lexico.Singleton.stepHTML())
                {
                    btnHTMLError.Visible = false;
                    lblHTML.Text = "          NO SE ENCONTRARON             ERRORES";
                    btnOpenImage.Visible = true;
                    btnGenerarPDF.Visible = true;
                    areaGrafica.ImageLocation = Application.StartupPath + "\\grafica_dot.png";
                }
                else
                {
                    btnHTMLError.Visible = true;
                    lblHTML.Text = "          SE ENCONTRARON                   ERRORES";
                    btnOpenImage.Visible = false;
                    btnGenerarPDF.Visible = false;
                }
                btnHTMLToken.Visible = true;
                lblErrores.Visible = true;

            }
            else {
                MessageBox.Show("No hay texto que analizar");
                lblErrores.Visible = false;
            }
        }

        private void BtnGenerarPDF_Click(object sender, EventArgs e)
        {
            /*
            Grafica pruebaGrafo = new Grafica("Prueba Grafo");
            Continente Asia = new Continente("ASIA");
            Asia.AgregarPais(new Pais("Japon", 2352342, 80, "C:\\imagen.jpg"));
            Asia.AgregarPais(new Pais("China", 1350000000, 95, "C:\\imagen.jpg"));
            Asia.AgregarPais(new Pais("Korea", 2352342, 40, "C:\\imagen.jpg"));
            pruebaGrafo.agregarContinente(Asia);

            Continente America = new Continente("AMERICA");
            America.AgregarPais(new Pais("Canada", 23423423, 65, "C:\\imagen.jpg"));
            America.AgregarPais(new Pais("Guatemala", 17263239, 40, "C:\\guate.jpg"));
            America.AgregarPais(new Pais("Chile", 235234234, 60, "C:\\imagen.jpg"));
            America.AgregarPais(new Pais("Estados Unidos", 235234234, 55, "C:\\imagen.jpg"));
            pruebaGrafo.agregarContinente(America);

            File.WriteAllText(Application.StartupPath + '\\' + "grafica.dot", pruebaGrafo.ObtenerDot());

            pruebaGrafo.creacionGrafica();
            */
            /*
            OpenFileDialog Archivo = new OpenFileDialog();
            Archivo.FileName = Application.StartupPath + "\\grafica_dot.png";
            Image imagenG = Image.FromFile(Archivo.FileName);
            //areaGrafica.Image = null;
            areaGrafica.Image = imagenG;
            */
            /*
            FileStream file = new FileStream(Application.StartupPath + "\\grafica_dot.png", FileMode.Open);
            Image toLoad = Image.FromStream(file);
            */
            areaGrafica.ImageLocation = Application.StartupPath + "\\grafica_dot.png";
        }

        private void AreaSeleccionPais_Click(object sender, EventArgs e)
        {

        }

        private void BtnOpenImage_Click(object sender, EventArgs e)
        {
            /*
            *Proceso de inicir el grafico generado 
            */
            Process.Start(Application.StartupPath + @"\\grafica_dot.png");
        }
    }
}

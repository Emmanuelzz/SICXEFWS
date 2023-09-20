using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

using Antlr4;
using Antlr4.Runtime;

namespace SICXE
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void analizar_Click(object sender, EventArgs e)
        {
            List<string> lang1 = new List<string>();
            List<string> lang2 = new List<string>();
            List<List<string>> tabSim = new List<List<string>>();//Lista para la tabla de simbolos
            tabSim.Add(lang1);
            tabSim.Add(lang2);
            int linea = 0;
            int ce = 0;
            List<string> codObj = new List<string>();//Lista para el manejo del cp (codObj[0]) y errores (codObj[1])
            String line;
            // Crear un cuadro de diálogo de archivo para que el usuario seleccione un archivo de texto.
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Establecer la ruta predeterminada en el escritorio.
            openFileDialog.InitialDirectory = Environment.CurrentDirectory;

            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = openFileDialog.FileName;
                    try
                    {
                        string path = Environment.CurrentDirectory;
                        //Pass the filepath and filename to the StreamWriter Constructor
                        StreamWriter sw = new StreamWriter(path + "\\prueba.err");
                        //Pass the file path and file name to the StreamReader constructor
                        StreamReader sr = new StreamReader(filePath);
                        //archivo intermedio
                        StreamWriter archInt = new StreamWriter(path + "\\archivoIntermedio.txt");
                        archInt.WriteLine("\t\t\tArchivo Intermedio\n");
                        archInt.WriteLine("LINEA\tCP\t\t\tCodigo Objeto y/o Errores");
                        codObj.Add("0000");
                        codObj.Add("");
                        //Read the first line of text
                        line = sr.ReadLine();
                        //Continue to read until you reach end of file
                        while (line != null)
                        {
                            analizadorLSLexer lex = new analizadorLSLexer(new AntlrInputStream(line));
                            //CREAMOS UN LEXER CON LA CADENA QUE ESCRIBIO EL USUARIO
                            CommonTokenStream tokens = new CommonTokenStream(lex);
                            //CREAMOS LOS TOKENS SEGUN EL LEXER CREADO
                            analizadorLSParser parser = new analizadorLSParser(tokens);
                            //CREAMOS EL PARSER CON LOS TOKENS CREADOS
                            var errorListener = new ErrorListener();
                            parser.RemoveErrorListeners();
                            parser.AddErrorListener(errorListener);
                            codObj[1] = "";//Se restable el valor del error para el siguiente calculo
                            try
                            {
                                string cp = codObj[0]; //obtiene el valor cp actual ya que cp apunta al siguiente
                                //System.Console.WriteLine("Resultado linea:"+linea.ToString());
                                parser.programa(ref codObj, ref tabSim);//Parametros por referencia para el calculo del cp,errores y tabsim
                                //SE VERIFICA QUE EL ANALIZADOR EMPIECE CON LA EXPRESION

                                //Se escribe en el archivo la linea que corresponde con los datos
                                archInt.WriteLine(linea.ToString() + "\t" + cp + "\t" + line + "\t" + codObj[1].ToString());
                                
                                if (errorListener.Errors.Count > 0)
                                {
                                    //Console.WriteLine("Error linea:"+linea.ToString());
                                    foreach (var error in errorListener.Errors)
                                    {
                                        Console.WriteLine("Linea:" + linea.ToString() + " " + error);
                                        try
                                        {
                                            ce++;
                                            //Write a line of text
                                            sw.WriteLine("Linea:" + linea.ToString() + " " + error.ToString());

                                        }
                                        catch (Exception ex)
                                        {
                                            Console.WriteLine("Exception: " + ex.Message);
                                        }
                                    }
                                }
                            }
                            catch (RecognitionException ex)
                            {
                                Console.Error.WriteLine(ex.StackTrace);
                            }
                            //write the line to console window
                            //Console.WriteLine(line);
                            //Read the next line
                            line = sr.ReadLine();
                            linea++;

                        }

                        //Se cargan los datos de la tabla de simbolos a dataGrid
                        dt_TabSim.Rows.Clear();
                        dt_TabSim.DataSource = null;
                        dt_TabSim.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
                        for (int i =0; i< tabSim[0].Count;i++) {
                            dt_TabSim.Rows.Add();
                            for (int j=0;j<tabSim.Count;j++) {
                                dt_TabSim.Rows[i].Cells[j].Value = tabSim[j][i];
                            }    
                        }

                        //close the file
                        sr.Close();
                        sw.Close();
                        archInt.Close();
                        if (ce == 0)
                            Console.WriteLine("#EJECUCION SIN ERRORES#");
                        Console.Read();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Exception: " + ex.Message);
                        Console.Read();
                    }

                }
                catch (Exception ex) {
                    MessageBox.Show($"Error al leer el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
    public class ErrorListener : BaseErrorListener
    {
        public List<string> Errors { get; } = new List<string>();

        public override void SyntaxError(
            IRecognizer recognizer,
            IToken offendingSymbol,
            int line,
            int charPositionInLine,
            string msg,

            RecognitionException e)
        {
            string error = $"Error en línea {line}:{charPositionInLine} - {msg}";
            Errors.Add(error);
        }
    }
}

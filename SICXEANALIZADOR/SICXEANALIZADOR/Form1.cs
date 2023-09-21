using System;
using System.IO;
using System.Windows.Forms;
using Antlr4.Runtime;
using System.Collections.Generic;

namespace SICXEANALIZADOR
{
    public partial class Form1 : Form
    {
        private int errorCounter = 0; // Contador para el nombre del archivo de error

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Puedes agregar código aquí para manejar eventos de etiquetas si es necesario.
        }

        private void botonex_Click(object sender, EventArgs e)
        {
            // Crear un cuadro de diálogo de archivo para que el usuario seleccione un archivo de texto.
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Establecer la ruta predeterminada en el escritorio.
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = openFileDialog.FileName;

                    // Obtener la carpeta del archivo base de la aplicación
                    string appDirectory = AppDomain.CurrentDomain.BaseDirectory;

                    // Leer el contenido del archivo seleccionado.
                    string text = File.ReadAllText(filePath);

                    SICXELexer lex = new SICXELexer(new AntlrInputStream(text));
                    CommonTokenStream tokens = new CommonTokenStream(lex);
                    SICXEParser parser = new SICXEParser(tokens);

                    // Modificamos la bandera para detectar errores
                    bool errorEncontrado = false;

                    try
                    {
                        CustomErrorListener errorListener = new CustomErrorListener();

                        parser.RemoveErrorListeners(); // Remover los manejadores de errores predeterminados
                        parser.AddErrorListener(errorListener); // Agregar el manejador de errores personalizado

                        // Llama al método compileUnit para analizar la expresión
                        var result = parser.compileUnit();

                        // Verifica si hubo errores de sintaxis
                        if (errorListener.SyntaxErrors.Count > 0)
                        {
                            string errorMessages = "Errores de sintaxis:";

                            foreach (var error in errorListener.SyntaxErrors)
                            {
                                errorMessages += "\n" + error;
                            }

                            MessageBox.Show(errorMessages, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            errorEncontrado = true;

                            // Genera el nombre del archivo de error
                            string errorFileName = $"Errores{++errorCounter}.err";
                            string errorFilePath = Path.Combine(appDirectory, errorFileName); // Ruta completa del archivo de errores

                            // Guarda los mensajes de error en el archivo de errores
                            File.WriteAllText(errorFilePath, errorMessages);
                        }
                    }
                    catch (RecognitionException ex)
                    {
                        // Imprime el mensaje de error de sintaxis
                        MessageBox.Show("Error de sintaxis: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        errorEncontrado = true;

                        // Genera el nombre del archivo de error
                        string errorFileName = $"Errores{++errorCounter}.err";
                        string errorFilePath = Path.Combine(appDirectory, errorFileName); // Ruta completa del archivo de errores

                        // Guarda el mensaje de error en el archivo de errores
                        File.WriteAllText(errorFilePath, "Error de sintaxis: " + ex.Message);
                    }
                    catch (Exception ex)
                    {
                        // Imprime el mensaje de error inesperado
                        MessageBox.Show("Error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        errorEncontrado = true;

                        // Genera el nombre del archivo de error
                        string errorFileName = $"Errores{++errorCounter}.err";
                        string errorFilePath = Path.Combine(appDirectory, errorFileName); // Ruta completa del archivo de errores

                        // Guarda el mensaje de error en el archivo de errores
                        File.WriteAllText(errorFilePath, "Error inesperado: " + ex.Message);
                    }

                    if (!errorEncontrado)
                    {
                        MessageBox.Show("ANÁLISIS EXITOSO");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al leer el archivo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }

    public class CustomErrorListener : BaseErrorListener
    {
        public List<string> SyntaxErrors { get; } = new List<string>();

        public override void SyntaxError(IRecognizer recognizer, IToken offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
        {
            SyntaxErrors.Add($"Línea {line}:{charPositionInLine} {msg}");
        }
    }
}

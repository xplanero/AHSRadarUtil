using Microsoft.VisualBasic.Logging;
using System;
using System.Diagnostics;
using System.Net;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;
using System.Windows.Forms.VisualStyles;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AHSRadarUtil
{
    public partial class IntFile : Form
    {
        public IntFile()
        {
            InitializeComponent();
            tBoxArchivoRadar.TextChanged += new EventHandler(tBoxArchivoRadar_Change);
            btnAnalizar.Enabled = false;
            tBoxArchivoRadar.ReadOnly = true;
        }

        private void tBoxArchivoRadar_Change(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tBoxArchivoRadar.Text))
            {
                btnAnalizar.Enabled = true;
            }
            else
            {
                btnAnalizar.Enabled = false;
            }
        }

        private void btnSelecFichRadar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                tBoxArchivoRadar.Text = openFileDialog.FileName;

            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAnalizar_Click(object sender, EventArgs e)
        {
            //Creamos un diccionario para asegurarnos que no tengamos repetidos
            //en fijos, vor y ndb.
            //Servira para comprobar que cuando se usen como referencias existan.
            Dictionary<string, string> diccionario = new Dictionary<string, string>();
            string[] lines = File.ReadAllLines(tBoxArchivoRadar.Text);
            diccionario = ProcesarFixesVorNdb(lines);
            using (StreamWriter file = new StreamWriter("diccionario.txt"))
            {
                foreach (var kvp in diccionario)
                {
                    file.WriteLine($"{kvp.Key}={kvp.Value}");
                }
            }

            int lineCount = lines.Length;
            //string bloque = "";

            var errors = ValidateFile(lines, diccionario);


            string filePath = "output.txt";

            // Escribir todas las líneas en el archivo
            File.WriteAllLines(filePath, errors);

            //****************************************
            // Abrir archivo de errores en Notepad++
            string executionPath = AppDomain.CurrentDomain.BaseDirectory;
            string pathFileError = executionPath + @"\output.txt"; // Ruta completa del archivo de texto
            string notepadPlusPlusPath = @"C:\Program Files\Notepad++\notepad++.exe"; // Ruta completa del ejecutable de Notepad++

            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = notepadPlusPlusPath;
                startInfo.Arguments = pathFileError;
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un error al intentar abrir el archivo en Notepad++: " + ex.Message);
            }

            MessageBox.Show($"Se han procesado {lineCount} líneas.");
            

        }
        
        static List<string> ValidateFile(string[] lines, Dictionary<string, string> diccionario)
        {
            var errors = new List<string>();
            string bloque = "";
            int lineCount = lines.Length;
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                if (line.StartsWith("["))
                {
                    bloque = line;
                    //MessageBox.Show($"Encontrado {line}");

                }
                else
                {
                    if (!line.StartsWith(";") & !string.IsNullOrWhiteSpace(line))
                    {

                        switch (bloque)
                        {
                            case "[INFO]":
                                ProcesarInfo(line, errors, i);
                                break;
                            case "[AIRPORT]":
                                ProcesarAirport(line, errors, i);
                                break;
                            // Añadir más casos para otras secciones según sea necesario
                            case "[RUNWAY]":
                                ProcesarRunway(line, errors, i);
                                break;
                            case "[VOR]":
                                ProcesarVor(line, errors, i);
                                break;
                            case "[NDB]":
                                ProcesarNdb(line, errors, i);
                                break;
                            case "[PARKING]":
                                ProcesarParking(line, errors, i);
                                break;
                            case "[FIXES]":
                                ProcesarFixes(line, errors, i);
                                break;
                            case "[VFR]":
                                ProcesarVfr(line, errors, i);
                                break;
                            case "[HOLD]":
                                ProcesarHold(line, errors, i, diccionario);
                                break;
                            case "[IAC]":
                                ProcesarHold(line, errors, i, diccionario);
                                break;
                            case "[ILS]":
                                ProcesarHold(line, errors, i, diccionario);
                                break;
                            // ... Añadir más secciones aquí
                            case "[GEO]":
                                ProcesarGeo(line, errors, i);
                                break;
                            default:
                                //Console.WriteLine($"Línea no reconocida en {bloque}: {line}");
                                break;
                        }
                    }
                }

            }

            return errors;
        }
        static List<string> ProcesarInfo(string linea, List<string> errors, int i)
        {
            // Lógica específica para la sección [INFO]
            return errors;
        }

        static List<string> ProcesarAirport(string linea, List<string> errors, int i)
        {
            //Lógica específica para la sección [AIRPORT]
            //Mediante este bloque definiremos los aeropuertos que se encuentran en nuestro Sector.
            //Cada definición constará de 42 caracteres, dividida en 4 campos separados cada uno de ellos por un espacio.
            //El bloque comenzará por la etiqueta[AIRPORT]
            //Nombre aeropuerto: 4 caracteres = código ICAO.
            //Frecuencia de torre: 7 caracteres, 3 dígitos, Punto decimal y 2 decimales.
            //Latitud: 14 caracteres.Longitud: 14 caracteres.
            //Si la frecuencia es desconocida pondremos 3 espacios, punto decimal y dos espacios.

            if (linea.Length < 44)
            {
                errors.Add($"Línea {i + 1}: {linea} Longitud insuficiente.");

            }
            else
            {
                if (!Regex.IsMatch(linea.Substring(0, 44), @"^[A-Z0-9]{4} [0-9 ]{3}.[0-9 ]{3} [NS]\d{3}\.\d{2}\.\d{2}\.\d{3} [WE]\d{3}\.\d{2}\.\d{2}\.\d{3} [A-Z]$"))
                {
                    errors.Add($"Línea {i + 1}: {linea} Formato inválido.");
                }
            }
            return errors;
        }


        static List<string> ProcesarRunway(string linea, List<string> errors, int i)
        {
            // Lógica específica para la sección [RUNWAY]


            if (!Regex.IsMatch(linea.Substring(0, 75), @"^\d{2}[RLC ] \d{2}[RLC ] \d{3} \d{3} [NS]\d{3}\.\d{2}\.\d{2}\.\d{3} [WE]\d{3}\.\d{2}\.\d{2}\.\d{3} [NS]\d{3}\.\d{2}\.\d{2}\.\d{3} [WE]\d{3}\.\d{2}\.\d{2}\.\d{3}$"))
            {
                errors.Add($"Línea {i + 1}: {linea} Formato inválido.");
            }
            return errors;

        }

        static List<string> ProcesarVor(string linea, List<string> errors, int i)
        {
            // Lógica específica para la sección [VOR]
            if (!Regex.IsMatch(linea.Substring(0, 41), @"^[A-Z ]{3} \d{3}\.\d{3} [NS]\d{3}\.\d{2}\.\d{2}\.\d{3} [WE]\d{3}\.\d{2}\.\d{2}\.\d{3}$"))
            {
                errors.Add($"Línea {i + 1}: {linea} Formato inválido.");
            }
            return errors;

        }

        static List<string> ProcesarNdb(string linea, List<string> errors, int i)
        {
            // Lógica específica para la sección [NDB]
            if (!Regex.IsMatch(linea.Substring(0, 43), @"^[A-Z0-9 ]{5} \d{3}\.\d{3} [NS]\d{3}\.\d{2}\.\d{2}\.\d{3} [WE]\d{3}\.\d{2}\.\d{2}\.\d{3}$"))
            {
                errors.Add($"Línea {i + 1}: {linea} Formato inválido.");
            }
            return errors;

        }

        static List<string> ProcesarParking(string linea, List<string> errors, int i)
        {
            // Lógica específica para la sección [PARKING]
            if (!Regex.IsMatch(linea.Substring(0, 42), @"^[A-Z0-9-./ ]{12} [NS]\d{3}\.\d{2}\.\d{2}\.\d{3} [WE]\d{3}\.\d{2}\.\d{2}\.\d{3}$"))
            {
                errors.Add($"Línea {i + 1}: {linea} Formato inválido.");
            }
            return errors;
        }
        static List<string> ProcesarFixes(string linea, List<string> errors, int i)
        {
            // Lógica específica para la sección [FIXES]
            if ((linea.Length < 35))
            {
                errors.Add($"Línea {i + 1}: {linea} Longitud menor de 35 caracteres");
                return errors;
            }
            if (!Regex.IsMatch(linea.Substring(0, 35), @"^[A-Z0-9-. ]{5} [NS]\d{3}\.\d{2}\.\d{2}\.\d{3} [WE]\d{3}\.\d{2}\.\d{2}\.\d{3}$"))
            {
                errors.Add($"Línea {i + 1}: {linea} Formato inválido.");
            }
            return errors;
        }
        static List<string> ProcesarVfr(string linea, List<string> errors, int i)
        {
            // Lógica específica para la sección [VFR]
            if ((linea.Length < 35))
            {
                errors.Add($"Línea {i + 1}: {linea} Longitud menor de 35 caracteres");
                return errors;
            }
            if (!Regex.IsMatch(linea.Substring(0, 35), @"^[A-Z0-9-. ]{5} [NS]\d{3}\.\d{2}\.\d{2}\.\d{3} [WE]\d{3}\.\d{2}\.\d{2}\.\d{3}$"))
            {
                errors.Add($"Línea {i + 1}: {linea} Formato inválido.");
            }
            return errors;
        }
        static List<string> ProcesarHold(string linea, List<string> errors, int i, Dictionary<string, string> diccionario)
        {
            // Lógica específica para la sección [HOLD]
            //bool error = false;
            int largo = linea.Length;
            //MessageBox.Show($"Longitud de linea {largo} ");
            if (largo >= 85)
            {
                //MessageBox.Show("Se esta procesando " + linea);

                string latitud1 = linea.Substring(25, 15).Trim();
                string longitud1 = linea.Substring(40, 15).Trim();
                string latitud2 = linea.Substring(55, 15).Trim();
                string longitud2 = linea.Substring(70, 15).Trim();
                //MessageBox.Show($"Longitud de linea {latitud1.Length} {longitud1.Length} {latitud1} ");
                if (latitud1.Length == 14 && longitud1.Length == 14)
                {
                    //MessageBox.Show("Se esta procesando " + linea);
                    if (!verificaCoordenada(latitud1, longitud1))
                    {
                        errors.Add($"Línea {i + 1}: {linea} Formato inválido.");
                    }
                }
                else
                {
                    //Si no son coordenadas tendrian que ser un fijo.
                    //Comprobar que el fijo existe
                    //comprobar si latitud1 esta en el diccionario
                    if (!diccionario.ContainsKey(latitud1))
                    {
                        errors.Add($"Línea {i + 1}: {linea} Referencia no encontrada.");
                    }
                    
                    
                    
                }
                if (latitud2.Length == 14 && longitud2.Length == 14)
                {
                    if (!verificaCoordenada(latitud2, longitud2))
                    {
                        errors.Add($"Línea {i + 1}: {linea} Formato inválido.");
                    }
                }
                else
                {
                    //Si no son coordenadas tendrian que ser un fijo.
                    //Comprobar que el fijo existe
                    if (!diccionario.ContainsKey(latitud2))
                    {
                        errors.Add($"Línea {i + 1}: {linea} Referencia no encontrada.");
                    }
                }


            }
            return errors;
            

        }
        static List<string> ProcesarGeo(string linea, List<string> errors, int i)
        {
            // Lógica específica para la sección [GEO]
            return errors;

        }

        static Dictionary<string, string> ProcesarFixesVorNdb(string[] radar)
        {

            string bloque = "";
            Dictionary<string, string> fixes = new Dictionary<string, string>();
            foreach (string linea in radar)
            {
                int longitudLinea = Math.Min(linea.Trim().Length-6, 29);
                
                if (linea.StartsWith("["))
                {
                    bloque = linea.Trim();

                }
                else
                {
                    if (!linea.StartsWith(";") & !string.IsNullOrWhiteSpace(linea))
                    {

                        if (bloque == "[FIXES]")
                        {
                            //Console.WriteLine(linea.Substring(0, 5));
                            //MessageBox.Show($"{linea.Substring(6, longitudLinea)} , { longitudLinea}");
                            if (!fixes.ContainsKey(linea.Substring(0, 5)))
                            {
                                fixes.Add(linea.Substring(0, 5), linea.Substring(6, longitudLinea));
                            }
                            else
                            {
                                MessageBox.Show("El fijo " + linea.Substring(0, 5) + " está repetido");
                            }

                        }
                        //***********************************************
                        if (bloque == "[VOR]")
                        {
                            //Console.WriteLine(linea.Substring(0, 3));
                            //Console.WriteLine(linea.Substring(12, 29));
                            if (!fixes.ContainsKey(linea.Substring(0, 3).Trim()))
                            {
                                fixes.Add(linea.Substring(0, 3).Trim(), linea.Substring(12, longitudLinea));
                            }
                            else
                            {
                                MessageBox.Show("El VOR " + linea.Substring(0, 3).Trim() + " está repetido");
                            }

                        }
                        //***********************************************
                        if (bloque == "[NDB]")
                        {
                            //Console.WriteLine(linea.Substring(0, 5));
                            //Console.WriteLine(linea.Substring(14, 29));
                            if (!fixes.ContainsKey(linea.Substring(0, 5).Trim()))
                            {
                                fixes.Add(linea.Substring(0, 5).Trim(), linea.Substring(14, longitudLinea));
                            }
                            else
                            {
                                MessageBox.Show("El NDB " + linea.Substring(0, 5).Trim() + " está repetido");
                            }

                        }
                    }
                }

            }
            //MessageBox.Show("Se ha procesado el archivo de radar.");
            return fixes;
        }

        static bool verificaCoordenada(string latitud, string longitud)
        {
            return Regex.IsMatch(latitud, @"^[NS]\d{3}\.\d{2}\.\d{2}\.\d{3}$") && Regex.IsMatch(longitud, @"^[EW]\d{3}\.\d{2}\.\d{2}\.\d{3}$");
        }
    }

}


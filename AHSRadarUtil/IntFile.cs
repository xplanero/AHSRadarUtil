using System.Text.RegularExpressions;

namespace AHSRadarUtil
{
    public partial class IntFile : Form
    {
        public IntFile()
        {
            InitializeComponent();
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
            //try
            //{
            // 2. Leer el archivo de texto
            string[] lines = File.ReadAllLines(tBoxArchivoRadar.Text);
            int lineCount = lines.Length;
            string bloque = "";
            var errors = ValidateFile(lines);

            // 3. Contar las líneas en el archivo



            // 4. Mostrar el número de líneas en la consola
            //foreach (var item in errors)
            //{
            //    MessageBox.Show($"Error en {item}");
            //}
            // Ruta del archivo donde se guardarán las líneas
            string filePath = "output.txt";

            // Escribir todas las líneas en el archivo
            File.WriteAllLines(filePath, errors);

            // Confirmación
            MessageBox.Show("Las líneas han sido guardadas en el archivo: " + filePath);
            MessageBox.Show($"Se han procesado {lineCount} líneas.");
            //}
            //catch (Exception ex)
            //{
            //    // Manejar posibles errores
            //    MessageBox.Show($"Se ha producido un error: {ex.Message}");
            //}

        }
        static List<string> ValidateFile(string[] lines)
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
                            case "[IAC]":
                                ProcesarHold(line, errors, i);
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
            // Lógica específica para la sección [AIRPORT]
            if (linea.Length < 44)
            {
                errors.Add($"Línea {i + 1}: {linea} Longitud insuficiente.");

            }

            // Validar formato de la línea
            //if (!Regex.IsMatch(line.Substring(0, 44), @"^[A-Z0-9]{4} \d{3}\.\d{3} [NS]\d{2}\.\d{2}\.\d{2}\.\d{3} [WE]\d{3}\.\d{2}\.\d{2}\.\d{3} [A-Z]$"))
            //MessageBox.Show(linea);

            if (!Regex.IsMatch(linea.Substring(0, 44), @"^[A-Z0-9]{4} [0-9 ]{3}.[0-9 ]{3} [NS]\d{3}\.\d{2}\.\d{2}\.\d{3} [WE]\d{3}\.\d{2}\.\d{2}\.\d{3} [A-Z]$"))
            {
                errors.Add($"Línea {i + 1}: {linea} Formato inválido.");
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
        static List<string> ProcesarHold(string linea, List<string> errors, int i)
        {
            // Lógica específica para la sección [HOLD]
            if ((linea.Length < 85))
            {
                errors.Add($"Línea {i + 1}: {linea} Longitud menor de 85 caracteres");
                return errors;
            }


            if (!Regex.IsMatch(linea.Substring(0, 85), @"^[A-Z0-9-./ ]{25} [NS]\d{3}\.\d{2}\.\d{2}\.\d{3} [WE]\d{3}\.\d{2}\.\d{2}\.\d{3} [NS]\d{3}\.\d{2}\.\d{2}\.\d{3} [WE]\d{3}\.\d{2}\.\d{2}\.\d{3}$"))
            {
                errors.Add($"Línea {i + 1}: {linea} Formato inválido.");
            }
            return errors;

        }
        static List<string> ProcesarGeo(string linea, List<string> errors, int i)
        {
            // Lógica específica para la sección [GEO]
            return errors;

        }

    }

}


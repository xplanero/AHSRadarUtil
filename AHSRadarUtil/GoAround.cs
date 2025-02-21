namespace AHSRadarUtil
{
    public partial class GoAround : Form
    {

        private string rutaArchivoOrigen;
        private string rutaArchivoDestino;
        private const string configFilePath = "GoAroundConfig.txt";
        public GoAround()
        {
            InitializeComponent();
            CargarConfiguracion();
        }

        private void btnOrigen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                rutaArchivoOrigen = openFileDialog.FileName; // Asignar la ruta a la variable
                tBoxOrigen.Text = rutaArchivoOrigen;
                GuardarConfiguracion(); // Guardar después de actualizar la variable
            }
        }

        private void btnDestino_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                rutaArchivoDestino = openFileDialog.FileName; // Asignar la ruta a la variable
                tBoxDestino.Text = rutaArchivoDestino;
                GuardarConfiguracion(); // Guardar después de actualizar la variable
            }
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            // File paths
            string inputFilePath = tBoxOrigen.Text;
            string outputFilePath = tBoxDestino.Text;

            try
            {
                // Usar StreamReader para leer el archivo línea por línea
                using (StreamReader reader = new StreamReader(inputFilePath))
                using (StreamWriter writer = new StreamWriter(outputFilePath))
                {
                    string previousCoords = null;
                    string currentICAO = "";
                    string runway = "";
                    string approachName = "";
                    string line;
                    string espacios26 = new string(' ', 26);

                    while ((line = reader.ReadLine()) != null)
                    {
                        // Ignorar comentarios (líneas que empiezan con "//") o líneas en blanco
                        if (line.StartsWith("//") || string.IsNullOrWhiteSpace(line))
                        {
                            continue;
                        }

                        var parts = line.Split(';');

                        // Si el tercer campo empieza con "GA", es un bloque que debemos procesar
                        if (parts.Length >= 3 && parts[2].TrimStart().StartsWith("GA"))
                        {
                            currentICAO = parts[0];  // ICAO del aeropuerto
                            runway = parts[1];        // Pista
                            approachName = parts[2];  // Nombre de la aproximación
                            previousCoords = null;

                            // Vamos a leer las líneas válidas dentro de un bucle hasta encontrar dos coordenadas
                            int validLinesCount = 0;  // Contador para asegurarnos de procesar dos líneas válidas con coordenadas
                            while (validLinesCount < 2)
                            {
                                line = reader.ReadLine();

                                // Ignorar comentarios o líneas en blanco
                                if (line == null || line.StartsWith("//") || string.IsNullOrWhiteSpace(line))
                                {
                                    continue;
                                }

                                parts = line.Split(';');
                                if (validLinesCount == 0)
                                {
                                    // Primera línea válida con coordenadas
                                    if (parts[0].Length < 14)
                                    {
                                        previousCoords = parts[0];
                                    }
                                    else
                                    {
                                        previousCoords = $"{parts[0]} {parts[1]}";
                                    }
                                    validLinesCount++;
                                }
                                else if (validLinesCount == 1)
                                {
                                    // Segunda línea válida con coordenadas
                                    string coords = parts[0];
                                    if (coords.Length > 13)
                                    {
                                        coords = $"{parts[0]} {parts[1]}";
                                    }

                                    // Primera línea de salida
                                    string formattedLine = $"{currentICAO}-{runway} {approachName}".PadRight(26) +
                                                           $"{previousCoords} ".PadRight(30) + $"{coords}";
                                    writer.WriteLine(formattedLine);

                                    previousCoords = coords;
                                    validLinesCount++;
                                }
                            }

                            // Después de haber procesado las dos primeras coordenadas, continuar procesando el resto
                            while ((line = reader.ReadLine()) != null)
                            {
                                // Si encontramos una línea vacía, terminamos el bloque "GA"
                                if (string.IsNullOrWhiteSpace(line))
                                {
                                    writer.WriteLine(";");
                                    break; // Termina el bloque GA
                                }

                                // Ignorar comentarios
                                if (line.StartsWith("//")) continue;

                                parts = line.Split(';');
                                if (parts.Length > 0)
                                {
                                    string coords = parts[0];
                                    if (coords.Length > 13)
                                    {
                                        coords = $"{parts[0]} {parts[1]}";
                                    }

                                    string formattedLine = $"{espacios26}" + $"{previousCoords}".PadRight(30) + $"{coords}";
                                    writer.WriteLine(formattedLine);
                                    previousCoords = coords;
                                }
                            }
                        }
                    }
                }

                MessageBox.Show("Archivo procesado exitosamente!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar el archivo: {ex.Message}");
            }
        }



        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void GuardarConfiguracion()
        {
            try
            {
                using (var writer = new StreamWriter(configFilePath))
                {
                    writer.WriteLine(rutaArchivoOrigen ?? ""); // Evitar null
                    writer.WriteLine(rutaArchivoDestino ?? ""); // Evitar null
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar configuración: {ex.Message}");
            }
        }
        private void CargarConfiguracion()
        {
            if (File.Exists(configFilePath))
            {
                var lineas = File.ReadAllLines(configFilePath);
                if (lineas.Length >= 2)
                {
                    rutaArchivoOrigen = lineas[0];
                    rutaArchivoDestino = lineas[1];

                    if (!string.IsNullOrWhiteSpace(rutaArchivoOrigen))
                        tBoxOrigen.Text = rutaArchivoOrigen;

                    if (!string.IsNullOrWhiteSpace(rutaArchivoDestino))
                        tBoxDestino.Text = rutaArchivoDestino;
                }
            }
        }
    }
}

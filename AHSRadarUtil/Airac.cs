using System.Data;
namespace AHSRadarUtil
{
    public partial class Airac : Form
    {
        public Airac()
        {
            InitializeComponent();
        }

        private void btnBuscarFix_Click(object sender, EventArgs e)
        {
            //Obtener ruta del archivo
            string rutaArchivo = ObtenerRutaArchivo();
            if (rutaArchivo != null)
            {
                tBoxFijos.Text = rutaArchivo;
            }

        }
        private void btnVorNdb_Click(object sender, EventArgs e)
        {
            //Obtener ruta del archivo
            string rutaArchivo = ObtenerRutaArchivo();
            if (rutaArchivo != null)
            {
                tBoxRadioAyudas.Text = rutaArchivo;
            }

        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            List<Punto> puntos = new List<Punto>();

            puntos.AddRange(CargarCSV(tBoxFijos.Text, 3, 10, 11));
            puntos.AddRange(CargarCSV(tBoxRadioAyudas.Text, 1, 3, 4));

            puntos = puntos.OrderBy(p => p.Identificador).ToList();

            MostrarDatosEnGrid(puntos);
            GuardarCSV(puntos, "puntosSignificativos.csv");
        }
        //private void CargarCSV(string filePath, int columnaFijo, int columnaLatitud, int columnaLongitud)
        //{
        //    try
        //    {
        //        var lines = File.ReadAllLines(filePath);
        //        if (lines.Length == 0)
        //        {
        //            MessageBox.Show("El archivo está vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return;
        //        }

        //        var dt = new DataTable();
        //        dt.Columns.Add("Identificador");
        //        dt.Columns.Add("Latitud");
        //        dt.Columns.Add("Longitud");

        //        foreach (var line in lines.Skip(1)) // Omitir encabezado
        //        {
        //            var columns = line.Split(';'); // Separador CSV

        //            if (columns.Length >= 5) // Verificar que existan columnas suficientes
        //            {
        //                Coordenadas coordenadas = new Coordenadas(columns[columnaLatitud], columns[columnaLongitud]);
        //                dt.Rows.Add(columns[columnaFijo], coordenadas.Latitud, coordenadas.Longitud);
        //            }
        //        }

        //        dataGridView1.DataSource = dt; // Mostrar en DataGridView
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error al leer el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
        private List<Punto> CargarCSV(string filePath, int columnaFijo, int columnaLatitud, int columnaLongitud)
        {
            List<Punto> puntos = new List<Punto>();

            try
            {
                var lines = File.ReadAllLines(filePath);
                if (lines.Length == 0)
                {
                    MessageBox.Show("El archivo está vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return puntos;
                }

                foreach (var line in lines.Skip(1)) // Omitir encabezado
                {
                    var columns = line.Split(';');

                    if (columns.Length > Math.Max(columnaFijo, Math.Max(columnaLatitud, columnaLongitud)))
                    {
                                                
                        puntos.Add(new Punto(columns[columnaFijo], columns[columnaLatitud], columns[columnaLongitud]));

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return puntos;
        }


        private string ObtenerRutaArchivo()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.csv)|*.csv";
            openFileDialog.Title = "Seleccione el archivo de puntos";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return openFileDialog.FileName;
            }
            return null;
        }
        private void MostrarDatosEnGrid(List<Punto> puntos)
        {
            var dt = new DataTable();
            dt.Columns.Add("Identificador");
            dt.Columns.Add("Latitud");
            dt.Columns.Add("Longitud");

            foreach (var punto in puntos)
            {
                dt.Rows.Add(punto.Identificador, punto.Latitud, punto.Longitud);
            }

            dataGridView1.DataSource = dt;
        }

        private void GuardarCSV(List<Punto> puntos, string filePath)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("Identificador;Latitud;Longitud;Coordenada GMS");
                    foreach (var punto in puntos)
                    {
                        writer.WriteLine($"{punto.Identificador};{punto.Latitud};{punto.Longitud};{punto.ObtenerCoordenadasDMS()}");
                    }
                }
                MessageBox.Show("Archivo guardado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el archivo: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



    }
}

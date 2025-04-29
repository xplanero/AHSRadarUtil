using System.Data;
using System.Data.SQLite;
using System.Text;

namespace AHSRadarUtil
{
    public partial class SQlite : Form
    {
        //Conexion con la base de datos
        private string connectionString = "Data Source=little_navmap_msfs.sqlite;Version=3;";

        public SQlite()
        {
            //Ajustar tamaño del formulario al tamaño de la pantalla
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            //CargarDatos();
            //CargarTablas();
            //MostrarEstructuraEnGrid();
            //MostrarEstructuraBD();
        }

        private void MostrarEstructuraBD()
        {
            treeView1.Nodes.Clear();
            TreeNode rootNode = new TreeNode("Base de Datos");
            treeView1.Nodes.Add(rootNode);

            using (SQLiteConnection conexion = new SQLiteConnection(connectionString))
            {
                try
                {
                    conexion.Open();

                    // Obtener lista de tablas
                    string queryTablas = "SELECT name FROM sqlite_master WHERE type='table' ORDER BY name;";
                    using (SQLiteCommand cmd = new SQLiteCommand(queryTablas, conexion))
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string nombreTabla = reader["name"].ToString();
                            TreeNode tablaNode = new TreeNode($"📂 {nombreTabla}");
                            rootNode.Nodes.Add(tablaNode);

                            // Obtener columnas de la tabla
                            string queryColumnas = $"PRAGMA table_info({nombreTabla});";
                            using (SQLiteCommand cmdColumnas = new SQLiteCommand(queryColumnas, conexion))
                            using (SQLiteDataReader readerColumnas = cmdColumnas.ExecuteReader())
                            {
                                while (readerColumnas.Read())
                                {
                                    string nombreColumna = readerColumnas["name"].ToString();
                                    string tipoColumna = readerColumnas["type"].ToString();
                                    bool esPrimaria = readerColumnas["pk"].ToString() == "1";
                                    string columnaTexto = esPrimaria ? $"🔑 {nombreColumna} ({tipoColumna})" : $"{nombreColumna} ({tipoColumna})";
                                    tablaNode.Nodes.Add(new TreeNode(columnaTexto));
                                }
                            }

                            // Obtener relaciones (claves foráneas)
                            string queryRelaciones = $"PRAGMA foreign_key_list({nombreTabla});";
                            using (SQLiteCommand cmdRelaciones = new SQLiteCommand(queryRelaciones, conexion))
                            using (SQLiteDataReader readerRelaciones = cmdRelaciones.ExecuteReader())
                            {
                                while (readerRelaciones.Read())
                                {
                                    string tablaReferencia = readerRelaciones["table"].ToString();
                                    string columnaOrigen = readerRelaciones["from"].ToString();
                                    string columnaDestino = readerRelaciones["to"].ToString();
                                    string relacionTexto = $"🔗 FK: {columnaOrigen} → {tablaReferencia}({columnaDestino})";
                                    tablaNode.Nodes.Add(new TreeNode(relacionTexto));
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al escanear la base de datos: " + ex.Message);
                }
            }

            treeView1.ExpandAll();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text.StartsWith("📂 "))
            {
                string nombreTabla = e.Node.Text.Replace("📂 ", "");
                MostrarDatosTabla(nombreTabla);
            }
        }

        private void MostrarDatosTabla(string nombreTabla)
        {
            using (SQLiteConnection conexion = new SQLiteConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    string query = $"SELECT * FROM {nombreTabla} LIMIT 100"; // Muestra solo los primeros 100 registros

                    SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, conexion);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos de la tabla: " + ex.Message);
                }
            }
        }


        

        private void btnBuscarTaxi_Click(object sender, EventArgs e)
        {

            BuscarYMostrarCoordenadas(tBoxAeropuerto.Text);
        }
        private int ObtenerAirportID(string ident)
        {
            using (SQLiteConnection conexion = new SQLiteConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT airport_id FROM airport WHERE ident = @ident";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@ident", ident.Trim());
                        object result = cmd.ExecuteScalar();

                        if (result != null && int.TryParse(result.ToString(), out int airportID))
                        {
                            return airportID;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al consultar la base de datos: " + ex.Message);
                }
            }
            return -1; // Devuelve -1 si no se encontró el aeropuerto
        }

        private List<(Coordenadas, Coordenadas)> ObtenerCoordenadasTaxiPath(int airportID)
        {
            List<(Coordenadas, Coordenadas)> coordenadas = new List<(Coordenadas, Coordenadas)>();

            using (SQLiteConnection conexion = new SQLiteConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    string query = "SELECT start_laty, start_lonx, end_laty, end_lonx FROM taxi_path WHERE airport_id = @airportID";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@airportID", airportID);
                        using (SQLiteDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                double startLaty = reader.GetDouble(0);
                                double startLonx = reader.GetDouble(1);
                                double endLaty = reader.GetDouble(2);
                                double endLonx = reader.GetDouble(3);
                                Coordenadas startCoordenadas = new Coordenadas(startLaty, startLonx);
                                Coordenadas endCoordenadas = new Coordenadas(endLaty, endLonx);


                                coordenadas.Add((startCoordenadas, endCoordenadas));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener coordenadas: " + ex.Message);
                }
            }
            return coordenadas;
        }

        private void BuscarYMostrarCoordenadas(string ident)
        {
            int airportID = ObtenerAirportID(ident);
            if (airportID == -1)
            {
                MessageBox.Show("No se encontró el aeropuerto.");
                return;
            }

            List<(Coordenadas, Coordenadas)> coordenadas = ObtenerCoordenadasTaxiPath(airportID);

            if (coordenadas.Count == 0)
            {
                MessageBox.Show("No se encontraron coordenadas para este aeropuerto.");
            }
            else
            {

                //Pegar en el portapapeles
                StringBuilder sb = new StringBuilder();

                foreach (var coord in coordenadas)
                {
                    sb.AppendLine($"{coord.Item1.ObtenerCoordenadasDMS()} {coord.Item2.ObtenerCoordenadasDMS()}");
                }

                Clipboard.SetText(sb.ToString());
                MessageBox.Show("Coordenadas copiadas al portapapeles.");
                //Abrir el formulario de dibujo
                DibujarSegmentos formDibujar = new DibujarSegmentos();
                formDibujar.ShowDialog();



            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Archivos SQLite (*.sqlite;*.db)|*.sqlite;*.db",
                Title = "Selecciona una base de datos SQLite"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                connectionString = $"Data Source={openFileDialog.FileName};Version=3;";
                MostrarEstructuraBD();
            }
        }
    }
}

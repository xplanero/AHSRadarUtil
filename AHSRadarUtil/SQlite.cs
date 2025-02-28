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
            MostrarEstructuraEnGrid();
            MostrarEstructuraBD();
        }
        

        private void MostrarEstructuraEnGrid()
        {
            using (SQLiteConnection conexion = new SQLiteConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    string query = @"
                SELECT m.name AS 'Tabla', p.name AS 'Columna', p.type AS 'Tipo', p.pk AS 'Clave Primaria'
                FROM sqlite_master m
                JOIN pragma_table_info(m.name) p
                WHERE m.type = 'table'
                ORDER BY m.name, p.cid;";

                    SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, conexion);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);

                    dataGridView1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void MostrarEstructuraBD()
        {
            using (SQLiteConnection conexion = new SQLiteConnection(connectionString))
            {
                try
                {
                    conexion.Open();
                    treeView1.Nodes.Clear();
                    TreeNode rootNode = new TreeNode("Base de Datos");
                    treeView1.Nodes.Add(rootNode);

                    // Obtener todas las tablas
                    string queryTablas = "SELECT name FROM sqlite_master WHERE type='table' ORDER BY name;";
                    using (SQLiteCommand cmd = new SQLiteCommand(queryTablas, conexion))
                    using (SQLiteDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string nombreTabla = reader["name"].ToString();
                            TreeNode tablaNode = new TreeNode(nombreTabla);
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
                                    tablaNode.Nodes.Add(new TreeNode($"{nombreColumna} ({tipoColumna})"));
                                }
                            }

                            // Obtener índices de la tabla
                            string queryIndices = $"PRAGMA index_list({nombreTabla});";
                            using (SQLiteCommand cmdIndices = new SQLiteCommand(queryIndices, conexion))
                            using (SQLiteDataReader readerIndices = cmdIndices.ExecuteReader())
                            {
                                while (readerIndices.Read())
                                {
                                    string nombreIndice = readerIndices["name"].ToString();
                                    TreeNode indiceNode = new TreeNode($"Índice: {nombreIndice}");
                                    tablaNode.Nodes.Add(indiceNode);
                                }
                            }
                        }
                    }

                    treeView1.ExpandAll(); // Expande todo el árbol al cargar
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
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


    }
}

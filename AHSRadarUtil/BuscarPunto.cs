namespace AHSRadarUtil
{
    public partial class BuscarPunto : Form
    {
        private Dictionary<string, string> puntosDict = new Dictionary<string, string>();

        public string CoordenadasSeleccionadas { get; private set; }
        public BuscarPunto()
        {
            InitializeComponent();
            CargarPuntos();
            //puntosDict = puntos;
            listBoxResultados.DoubleClick += listBoxResultados_DoubleClick;
            tBoxBusqueda.TextChanged += tBoxBusqueda_TextChanged;
        }

        private void tBoxBusqueda_TextChanged(object sender, EventArgs e)
        {
            listBoxResultados.Items.Clear();
            //MessageBox.Show(tBoxBusqueda.Text);
            string textoBusqueda = tBoxBusqueda.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(textoBusqueda)) return;

            foreach (var item in puntosDict)
            {
                if (item.Key.ToLower().Contains(textoBusqueda))
                {
                    string espacios = new string(' ', Math.Max(0, 12 - item.Key.Length));
                    listBoxResultados.Items.Add(item.Key + espacios + item.Value);
                }
            }
        }



        private void listBoxResultados_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxResultados.SelectedItem != null)
            {
                string seleccion = listBoxResultados.SelectedItem.ToString();
                //seleccionamos los 29 ultimos caracteres que son las coordenadas
                CoordenadasSeleccionadas = seleccion.Substring(seleccion.Length - 29).Trim();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        public void CargarPuntos()
        {
            try
            {
                string[] lineas = File.ReadAllLines("puntosSignificativos.csv").Skip(1).ToArray();
                foreach (string linea in lineas)
                {
                    string[] columnas = linea.Split(';');
                    if (columnas.Length > 3)
                    {
                        string punto = columnas[0].Trim();
                        string coordenadas = columnas[3].Trim();
                        puntosDict[punto] = coordenadas;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los puntos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

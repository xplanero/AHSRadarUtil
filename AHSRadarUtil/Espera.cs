namespace AHSRadarUtil
{
    public partial class Espera : Form
    {
        private Dictionary<string, string> puntosDict = new Dictionary<string, string>();
        public Espera()
        {
            InitializeComponent();
            comboBoxSentido.Items.AddRange(new string[] { "Right", "Left" });
            comboBoxSentido.SelectedIndex = 0; // Por defecto seleccionamos "Right"
            //CargarPuntos();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            Coordenadas fijo = new Coordenadas(tBoxFijo.Text);
            bool sentidoHorario = comboBoxSentido.SelectedIndex == 0;
            double ancho = Convert.ToDouble(tBoxAncho.Text);
            double largo = Convert.ToDouble(tBoxLargo.Text);
            double rumboInbound = Convert.ToDouble(tBoxRumboInbound.Text);
            fijo.Espera(rumboInbound, ancho, largo, sentidoHorario);
            MessageBox.Show("Espera generada correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            BuscarPunto formBuscar = new BuscarPunto();
            if (formBuscar.ShowDialog() == DialogResult.OK)
            {
                tBoxFijo.Text = formBuscar.CoordenadasSeleccionadas;
            }
        }
        private void CargarPuntos()
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

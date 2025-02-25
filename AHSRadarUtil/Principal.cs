namespace AHSRadarUtil
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            Circulo circulo = new Circulo();
            circulo.ShowDialog(); //Bloquea el formulario principal
            //circulo.Show();     //No bloquea el formulario principal
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEncontrar_Click(object sender, EventArgs e)
        {
            Encontrar encontrar = new Encontrar();
            encontrar.ShowDialog();
        }

        private void btnFileInt_Click(object sender, EventArgs e)
        {
            IntFile intFile = new IntFile();
            intFile.ShowDialog();
        }

        private void btnArco_Click(object sender, EventArgs e)
        {
            Arco arco = new Arco();
            arco.ShowDialog();
        }

        private void btnAreas_Click(object sender, EventArgs e)
        {
            Areas areas = new Areas();
            areas.ShowDialog();
        }

        private void btnDeIvao_Click(object sender, EventArgs e)
        {
            Ivao ivao = new Ivao();
            ivao.ShowDialog();
        }


        private void btnCopiarArchivos_Click(object sender, EventArgs e)
        {
            CopiarArchivo copiarArchivo = new CopiarArchivo();
            copiarArchivo.ShowDialog();
        }

        private void BtnFixes_Click(object sender, EventArgs e)
        {
            Fixes fixes = new Fixes();
            fixes.ShowDialog();
        }


        private void btnEspera_Click(object sender, EventArgs e)
        {
            Espera espera = new Espera();
            espera.ShowDialog();
        }

        private void btnGoAround_Click(object sender, EventArgs e)
        {
            GoAround goAround = new GoAround();
            goAround.ShowDialog();
        }

        private void btnAirac_Click(object sender, EventArgs e)
        {
            Airac airac = new Airac();
            airac.ShowDialog();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            //Comprobar si existe el archivo puntosSignigicativos.csv
            if (!File.Exists("puntosSignificativos.csv"))
            {
                MessageBox.Show("No se encontró el archivo puntosSignificativos.csv. Descarge los archivos ENR_4_1_en.csv y ENR_4_4_en.csv. Pulsar el boton de Airac y añada los archivos y presione Generar.");
            }
            
        }
    }
}

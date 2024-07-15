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
    }
}

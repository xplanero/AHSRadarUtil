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
    }
}

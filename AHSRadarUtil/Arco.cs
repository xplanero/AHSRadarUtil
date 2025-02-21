namespace AHSRadarUtil
{
    public partial class Arco : Form
    {
        public Arco()
        {
            InitializeComponent();
            comboBoxSentido.Items.AddRange(new string[] { "Horario", "Antihorario" });
            comboBoxSentido.SelectedIndex = 0; // Por defecto seleccionamos "Horario"
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        private void btn2PuntosCentro_Click(object sender, EventArgs e)
        {
            Coordenadas inicio = new Coordenadas(tBoxPuntoInicio.Text);
            Coordenadas fin = new Coordenadas(tBoxPuntoFin.Text);
            Coordenadas centro = new Coordenadas(tBoxCentro.Text);
            int numeroSegmentos = int.Parse(tBoxNumeroSegmentos.Text);
            int numeroEspacios = int.Parse(tBoxNumeroEspacios.Text);

            bool sentidoGiro = (comboBoxSentido.SelectedIndex == 0) ? true : false;

            Coordenadas.DibujarArco(inicio, fin, centro, sentidoGiro, numeroSegmentos, numeroEspacios);
            MessageBox.Show("Arco generado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void btnCirculoCentroRadio_Click(object sender, EventArgs e)
        {
            Coordenadas centro = new Coordenadas(tBoxCentro.Text);
            Double radio = double.Parse(tBoxRadio.Text);
            centro.DibujarCirculo(radio);
        }

        private void btnCalcularEquidistancia_Click(object sender, EventArgs e)
        {
            Coordenadas punto1 = new Coordenadas(tBoxPuntoInicio.Text);
            Coordenadas punto2 = new Coordenadas(tBoxPuntoFin.Text);
            double radio = double.Parse(tBoxRadio.Text);
            Coordenadas centro1 = new Coordenadas();
            Coordenadas centro2 = new Coordenadas();
            (centro1, centro2) = punto1.EncontrarEquidistancia(punto2, radio);
            tBoxEquidistancia1.Text = centro1.ObtenerCoordenadasDMS();
            tBoxEquidistancia2.Text = centro2.ObtenerCoordenadasDMS();
        }

        private void btnArcoCentro2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tBoxEquidistancia2.Text))
            {
                MessageBox.Show("Primero debe calcular la equidistancia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int numeroSegmentos = int.Parse(tBoxNumeroSegmentos.Text);
            int numeroEspacios = int.Parse(tBoxNumeroEspacios.Text);
            Coordenadas inicio = new Coordenadas(tBoxPuntoInicio.Text);
            Coordenadas fin = new Coordenadas(tBoxPuntoFin.Text);
            bool sentidoGiro = (comboBoxSentido.SelectedIndex == 0) ? true : false;

            Coordenadas centro = new Coordenadas(tBoxEquidistancia2.Text);
            Coordenadas.DibujarArco(inicio, fin, centro, sentidoGiro, numeroSegmentos, numeroEspacios);
            MessageBox.Show("Arco generado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnArcoCentro1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tBoxEquidistancia1.Text))
            {
                MessageBox.Show("Primero debe calcular la equidistancia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int numeroSegmentos = int.Parse(tBoxNumeroSegmentos.Text);
            int numeroEspacios = int.Parse(tBoxNumeroEspacios.Text);

            Coordenadas inicio = new Coordenadas(tBoxPuntoInicio.Text);
            Coordenadas fin = new Coordenadas(tBoxPuntoFin.Text);
            bool sentidoGiro = (comboBoxSentido.SelectedIndex == 0) ? true : false;
            Coordenadas centro = new Coordenadas(tBoxEquidistancia1.Text);
            Coordenadas.DibujarArco(inicio, fin, centro, sentidoGiro, numeroSegmentos, numeroEspacios);
            MessageBox.Show("Arco generado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBusquedaInicio_Click(object sender, EventArgs e)
        {
            BuscarPunto formBuscar = new BuscarPunto();
            if (formBuscar.ShowDialog() == DialogResult.OK)
            {
                tBoxPuntoInicio.Text = formBuscar.CoordenadasSeleccionadas;
            }
        }

        private void btnBusquedaFinal_Click(object sender, EventArgs e)
        {
            BuscarPunto formBuscar = new BuscarPunto();
            if (formBuscar.ShowDialog() == DialogResult.OK)
            {
                tBoxPuntoFin.Text = formBuscar.CoordenadasSeleccionadas;
            }
        }

        private void btnBusquedaCentro_Click(object sender, EventArgs e)
        {
            BuscarPunto formBuscar = new BuscarPunto();
            if (formBuscar.ShowDialog() == DialogResult.OK)
            {
                tBoxCentro.Text = formBuscar.CoordenadasSeleccionadas;
            }
        }
    }
}

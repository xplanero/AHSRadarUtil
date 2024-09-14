using System;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

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

        //método principal donde se genera la circunferencia completa y se comprueba si pasa por los puntos
        private void btnGenerar_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtenemos los puntos de inicio y fin
                Coordenadas puntoInicio = new Coordenadas(tBoxPuntoInicio.Text);
                Coordenadas puntoFin = new Coordenadas(tBoxPuntoFin.Text);
                Coordenadas centro = new Coordenadas(tBoxCentro.Text);

                int numeroDeSegmentos = Convert.ToInt32(tBoxNumeroSegmentos.Text);
                int numeroDeEspacios = Convert.ToInt32(tBoxNumeroEspacios.Text);

                Coordenadas.CrearArco(puntoInicio, puntoFin, centro, numeroDeSegmentos, numeroDeEspacios);

                MessageBox.Show("Arco generado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCalcularEquidistancia_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"No hace nada de momento", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Coordenadas puntoInicio = new Coordenadas(tBoxPuntoInicio.Text);
            Coordenadas puntoFin = new Coordenadas(tBoxPuntoFin.Text);
            Coordenadas centro = new Coordenadas(tBoxCentro.Text);
            double tolerancia = 0.01;
            Coordenadas nuevoCentro = Coordenadas.EncontrarEquidistancia(puntoInicio, puntoFin, centro, tolerancia);

            tBoxEquidistancia.Text = $"{nuevoCentro.ObtenerCoordenadasDMS()}";
        }

        private void btnArco180_Click(object sender, EventArgs e)
        {
            try
            {
                Coordenadas puntoInicio = new Coordenadas(tBoxPuntoInicio.Text);
                Coordenadas puntoFin = new Coordenadas(tBoxPuntoFin.Text);
                bool sentidoHorario = comboBoxSentido.SelectedIndex == 0;
                Coordenadas.Arco2puntos180Grados(puntoInicio, puntoFin, Convert.ToInt32(tBoxNumeroSegmentos.Text), Convert.ToInt32(tBoxNumeroEspacios.Text), sentidoHorario);
                MessageBox.Show("Arco generado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnArcoRadio_Click(object sender, EventArgs e)
        {
            //llamar a CrearArcoConRadio
            try
            {
                Coordenadas puntoInicio = new Coordenadas(tBoxPuntoInicio.Text);
                Coordenadas puntoFin = new Coordenadas(tBoxPuntoFin.Text);
                Coordenadas centro = new Coordenadas(tBoxCentro.Text);
                double radio = Convert.ToDouble(tBoxRadio.Text);
                bool sentidoHorario = comboBoxSentido.SelectedIndex == 0;

                Coordenadas.CrearArco2PuntosCentro(puntoInicio, puntoFin, centro, Convert.ToInt32(tBoxNumeroSegmentos.Text),
                    Convert.ToInt32(tBoxNumeroEspacios.Text), sentidoHorario);
                MessageBox.Show("Arco generado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLeerArchivoMarcas_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarMarcas_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                tBoxArchivoMarcas.Text = openFileDialog.FileName;
                int encontrada = 0;
                foreach (var line in File.ReadLines(openFileDialog.FileName))
                {
                    // Buscar coordenadas en el formato especificado en la línea
                    var match = Regex.Match(line, @"(N|S)\d{3}\.\d{2}\.\d{2}\.\d{3} (E|W)\d{3}\.\d{2}\.\d{2}\.\d{3}");
                    
                    if (match.Success)
                    {
                        encontrada++;
                        
                        // Si encontramos la 1ra coordenada, la guardamos en tBoxPuntoInicio
                        if (encontrada == 1)
                        {
                            tBoxPuntoFin.Text = match.Value;
                        }
                        // Si encontramos la 2da coordenada, la guardamos en tBoxPuntoFin
                        else if (encontrada == 2)
                        {
                            tBoxPuntoInicio.Text = match.Value;
                        }
                        // Si encontramos la 3ra coordenada, la guardamos en tBoxCentro
                        else if (encontrada == 3)
                        {
                            tBoxCentro.Text = match.Value;
                            break; // Salir del bucle una vez que se han encontrado las tres coordenadas
                        }
                    }
                }

            }
        }
    }
}

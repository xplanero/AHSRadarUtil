using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string centro = tBoxCentro.Text;
            double radio = double.Parse(tBoxRadio.Text);
            string puntoInicio = tBoxPuntoInicio.Text;
            string puntoFin = tBoxPuntoFin.Text;
            bool sentidoGiro = comboBoxSentido.SelectedItem.ToString() == "Horario";
            int numSegmentos = int.Parse(tBoxNumeroSegmentos.Text);

            // Convierte las coordenadas a decimal
            (double latCentro, double lonCentro) = ConvertirCoordenadasADecimal(centro);
            (double latInicio, double lonInicio) = ConvertirCoordenadasADecimal(puntoInicio);
            (double latFin, double lonFin) = ConvertirCoordenadasADecimal(puntoFin);

            // Calcula los segmentos del arco
            var segmentos = CalcularSegmentosArco(latCentro, lonCentro, radio, latInicio, lonInicio, latFin, lonFin, sentidoGiro, numSegmentos);

            // Genera el archivo de texto con los segmentos del arco
            GenerarArchivoDeSegmentos(segmentos, "segmentos_arco.txt");

            string textToCopy = File.ReadAllText("segmentos_arco.txt");  // Lee todo el texto del archivo
            Clipboard.SetText(textToCopy);
            MessageBox.Show("Archivo generado y copiado al portapapeles.");
        }

        static (double, double) ConvertirCoordenadasADecimal(string coordenadas)
        {
            var partes = coordenadas.Split(' ');
            double lat = ConvertirAhsADecimal(partes[0]);
            double lon = ConvertirAhsADecimal(partes[1]);
            return (lat, lon);
        }

        static double ConvertirAhsADecimal(string parte)
        {
            var grados = double.Parse(parte.Substring(1, 3));
            var minutos = double.Parse(parte.Substring(5, 2));
            var segundos = double.Parse(parte.Substring(8, 2) + "." + parte.Substring(11, 3), CultureInfo.InvariantCulture);
            var signo = (parte[0] == 'S' || parte[0] == 'W') ? -1 : 1;

            return signo * (grados + minutos / 60 + segundos / 3600);
        }

        static (double, double)[] CalcularSegmentosArco(double latCentro, double lonCentro, double radio, double latInicio, double lonInicio, double latFin, double lonFin, bool sentidoGiro, int numSegmentos)
        {
            var segmentos = new (double, double)[numSegmentos + 3]; // Espacio para los puntos de inicio y fin

            double anguloInicio = CalcularAngulo(latCentro, lonCentro, latInicio, lonInicio);
            double anguloFin = CalcularAngulo(latCentro, lonCentro, latFin, lonFin);

            if (sentidoGiro)
            {
                if (anguloInicio > anguloFin)
                {
                    anguloFin += 2 * Math.PI; // Asegura un arco en sentido horario
                }
            }
            else
            {
                if (anguloInicio < anguloFin)
                {
                    anguloInicio += 2 * Math.PI; // Asegura un arco en sentido antihorario
                }
            }

            double anguloPaso = (anguloFin - anguloInicio) / (numSegmentos + 1);

            segmentos[0] = (latInicio, lonInicio); // Punto inicial

            for (int i = 1; i <= numSegmentos + 1; i++)
            {
                double angulo = anguloInicio + (i - 1) * anguloPaso;
                var (lat, lon) = CalcularPuntoEnElCírculo(latCentro, lonCentro, radio, angulo);
                segmentos[i] = (lat, lon);
            }

            segmentos[numSegmentos + 2] = (latFin, lonFin); // Punto final

            return segmentos;
        }

        static double CalcularAngulo(double latCentro, double lonCentro, double latPunto, double lonPunto)
        {
            double dLon = (lonPunto - lonCentro) * Math.PI / 180;
            latCentro = latCentro * Math.PI / 180;
            latPunto = latPunto * Math.PI / 180;

            double y = Math.Sin(dLon) * Math.Cos(latPunto);
            double x = Math.Cos(latCentro) * Math.Sin(latPunto) - Math.Sin(latCentro) * Math.Cos(latPunto) * Math.Cos(dLon);
            double angulo = Math.Atan2(y, x);

            return (angulo >= 0 ? angulo : (2 * Math.PI + angulo)); // Asegura un valor positivo
        }

        static (double, double) CalcularPuntoEnElCírculo(double latCentro, double lonCentro, double radio, double angulo)
        {
            double R = 3440.065; // Radio de la Tierra en millas náuticas
            double latCentroRad = latCentro * Math.PI / 180;
            double lonCentroRad = lonCentro * Math.PI / 180;

            double distanciaAng = radio / R; // Distancia angular en radianes

            double latPuntoRad = Math.Asin(Math.Sin(latCentroRad) * Math.Cos(distanciaAng) + Math.Cos(latCentroRad) * Math.Sin(distanciaAng) * Math.Cos(angulo));
            double lonPuntoRad = lonCentroRad + Math.Atan2(Math.Sin(angulo) * Math.Sin(distanciaAng) * Math.Cos(latCentroRad), Math.Cos(distanciaAng) - Math.Sin(latCentroRad) * Math.Sin(latPuntoRad));

            double latPunto = latPuntoRad * 180 / Math.PI;
            double lonPunto = lonPuntoRad * 180 / Math.PI;

            return (latPunto, lonPunto);
        }

        static void GenerarArchivoDeSegmentos((double, double)[] segmentos, string nombreArchivo)
        {
            using (StreamWriter sw = new StreamWriter(nombreArchivo))
            {
                sw.WriteLine($";-arco");
                for (int i = 0; i < segmentos.Length - 1; i++)
                {
                    string coordInicio = ConvertirDecimalACoordenadas(segmentos[i]);
                    string coordFin = ConvertirDecimalACoordenadas(segmentos[i + 1]);
                    sw.WriteLine($"           {coordInicio} {coordFin}");
                }
            }
        }

        static string ConvertirDecimalACoordenadas((double lat, double lon) coord)
        {
            string lat = ConvertirDecimalAParte(coord.lat, 'N', 'S');
            string lon = ConvertirDecimalAParte(coord.lon, 'E', 'W');
            return $"{lat} {lon}";
        }

        static string ConvertirDecimalAParte(double valor, char positivo, char negativo)
        {
            char direccion = valor >= 0 ? positivo : negativo;
            valor = Math.Abs(valor);
            int grados = (int)valor;
            int minutos = (int)((valor - grados) * 60);
            double segundos = ((valor - grados) * 60 - minutos) * 60;
            return $"{direccion}{grados:000}.{minutos:00}.{segundos:00.000}".Replace(",", "."); // Aquí se asegura el punto decimal
        }
    }

}

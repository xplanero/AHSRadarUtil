using System.Globalization;

namespace AHSRadarUtil
{
    public partial class Circulo : Form
    {
        public Circulo()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string centro = tBoxCentro.Text;
            double radio1 = double.Parse(tBoxRadio1.Text);
            double radio2 = double.Parse(tBoxRadio2.Text);

            // Convierte las coordenadas a decimal
            (double latCentro, double lonCentro) = ConvertirCoordenadasADecimal(centro);

            // Calcula los segmentos del círculo 1
            var segmentos1 = CalcularSegmentosCirculo(latCentro, lonCentro, radio1);

            // Genera el archivo de texto con los segmentos circulo 1
            GenerarArchivoDeSegmentos(segmentos1, tBoxColor.Text, "segmentos.txt");

            if (tBoxNumero.Text == "2")
            {
                // Calcula los segmentos del círculo 2
                var segmentos2 = CalcularSegmentosCirculo(latCentro, lonCentro, radio2);

                // Genera el archivo de texto con los segmentos circulo 2
                GenerarArchivoDeSegmentos(segmentos2, tBoxColor.Text, "segmentos2.txt");

                string contenidoArchivo2 = File.ReadAllText("segmentos2.txt");
                using (StreamWriter writer = File.AppendText("segmentos.txt"))
                {
                    writer.WriteLine(contenidoArchivo2);
                }

                File.Delete("segmentos2.txt");
            }
            string textToCopy = File.ReadAllText("segmentos.txt");  // Lee todo el texto del archivo
            Clipboard.SetText(textToCopy);
            MessageBox.Show("Archivo generado y copiado al portapapeles.");


        }
        static (double, double) ConvertirCoordenadasADecimal(string coordenadas)
        {
            var partes = coordenadas.Split(' ');
            double lat = ConvertirParteADecimal(partes[0]);
            double lon = ConvertirParteADecimal(partes[1]);
            return (lat, lon);
        }
        static double ConvertirParteADecimal(string parte)
        {
            var grados = double.Parse(parte.Substring(1, 3));
            var minutos = double.Parse(parte.Substring(5, 2));
            var segundos = double.Parse(parte.Substring(8, 2) + "." + parte.Substring(11, 3), CultureInfo.InvariantCulture);
            var signo = (parte[0] == 'S' || parte[0] == 'W') ? -1 : 1;

            return signo * (grados + minutos / 60 + segundos / 3600);
        }
        static (double, double)[] CalcularSegmentosCirculo(double latCentro, double lonCentro, double radio)
        {
            const int numSegmentos = 36; // Dividir el círculo en 36 segmentos (10 grados cada uno)
            var segmentos = new (double, double)[numSegmentos + 1];

            for (int i = 0; i <= numSegmentos; i++)
            {
                double angulo = i * 10 * Math.PI / 180; // Convertir a radianes
                var (lat, lon) = CalcularPuntoEnElCírculo(latCentro, lonCentro, radio, angulo);
                segmentos[i] = (lat, lon);
            }

            return segmentos;
        }
        static (double, double) CalcularPuntoEnElCírculo(double latCentro, double lonCentro, double radio, double angulo)
        {
            double R = 6378137; // Radio de la Tierra en metros
            double latCentroRad = latCentro * Math.PI / 180;
            double lonCentroRad = lonCentro * Math.PI / 180;

            double distanciaAng = radio / R; // Distancia angular en radianes

            double latPuntoRad = Math.Asin(Math.Sin(latCentroRad) * Math.Cos(distanciaAng) + Math.Cos(latCentroRad) * Math.Sin(distanciaAng) * Math.Cos(angulo));
            double lonPuntoRad = lonCentroRad + Math.Atan2(Math.Sin(angulo) * Math.Sin(distanciaAng) * Math.Cos(latCentroRad), Math.Cos(distanciaAng) - Math.Sin(latCentroRad) * Math.Sin(latPuntoRad));

            double latPunto = latPuntoRad * 180 / Math.PI;
            double lonPunto = lonPuntoRad * 180 / Math.PI;

            return (latPunto, lonPunto);
        }
        static void GenerarArchivoDeSegmentos((double, double)[] segmentos, string color, string nombreArchivo)
        {
            using (StreamWriter sw = new StreamWriter(nombreArchivo))
            {
                sw.WriteLine($";-circulo");
                for (int i = 0; i < segmentos.Length - 1; i++)
                {
                    string coordInicio = ConvertirDecimalACoordenadas(segmentos[i]);
                    string coordFin = ConvertirDecimalACoordenadas(segmentos[i + 1]);
                    sw.WriteLine($"{coordInicio} {coordFin} {color}");
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
            return $"{direccion}{grados:000}.{minutos:00}.{segundos:00.000}";
        }
    }
}

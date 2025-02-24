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
    public partial class DibujarSegmentos : Form
    {
        public DibujarSegmentos()
        {
            InitializeComponent();

            
        }
        /// <summary>
        /// Lee el texto del portapapeles y lo convierte en una lista de segmentos.
        /// Se asume que cada línea tiene el formato:
        /// latInicio, lonInicio, latFin, lonFin
        /// </summary>
        private List<(Coordenadas inicio, Coordenadas fin)> ObtenerSegmentosDesdePortapapeles()
        {
            List<(Coordenadas inicio, Coordenadas fin)> segmentos = new List<(Coordenadas inicio, Coordenadas fin)>();

            string clipboardText = Clipboard.GetText();
            if (string.IsNullOrEmpty(clipboardText))
            {
                MessageBox.Show("El portapapeles está vacío o no contiene datos.");
                return segmentos;
            }

            // Separar el contenido en líneas
            string[] lines = clipboardText.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var line in lines)
            {
                // Se espera que cada línea tenga 4 valores separados por espacios
                //Eliminar espacios en blanco al principio y al final de la línea
                string lineaLimpia = line.Trim();
                var parts = lineaLimpia.Split(' ');
                if (parts.Length != 4)
                {
                    MessageBox.Show("Formato incorrecto en la línea: " + line);
                    return null;
                }
                try
                {
                    // Se espera que los valores sean en DMS en formato string
                    string lat1 = parts[0].Trim();
                    string lon1 = parts[1].Trim();
                    string lat2 = parts[2].Trim();
                    string lon2 = parts[3].Trim();


                    // Crear los objetos Coordenadas
                    Coordenadas c1 = new Coordenadas($"{lat1} {lon1}");
                    Coordenadas c2 = new Coordenadas($"{lat2} {lon2}");

                    segmentos.Add((c1, c2));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al procesar la línea: " + line + "\n" + ex.Message);
                    return null;
                }
            }
            return segmentos;
        }
        /// <summary>
        /// Dibuja la lista de segmentos en el PictureBox adaptando el área de dibujo a los extremos de las coordenadas.
        /// Se utiliza la Longitud para el eje X y la Latitud para el eje Y.
        /// </summary>
        /// <summary>
        /// Dibuja los segmentos en el PictureBox aplicando una corrección en el eje X basada en la latitud.
        /// Se usa el coseno de la latitud media para corregir la longitud.
        /// </summary>
        private void PintarSegmentos(List<(Coordenadas inicio, Coordenadas fin)> segmentos)
        {
            // Primero, determinar los límites originales
            double minLon = double.MaxValue, maxLon = double.MinValue;
            double minLat = double.MaxValue, maxLat = double.MinValue;
            foreach (var seg in segmentos)
            {
                minLon = Math.Min(minLon, Math.Min(seg.inicio.Longitud, seg.fin.Longitud));
                maxLon = Math.Max(maxLon, Math.Max(seg.inicio.Longitud, seg.fin.Longitud));
                minLat = Math.Min(minLat, Math.Min(seg.inicio.Latitud, seg.fin.Latitud));
                maxLat = Math.Max(maxLat, Math.Max(seg.inicio.Latitud, seg.fin.Latitud));
            }

            // Calcular la latitud media y el factor de corrección para el eje X
            double midLat = (minLat + maxLat) / 2.0;
            double cosFactor = Math.Cos(midLat * Math.PI / 180.0);

            // Convertir las longitudes a "coordenadas corregidas" multiplicándolas por el cosFactor.
            // Se creará una lista de segmentos con puntos corregidos.
            List<(PointF p1, PointF p2)> segmentosCorregidos = new List<(PointF, PointF)>();
            foreach (var seg in segmentos)
            {
                float x1 = (float)(seg.inicio.Longitud * cosFactor);
                float y1 = (float)seg.inicio.Latitud;
                float x2 = (float)(seg.fin.Longitud * cosFactor);
                float y2 = (float)seg.fin.Latitud;
                segmentosCorregidos.Add((new PointF(x1, y1), new PointF(x2, y2)));
            }

            // Calcular los nuevos límites en X a partir de las coordenadas corregidas
            double correctedMinX = double.MaxValue, correctedMaxX = double.MinValue;
            foreach (var seg in segmentosCorregidos)
            {
                correctedMinX = Math.Min(correctedMinX, Math.Min(seg.p1.X, seg.p2.X));
                correctedMaxX = Math.Max(correctedMaxX, Math.Max(seg.p1.X, seg.p2.X));
            }

            // Los límites en Y siguen siendo los mismos
            // Definir un margen para que el dibujo no toque los bordes
            float margin = 10f;
            int canvasWidth = pictureBoxCanvas.Width;
            int canvasHeight = pictureBoxCanvas.Height;
            float availableWidth = canvasWidth - 2 * margin;
            float availableHeight = canvasHeight - 2 * margin;

            // Calcular factores de escala para los ejes X e Y
            float scaleX = availableWidth / (float)(correctedMaxX - correctedMinX);
            float scaleY = availableHeight / (float)(maxLat - minLat);
            float scale = Math.Min(scaleX, scaleY);

            // Crear el Bitmap para dibujar
            Bitmap bmp = new Bitmap(canvasWidth, canvasHeight);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);

                // 1. Trasladar el origen al margen inferior izquierdo.
                g.TranslateTransform(margin, canvasHeight - margin);

                // 2. Aplicar la escala:
                // - scale se calculó previamente, usando la corrección de la longitud (por coseno de la latitud media)
                // - La escala en Y es negativa para invertir el eje vertical, de modo que el norte quede arriba.
                g.ScaleTransform(scale, -scale);

                // 3. Trasladar para que el punto (correctedMinX, minLat) quede en la posición adecuada.
                g.TranslateTransform((float)-correctedMinX, (float)-minLat);

                // Ahora se dibuja la figura y se mantendrá siempre la orientación de mapa.
                using (Pen pen = new Pen(Color.Blue, 1 / scale))
                {
                    foreach (var seg in segmentosCorregidos)
                    {
                        g.DrawLine(pen, seg.p1, seg.p2);
                    }
                }
            }
            pictureBoxCanvas.Image = bmp;
        }

        private void DibujarSegmentos_Load(object sender, EventArgs e)
        {
            PintarSegmentos(ObtenerSegmentosDesdePortapapeles());
        }
    }
}

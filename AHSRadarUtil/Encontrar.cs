using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AHSRadarUtil
{
    public partial class Encontrar : Form
    {
        private const string ConfigFilePath = "config.txt";
        public Encontrar()
        {
            InitializeComponent();
            LoadPaths();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadPaths()
        {
            if (File.Exists(ConfigFilePath))
            {
                string[] paths = File.ReadAllLines(ConfigFilePath);
                if (paths.Length == 3)
                {
                    tBoxArchivoPoligono.Text = paths[0];
                    tBoxArchivoRadar.Text = paths[1];
                    tBoxArchivoSalida.Text = paths[2];
                }
            }
        }
        private void SavePaths()
        {
            string[] paths = new string[]
            {
                tBoxArchivoPoligono.Text,
                tBoxArchivoRadar.Text,
                tBoxArchivoSalida.Text
            };
            File.WriteAllLines(ConfigFilePath, paths);
        }

        private void btnRutaArchPol_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                tBoxArchivoPoligono.Text = openFileDialog.FileName;
                SavePaths();
            }
        }

        private void btnRutaArchRadar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                tBoxArchivoRadar.Text = openFileDialog.FileName;
                SavePaths();
            }

        }

        private void btnRutaSalida_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                tBoxArchivoSalida.Text = openFileDialog.FileName;
                SavePaths();
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            // Rutas a los archivos de entrada y salida
            string polygonFilePath = tBoxArchivoPoligono.Text;
            string coordinatesFilePath = tBoxArchivoRadar.Text;
            string outputFilePath = tBoxArchivoSalida.Text;
            int encontrados = 0;
            int leidas = 0;

            // Leer las coordenadas del polígono
            List<Coordinate> polygonCoordinates = ReadCoordinatesFromFile(polygonFilePath);
            List<string> linesWithinPolygon = new List<string>();

            // Leer y verificar cada línea de coordenadas
            foreach (var line in File.ReadLines(coordinatesFilePath))
            {
                // Buscar coordenadas en el formato especificado en la línea
                var match = Regex.Match(line, @"(N|S)\d{3}\.\d{2}\.\d{2}\.\d{3} (E|W)\d{3}\.\d{2}\.\d{2}\.\d{3}");
                if (match.Success)
                {
                    leidas = leidas + 1;
                    // Parsear la coordenada
                    var coord = ParseCoordinate(match.Value);
                    // Verificar si la coordenada está dentro del polígono
                    if (IsPointInPolygon(coord, polygonCoordinates))
                    {
                        // Añadir la línea a la lista de resultados si está dentro del polígono
                        encontrados = encontrados + 1;
                        linesWithinPolygon.Add(line);
                    }
                }
            }

            // Escribir las líneas que están dentro del polígono en el archivo de salida
            File.WriteAllLines(outputFilePath, linesWithinPolygon);
            MessageBox.Show($"Se han analizado {leidas} líneas y se han encontrado {encontrados} coincidencias");
        }
        // Leer coordenadas desde un archivo y parsearlas
        static List<Coordinate> ReadCoordinatesFromFile(string filePath)
        {
            var coordinates = new List<Coordinate>();
            foreach (var line in File.ReadLines(filePath))
            {
                var match = Regex.Match(line, @"(N|S)\d{3}\.\d{2}\.\d{2}\.\d{3} (E|W)\d{3}\.\d{2}\.\d{2}\.\d{3}");
                if (match.Success)
                {
                    coordinates.Add(ParseCoordinate(match.Value));
                }
            }
            return coordinates;
        }
        // Parsear una coordenada en formato "N000.00.00.000 W000.00.00.000"
        static Coordinate ParseCoordinate(string coordinateString)
        {
            var parts = coordinateString.Split(' ');
            var latPart = parts[0];
            var lonPart = parts[1];

            // Parsear latitud
            var latDeg = int.Parse(latPart.Substring(1, 3));
            var latMin = int.Parse(latPart.Substring(5, 2));
            var latSec = double.Parse(latPart.Substring(8), CultureInfo.InvariantCulture);
            var lat = latDeg + latMin / 60.0 + latSec / 3600.0;
            if (latPart[0] == 'S') lat = -lat;

            // Parsear longitud
            var lonDeg = int.Parse(lonPart.Substring(1, 3));
            var lonMin = int.Parse(lonPart.Substring(5, 2));
            var lonSec = double.Parse(lonPart.Substring(8), CultureInfo.InvariantCulture);
            var lon = lonDeg + lonMin / 60.0 + lonSec / 3600.0;
            if (lonPart[0] == 'W') lon = -lon;

            return new Coordinate(lat, lon);
        }
        // Verificar si un punto está dentro de un polígono utilizando el algoritmo de ray-casting
        static bool IsPointInPolygon(Coordinate point, List<Coordinate> polygon)
        {
            bool isInside = false;
            int j = polygon.Count - 1; // Índice del último vértice
            for (int i = 0; i < polygon.Count; i++)
            {
                // Verificar si el punto está dentro de los límites del polígono
                if (polygon[i].Longitude < point.Longitude && polygon[j].Longitude >= point.Longitude || polygon[j].Longitude < point.Longitude && polygon[i].Longitude >= point.Longitude)
                {
                    if (polygon[i].Latitude + (point.Longitude - polygon[i].Longitude) / (polygon[j].Longitude - polygon[i].Longitude) * (polygon[j].Latitude - polygon[i].Latitude) < point.Latitude)
                    {
                        isInside = !isInside;
                    }
                }
                j = i;
            }
            return isInside;
        }
    }
}
// Clase para representar coordenadas
public class Coordinate
{
    public double Latitude { get; set; }
    public double Longitude { get; set; }

    public Coordinate(double latitude, double longitude)
    {
        Latitude = latitude;
        Longitude = longitude;
    }
}

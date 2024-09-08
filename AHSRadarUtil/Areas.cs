
using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using OfficeOpenXml;


namespace AHSRadarUtil
{
    public partial class Areas : Form
    {
        public Areas()
        {
            InitializeComponent();
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
        }

        private void btnCargarArchivo_Click(object sender, EventArgs e)
        {
            ProcesarArchivo(false);
        }

        private void btnR_D_P_Click(object sender, EventArgs e)
        {
            ProcesarArchivo(true);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ProcesarArchivo(bool soloTipoPRD)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*",
                Title = "Seleccionar archivo XML"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                try
                {
                    XDocument xDoc = XDocument.Load(filePath);
                    AirspaceProcessor processor = new AirspaceProcessor(xDoc);
                    string fileName = soloTipoPRD ? "Areas_P_R_D.xlsx" : "EspaciosAereos.xlsx";
                    processor.ProcesarEspaciosAereos(soloTipoPRD, fileName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar el archivo XML: {ex.Message}");
                }
            }
        }

       
    }
    public class AirspaceProcessor
    {
        private readonly XDocument _xDoc;
        private readonly XNamespace _aixm = "http://www.aixm.aero/schema/5.1";
        private readonly XNamespace _gml = "http://www.opengis.net/gml/3.2";

        public AirspaceProcessor(XDocument xDoc)
        {
            _xDoc = xDoc;
        }

        public void ProcesarEspaciosAereos(bool soloTipoPRD, string xlsxFileName)
        {
            var espaciosAereos = _xDoc.Descendants(_aixm + "Airspace");
            if (!espaciosAereos.Any())
            {
                MessageBox.Show("No se encontraron elementos Airspace en el archivo XML.");
                return;
            }

            string xlsxFilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), xlsxFileName);

            using (ExcelPackage package = new ExcelPackage())
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Espacios Aéreos");
                worksheet.Cells.Style.Font.Name = "Consolas";
                worksheet.Cells.Style.Font.Size = 10;

                EscribirEncabezado(worksheet);
                int currentRow = 2;

                foreach (var espacio in espaciosAereos)
                {
                    string tipo = espacio.Descendants(_aixm + "type").FirstOrDefault()?.Value;
                    string designator = espacio.Descendants(_aixm + "designator").FirstOrDefault()?.Value;
                    string nombre = espacio.Descendants(_aixm + "name").FirstOrDefault()?.Value;
                    string clasificacion = espacio.Descendants(_aixm + "classification").FirstOrDefault()?.Value;
                    string coordenadas = espacio.Descendants(_gml + "posList").FirstOrDefault()?.Value;

                    if (ValidarCoordenadasYTipo(coordenadas, tipo, soloTipoPRD))
                    {
                        currentRow = ProcesarCoordenadas(worksheet, designator, nombre, tipo, clasificacion, coordenadas, currentRow);
                    }
                }

                // Ajustar el ancho de todas las columnas automáticamente
                worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                FileInfo excelFile = new FileInfo(xlsxFilePath);
                package.SaveAs(excelFile);
                MessageBox.Show($"El archivo XLSX se ha creado en: {xlsxFilePath}");
            }
        }

        private bool ValidarCoordenadasYTipo(string coordenadas, string tipo, bool soloTipoPRD)
        {
            if (string.IsNullOrEmpty(coordenadas)) return false;
            if (soloTipoPRD)
            {
                return tipo == "P" || tipo == "R" || tipo == "D";
            }
            return tipo != "P" && tipo != "R" && tipo != "D";
        }

        private int ProcesarCoordenadas(ExcelWorksheet worksheet, string designator, string nombre, string tipo, string clasificacion, string coordenadas, int currentRow)
        {
            string[] coordenadasArray = coordenadas.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < coordenadasArray.Length - 2; i += 2)
            {
                double latitud1 = double.Parse(coordenadasArray[i], CultureInfo.InvariantCulture);
                double longitud1 = double.Parse(coordenadasArray[i + 1], CultureInfo.InvariantCulture);
                double latitud2 = double.Parse(coordenadasArray[i + 2], CultureInfo.InvariantCulture);
                double longitud2 = double.Parse(coordenadasArray[i + 3], CultureInfo.InvariantCulture);

                string coordenada1 = ConvertirDecimalACoordenadas(latitud1, longitud1);
                string coordenada2 = ConvertirDecimalACoordenadas(latitud2, longitud2);
                string segmento = $"{coordenada1} {coordenada2}";

                if (i == 0)
                {
                    worksheet.Cells[currentRow, 1].Value = designator;
                    worksheet.Cells[currentRow, 2].Value = nombre;
                    worksheet.Cells[currentRow, 3].Value = tipo;
                    worksheet.Cells[currentRow, 4].Value = clasificacion;

                    string etiqueta = $"{designator}          ";
                    etiqueta = tipo == "D" || tipo == "R" || tipo == "P" ? $"{etiqueta.Substring(0, 8)}{tipo} " : $"{etiqueta.Substring(0, 9)}  ";
                    segmento = $"{etiqueta}{segmento};{nombre} ";

                    worksheet.Cells[currentRow, 5].Value = segmento;
                }
                else
                {
                    segmento = tipo == "D" || tipo == "R" || tipo == "P" ? $"          {segmento}" : $"           {segmento}";
                    worksheet.Cells[currentRow, 5].Value = segmento;
                }

                currentRow++;
            }
            worksheet.Cells[currentRow, 5].Value = ";";
            return currentRow + 1;
        }

        private void EscribirEncabezado(ExcelWorksheet worksheet)
        {
            worksheet.Cells[1, 1].Value = "Codigo";
            worksheet.Cells[1, 2].Value = "Nombre";
            worksheet.Cells[1, 3].Value = "Tipo";
            worksheet.Cells[1, 4].Value = "Clasificacion";
            worksheet.Cells[1, 5].Value = "Coordenadas";
        }

        private static string ConvertirDecimalACoordenadas(double latitud, double longitud)
        {
            string lat = ConvertirDecimalAParte(latitud, 'N', 'S');
            string lon = ConvertirDecimalAParte(longitud, 'E', 'W');
            return $"{lat} {lon}";
        }

        private static string ConvertirDecimalAParte(double valor, char positivo, char negativo)
        {
            char direccion = valor >= 0 ? positivo : negativo;
            valor = Math.Abs(valor);
            int grados = (int)valor;
            int minutos = (int)((valor - grados) * 60);
            double segundos = ((valor - grados) * 60 - minutos) * 60;
            return $"{direccion}{grados:000}.{minutos:00}.{segundos:00.000}".Replace(",", ".");
        }
    }
}

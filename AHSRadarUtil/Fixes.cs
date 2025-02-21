namespace AHSRadarUtil
{
    public partial class Fixes : Form
    {
        private string rutaArchivoAhs;
        private string rutaArchivoAip;
        private const string configFilePath = "fixesConfig.txt";

        public Fixes()
        {
            InitializeComponent();
            CargarConfiguracion();
        }

        // Define la ruta del archivo de coordenadas AHS
        private void btnCoordAHS_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                rutaArchivoAhs = openFileDialog.FileName;
                lblCoordAHS.Text = rutaArchivoAhs;
                GuardarConfiguracion();
            }
        }

        private void btnCoordAIP_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                rutaArchivoAip = openFileDialog.FileName;
                lblCoordAIP.Text = rutaArchivoAip;
                GuardarConfiguracion();
            }

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(rutaArchivoAhs) || string.IsNullOrEmpty(rutaArchivoAip))
            {
                MessageBox.Show("Por favor, seleccione ambos archivos de coordenadas.");
                return;
            }

            string archivoSalida = "FixesAhsActualizado.txt";
            ActualizarFixes(rutaArchivoAhs, rutaArchivoAip, archivoSalida);
            MessageBox.Show("Archivo actualizado generado correctamente.");

        }

        private void btnMwnu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ActualizarFixes(string archivoAhs, string archivoAip, string archivoSalida)
        {
            var fixesAip = LeerArchivoAip(archivoAip);
            using (var writer = new StreamWriter(archivoSalida))
            {
                foreach (var linea in File.ReadLines(archivoAhs))
                {
                    if (linea.StartsWith(";"))
                    {
                        // Copiar la línea tal cual si empieza por ;
                        writer.WriteLine(linea);
                    }
                    else
                    {
                        var partes = linea.Split(' ');
                        var nombre = partes[0];
                        var latitudAhs = partes[1];
                        var longitudAhs = partes[2];

                        if (fixesAip.ContainsKey(nombre))
                        {
                            // Si existe el nombre en el archivo de AIP, actualizar las coordenadas
                            var (latitudAip, longitudAip) = fixesAip[nombre];
                            var latitudActualizada = ConvertirCoordenada(latitudAip, true);
                            var longitudActualizada = ConvertirCoordenada(longitudAip, false);
                            writer.WriteLine($"{nombre} {latitudActualizada} {longitudActualizada}");

                        }
                        else
                        {
                            // Si no existe, copiar la línea del archivo de AHS
                            writer.WriteLine(linea);
                        }
                    }
                }
            }
        }
        private void GuardarConfiguracion()
        {
            using (var writer = new StreamWriter(configFilePath))
            {
                writer.WriteLine(rutaArchivoAhs);
                writer.WriteLine(rutaArchivoAip);
            }
        }
        private Dictionary<string, (string, string)> LeerArchivoAip(string archivoAip)
        {
            var fixesAip = new Dictionary<string, (string, string)>();
            foreach (var linea in File.ReadLines(archivoAip))
            {
                var partes = linea.Split('\t');
                var nombre = partes[0];
                var latitud = partes[1];
                var longitud = partes[2];
                fixesAip[nombre] = (latitud, longitud);
            }
            return fixesAip;
        }

        private string ConvertirCoordenada(string coordenada, bool esLatitud)
        {
            // Convertir coordenada de formato AIP a formato AHS


            //formato latitud 394645N a N039.46.45.000 extrayendo caracteres
            //formato longitud 0152546W a W015.25.46.000 extrayendo caracteres
            if (esLatitud)
            {
                //extrae caracterde la posicion 6 y asignarlo a direccion
                var direccion = coordenada.Substring(6, 1);
                //extrae caracteres de la posicion 0 a 1 y asignarlos a grados
                var grados = coordenada.Substring(0, 2);
                //extrae caracteres de la posicion 2 a 3 y asignarlos a minutos
                var minutos = coordenada.Substring(2, 2);
                //extrae caracteres de la posicion 4 a 5 y asignarlos a segundos
                var segundos = coordenada.Substring(4, 2);
                return $"{direccion}0{grados}.{minutos}.{segundos}.000";

            }


            else
            {
                //extrae caracterde la posicion 7 y asignarlo a direccion
                var direccion = coordenada.Substring(7, 1);
                //extrae caracteres de la posicion 0 a 2 y asignarlos a grados
                var grados = coordenada.Substring(0, 3);
                //extrae caracteres de la posicion 3 a 4 y asignarlos a minutos
                var minutos = coordenada.Substring(3, 2);
                //extrae caracteres de la posicion 5 a 6 y asignarlos a segundos
                var segundos = coordenada.Substring(5, 2);
                return $"{direccion}{grados}.{minutos}.{segundos}.000";
            }


        }

        private void CargarConfiguracion()
        {
            if (File.Exists(configFilePath))
            {
                var lineas = File.ReadAllLines(configFilePath);
                if (lineas.Length >= 2)
                {
                    rutaArchivoAhs = lineas[0];
                    rutaArchivoAip = lineas[1];
                    lblCoordAHS.Text = rutaArchivoAhs;
                    lblCoordAIP.Text = rutaArchivoAip;
                }
            }
        }

        private void Fixes_Load(object sender, EventArgs e)
        {

        }
    }
}

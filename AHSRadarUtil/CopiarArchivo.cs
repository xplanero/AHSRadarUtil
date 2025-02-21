namespace AHSRadarUtil
{
    public partial class CopiarArchivo : Form
    {
        private List<string> carpetasOrigen = new List<string>();
        private string carpetaDestino = string.Empty;
        private readonly string configFilePath = "configCopiarArchivo.txt";

        public CopiarArchivo()
        {
            InitializeComponent();
            CargarConfiguracion();
        }

        private void btnSeleccionarCarpetas_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.Description = "Selecciona una carpeta de origen";
                fbd.ShowNewFolderButton = false;
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    if (!carpetasOrigen.Contains(fbd.SelectedPath))
                    {
                        carpetasOrigen.Add(fbd.SelectedPath);
                        ActualizarListaCarpetas();
                    }
                }
            }
        }

        private void btnSeleccionarDestino_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.Description = "Selecciona la carpeta de destino";
                fbd.ShowNewFolderButton = true;
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    carpetaDestino = fbd.SelectedPath;
                    lblCarpetaDestino.Text = "Destino: " + carpetaDestino;
                }
            }
        }

        private void btnCopiarArchivos_Click(object sender, EventArgs e)
        {
            if (carpetasOrigen.Count == 0 || string.IsNullOrEmpty(carpetaDestino))
            {
                MessageBox.Show("Debe seleccionar al menos una carpeta de origen y una de destino.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            foreach (var carpeta in carpetasOrigen)
            {
                try
                {
                    foreach (var archivo in Directory.GetFiles(carpeta))
                    {
                        string nombreArchivo = Path.GetFileName(archivo);
                        string destinoArchivo = Path.Combine(carpetaDestino, nombreArchivo);
                        File.Copy(archivo, destinoArchivo, true);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error copiando archivos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            MessageBox.Show("Copia completada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            GuardarConfiguracion();
        }

        private void btnEliminarSeleccion_Click(object sender, EventArgs e)
        {
            if (lstCarpetas.SelectedIndex != -1)
            {
                carpetasOrigen.RemoveAt(lstCarpetas.SelectedIndex);
                ActualizarListaCarpetas();
            }
        }

        private void ActualizarListaCarpetas()
        {
            lstCarpetas.Items.Clear();
            lstCarpetas.Items.AddRange(carpetasOrigen.ToArray());
        }

        private void CargarConfiguracion()
        {
            if (File.Exists(configFilePath))
            {
                var lines = File.ReadAllLines(configFilePath);
                if (lines.Length > 0)
                {
                    carpetasOrigen = lines[0].Split('|').ToList();
                    carpetaDestino = lines.Length > 1 ? lines[1] : string.Empty;
                    ActualizarListaCarpetas();
                    lblCarpetaDestino.Text = "Destino: " + carpetaDestino;
                }
            }
        }

        private void GuardarConfiguracion()
        {
            File.WriteAllLines(configFilePath, new string[]
            {
                string.Join("|", carpetasOrigen),
                carpetaDestino
            });
        }

        private void btnMwnu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

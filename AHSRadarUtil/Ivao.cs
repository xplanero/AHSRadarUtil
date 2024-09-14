using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AHSRadarUtil
{
    public partial class Ivao : Form
    {
        public Ivao()
        {
            InitializeComponent();
        }

        private void btnAreasHigh_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                string clipboardText = Clipboard.GetText();
                string formattedText = FormatCoordinates(clipboardText);
                Clipboard.SetText(formattedText);
                MessageBox.Show("Texto formateado copiado al portapapeles.");
            }
            else
            {
                MessageBox.Show("El portapapeles no contiene texto.");
            }
        }
        private string FormatCoordinates(string input)
        {
            var lines = input.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < lines.Length-1; i++)
            {
                var parts = lines[i].Split(';');
                var parts2 = lines[i+1].Split(";");
                if (parts.Length >= 4)
                {
                    string identifier = parts[1].Replace(" ", "_").PadRight(10);
                    string latitude = parts[2];
                    string longitude = parts[3];
                    string latitude2 = parts2[2];
                    string longitude2 = parts2[3];

                    if (i == 0)
                    {
                        result.AppendLine($"{identifier} {latitude} {longitude} {latitude2} {longitude2}");
                    }
                    else
                    {
                        result.AppendLine($"           {latitude} {longitude} {latitude2} {longitude2}");
                    }
                }
            }

            return result.ToString();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System.Text;

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
        private void btnHolding_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                string clipboardText = Clipboard.GetText();
                string formatted2To2 = FormatCoordinates2To2(clipboardText);
                Clipboard.SetText(formatted2To2);
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

            for (int i = 0; i < lines.Length - 1; i++)
            {
                var parts = lines[i].Split(';');
                var parts2 = lines[i + 1].Split(";");
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
            //comprobar si hay texto en result
            return result.ToString();
        }
        private string FormatCoordinates2To2(string input)
        {
            var lines = input.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].Substring(0, 2) == "//")
                {
                    result.AppendLine($";{lines[i].Substring(2, lines[i].Length - 2)}");
                }
                else
                {
                    var parts = lines[i].Split(';');

                    if (parts.Length >= 4)
                    {
                        string latitudeFrom = parts[0];
                        string longitudeFrom = parts[1];
                        string latitudeTo = parts[2];
                        string longitudeTo = parts[3];
                        //Añadimos 26 espacios al principio.
                        result.AppendLine($"                          {latitudeFrom} {longitudeFrom} {latitudeTo} {longitudeTo}");

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

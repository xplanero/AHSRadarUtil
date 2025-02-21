namespace AHSRadarUtil
{
    internal class Punto : Coordenadas
    {
        public string Identificador { get; set; }

        public Punto(string identificador, string latitud, string longitud) : base(latitud, longitud)
        {
            Identificador = identificador;
        }
    }


}

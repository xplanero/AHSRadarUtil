using System;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;

namespace AHSRadarUtil
{
    public class Coordenadas
    {
        public double Latitud { get; set; }
        public double Longitud { get; set; }

        public Coordenadas(double latitud, double longitud)
        {
            Latitud = latitud;
            Longitud = longitud;
        }

        public Coordenadas(string coordenadasDMS)
        {
            var partes = coordenadasDMS.Split(' ');
            Latitud = ConvertirADecimal(partes[0]);
            Longitud = ConvertirADecimal(partes[1]);
        }

        public double CalcularDistancia(Coordenadas otraCoordenada)
        {
            const double RadioTierraKm = 6371.0;

            double dLat = GradosARadianes(otraCoordenada.Latitud - this.Latitud);
            double dLon = GradosARadianes(otraCoordenada.Longitud - this.Longitud);

            double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                       Math.Cos(GradosARadianes(this.Latitud)) * Math.Cos(GradosARadianes(otraCoordenada.Latitud)) *
                       Math.Sin(dLon / 2) * Math.Sin(dLon / 2);

            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            return RadioTierraKm * c;
        }

        public string ConvertirADMS(double coordenada, bool esLatitud)
        {
            char direccion;
            if (esLatitud)
            {
                direccion = coordenada >= 0 ? 'N' : 'S';
            }
            else
            {
                direccion = coordenada >= 0 ? 'E' : 'W';
            }

            coordenada = Math.Abs(coordenada);
            int grados = (int)coordenada;
            double minutosDecimales = (coordenada - grados) * 60;
            int minutos = (int)minutosDecimales;
            double segundos = (minutosDecimales - minutos) * 60;

            return string.Format(System.Globalization.CultureInfo.InvariantCulture, "{0}{1:000}.{2:00}.{3:00.000}", direccion, grados, minutos, segundos);
        }

        public string ObtenerCoordenadasDMS()
        {
            string latitudDMS = ConvertirADMS(Latitud, true);
            string longitudDMS = ConvertirADMS(Longitud, false);
            return $"{latitudDMS} {longitudDMS}";
        }

        public double ConvertirADecimal(string coordenadaDMS)
        {
            char direccion = coordenadaDMS[0];
            string[] partes = coordenadaDMS.Substring(1).Split('.');

            int grados = int.Parse(partes[0], System.Globalization.CultureInfo.InvariantCulture);
            int minutos = int.Parse(partes[1], System.Globalization.CultureInfo.InvariantCulture);
            double segundos = double.Parse(partes[2] + "." + partes[3], System.Globalization.CultureInfo.InvariantCulture);

            double decimalCoordenada = grados + (minutos / 60.0) + (segundos / 3600.0);

            if (direccion == 'S' || direccion == 'W')
            {
                decimalCoordenada *= -1;
            }

            return decimalCoordenada;
        }

        public static void Arco2puntos180Grados(Coordenadas puntoInicial, Coordenadas puntoFinal, int numeroSegmentos, int numeroEspacios, bool sentidoHorario)
        {
            StringBuilder sb = new StringBuilder();

            Coordenadas centro = new Coordenadas(
                (puntoInicial.Latitud + puntoFinal.Latitud) / 2,
                (puntoInicial.Longitud + puntoFinal.Longitud) / 2
            );

            double anguloInicial = CalcularAnguloRelativoAlCentro(puntoInicial, centro);
            double anguloFinal = CalcularAnguloRelativoAlCentro(puntoFinal, centro);

            //// Asegurarse de que el ángulo final es mayor que el ángulo inicial
            //if (anguloFinal < anguloInicial)
            //{
            //    anguloFinal += 2 * Math.PI;
            //}

            double deltaAngulo = Math.Abs((anguloFinal - anguloInicial)) / numeroSegmentos;
            if (!sentidoHorario) 
            {
                deltaAngulo = -deltaAngulo;
            }

            string espacios = new string(' ', numeroEspacios);

            // Calcular el radio como la distancia mínima desde el centro a los dos puntos
            double radioInicial = puntoInicial.CalcularDistancia(centro);
            double radioFinal = puntoFinal.CalcularDistancia(centro);
            double radio = Math.Min(radioInicial, radioFinal);

            Coordenadas puntoAnterior = puntoInicial;

            for (int i = 1; i <= numeroSegmentos; i++)
            {
                double angulo = anguloInicial + i * deltaAngulo; // Incrementar el ángulo en el sentido especificado

                Coordenadas punto = new Coordenadas(
                    centro.Latitud + Math.Sin(angulo) * radio / 111.0, // Aproximadamente 111 km por grado de latitud
                    centro.Longitud + Math.Cos(angulo) * radio / (111.0 * Math.Cos(GradosARadianes(centro.Latitud))) // Ajuste por la latitud
                );

                sb.AppendLine($"{espacios}{puntoAnterior.ObtenerCoordenadasDMS()} {punto.ObtenerCoordenadasDMS()}");
                puntoAnterior = punto;
            }

            // Añadir el último segmento hasta el punto final
            sb.AppendLine($"{espacios}{puntoAnterior.ObtenerCoordenadasDMS()} {puntoFinal.ObtenerCoordenadasDMS()}");

            Clipboard.SetText(sb.ToString());
        }

        public static void CrearArco2PuntosCentro(Coordenadas puntoInicial, Coordenadas puntoFinal, Coordenadas centro, int numeroSegmentos, int numeroEspacios, bool sentidoHorario)
        {
            StringBuilder sb = new StringBuilder();
            //¿Los angulos si aumenta giran en sentido anti horario?
            if (sentidoHorario) //lo logico seria negado
            {
                //Intercambiar puntoInicial por puntoFinal
                Coordenadas temp = puntoInicial;
                puntoInicial = puntoFinal;
                puntoFinal = temp;
            }

            double anguloInicial = CalcularAnguloRelativoAlCentro(puntoInicial, centro);
            double anguloFinal = CalcularAnguloRelativoAlCentro(puntoFinal, centro);

            //// Asegurarse de que el ángulo final es mayor que el ángulo inicial
            //if (anguloFinal < anguloInicial)
            //{
            //    anguloFinal += 2 * Math.PI;
            //}
                        
            double deltaAngulo = Math.Abs((anguloFinal - anguloInicial)) / numeroSegmentos;
            if (!sentidoHorario)
            {
                deltaAngulo = -deltaAngulo;
            }

            string espacios = new string(' ', numeroEspacios);

            // Calcular el radio como la distancia mínima desde el centro a los dos puntos
            double radioInicial = puntoInicial.CalcularDistancia(centro);
            double radioFinal = puntoFinal.CalcularDistancia(centro);
            double radio = Math.Min(radioInicial, radioFinal);

            Coordenadas puntoAnterior = puntoInicial;

            for (int i = 1; i <= numeroSegmentos; i++)
            {
                double angulo = anguloInicial + i * deltaAngulo; // Incrementar el ángulo en el sentido especificado

                Coordenadas punto = new Coordenadas(
                    centro.Latitud + Math.Sin(angulo) * radio / 111.0, // Aproximadamente 111 km por grado de latitud
                    centro.Longitud + Math.Cos(angulo) * radio / (111.0 * Math.Cos(GradosARadianes(centro.Latitud))) // Ajuste por la latitud
                );

                sb.AppendLine($"{espacios}{puntoAnterior.ObtenerCoordenadasDMS()} {punto.ObtenerCoordenadasDMS()}");
                puntoAnterior = punto;
            }

            // Añadir el último segmento hasta el punto final
            sb.AppendLine($"{espacios}{puntoAnterior.ObtenerCoordenadasDMS()} {puntoFinal.ObtenerCoordenadasDMS()}");

            Clipboard.SetText(sb.ToString());
        }

        private static List<Coordenadas> EncontrarCentros(Coordenadas puntoInicial, Coordenadas puntoFinal, double radioKm, double tolerancia)
        {
            List<Coordenadas> centros = new List<Coordenadas>();

            // Calcular el punto medio entre los puntos inicial y final
            Coordenadas puntoMedio = new Coordenadas(
                (puntoInicial.Latitud + puntoFinal.Latitud) / 2,
                (puntoInicial.Longitud + puntoFinal.Longitud) / 2
            );

            // Calcular la distancia desde el punto medio a los posibles centros
            double distanciaCentro = Math.Sqrt((radioKm * radioKm) - (puntoInicial.CalcularDistancia(puntoMedio) * puntoInicial.CalcularDistancia(puntoMedio)));

            // Calcular los dos posibles centros
            double anguloEntrePuntos = Math.Atan2(puntoFinal.Latitud - puntoInicial.Latitud, puntoFinal.Longitud - puntoInicial.Longitud);
            Coordenadas centro1 = new Coordenadas(
                puntoMedio.Latitud + distanciaCentro * Math.Cos(anguloEntrePuntos + Math.PI / 2) / 111.0,
                puntoMedio.Longitud + distanciaCentro * Math.Sin(anguloEntrePuntos + Math.PI / 2) / (111.0 * Math.Cos(GradosARadianes(puntoMedio.Latitud)))
            );
            Coordenadas centro2 = new Coordenadas(
                puntoMedio.Latitud + distanciaCentro * Math.Cos(anguloEntrePuntos - Math.PI / 2) / 111.0,
                puntoMedio.Longitud + distanciaCentro * Math.Sin(anguloEntrePuntos - Math.PI / 2) / (111.0 * Math.Cos(GradosARadianes(puntoMedio.Latitud)))
            );

            // Comprobar que las distancias entre los centros y los puntos inicial y final sean iguales
            if (Math.Abs(puntoInicial.CalcularDistancia(centro1) - radioKm) < tolerancia &&
                Math.Abs(puntoFinal.CalcularDistancia(centro1) - radioKm) < tolerancia)
            {
                centros.Add(centro1);
            }

            if (Math.Abs(puntoInicial.CalcularDistancia(centro2) - radioKm) < tolerancia &&
                Math.Abs(puntoFinal.CalcularDistancia(centro2) - radioKm) < tolerancia)
            {
                centros.Add(centro2);
            }

            return centros;
        }

        private static double CalcularAnguloRelativoAlCentro(Coordenadas punto, Coordenadas centro)
        {
            double deltaLongitud = punto.Longitud - centro.Longitud;
            double deltaLatitud = punto.Latitud - centro.Latitud;
            double angulo = Math.Atan2(deltaLatitud, deltaLongitud); // Ajuste para medir desde el centro del arco
            if (angulo < 0)
            {
                angulo += 2 * Math.PI; // Asegurarse de que el ángulo esté en el rango [0, 2*PI]
            }
            return angulo;
        }

        private static double GradosARadianes(double grados)
        {
            return grados * (Math.PI / 180.0);
        }

            


        //Método que no funciona 
        public static void CrearArco(Coordenadas puntoInicial, Coordenadas puntoFinal, Coordenadas centro, int numeroSegmentos, int numeroEspacios)
        {
            StringBuilder sb = new StringBuilder();
           
            double anguloInicial = CalcularAnguloDesdeNorte(puntoInicial, centro);
            double anguloFinal = CalcularAnguloDesdeNorte(puntoFinal, centro);

            // Asegurarse de que el ángulo final es mayor que el ángulo inicial
            if (anguloFinal < anguloInicial)
            {
                anguloFinal += 2 * Math.PI;
            }

            double deltaAngulo = (anguloFinal - anguloInicial) / numeroSegmentos;
            string espacios = new string(' ', numeroEspacios);

            double radio = puntoInicial.CalcularDistancia(centro);

            Coordenadas puntoAnterior = puntoInicial;

            for (int i = 1; i <= numeroSegmentos; i++)
            {
                double angulo = anguloInicial + i * deltaAngulo; // Incrementar el ángulo en sentido horario

                Coordenadas punto = new Coordenadas(
                    centro.Latitud + Math.Sin(angulo) * radio,
                    centro.Longitud + Math.Cos(angulo) * radio
                );

                sb.AppendLine($"{espacios}{puntoAnterior.ObtenerCoordenadasDMS()} {punto.ObtenerCoordenadasDMS()}");
                puntoAnterior = punto;
            }

            // Añadir el último segmento hasta el punto final
            sb.AppendLine($"{espacios}{puntoAnterior.ObtenerCoordenadasDMS()} {puntoFinal.ObtenerCoordenadasDMS()}");

            Clipboard.SetText(sb.ToString());
        }

        private static double CalcularAnguloDesdeNorte(Coordenadas punto, Coordenadas centro)
        {
            double deltaLongitud = punto.Longitud - centro.Longitud;
            double deltaLatitud = punto.Latitud - centro.Latitud;
            double angulo = Math.Atan2(deltaLongitud, deltaLatitud); // Ajuste para medir desde el norte geográfico
            if (angulo < 0)
            {
                angulo += 2 * Math.PI; // Asegurarse de que el ángulo esté en el rango [0, 2*PI]
            }
            return angulo;
        }
        

                
        private static double RadianesAGrados(double radianes)
        {
            return radianes * (180.0 / Math.PI);
        }

        public static Coordenadas EncontrarEquidistancia(Coordenadas punto1, Coordenadas punto2, Coordenadas centro, double tolerancia)
        {
            double distancia1 = centro.CalcularDistancia(punto1);
            double distancia2 = centro.CalcularDistancia(punto2);

            // Calcular la pendiente de la línea que conecta punto1 y punto2
            double pendiente = (punto2.Latitud - punto1.Latitud) / (punto2.Longitud - punto1.Longitud);

            while (Math.Abs(distancia1 - distancia2) > tolerancia)
            {
                // Calcular la desviación de latitud y longitud respecto del punto central
                double desviacionLatitud = (punto1.Latitud + punto2.Latitud) / 2 - centro.Latitud;
                double desviacionLongitud = (punto1.Longitud + punto2.Longitud) / 2 - centro.Longitud;

                // Ajustar el centro teniendo en cuenta la desviación y la pendiente
                if (Math.Abs(distancia1 - distancia2) > tolerancia)
                {
                    if (distancia1 > distancia2)
                    {
                        centro.Latitud += desviacionLatitud * 0.001; // Ajuste con un factor de 0.1 para converger gradualmente
                    }
                    else
                    {
                        centro.Latitud -= desviacionLatitud * 0.1;
                    }

                    distancia1 = centro.CalcularDistancia(punto1);
                    distancia2 = centro.CalcularDistancia(punto2);

                    if (Math.Abs(distancia1 - distancia2) > tolerancia)
                    {
                        if (distancia1 > distancia2)
                        {
                            centro.Longitud += desviacionLongitud * 0.1 / pendiente;
                        }
                        else
                        {
                            centro.Longitud -= desviacionLongitud * 0.1 / pendiente;
                        }

                        distancia1 = centro.CalcularDistancia(punto1);
                        distancia2 = centro.CalcularDistancia(punto2);
                    }
                }
            }

            return centro;
        }
    }
}


using System.Globalization;
using System.Text;

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
        public Coordenadas(string aipLatitud, string aipLongitud)
        {
            Latitud = ConvertirAipADecimal(aipLatitud);
            Longitud = ConvertirAipADecimal(aipLongitud);
        }

        public Coordenadas()
        {
            Latitud = 0;
            Longitud = 0;
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
        public double ConvertirAipADecimal(string dms)
        {
            // Extraer dirección (N, S, E, W)
            char direction = dms[dms.Length - 1];
            dms = dms.Substring(0, dms.Length - 1); // Eliminar la dirección
            int grados = 0;
            int minutos = 0;
            double segundos = 0;

            if (dms.Contains("."))
            {
                if (dms.Length == 8)
                {
                    grados = int.Parse(dms.Substring(0, 2));
                    minutos = int.Parse(dms.Substring(2, 2));
                    segundos = double.Parse(dms.Substring(4), CultureInfo.InvariantCulture);
                }
                else
                {
                    grados = int.Parse(dms.Substring(0, 3));
                    minutos = int.Parse(dms.Substring(3, 2));
                    segundos = double.Parse(dms.Substring(5), CultureInfo.InvariantCulture);
                }

            }
            else
            {
                if (dms.Length == 6)
                {
                    grados = int.Parse(dms.Substring(0, 2));
                    minutos = int.Parse(dms.Substring(2, 2));
                    segundos = int.Parse(dms.Substring(4));
                }
                else
                {
                    grados = int.Parse(dms.Substring(0, 3));
                    minutos = int.Parse(dms.Substring(3, 2));
                    segundos = int.Parse(dms.Substring(5));
                }
            }

            // Convertir a decimal
            double decimalDegrees = grados + (minutos / 60.0) + (segundos / 3600.0);

            // Aplicar signo según hemisferio
            if (direction == 'S' || direction == 'W')
                decimalDegrees *= -1;

            return decimalDegrees;
        }

        public void DibujarCirculo(double radio)
        {
            double h = Longitud;
            double k = Latitud;
            radio = radio / 60;
            int numeroPuntos = 18;
            int numeroEspacios = 0;
            string color = "parking";
            string espacios = new string(' ', numeroEspacios);

            double incrementoAngular = 2 * Math.PI / numeroPuntos;
            StringBuilder sb = new StringBuilder();

            Coordenadas anterior = new Coordenadas(
                                    k + radio * Math.Sin(0) * 0.878,
                                    h + radio * Math.Cos(0));
            Coordenadas inicial = new Coordenadas(anterior.Latitud, anterior.Longitud);
            Coordenadas siguiente = new Coordenadas(0.0, 0.0);


            for (int i = 1; i < numeroPuntos; i++)
            {
                double angulo = i * incrementoAngular;
                siguiente.Latitud = k + radio * Math.Sin(angulo) * 0.878;
                siguiente.Longitud = h + radio * Math.Cos(angulo);

                sb.AppendLine($"{espacios}{anterior.ObtenerCoordenadasDMS()} {siguiente.ObtenerCoordenadasDMS()} {color}");

                anterior.Latitud = siguiente.Latitud;
                anterior.Longitud = siguiente.Longitud;

            }
            sb.Append($"{espacios}{anterior.ObtenerCoordenadasDMS()} {inicial.ObtenerCoordenadasDMS()} {color}");
            Clipboard.SetText(sb.ToString());

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



        private static double RadianesAGrados(double radianes)
        {
            return radianes * (180.0 / Math.PI);
        }


        public (Coordenadas, Coordenadas) EncontrarEquidistancia(Coordenadas puntoB, double radio)
        {
            double ax = Longitud;
            double ay = Latitud;
            double bx = puntoB.Longitud;
            double by = puntoB.Latitud;
            double r = radio / 60;
            //Distancia entre los puntos
            double d = this.DistanciaGradosCorregida(puntoB);

            //MessageBox.Show($"Radio= {r}  Distancia= {d}");

            // Verificar si los puntos son idénticos
            if (d == 0)
            {
                MessageBox.Show("Los puntos son idénticos, no hay equidistancia.");
                return (null, null);
            }
            // Verificar si el radio es suficiente
            if (r < d / 2)
            {
                MessageBox.Show("El radio es demasiado pequeño para generar una equidistancia válida.");
                return (null, null);
            }
            // Coordenadas del punto medio entre A y B
            double mx = (ax + bx) / 2;
            double my = (ay + by) / 2;

            // Distancia desde el punto medio a los puntos solución
            double h = Math.Sqrt(r * r - (d / 2) * (d / 2));

            // Vector perpendicular a AB
            double vx = (bx - ax) / d;
            double vy = (by - ay) / d;

            // Dos soluciones de intersección de los círculos
            double px1 = mx + h * (-vy);
            double py1 = my + h * (vx);
            double px2 = mx - h * (-vy);
            double py2 = my - h * (vx);
            Coordenadas punto1 = new Coordenadas(py1, px1);
            Coordenadas punto2 = new Coordenadas(py2, px2);

            //MessageBox.Show(string.Join(Environment.NewLine,
            //    $"Distancia p1 a c1= {this.DistanciaLineal(punto1)}",
            //    $"Distancia p1 a c2= {this.DistanciaLineal(punto2)}",
            //    $"Distancia p2 a c1= {puntoB.DistanciaLineal(punto1)}",
            //    $"Distancia p2 a c2= {puntoB.DistanciaLineal(punto2)}"));

            //MessageBox.Show(string.Join(Environment.NewLine,
            //    $"Distancia p1 a c1= {this.DistanciaGradosCorregida(punto1)}",
            //    $"Distancia p1 a c2= {this.DistanciaGradosCorregida(punto2)}",
            //    $"Distancia p2 a c1= {puntoB.DistanciaGradosCorregida(punto1)}",
            //    $"Distancia p2 a c2= {puntoB.DistanciaGradosCorregida(punto2)}"));



            return (punto1, punto2);
        }



        public double DistanciaLineal(Coordenadas puntoB)
        {
            double ax = Longitud;
            double ay = Latitud;
            double bx = puntoB.Longitud;
            double by = puntoB.Latitud;
            //Distancia entre los puntos
            double d = Math.Sqrt((bx - ax) * (bx - ax) + (by - ay) * (by - ay));
            return d;
        }




        public double DistanciaGradosCorregida(Coordenadas otraCoordenada)
        {
            // Diferencia en latitud y longitud
            double dLat = otraCoordenada.Latitud - this.Latitud;
            double dLon = otraCoordenada.Longitud - this.Longitud;

            // Corrección de la longitud por latitud (para evitar distorsión en la escala)
            double factorCorreccion = Math.Cos(GradosARadianes((this.Latitud + otraCoordenada.Latitud) / 2.0));
            dLon *= factorCorreccion;

            // Distancia en grados usando el teorema de Pitágoras
            double distanciaGrados = Math.Sqrt(dLat * dLat + dLon * dLon);

            return distanciaGrados;
        }


        // Método auxiliar para convertir grados a radianes
        private static double GradosARadianes(double grados)
        {
            return grados * (Math.PI / 180.0);
        }
        public static double CalcularAnguloEntrePuntos(Coordenadas inicio, Coordenadas fin, Coordenadas centro, bool sentidoHorario)
        {
            // Calcular vectores desde el centro a los puntos
            double vectorInicioX = inicio.Longitud - centro.Longitud;
            double vectorInicioY = inicio.Latitud - centro.Latitud;
            double vectorFinX = fin.Longitud - centro.Longitud;
            double vectorFinY = fin.Latitud - centro.Latitud;

            // Calcular los ángulos de cada punto respecto al centro
            double anguloInicio = Math.Atan2(vectorInicioY, vectorInicioX);
            if (anguloInicio < 0)
                anguloInicio += 2 * Math.PI; // Asegurar que el ángulo sea positivo
            double anguloFin = Math.Atan2(vectorFinY, vectorFinX);
            if (anguloFin < 0)
                anguloFin += 2 * Math.PI; // Asegurar que el ángulo sea positivo
            //MessageBox.Show($"Angulo inicio= {anguloInicio}  Angulo fin= {anguloFin}");
            double angulo = 0;
            // Calcular la diferencia angular
            if (sentidoHorario) angulo = anguloInicio - anguloFin;
            else angulo = anguloFin - anguloInicio;


            if (angulo < 0)
                angulo += 2 * Math.PI; // Asegurar que el giro sea en sentido antihorario


            return angulo;
        }
        public static void DibujarArco(Coordenadas inicio, Coordenadas fin, Coordenadas centro, bool sentidoHorario = true, int numeroSegmentos = 30, int numeroEspacios = 26)
        {
            StringBuilder sb = new StringBuilder();
            string espacios = new string(' ', numeroEspacios);

            // Calcular el radio exacto de los puntos
            double radioInicio = inicio.DistanciaGradosCorregida(centro); //Plantearse que metodo usar para calcular la distancia.
            double radioFin = fin.DistanciaGradosCorregida(centro);

            // Calcular ángulos inicial y final respecto al centro
            double anguloInicial = centro.CalcularAnguloCentro(inicio);
            double anguloFinal = centro.CalcularAnguloCentro(fin);


            // **Calcular el incremento angular correctamente**
            double anguloTotal = CalcularAnguloEntrePuntos(inicio, fin, centro, sentidoHorario);
            //MessageBox.Show($"Angulo total= {anguloTotal}");
            double incrementoAngular = anguloTotal / (numeroSegmentos - 1);
            if (sentidoHorario) incrementoAngular = -incrementoAngular;  // Invertir el incremento si el arco es antihorario

            Coordenadas anterior = inicio;  // El primer punto siempre es `inicio`

            for (int i = 0; i < numeroSegmentos; i++)
            {
                double angulo = anguloInicial + i * incrementoAngular;
                if (angulo < 0)
                    angulo += 2 * Math.PI;
                if (angulo > 2 * Math.PI)
                    angulo -= 2 * Math.PI;

                // **Interpolación progresiva del radio**
                double factorInterpolacion = (double)i / (numeroSegmentos - 1);
                double radioInterpolado = radioInicio * (1 - factorInterpolacion) + radioFin * factorInterpolacion;

                // **Generar el punto corregido**
                Coordenadas siguiente = new Coordenadas(
                    centro.Latitud + Math.Sin(angulo) * radioInterpolado,
                    centro.Longitud + Math.Cos(angulo) * radioInterpolado / Math.Cos(GradosARadianes(centro.Latitud))
                );

                // **Forzar el primer y el último punto a ser exactos**
                if (i == 0) siguiente = inicio;
                if (i == numeroSegmentos - 1) siguiente = fin;

                sb.AppendLine($"{espacios}{anterior.ObtenerCoordenadasDMS()} {siguiente.ObtenerCoordenadasDMS()}");
                anterior = siguiente;
            }

            // Copiar los datos al portapapeles
            Clipboard.SetText(sb.ToString());
        }

        //Calcular ángulo de un punto respecto del centro
        public double CalcularAnguloCentro(Coordenadas punto)
        {
            double angulo = Math.Atan2(punto.Latitud - Latitud, punto.Longitud - Longitud);
            return angulo;

        }


        //Devuelve las coordenadas del punto a una distancia determinada con el angulo dado
        private Coordenadas CoordenadaAnguloDistancia(double angulo, double distancia)
        {
            distancia = distancia / 60; // Conversión a grados (1 NM = 1/60°)
            angulo = 90 - angulo; // Ajuste del ángulo al sistema de coordenadas
            angulo = GradosARadianes(angulo);
            //MessageBox.Show($"´{angulo}     {distancia}");
            double x = Longitud + distancia * Math.Cos(angulo) / Math.Cos(GradosARadianes(Latitud));
            double y = Latitud + distancia * Math.Sin(angulo);

            return new Coordenadas(y, x);
        }


        public void Espera(double rumboIn, double ancho, double largo, bool sentido)
        {
            StringBuilder sb = new StringBuilder();
            string espacios = new string(' ', 26);

            // Calculamos los puntos de la espera
            Coordenadas inboundIn = this.CoordenadaAnguloDistancia(rumboIn, -largo);
            double ajusteAngulo = sentido ? 90 : -90;

            Coordenadas outboundIn = this.CoordenadaAnguloDistancia(rumboIn + ajusteAngulo, ancho);
            Coordenadas outboundOut = inboundIn.CoordenadaAnguloDistancia(rumboIn + ajusteAngulo, ancho);

            //dibujar una flecha en el tramo inbound
            Coordenadas puntoMedioInbound = this.EncontrarPuntoMedio(inboundIn);
            Coordenadas extremo1FlechaInbound = puntoMedioInbound.CoordenadaAnguloDistancia(rumboIn + 30, -0.2);
            Coordenadas extremo2FlechaInbound = puntoMedioInbound.CoordenadaAnguloDistancia(rumboIn - 30, -0.2);
            sb.AppendLine($"{espacios}{puntoMedioInbound.ObtenerCoordenadasDMS()} {extremo1FlechaInbound.ObtenerCoordenadasDMS()}");
            sb.AppendLine($"{espacios}{puntoMedioInbound.ObtenerCoordenadasDMS()} {extremo2FlechaInbound.ObtenerCoordenadasDMS()}");
            //dibujar una flecha en el tramo outbound
            Coordenadas puntoMedioOutbound = outboundIn.EncontrarPuntoMedio(outboundOut);
            Coordenadas extremo1FlechaOutbound = puntoMedioOutbound.CoordenadaAnguloDistancia(rumboIn + 30, 0.2);
            Coordenadas extremo2FlechaOutbound = puntoMedioOutbound.CoordenadaAnguloDistancia(rumboIn - 30, 0.2);
            sb.AppendLine($"{espacios}{puntoMedioOutbound.ObtenerCoordenadasDMS()} {extremo1FlechaOutbound.ObtenerCoordenadasDMS()}");
            sb.AppendLine($"{espacios}{puntoMedioOutbound.ObtenerCoordenadasDMS()} {extremo2FlechaOutbound.ObtenerCoordenadasDMS()}");

            // Construcción de salida

            sb.AppendLine($"{espacios}{inboundIn.ObtenerCoordenadasDMS()} {this.ObtenerCoordenadasDMS()}");
            //sb.AppendLine($"{espacios}{this.ObtenerCoordenadasDMS()} {outboundIn.ObtenerCoordenadasDMS()}");
            sb.AppendLine($"{espacios}{outboundIn.ObtenerCoordenadasDMS()} {outboundOut.ObtenerCoordenadasDMS()}");
            //sb.AppendLine($"{espacios}{outboundOut.ObtenerCoordenadasDMS()} {inboundIn.ObtenerCoordenadasDMS()}");
            Coordenadas puntoMedio = this.EncontrarPuntoMedio(outboundIn);
            string segmentos = Arco2PuntosCentro(this, outboundIn, puntoMedio, sentido, 14, 26);
            sb.Append(segmentos);
            Coordenadas puntoMedio2 = outboundOut.EncontrarPuntoMedio(inboundIn);
            segmentos = Arco2PuntosCentro(outboundOut, inboundIn, puntoMedio2, sentido, 14, 26);
            sb.Append(segmentos);
            // Copiar al portapapeles
            Clipboard.SetText(sb.ToString());
        }
        public static string Arco2PuntosCentro(Coordenadas inicio, Coordenadas fin, Coordenadas centro, bool sentidoHorario = true, int numeroSegmentos = 30, int numeroEspacios = 26)
        {
            StringBuilder sb = new StringBuilder();
            string espacios = new string(' ', numeroEspacios);

            // Calcular el radio exacto de los puntos
            double radioInicio = inicio.DistanciaGradosCorregida(centro); //Plantearse que metodo usar para calcular la distancia.
            double radioFin = fin.DistanciaGradosCorregida(centro);

            // Calcular ángulos inicial y final respecto al centro
            double anguloInicial = centro.CalcularAnguloCentro(inicio);
            double anguloFinal = centro.CalcularAnguloCentro(fin);


            // **Calcular el incremento angular correctamente**
            double anguloTotal = CalcularAnguloEntrePuntos(inicio, fin, centro, sentidoHorario);
            //MessageBox.Show($"Angulo total= {anguloTotal}");
            double incrementoAngular = anguloTotal / (numeroSegmentos - 1);
            if (sentidoHorario) incrementoAngular = -incrementoAngular;  // Invertir el incremento si el arco es antihorario

            Coordenadas anterior = inicio;  // El primer punto siempre es `inicio`

            for (int i = 0; i < numeroSegmentos; i++)
            {
                double angulo = anguloInicial + i * incrementoAngular;
                if (angulo < 0)
                    angulo += 2 * Math.PI;
                if (angulo > 2 * Math.PI)
                    angulo -= 2 * Math.PI;

                // **Interpolación progresiva del radio**
                double factorInterpolacion = (double)i / (numeroSegmentos - 1);
                double radioInterpolado = radioInicio * (1 - factorInterpolacion) + radioFin * factorInterpolacion;

                // **Generar el punto corregido**
                Coordenadas siguiente = new Coordenadas(
                    centro.Latitud + Math.Sin(angulo) * radioInterpolado,
                    centro.Longitud + Math.Cos(angulo) * radioInterpolado / Math.Cos(GradosARadianes(centro.Latitud))
                );

                // **Forzar el primer y el último punto a ser exactos**
                if (i == 0) siguiente = inicio;
                if (i == numeroSegmentos - 1) siguiente = fin;

                sb.AppendLine($"{espacios}{anterior.ObtenerCoordenadasDMS()} {siguiente.ObtenerCoordenadasDMS()}");
                anterior = siguiente;
            }
            string segmentos = sb.ToString();
            return segmentos;

        }
        private Coordenadas EncontrarPuntoMedio(Coordenadas puntoB)
        {
            double latitudMedia = (Latitud + puntoB.Latitud) / 2;
            double longitudMedia = (Longitud + puntoB.Longitud) / 2;
            return new Coordenadas(latitudMedia, longitudMedia);
        }

    }
}


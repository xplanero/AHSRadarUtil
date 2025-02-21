namespace AHSRadarUtil
{
    static class Utilidades
    {
        //metodo que recibe la ubicacion de un archivo y devuelve el contenido del mismo
        //public static string LeerArchivo(string ruta)
        public static string LeerArchivo(string ruta)
        {
            string contenido = "";
            try
            {
                contenido = System.IO.File.ReadAllText(ruta);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error al leer el archivo: {ex.Message}");
            }
            return contenido;
        }
    }
}

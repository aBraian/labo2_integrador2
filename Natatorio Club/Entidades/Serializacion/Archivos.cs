using System.IO;
using System.Text.Json;

namespace Entidades.Serializacion
{
    public static class Archivos<T>
    {
        private static string rutaEjecutable;
        private static string rutaDirectorioBase;
        private static string rutaArchivo;
        private static JsonSerializerOptions? configuracionJson;

        /// <summary>
        /// Inicializa las rutas de los archivos y directorios necesarios, 
        /// y realiza operaciones de creación y formateo.
        /// </summary>
        static Archivos()
        {
            rutaEjecutable = AppDomain.CurrentDomain.BaseDirectory;
            rutaDirectorioBase = Path.Combine(rutaEjecutable, @"..\..\..\..\Archivos");
            rutaArchivo = Path.Combine(rutaDirectorioBase, "Listado.json");
            CrearDirectorio();
            CrearJson();
            FormatearJson();
        }

        /// <summary>
        /// Crea el directorio en el que se guardara el archivo JSON.
        /// </summary>
        /// <remarks>
        /// Si el directorio especificado no existe, este metodo lo crea.
        /// En caso de existir el directorio, no se vuelve a crear.
        /// </remarks>
        private static void CrearDirectorio()
        {
            if (!Directory.Exists(rutaDirectorioBase))
            {
                Directory.CreateDirectory(rutaDirectorioBase);
            }
        }

        /// <summary>
        /// Crea el archivo JSON.
        /// </summary>
        /// <remarks>
        /// Si el archivo especificado no existe, este metodo lo crea.
        /// En caso de existir el archivo, no se vuelve a crear.
        /// </remarks>
        private static void CrearJson()
        {
            if (!File.Exists(rutaArchivo))
            {
                using (File.Create(rutaArchivo)) { }
            }
        }

        /// <summary>
        /// Carga el formato con el que se mostrara el archivo JSON.
        /// </summary>
        private static void FormatearJson() 
        {
            if (configuracionJson is null)
            {
                configuracionJson = new JsonSerializerOptions();
            }
            configuracionJson.WriteIndented = true;
        }

        /// <summary>
        /// Se encarga de serializar una lista con datos, para luego guardarlos 
        /// en formato JSON.
        /// </summary>
        /// <param name="lista">Lista que se va a serializar.</param>
        public static void GuardarJson(List<T> lista)
        {
            using (StreamWriter archivo = new StreamWriter(rutaArchivo))
            {
                string datos = JsonSerializer.Serialize(lista, configuracionJson);
                archivo.WriteLine(datos);
            }
        }

        /// <summary>
        /// Se encarga de deserializar un archivo JSON, para poder usar los datos.
        /// </summary>
        /// <remarks>
        /// Puede retornar nulo.
        /// </remarks>
        /// <returns>Lista con los datos.</returns>
        public static List<T>? LeerJson()
        {
            List<T>? retorno = new List<T>();
            using (StreamReader archivo = new StreamReader(rutaArchivo))
            {
                string datos = archivo.ReadToEnd();
                if (!string.IsNullOrWhiteSpace(datos))
                {
                    retorno = JsonSerializer.Deserialize<List<T>>(datos);
                }
            }
            return retorno;
        }
    }
}

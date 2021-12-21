using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entidades
{
    public class JSON<T>: IArchivo<T>
    {
        private static string ruta;

        static JSON()
        {
            ruta = AppDomain.CurrentDomain.BaseDirectory + @"\ArchivosJSON\";
        }

        /// <summary>
        /// Metodo que lee un archivo
        /// </summary>
        /// <param name="nombreArchivo">String que indica donde se encuentra el archivo a leer</param>
        /// <param name="info">Indica donde se va a guardar lo leido</param>
        /// <returns>Retorna true si pudo leerlo, false si no</returns>
        public bool Exportar(string nombreArchivo, T info)
        {
            string rutaDefnitiva = Path.Combine(ruta, nombreArchivo); 

            try
            {
                JsonSerializerOptions opciones = new JsonSerializerOptions();
                opciones.WriteIndented = true;
                string jsosString = JsonSerializer.Serialize(info, opciones);
                File.WriteAllText(rutaDefnitiva, jsosString);
                return true;
            }
            catch (Exception)
            {
                throw new ArchivoException($"Ruta erronea: {rutaDefnitiva}");
            }
        }

        /// <summary>
        /// Método que lee un archivo
        /// </summary>
        /// <param name="nombreArchivo">String que indica donde se encuentra el archivo a leer</param>
        /// <returns>Retorna true si pudo leerlo, false si no</returns>
        public T Importar(string nombreArchivo)
        {
            string rutaDefinitiva = Path.Combine(ruta, nombreArchivo);
            T objeto;

            try
            {
                string informacion = File.ReadAllText(rutaDefinitiva);
                objeto = JsonSerializer.Deserialize<T>(informacion);
                return objeto;
            }
            catch (Exception)
            {
                throw new ArchivoException($"Ruta erronea: {rutaDefinitiva}");
            }
        }
    }
}

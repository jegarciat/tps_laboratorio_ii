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

        public static string Ruta
        {
            get
            {
                return ruta;
            }
        }

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

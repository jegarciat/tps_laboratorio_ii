using System;
using System.IO;
using System.Xml.Serialization;

namespace Entidades
{
    public class XML<T> : IArchivo<T>
    {
        static string ruta;

        static XML()
        {
            ruta = AppDomain.CurrentDomain.BaseDirectory + @"\ArchivosXML\";
        }

        public bool Exportar(string nombreArchivo, T info)
        {
            string rutaDefinitiva = ruta + nombreArchivo;

            try
            {
                using (StreamWriter archivo = new StreamWriter(rutaDefinitiva))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    serializer.Serialize(archivo, info);
                }

                return true;
            }
            catch (ArchivoException)
            {
                throw new ArchivoException("Hubo un problema para exportar a XML");
            }
        }

        public T Importar(string nombreArchivo)
        {
            string rutaDefinitiva = ruta + nombreArchivo;
            T objeto;

            try
            {
                using (StreamReader lector = new StreamReader(rutaDefinitiva))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    objeto = (T)serializer.Deserialize(lector);
                }

            }
            catch (Exception)
            {
                throw new ArchivoException("Hubo un problema para importar de XML");
            }

            return objeto;
        }
    }
}

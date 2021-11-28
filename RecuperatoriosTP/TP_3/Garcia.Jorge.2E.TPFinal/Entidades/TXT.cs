using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TXT : IArchivo<string>
    {
        private static string ruta;

        static TXT()
        {
            ruta = AppDomain.CurrentDomain.BaseDirectory + @"\EstadisticasTXT\";
        }

        public static string Ruta { get => ruta; set => ruta = value; }

        public bool Exportar(string nombreArchivo, string info)
        {
            string rutaDefinitiva = ruta + nombreArchivo;

            try
            {
                using (StreamWriter escritor = new StreamWriter(rutaDefinitiva))
                {
                    escritor.WriteLine(info);
                }

                return true;
            }
            catch (Exception)
            {
                throw new ArchivoException($"Hubo un problema para importar la información de: {rutaDefinitiva}");
            }
        }

        public string Importar(string nombreArchivo)
        {
            string informacion; 

            try
            {
                using (StreamReader reader = new StreamReader(nombreArchivo))
                {
                    informacion = reader.ReadToEnd();
                }

                return informacion;
            }
            catch (Exception)
            {
                throw new ArchivoException($"Hubo un problema para importar la información de: {nombreArchivo}");
            }
        }
    }
}

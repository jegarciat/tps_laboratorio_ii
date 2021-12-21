using System;
using System.Collections.Generic;
using System.Linq;

namespace Entidades
{
    public static class Suscripciones
    {
        private static List<PolizaVehiculo> polizasVehiculo;
        private static List<PolizaVida> polizasVida;
        private static List<Poliza> polizasTodas;

        static Suscripciones()
        {
            polizasVehiculo = new List<PolizaVehiculo>();
            polizasVida = new List<PolizaVida>();
            polizasTodas = new List<Poliza>();
        }

        /// <summary>
        /// Se encarga de importar las pólizas de vida en formato .XML
        /// </summary>
        /// <returns>La lista de pólizas o un ArchivoException en caso de error al importar.</returns>
        public static List<PolizaVida> CargarPolizasVida()
        {
            try
            {
                XML<List<PolizaVida>> vidaXml = new XML<List<PolizaVida>>();
                List<PolizaVida> lista = vidaXml.Importar("Polizas_Vida.xml");
                return lista;
            }
            catch (ArchivoException ex)
            {
                throw new ArchivoException(ex.Message);
            }
        }

        /// <summary>
        /// Se encarga de importar las pólizas de vehiculo en formato .XML
        /// </summary>
        /// <returns>La lista de pólizas o un ArchivoException en caso de error al importar.</returns>
        public static List<PolizaVehiculo> CargarPolizasVehiculos()
        {
            try
            {
                XML<List<PolizaVehiculo>> vehiculosXml = new XML<List<PolizaVehiculo>>();
                List<PolizaVehiculo> lista = vehiculosXml.Importar("Polizas_Vehiculo.xml");
                return lista;
            }
            catch (ArchivoException ex)
            {
                throw new ArchivoException($"{ex.Message}");
            }
        }

        public static List<PolizaVehiculo> PolizasVehiculos
        {
            get
            {
                return polizasVehiculo;
            }
            set
            {
                if (value is not null)
                {
                    polizasVehiculo = value;
                }
            }
        }
        public static List<PolizaVida> PolizasVida
        {
            get
            {
                return polizasVida;
            }
            set
            {
                if (value is not null)
                {
                    polizasVida = value;
                }
            }
        }

        public static List<Poliza> TodasLasPolizas
        {
            get
            {
                if (polizasTodas.Count > 0)
                {
                    polizasTodas.Clear();
                }

                polizasTodas.AddRange(PolizasVida);
                polizasTodas.AddRange(PolizasVehiculos);

                return polizasTodas;
            }
        }

        /// <summary>
        /// Elimina un póliza de la lista de su tipo.
        /// </summary>
        /// <param name="poliza"></param>
        /// <returns>true en caso de exito, o una exception en error.</returns>
        public static bool Eliminar(Poliza poliza)
        {
            if (poliza is PolizaVehiculo)
            {
                PolizaVehiculo auxiliar = PolizasVehiculos.Find((x) => x.DNI == poliza.DNI);
                if(PolizasVehiculos.Remove(auxiliar))
                    return true;
                else
                    throw new Exception();
            }
            else
            {
                PolizaVida auxiliar = PolizasVida.Find((x) => x.DNI == poliza.DNI);
                if (PolizasVida.Remove(auxiliar))
                    return true;
                else
                    throw new Exception();
            }
        }
    }
}

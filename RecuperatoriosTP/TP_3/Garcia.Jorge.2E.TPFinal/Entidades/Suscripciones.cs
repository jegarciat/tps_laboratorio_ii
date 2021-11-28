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
        private static int numInforme;

        static Suscripciones()
        {
            polizasVehiculo = new List<PolizaVehiculo>();
            polizasVida = new List<PolizaVida>();
            polizasTodas = new List<Poliza>();

            //JSON<List<PolizaVehiculo>> jsonVehiculo = new JSON<List<PolizaVehiculo>>();
            //JSON<List<PolizaVida>> jsonVida = new JSON<List<PolizaVida>>();

            //jsonVehiculo.Exportar("Polizas_Vehiculo2.json", polizasVehiculo);
            //jsonVida.Exportar("Polizas_Vida2.json", polizasVida);

            //XML<List<PolizaVehiculo>> vehiculosXml = new XML<List<PolizaVehiculo>>();
            //XML<List<PolizaVida>> vidaXml = new XML<List<PolizaVida>>();

            //vehiculosXml.Exportar("Polizas_Vehiculo.xml", polizasVehiculo);
            //vidaXml.Exportar("Polizas_Vida.xml", polizasVida);
        }

        #region Harcodeo

        //public static void CargarPolizasVida()
        //{
        //    double sumaAseguradaRandom = 1000000;

        //    for (int i = 0; i < 10; i++)
        //    {
        //        //sumaAseguradaRandom = new Random().Next(1000000, 5000000);
        //        polizasVida.Add(new PolizaVida(clientes[i].Nombre, clientes[i].Apellido, clientes[i].DNI, clientes[i].Sexo, clientes[i].Edad, sumaAseguradaRandom, true));
        //    }
        //    for (int i = 10; i < 20; i++)
        //    {
        //        //sumaAseguradaRandom = new Random().Next(1000000, 5000000);
        //        polizasVida.Add(new PolizaVida(clientes[i].Nombre, clientes[i].Apellido, clientes[i].DNI, clientes[i].Sexo, clientes[i].Edad, sumaAseguradaRandom, false));
        //    }
        //}

        //public static void CargarPolizasVehiculos()
        //{
        //    double sumaAseguradaRandom = 1000000;
        //    int anioRandom;
        //    ETipo eTipoRandom;

        //    for (int i = 20; i < 40; i++)
        //    {
        //        //sumaAseguradaRandom = new Random().Next(1000000, 3000000);
        //        anioRandom = new Random().Next(2000, 2022);
        //        eTipoRandom = (ETipo)new Random().Next(1, 4);
        //        polizasVehiculo.Add(new PolizaVehiculo(clientes[i].Nombre, clientes[i].Apellido, clientes[i].DNI, clientes[i].Sexo, clientes[i].Edad, sumaAseguradaRandom, anioRandom, eTipoRandom));
        //    }

        //}

        #endregion

        public static List<PolizaVida> CargarPolizasVida()
        {
            try
            {
                //JSON<List<PolizaVida>> json = new JSON<List<PolizaVida>>();
                //return json.Importar("Polizas_Vida.json");

                XML<List<PolizaVida>> vidaXml = new XML<List<PolizaVida>>();
                List<PolizaVida> lista = vidaXml.Importar("Polizas_Vida.xml");
                return lista;
            }
            catch (ArchivoException ex)
            {
                throw new ArchivoException($"{ex.Message}");
            }
        }

        public static List<PolizaVehiculo> CargarPolizasVehiculos()
        {
            try
            {
                //JSON<List<PolizaVehiculo>> json = new JSON<List<PolizaVehiculo>>();
                //return json.Importar("Polizas_Vehiculo.json");

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
                List<Poliza> polizas = polizasTodas.OrderBy(x => x.DNI).ToList();

                return polizas;
            }
        }

        public static List<T> Filtrar<T>(Predicate<T> predicate) where T : Poliza
        {
            List<T> listaFiltrada = new List<T>();

            return listaFiltrada.FindAll(predicate);
        }

        public static void Eliminar(Poliza poliza)
        {
            if (EsPolizaVehiculo(poliza))
            {
                PolizaVehiculo auxiliar = PolizasVehiculos.Find((x) => x.DNI == poliza.DNI);
                PolizasVehiculos.Remove(auxiliar);
            }
            else
            {
                PolizaVida auxiliar = PolizasVida.Find((x) => x.DNI == poliza.DNI);
                PolizasVida.Remove(auxiliar);
            }
        }

        private static bool EsPolizaVehiculo(Poliza poliza)
        {
            if (poliza is PolizaVehiculo)
                return true;
            else
                return false;
        }
    }
}

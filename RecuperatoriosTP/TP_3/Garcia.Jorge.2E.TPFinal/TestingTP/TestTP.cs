using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using System.Collections.Generic;
using System;

namespace TestingTP
{
    [TestClass]
    public class TestTP
    {
        /// <summary>
        /// Testea que lanza una excepcion al tratar de setear un id que ya existe.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ClienteException))]
        public void TestDosDniIguales()
        {
            PolizaVida poliza1 = new PolizaVida();
            PolizaVida poliza2 = new PolizaVida();

            Suscripciones.PolizasVida.Add(poliza1);
            Suscripciones.PolizasVida.Add(poliza2);

            poliza1.DNI = 1;
            poliza2.DNI = 1;
        }

        /// <summary>
        /// Testea que lanza una excepcion al tratar de setear un año inválido, en el negocio
        /// solo se aceptan vehiculos a partir del año 1980.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ClienteException))]
        public void TestAnioInvalido()
        {
            PolizaVehiculo poliza1 = new PolizaVehiculo();
            Suscripciones.PolizasVehiculos.Add(poliza1);
            poliza1.Anio = 1589;
        }

        /// <summary>
        /// Testea que las pólizas se hayan deserializado correctamente.
        /// </summary>
        [TestMethod]
        public void TestImportarXML()
        {
            XML<List<PolizaVida>> vidaXml = new XML<List<PolizaVida>>();
            XML<List<PolizaVehiculo>> vehiculosXml = new XML<List<PolizaVehiculo>>();

            List<PolizaVehiculo> lista2 = vehiculosXml.Importar("Polizas_Vehiculo.xml");
            List<PolizaVida> lista = vidaXml.Importar("Polizas_Vida.xml");

            Assert.IsTrue(lista.Count == 20);
            Assert.IsTrue(lista2.Count == 20);
        }

        /// <summary>
        /// Testea que el costo calculado según la tasa más alta sea el esperado.
        /// </summary>
        [TestMethod]
        public void TestCalculoCostoEnVehiculo()
        {
            double sumaAsegurada1 = 500000;
            double costoEsperado1 = sumaAsegurada1 * 0.005F;
            double sumaAsegurada2 = 600000;
            double costoEsperado2 = sumaAsegurada2 * 0.005F;
            PolizaVehiculo poliza4 = new PolizaVehiculo("PruebaUno", "Perez", 2, ESexo.Mujer, 25, sumaAsegurada1, 1999, ETipo.Moto);
            PolizaVehiculo poliza5 = new PolizaVehiculo("PruebaDos", "Garcia", 1, ESexo.Hombre, 25, sumaAsegurada2, 2000, ETipo.Auto);

            Assert.AreEqual(Math.Round(costoEsperado1, 2), poliza4.Costo);
            Assert.AreEqual(Math.Round(costoEsperado2, 2), poliza5.Costo);
        }
    }
}

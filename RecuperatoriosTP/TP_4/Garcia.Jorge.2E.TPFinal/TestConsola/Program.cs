using Entidades;
using System;
using System.Linq;

namespace TestConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Suscripciones.PolizasVehiculos = Suscripciones.CargarPolizasVehiculos();
                Suscripciones.PolizasVida = Suscripciones.CargarPolizasVida();
            }
            catch (ArchivoException)
            {
                Console.WriteLine("Excepcion controlada");
            }

            Console.WriteLine($"Pólizas totales: {Suscripciones.TodasLasPolizas.Count()}");
            Console.WriteLine($"Pólizas de vida actuales: {Suscripciones.PolizasVehiculos.Count()}");
            Console.WriteLine($"Pólizas de vehiculo actuales: {Suscripciones.PolizasVehiculos.Count()}");
            Suscripciones.Eliminar(Suscripciones.PolizasVida[15]);
            Suscripciones.Eliminar(Suscripciones.PolizasVehiculos[15]);
            Console.WriteLine("- Después de eliminar -");
            Console.WriteLine($"Pólizas totales: {Suscripciones.TodasLasPolizas.Count()}");
            Console.WriteLine($"Pólizas de vida actuales: {Suscripciones.PolizasVehiculos.Count()}");
            Console.WriteLine($"Pólizas de vehiculo actuales: {Suscripciones.PolizasVehiculos.Count()}");

            Calculos calculos = new Calculos();
            TXT manejadorTexto = new TXT();

            Console.WriteLine("");
            Console.WriteLine(calculos.Informacion());
        }
    }
}

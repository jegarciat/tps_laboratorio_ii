using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Calculos : IInformacion
    {
        private int totalPolizas;
        private int totalPolizasVida;
        private int totalPolizasVehiculos;
        private double totalSumaAsegurada;
        private double totalSumaAseguradaVida;
        private double totalSumaAseguradaVehiculo;
        private int totalMujeres;
        private int totalHombres;

        public Calculos()
        {
            //Total por poliza
            totalPolizas = Suscripciones.TodasLasPolizas.Count();
            totalPolizasVida = Suscripciones.PolizasVida.Count();
            totalPolizasVehiculos = Suscripciones.PolizasVehiculos.Count();

            //Total suma asegurada
            Suscripciones.TodasLasPolizas.ForEach((x) => totalSumaAsegurada += x.SumaAsegurada);
            Suscripciones.PolizasVida.ForEach((x) => totalSumaAseguradaVida += x.SumaAsegurada);
            Suscripciones.PolizasVehiculos.ForEach((x) => totalSumaAseguradaVehiculo += x.SumaAsegurada);

            //Total por sexo
            totalMujeres = Suscripciones.TodasLasPolizas.FindAll((x) => x.Sexo == ESexo.Mujer).Count();
            totalHombres = Suscripciones.TodasLasPolizas.FindAll((x) => x.Sexo == ESexo.Hombre).Count();
        }

        /// <summary>
        /// Método que recopila todas la estadísticas del seguro y las retorna en un string.
        /// </summary>
        /// <returns></returns>
        public string Informacion()
        {
            StringBuilder sb = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();

            sb.AppendLine("- Ánalisis de datos -\n");
            sb.AppendLine($"Fecha: {DateTime.Now.ToString("D")}\n");
            sb.AppendLine($"Total de pólizas: {totalPolizas} - {Porcentaje(totalPolizas, totalPolizasVehiculos)}% en vehiculos y un {Porcentaje(totalPolizas, totalPolizasVida)}% en vida");
            sb.AppendLine(AnalisisSumaAsegurada());
            sb.AppendLine(AnalisisSexo());
            sb.AppendLine(AnalisisCostos());
            sb.AppendLine(AnalisisEdad());
            sb.AppendLine(AnalisisFumadores());
            sb.AppendLine(AnalisisPorTipoVehiculo());
            sb.AppendLine(AnalisisAntiguedad());
            return sb.ToString();
        }

        /// <summary>
        /// Calcula el promedio de los datos pasados por parámetro.
        /// </summary>
        /// <param name="total"></param>
        /// <param name="cantidad"></param>
        /// <returns></returns>
        private static double Promedio(double total, int cantidad)
        {
            return Math.Round((double)total / cantidad, 3);
        }

        /// <summary>
        /// Calcula el porcentaje de los números pasados por parámetro.
        /// </summary>
        /// <param name="total"></param>
        /// <param name="cantidad"></param>
        /// <returns></returns>
        private static int Porcentaje(int total, int cantidad)
        {
            int porcentaje = cantidad * 100 / total;

            return porcentaje;
        }

        /// <summary>
        /// Calcula el procentaje de los números pasados por parámetro.
        /// </summary>
        /// <param name="total"></param>
        /// <param name="cantidad"></param>
        /// <returns></returns>
        public static double Porcentaje(double total, double cantidad)
        {
            double porcentaje = cantidad * 100 / total;

            return Math.Round(porcentaje, 3);
        }

        /// <summary>
        /// Recopila y devuelve los datos referente a la suma asegurada.
        /// </summary>
        /// <returns></returns>
        private string AnalisisSumaAsegurada()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Suma asegurada acumulada {totalSumaAsegurada}$:");
            sb.AppendLine($"{Porcentaje(totalSumaAsegurada, totalSumaAseguradaVida)}% de suma asegurada en vida ");
            sb.AppendLine($"{Porcentaje(totalSumaAsegurada, totalSumaAseguradaVehiculo)}% de suma asegurada en vehiculos");

            return sb.ToString();
        }

        /// <summary>
        /// Recopila y devuelve los datos referentes a los tipos de vehiculo
        /// </summary>
        /// <returns></returns>
        private string AnalisisPorTipoVehiculo()
        {
            StringBuilder sb = new StringBuilder();
            int totalMoto = Suscripciones.PolizasVehiculos.FindAll((x) => x.TipoVehiculo == ETipo.Moto).Count();
            int totalAuto = Suscripciones.PolizasVehiculos.FindAll((x) => x.TipoVehiculo == ETipo.Auto).Count();
            int totalCamiones = Suscripciones.PolizasVehiculos.FindAll((x) => x.TipoVehiculo == ETipo.Camion).Count();
            int mujeresMoto = Suscripciones.PolizasVehiculos.FindAll((x) => x.TipoVehiculo == ETipo.Moto && x.Sexo == ESexo.Mujer).Count();
            int hombreMoto = Suscripciones.PolizasVehiculos.FindAll((x) => x.TipoVehiculo == ETipo.Moto && x.Sexo == ESexo.Hombre).Count();
            int hombreAuto = Suscripciones.PolizasVehiculos.FindAll((x) => x.TipoVehiculo == ETipo.Auto && x.Sexo == ESexo.Hombre).Count();
            int mujeresAuto = Suscripciones.PolizasVehiculos.FindAll((x) => x.TipoVehiculo == ETipo.Auto && x.Sexo == ESexo.Mujer).Count();

            sb.AppendLine($"Porcentaje de mujeres con seguro de moto: {Porcentaje(totalMoto, mujeresMoto)}%");
            sb.AppendLine($"Porcentaje de hombres con seguro de moto: {Porcentaje(totalMoto, hombreMoto)}%");
            sb.AppendLine($"Porcentaje de mujeres con seguro de auto: {Porcentaje(totalAuto, mujeresAuto)}%");
            sb.AppendLine($"Porcentaje de hombres con seguro de auto: {Porcentaje(totalAuto, hombreAuto)}%");
            sb.AppendLine($"Porcentaje de pólizas para camiones: {Porcentaje(totalPolizasVehiculos, totalCamiones)}%");
            sb.AppendLine($"Porcentaje de pólizas para moto: {Porcentaje(totalPolizasVehiculos, totalMoto)}%");
            sb.AppendLine($"Porcentaje de pólizas para auto: {Porcentaje(totalPolizasVehiculos, totalAuto)}%");

            return sb.ToString();
        }

        /// <summary>
        /// Recopila y devuelve todos los datos referentes a los fumadores.
        /// </summary>
        /// <returns></returns>
        private string AnalisisFumadores()
        {
            StringBuilder sb = new StringBuilder();
            string conclusion = null;
            int totalHombresFumadores = Suscripciones.PolizasVida.FindAll((x) => x.Fumador == true && x.Sexo == ESexo.Hombre).Count();
            int totalMujeresFumadoras = Suscripciones.PolizasVida.FindAll((x) => x.Fumador == true && x.Sexo == ESexo.Mujer).Count();
            int totalFumadoresMayores = Suscripciones.PolizasVida.FindAll((x) => x.Fumador == true && x.Edad > 50).Count();
            int fumadoresEdadsMujeres = Suscripciones.PolizasVida.FindAll((x) => x.Fumador == true && x.Edad > 30 && x.Sexo == ESexo.Mujer).Count();
            int fumadoresEdadHombres = Suscripciones.PolizasVida.FindAll((x) => x.Fumador == true && x.Edad < 35 && x.Sexo == ESexo.Hombre).Count();
            int totalFumadores = totalHombresFumadores + totalMujeresFumadoras;

            if (totalHombresFumadores > totalMujeresFumadoras)
                conclusion = "Los hombres fumadores son más propensos a contratar un seguro de vida que las mujeres fumadores.";
            else if(totalMujeresFumadoras > totalHombresFumadores)
                conclusion = "Las mujeres fumadoras son más propensas a contratar un seguro de vida que los hombres fumadores.";

            sb.AppendLine($"Hombres fumadores: {Porcentaje(totalFumadores, totalHombresFumadores)}%");
            sb.AppendLine($"Mujeres fumadoras: {Porcentaje(totalFumadores, totalMujeresFumadoras)}%");
            sb.AppendLine($"Fumadores mayores de 50 años: {Porcentaje(totalFumadores, totalFumadoresMayores)}%");
            sb.AppendLine($"Mujeres fumadoras mayores de 30 años: {Porcentaje(totalFumadores, fumadoresEdadsMujeres)}%");
            sb.AppendLine($"Hombres fumadores con menos de 35 años: {Porcentaje(totalFumadores, fumadoresEdadHombres)}%");

            if(conclusion is not null)
                sb.AppendLine(conclusion);

            return sb.ToString();
        }

        /// <summary>
        /// Recopila y devuelve los datos referentes a los costos.
        /// </summary>
        /// <returns></returns>
        private string AnalisisCostos()
        {
            StringBuilder sb = new StringBuilder();
            double totalCosto = 0;
            double totalCostoVehiculo = 0;
            double totalCostoVida = 0;
            string conclusion = "La ganancia entre las 2 tipos de pólizas es igual.";
            Suscripciones.PolizasVehiculos.ForEach((x) => { totalCosto += x.Costo; totalCostoVehiculo += x.Costo; });
            Suscripciones.PolizasVida.ForEach((x) => { totalCosto += x.Costo; totalCostoVida += x.Costo; });

            if (totalCostoVehiculo > totalCostoVida)
                conclusion = "Se gana más dinero con los seguros de vehiculos que con los seguros de vida";
            else
                conclusion = "Se gana más dinero con los seguros de vida que con los seguros de vehiculo";

            sb.AppendLine($"Costo acumulado {totalCosto}$ - un {Porcentaje(totalCosto, totalCostoVehiculo)}% en vehiculo y un {Porcentaje(totalCosto, totalCostoVida)}% en vida");
            sb.AppendLine($"Promedio de costo en las pólizas de vida: {Promedio(totalCostoVida, totalPolizasVida)}$");
            sb.AppendLine($"Promedio de costo en las pólizas de vehiculo: {Promedio(totalCostoVehiculo, totalPolizasVehiculos)}$");
            sb.AppendLine(conclusion);

            return sb.ToString();
        }

        /// <summary>
        /// Recopila y devuelve los datos referentes al sexo.
        /// </summary>
        /// <returns></returns>
        private string AnalisisSexo()
        {
            StringBuilder sb = new StringBuilder();

            int totalMujeresVida = Suscripciones.PolizasVida.FindAll((x) => x.Sexo == ESexo.Mujer).Count();
            int totalMujeresVehiculos = Suscripciones.PolizasVehiculos.FindAll((x) => x.Sexo == ESexo.Mujer).Count();

            int totalHombresVida = Suscripciones.PolizasVida.FindAll((x) => x.Sexo == ESexo.Hombre).Count();
            int totalHombresVehiculos = Suscripciones.PolizasVehiculos.FindAll((x) => x.Sexo == ESexo.Hombre).Count();

            sb.AppendLine($"Total de mujeres aseguradas: {totalMujeres} - un {Porcentaje(totalMujeres, totalMujeresVida)}% en vida y un {Porcentaje(totalMujeres, totalMujeresVehiculos)}% en vehiculos");
            sb.AppendLine($"Total de hombres asegurados - {totalHombres} - un {Porcentaje(totalHombres, totalHombresVida)}% en vida y un {Porcentaje(totalHombres, totalHombresVehiculos)}% en vehiculos");

            return sb.ToString();
        }

        /// <summary>
        /// Recopila y devuelve los datos referentes a la edad.
        /// </summary>
        /// <returns></returns>
        private string AnalisisEdad()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Promedio de edad de los asegurados: {Suscripciones.TodasLasPolizas.PromedioEdad()} años");
            sb.AppendLine($"Promedio de edad en las pólizas de vida: {Suscripciones.PolizasVida.PromedioEdad()} años");
            sb.AppendLine($"Promedio de edad en las pólizas de vehiculo: {Suscripciones.PolizasVehiculos.PromedioEdad()} años");

            return sb.ToString();
        }


        /// <summary>
        /// Recopila y deuvuelve los datos referentes a la antiguedad.
        /// </summary>
        /// <returns></returns>
        private string AnalisisAntiguedad()
        {
            StringBuilder sb = new StringBuilder();

            int antiguedadTotal = 0;
            int vehiculosConMenosDe5 = 0;
            int vehiculosConMasde10 = 0;

            List<PolizaVehiculo> auxiliar5 = Suscripciones.PolizasVehiculos.FindAll((x) => x.Anio.CalcularAntiguedad() <= 5);
            List<PolizaVehiculo> auxiliar10 = Suscripciones.PolizasVehiculos.FindAll((x) => x.Anio.CalcularAntiguedad() > 10);
            Suscripciones.PolizasVehiculos.ForEach(x => antiguedadTotal += x.Anio.CalcularAntiguedad());

            vehiculosConMenosDe5 = auxiliar5.Count();
            vehiculosConMasde10 = auxiliar10.Count();

            sb.AppendLine($"Promedio de antiguedad de los vehiculos asegurados: {Promedio(antiguedadTotal, totalPolizasVehiculos)} años");
            sb.AppendLine($"Porcentaje de vehiculos asegurados con menos de 6 años de fabricación: {Porcentaje(totalPolizasVehiculos, vehiculosConMenosDe5)}%");
            sb.AppendLine($"Porcentaje de vehiculos asegurados con más de 10 años de fabricación: {Porcentaje(totalPolizasVehiculos, vehiculosConMasde10)}%");

            return sb.ToString();
        }
    }
}

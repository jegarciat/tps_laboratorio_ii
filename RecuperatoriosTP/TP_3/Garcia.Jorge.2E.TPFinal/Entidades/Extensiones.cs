using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Extensiones
    {
        /// <summary>
        /// Calcula la antiguedad de un vehiculo dependiendo de la año actual.
        /// </summary>
        /// <param name="antiguedad"></param>
        /// <returns></returns>
        public static int CalcularAntiguedad(this Int32 antiguedad)
        {
            return DateTime.Now.Year - antiguedad;
        }

        /// <summary>
        /// Verifica que el string este compuesto por solo letras.
        /// </summary>
        /// <param name="texto"></param>
        /// <returns>rtrue si es solo letras, false en caso contrario.</returns>
        public static bool SoloLetras(this string texto)
        {
            foreach (char caracter in texto.ToCharArray())
            {
                if (char.IsDigit(caracter))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Verifica que el DNI sea único en la lista de pólizas.
        /// </summary>
        /// <param name="dni"></param>
        /// <returns></returns>
        public static bool DniUnico(this Int32 dni)
        {
            if (dni <= 0)
                return false;

            foreach (Poliza item in Suscripciones.TodasLasPolizas)
            {
                if (item.DNI == dni)
                    throw new ClienteException("El DNI ya existe.");
            }

            return true;
        }

        /// <summary>
        /// Calcula el promedio de edad de la lista génerica pasada por parámetro. Siempre que la lista sea del tipo póliza.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="polizas"></param>
        /// <returns>el promedio calculado</returns>
        public static double PromedioEdad<T>(this List<T> polizas) where T: Poliza
        {
            int sumaEdades = 0;
            int cantidadClientes = polizas.Count();

            foreach (T item in polizas)
            {
                sumaEdades += item.Edad;
            }

            return sumaEdades / cantidadClientes;
        }
    }
}

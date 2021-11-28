using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Extensiones
    {
        public static bool SoloLetras(this String texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
                return false;

            foreach (char caracter in texto.ToCharArray())
            {
                if (char.IsDigit(caracter))
                {
                    return false;
                }
            }

            return true;
        }

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

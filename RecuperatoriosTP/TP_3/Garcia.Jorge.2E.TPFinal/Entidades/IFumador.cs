using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IFumador
    {
        /// <summary>
        /// Se encarga de calcular la tasa de un fumador.
        /// </summary>
        /// <param name="edad"></param>
        /// <returns></returns>
        float CalcularTasaFumador(int edad);

        /// <summary>
        /// Se encarga de calcular la tasa de un cliente no fumador.
        /// </summary>
        /// <param name="edad"></param>
        /// <returns></returns>
        float CalcularTasaNoFumador(int edad);
    }
}

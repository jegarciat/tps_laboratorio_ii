using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IInformacion
    {
        /// <summary>
        /// Obtiene la información del objeto que la implemente.
        /// </summary>
        /// <returns>String con la información</returns>
        string Informacion();
    }
}

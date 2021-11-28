using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public interface IFumador
    {
        float CalcularTasaFumador(int edad);
        float CalcularTasaNoFumador(int edad);
    }
}

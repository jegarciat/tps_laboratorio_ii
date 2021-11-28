using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class AntiguedadExtension
    {
        public static int CalcularAntiguedad(this Int32 antiguedad)
        {
            return DateTime.Now.Year - antiguedad;
        }
    }
}

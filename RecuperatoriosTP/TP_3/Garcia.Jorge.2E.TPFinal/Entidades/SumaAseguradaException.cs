using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SumaAseguradaException : Exception
    {
        public SumaAseguradaException(string mensaje) : base(mensaje)
        {

        }
    }
}

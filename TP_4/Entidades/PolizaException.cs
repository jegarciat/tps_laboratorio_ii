using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PolizaException : Exception
    {
        public PolizaException(string mensaje) : base(mensaje)
        {

        }
    }
}

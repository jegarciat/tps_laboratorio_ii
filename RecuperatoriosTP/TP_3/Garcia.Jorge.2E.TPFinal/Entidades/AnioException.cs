using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class AnioException : Exception
    {
        public AnioException() : base()
        {

        }

        public AnioException(string mensaje) : base(mensaje)
        {

        }
    }
}

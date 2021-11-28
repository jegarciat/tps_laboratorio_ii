using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class ValidacionExtension
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
    }
}

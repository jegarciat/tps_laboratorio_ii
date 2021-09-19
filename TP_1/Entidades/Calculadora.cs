using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Valida y realiza la operación pedida entre dos números.
        /// </summary>
        /// <param name="num1">Valor del tipo Operando</param>
        /// <param name="num2">Valor del tipo Operando</param>
        /// <param name="operador">Operación que se quiere realizar</param>
        /// <returns>Resultado de la operación</returns>
        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double resultado = 0;

            switch (ValidarOperador(operador))
            {
                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                case '/':
                    resultado = num1 / num2;
                    break;
            }

            return resultado;
        }

        /// <summary>
        /// Valida que el valor sea un operador.
        /// </summary>
        /// <param name="operador">Parámetro a validar</param>
        /// <returns>El operador o '+' en caso de que no sea un operador válido.</returns>
        private static char ValidarOperador(char operador)
        {
            if (operador == '+' || operador == '-' || operador == '*' || operador == '/')
            {
                return operador;
            }

            return '+';
        }
    }
}

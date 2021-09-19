using System;

namespace Entidades
{
    public class Operando
    {
        private double numero;

        #region Propiedades

        /// <summary>
        /// Propiedad que valida el valor y lo setea en el atributo numero.
        /// </summary>
        public string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }

        #endregion

        #region Constructores

        /// <summary>
        /// Constructor por defecto que inicializa el atributo numero en 0.
        /// </summary>
        public Operando() : this(0)
        {

        }

        /// <summary>
        /// Constructor que recibe un double como argumento.
        /// </summary>
        /// <param name="numero">Valor para inicializar el atributo número.</param>
        public Operando(double numero) : this(numero.ToString())
        {

        }

        /// <summary>
        /// Constructor que recibe un string como argumento.
        /// </summary>
        /// <param name="strNumero">Valor para inicializar el atributo número.</param>
        public Operando(string strNumero)
        {
            this.Numero = strNumero;
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Valida que el valor sea númerico.
        /// </summary>
        /// <param name="strNumero">Cadena a validar</param>
        /// <returns>El valor en formato double o 0 si la cadena no era un número. </returns>
        private double ValidarOperando(string strNumero)
        {
            double retorno;

            if (double.TryParse(strNumero, out retorno))
            {
                return retorno;
            }

            return 0;
        }

        /// <summary>
        /// Valida que el valor sea un número binario. Es decir, que este compuesta por solo 1 o 0.
        /// </summary>
        /// <param name="binario">Cadena a verficar</param>
        /// <returns>true si es un número binaro, false en caso contrario.</returns>
        private bool EsBinario(string binario)
        {
            foreach (char item in binario)
            {
                if (item != '1' && item != '0')
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Trata de convertir un número binario a un número decimal.
        /// </summary>
        /// <param name="binario">Binario a convertir</param>
        /// <returns>El número en tipo string convertido en decimal, mensaje de error en caso contrario.</returns>
        public string BinarioDecimal(string binario)
        {
            int numeroDecimal = 0;
            char[] binarioAux = binario.ToCharArray();
            Array.Reverse(binarioAux);

            if (EsBinario(binario))
            {
                for (int i = 0; i < binarioAux.Length; i++)
                {
                    if (binarioAux[i] == '1')
                    {
                        numeroDecimal += (int)Math.Pow(2, i);
                    }
                }

                return numeroDecimal.ToString();
            }

            return "Valor inválido";
        }

        /// <summary>
        /// Trata de convertir un número decimal a número binario.
        /// </summary>
        /// <param name="numero">Número en tipo double a pasar a binario</param>
        /// <returns>El número en tipo string convertido en binario, mensaje de error en caso contrario.</returns>
        public string DecimalBinario(double numero)
        {
            int numeroEntero = (int)numero;
            string binario = "";

            if (numeroEntero > 0) //Pedido por la consigna
            {
                for (int resto = numeroEntero % 2; numeroEntero > 0; numeroEntero /= 2, resto = numeroEntero % 2)
                {
                    binario = resto + binario;
                }

                if (EsBinario(binario))
                {
                    return binario;
                }
            }

            return "Valor inválido";
        }

        /// <summary>
        /// Trata de convertir un número decimal a número binario.
        /// </summary>
        /// <param name="numero">Número en tipo string a pasar a binario</param>
        /// <returns>El número en tipo string convertido en decimal, mensaje de error en caso contrario.</returns>
        public string DecimalBinario(string numero)
        {
            double auxNumero;

            if (double.TryParse(numero, out auxNumero))
            {
                return DecimalBinario(auxNumero);
            }

            return "Valor inválido";
        }

        #endregion

        #region Sobrecarga de operadores

        /// <summary>
        /// Resta los atributos numero de dos parámetros del tipo Operando.
        /// </summary>
        /// <param name="n1">Primero número</param>
        /// <param name="n2">Segundo número</param>
        /// <returns>Resta resultante</returns>
        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }

        /// <summary>
        /// Multiplica los atributos numero de dos parámetros del tipo Operando.
        /// </summary>
        /// <param name="n1">Primer número</param>
        /// <param name="n2">Segundo número</param>
        /// <returns>Multiplicación resultante</returns>
        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }

        /// <summary>
        /// Divide los atributos numero de dos parámetros del tipo Operando. 
        /// </summary>
        /// <param name="n1">Primer número</param>
        /// <param name="n2">Segundo número</param>
        /// <returns>División resultante o double.MinValue si el segundo número es 0.</returns>
        public static double operator /(Operando n1, Operando n2)
        {
            if (n2.numero != 0)
            {
                return n1.numero / n2.numero;
            }

            return double.MinValue;
        }

        /// <summary>
        /// Suma los atributos numero de dos parámetros del tipo Operando.
        /// </summary>
        /// <param name="n1">Primer número.</param>
        /// <param name="n2">Segundo número.</param>
        /// <returns>Suma resultante</returns>
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }

        #endregion
    }
}

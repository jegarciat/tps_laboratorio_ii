using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PolizaVida : Poliza, IFumador
    {
        private bool esFumador;

        public PolizaVida()
        {

        }

        public PolizaVida(string nombre, string apellido, int dni, ESexo sexo, int edad, double sumaAsegurada, bool esFumador) 
            : base(nombre, apellido, dni, sexo, edad, sumaAsegurada)
        {
            this.esFumador = esFumador;
            this.Costo = sumaAsegurada * CalcularTasa();
        }

        public bool Fumador
        {
            get
            {
                return this.esFumador;
            }
            set
            {
                this.esFumador = value;
            }
        }

        public double Costo
        {
            get
            {
                return Math.Round(this.sumaAsegurada * CalcularTasa(), 2);
            }
            set
            {
                this.costo = value;
            }
        }

        protected override float CalcularTasa()
        {
            int edad = this.Edad;

            if (this.esFumador)
            {
                return CalcularTasaFumador(edad);
            }
            else
            {
                return CalcularTasaNoFumador(edad);
            }
        }

        public float CalcularTasaFumador(int edad)
        {
            if (edad > 17 && edad < 30)
            {
                return 0.003F;
            }
            else if (edad > 29 && edad < 50)
            {
                return 0.004F;
            }
            else if (edad > 49 && edad < 60)
            {
                return 0.005F;
            }
            else
            {
                return 0.006F;
            }
        }

        public float CalcularTasaNoFumador(int edad)
        {
            if (edad > 17 && edad < 30)
            {
                return 0.0009F;
            }
            else if (edad > 29 && edad < 50)
            {
                return 0.001F;
            }
            else if (edad > 49 && edad < 60)
            {
                return 0.002F;
            }
            else
            {
                return 0.003F;
            }
        }

        public override string Informacion()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Poliza - Seguro de vida");
            sb.AppendLine(base.Informacion());
            sb.AppendLine($"Costo anual: {this.Costo}");

            return sb.ToString();
        }
    }
}

using System;
using System.Text;

namespace Entidades
{
    public class PolizaVehiculo : Poliza
    {
        private int anio;
        private ETipo tipo;

        public PolizaVehiculo()
        {

        }

        public PolizaVehiculo(string nombre, string apellido, int dni, ESexo sexo, int edad, double sumaAsegurada, int anio, ETipo tipo)
            : base(nombre, apellido, dni, sexo, edad, sumaAsegurada)
        {
            this.Anio = anio;
            this.tipo = tipo;
            this.Costo = sumaAsegurada * CalcularTasa();
        }

        public int Anio
        {
            get 
            { 
                return this.anio;
            }
            set
            {
                if (value >= 1980 && value <= DateTime.Now.Year)
                {
                    this.anio = value;
                }
                else
                {
                    throw new PolizaException("El año ingresado es inválido. Solo aseguramos vehiculos fabricados a partir del año 1980.");
                }
            }
        }

        public ETipo TipoVehiculo
        {
            get 
            { 
                return this.tipo; 
            }
            set 
            { 
                this.tipo = value; 
            }
        }

        public double Costo
        {
            get
            {
                return Math.Round(CalcularTasa() * this.sumaAsegurada, 2);
            }
            set
            {
                this.costo = value;
            }
        }

        /// <summary>
        /// Calcula la tasa a aplicar dependiendo de la antiguedad del vehiculo que se quiere asegurar.
        /// </summary>
        /// <returns></returns>
        protected override float CalcularTasa()
        {
            float tasa = 0.0008F;
            int antiguedad = Anio.CalcularAntiguedad();

            if (antiguedad > 0 && antiguedad <= 5)
            {
                tasa = 0.001F;
            }
            else if (antiguedad > 5 && antiguedad <= 10)
            {
                tasa = 0.002F;
            }
            else if(antiguedad > 10)
            {
                tasa = 0.005F;
            }

            return tasa;
        }

        /// <summary>
        /// Recopila y devuelve los datos de la póliza.
        /// </summary>
        /// <returns></returns>
        public override string Informacion()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Poliza - Seguro de vehiculo");
            sb.AppendLine(base.Informacion());
            sb.AppendLine($"Costo anual: {this.Costo}");
            sb.AppendLine($"Tipo de vehiculo: {this.TipoVehiculo}");
            sb.AppendLine($"Antiguedad del vehiculo: {Anio.CalcularAntiguedad()}");

            return sb.ToString();
        }
    }
}

using System;
using System.Text;
using System.Xml.Serialization;

namespace Entidades
{
    [XmlInclude(typeof(PolizaVehiculo))]
    [XmlInclude(typeof(PolizaVida))]
    public abstract class Poliza : IInformacion
    {
        private static int ultimoID;
        protected int id;
        protected string nombre;
        protected string apellido;
        protected int dni;
        protected ESexo sexo;
        protected int edad;
        protected double sumaAsegurada;
        protected double costo;

        static Poliza()
        {
            ultimoID = 0;
        }

        public Poliza()
        {

        }

        public Poliza(string nombre, string apellido, int dni, ESexo sexo, int edad, double sumaAsegurada)
        {
            ultimoID++;
            this.id = ultimoID;

            this.DNI = dni;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Sexo = sexo;
            this.Edad = edad;
            this.SumaAsegurada = sumaAsegurada;
        }

        public int DNI
        {
            get
            {
                return this.dni;
            }
            set
            {
                try
                {
                    if(value < 0)
                        throw new ClienteException("No puede haber un DNI negativo.");

                    if (value > 0 && value.DniUnico())
                    {
                        this.dni = value;
                    }
                }
                catch (ClienteException ex)
                {
                    throw new ClienteException($"Algo ha salido mal: DNI inválido. {ex.Message}");
                }
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.SoloLetras())
                {
                    this.nombre = value;
                }
                else
                {
                    throw new ClienteException("Algo ha salido mal: Nombre inválido");
                }
            }
        }

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.SoloLetras())
                {
                    this.apellido = value;
                }
                else
                {
                    throw new ClienteException("Algo ha salido mal: Apellido inválido");
                }
            }
        }

        public ESexo Sexo
        {
            get
            {
                return this.sexo;
            }
            set
            {
                this.sexo = value;
            }
        }

        public int Edad
        {
            get
            {
                return this.edad;
            }
            set
            {
                if (value > 17 && edad < 99)
                {
                    this.edad = value;
                }
                else
                {
                    throw new ClienteException("Algo ha salido mal: Edad inválida. Solo aseguramos a mayores de edad.");
                }
            }
        }        

        public double SumaAsegurada
        {
            get
            {
                return this.sumaAsegurada;
            }
            set
            {
                if (value > 200000)
                {
                    this.sumaAsegurada = value;
                }
                else
                {
                    throw new ClienteException("Algo ha salido mal: La suma asegurada no es válida. Aseguramos por un mínimo de 200.000$.");

                }
            }
        }

        protected abstract float CalcularTasa();

        /// <summary>
        /// Méodo que recopila y devuelve toda la información de la póliza.
        /// </summary>
        /// <returns></returns>
        public virtual string Informacion()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Fecha: {DateTime.Now.ToString("dd/MM/yyyy")}\n");
            sb.AppendLine($"Información del asegurado\n");
            sb.AppendLine($"DNI: {this.dni}");
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Apellido: {this.apellido}");
            sb.AppendLine($"Edad: {this.edad}");
            sb.AppendLine($"Sexo: {this.sexo}");
            sb.Append($"Suma asegurada anual: {this.sumaAsegurada}");

            return sb.ToString();
        }
    }
}

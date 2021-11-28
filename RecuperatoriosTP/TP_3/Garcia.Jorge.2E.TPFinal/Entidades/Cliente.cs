using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente
    {
        private string nombre;
        private string apellido;
        private int dni;
        private ESexo sexo;
        private int edad;

        public Cliente(string nombre, string apellido, int dni, ESexo sexo, int edad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.sexo = sexo;
            this.edad = edad;
        }

        public int DNI { get => dni; set => dni = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public ESexo Sexo { get => sexo; set => sexo = value; }
        public int Edad { get => edad; set => edad = value; }
    }
}

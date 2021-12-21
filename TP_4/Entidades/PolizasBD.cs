using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Entidades
{
    public static class PolizasBD
    {
        private static string conexionString;
        private static SqlCommand comando;
        private static SqlConnection conexion;
        private static SqlDataReader lectorBD;

        static PolizasBD()
        {
            conexionString = @"Server=.\SQLEXPRESS;Database=TP4_JorgeGarcia;Trusted_Connection=true;";
            conexion = new SqlConnection(conexionString);

            comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.Connection = conexion;
        }

        /// <summary>
        /// Se encarga de traer todas las pólizas de vida de la base de datos.
        /// </summary>
        /// <returns></returns>
        public static List<PolizaVida> TraerPolizasVida()
        {
            try
            {
                List<PolizaVida> polizas = new List<PolizaVida>();

                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                comando.CommandText = $"SELECT * FROM VIDA";
                lectorBD = comando.ExecuteReader();

                while (lectorBD.Read())
                {
                    polizas.Add(new PolizaVida(lectorBD["nombre"].ToString(),
                                                lectorBD["apellido"].ToString(),
                                                int.Parse(lectorBD["dni"].ToString()),
                                                (ESexo)int.Parse(lectorBD["sexo"].ToString()),
                                                int.Parse(lectorBD["edad"].ToString()),
                                                double.Parse(lectorBD["sumaAsegurada"].ToString()),
                                                bool.Parse(lectorBD["fumador"].ToString())));
                }

                lectorBD.Close();

                return polizas;
            }
            catch (Exception)
            {
                throw new Exception("Ocurrio un error al leer las polizas de vida desde la base de datos.");
            }
            finally
            {
                conexion.Close();
            }
        }

        /// <summary>
        /// Se encarga de traer todas las pólizas de vehiculos de la base de datos.
        /// </summary>
        /// <returns></returns>
        public static List<PolizaVehiculo> TraerPolizasVehiculo()
        {
            try
            {
                List<PolizaVehiculo> polizas = new List<PolizaVehiculo>();

                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                comando.CommandText = $"SELECT * FROM VEHICULOS";
                lectorBD = comando.ExecuteReader();

                while (lectorBD.Read())
                {
                    polizas.Add(new PolizaVehiculo(lectorBD["nombre"].ToString(),
                                                    lectorBD["apellido"].ToString(),
                                                    int.Parse(lectorBD["dni"].ToString()),
                                                    (ESexo)int.Parse(lectorBD["sexo"].ToString()),
                                                    int.Parse(lectorBD["edad"].ToString()),
                                                    double.Parse(lectorBD["sumaAsegurada"].ToString()),
                                                    int.Parse(lectorBD["anio"].ToString()),
                                                    (ETipo)int.Parse(lectorBD["tipo"].ToString())));
                }

                return polizas;
            }
            catch (Exception)
            {
                throw new Exception("Ocurrio un error al leer las polizas de vehiculos desde la base de datos.");
            }
            finally
            {
                conexion.Close();
            }
        }

        /// <summary>
        /// Se encarga de insertar una póliza de vida la base de datos.
        /// </summary>
        /// <param name="poliza"></param>
        /// <returns></returns>
        public static bool InsertarPolizaVida(PolizaVida poliza)
        {
            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                comando.Parameters.Clear();
                comando.CommandText = $"INSERT INTO VIDA VALUES (@dni, @nombre, @apellido, @sexo, @edad, @sumaAsegurada, @fumador)";
                comando.Parameters.AddWithValue("@dni", poliza.DNI);
                comando.Parameters.AddWithValue("@nombre", poliza.Nombre);
                comando.Parameters.AddWithValue("@apellido", poliza.Apellido);
                comando.Parameters.AddWithValue("@sexo", (int)poliza.Sexo);
                comando.Parameters.AddWithValue("@edad", poliza.Edad);
                comando.Parameters.AddWithValue("@sumaAsegurada", poliza.SumaAsegurada);
                comando.Parameters.AddWithValue("@fumador", poliza.Fumador);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                throw new Exception("Ocurrio un error al insertar la poliza de vida en la base de datos.");
            }
            finally
            {
                conexion.Close();
            }
        }

        /// <summary>
        /// Se encarga de insertar una póliza de vehiculo la base de datos.
        /// </summary>
        /// <param name="poliza"></param>
        /// <returns></returns>
        public static bool InsertarPolizaVehiculo(PolizaVehiculo poliza)
        {
            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                comando.Parameters.Clear();
                comando.CommandText = $"INSERT INTO VEHICULOS VALUES (@dni, @nombre, @apellido, @sexo, @edad, @sumaAsegurada, @anio, @tipo)";
                comando.Parameters.AddWithValue("@dni", poliza.DNI);
                comando.Parameters.AddWithValue("@nombre", poliza.Nombre);
                comando.Parameters.AddWithValue("@apellido", poliza.Apellido);
                comando.Parameters.AddWithValue("@sexo", (int)poliza.Sexo);
                comando.Parameters.AddWithValue("@edad", poliza.Edad);
                comando.Parameters.AddWithValue("@sumaAsegurada", poliza.SumaAsegurada);
                comando.Parameters.AddWithValue("@anio", poliza.Anio);
                comando.Parameters.AddWithValue("@tipo", (int)poliza.TipoVehiculo);
                comando.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                throw new Exception("Ocurrio un error al insertar la poliza de vehiculo en la base de datos.");
            }
            finally
            {
                conexion.Close();
            }
        }

        /// <summary>
        /// Se encarga de eliminar una póliza de vida la base de datos.
        /// </summary>
        /// <param name="dni"></param>
        public static void EliminarPolizaVida(int dni)
        {
            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                comando.Parameters.Clear();
                comando.CommandText = $"DELETE FROM dbo.vida WHERE dni = @dni";
                comando.Parameters.AddWithValue("@dni", dni);

                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Ocurrio un error al eliminar la poliza en la base de datos.");
            }
            finally
            {
                conexion.Close();
            }
        }

        /// <summary>
        /// Se encarga de eliminar una póliza de vida la base de datos.
        /// </summary>
        /// <param name="dni"></param>
        public static void EliminarPolizaVehiculo(int dni)
        {
            try
            {
                if (conexion.State != ConnectionState.Open)
                {
                    conexion.Open();
                }

                comando.Parameters.Clear();
                comando.CommandText = $"DELETE FROM dbo.vehiculos WHERE dni = @dni";
                comando.Parameters.AddWithValue("@dni", dni);

                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw new Exception("Ocurrio un error al eliminar la poliza en la base de datos.");
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}


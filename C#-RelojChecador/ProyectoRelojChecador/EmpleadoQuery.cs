using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRelojChecador
{
    public class EmpleadoQuery
    {

        //REGISTRA LOS EMPLEADOS 
        public static int AgregarEmpleado(Empleado empleado)
        {
            int retorno = 0;

            using (SqlConnection conexion = BDPrincipal.obtenerConexion())
            {
                string query = "INSERT INTO EMPLEADO (NOMBRE,APELLIDO_PATERNO,APELLIDO_MATERNO,EDAD,SEXO,PUESTO) VALUES ('" + empleado.nombre + "', '" + empleado.apellidoPaterno + "', '" + empleado.apellidoMaterno + "', " + empleado.edad + ", '" + empleado.sexo + "','" + empleado.puesto + "')";
                SqlCommand comando = new SqlCommand(query, conexion);

                retorno = comando.ExecuteNonQuery();

            }

            return retorno;

        }//FIN DE MI FUNCION 

        //MOSTRA EN EL DATA GRID 

        public static List<Empleado> MostrarRegistro()
        {
            List<Empleado> Lista = new List<Empleado>();

            using (SqlConnection conexion = BDPrincipal.obtenerConexion())
            {
                string query = "SELECT * FROM EMPLEADO";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Empleado empleado = new Empleado();

                    empleado.id = reader.GetInt32(0);
                    empleado.nombre = reader.GetString(1);
                    empleado.apellidoPaterno = reader.GetString(2);
                    empleado.apellidoMaterno = reader.GetString(3);
                    empleado.edad = reader.GetInt32(4);
                    empleado.sexo = reader.GetString(5);
                    empleado.puesto = reader.GetString(6);
                    Lista.Add(empleado);
                }

                conexion.Close();
                return Lista;

            }
        }//FIN DE LA FUNCION MOSTRAR REGISTRO


        public static int buscarEmpleado(int id)
        {
            int retorno = 0;

            using (SqlConnection conexion = BDPrincipal.obtenerConexion())
            {
                string query = "SELECT COUNT(1) FROM EMPLEADO WHERE ID_EMPLEADO_TE = @id";
                SqlCommand comando = new SqlCommand(query, conexion);
                comando.Parameters.AddWithValue("@id", id);

                // Abrimos la conexión antes de ejecutar el comando
                if (conexion.State == System.Data.ConnectionState.Closed)
                {
                    conexion.Open();
                }

                // ExecuteScalar devuelve el primer valor de la primera columna
                int count = (int)comando.ExecuteScalar();

                // Si count es mayor que 0, significa que encontró el registro
                retorno = (count > 0) ? 1 : 0;
            }

            return retorno;
        }// FIN BUSCAR EMPLEADO 


        public static List<Empleado> MostrarRegistroParticular(int argumentoId)
        {
            List<Empleado> Lista = new List<Empleado>();

            using (SqlConnection conexion = BDPrincipal.obtenerConexion())
            {
                string query = "SELECT * FROM EMPLEADO WHERE ID_EMPLEADO_TE = "+argumentoId+"";
                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Empleado empleado = new Empleado();

                    empleado.id = reader.GetInt32(0);
                    empleado.nombre = reader.GetString(1);
                    empleado.apellidoPaterno = reader.GetString(2);
                    empleado.apellidoMaterno = reader.GetString(3);
                    empleado.edad = reader.GetInt32(4);
                    empleado.sexo = reader.GetString(5);
                    empleado.puesto = reader.GetString(6);
                    Lista.Add(empleado);
                }

                conexion.Close();
                return Lista;

            }
        }//FIN DE LA FUNCION MOSTRAR REGISTRO PARTICULAR


        public static List<Empleado> MostrarRegistroJoin(int argumentoId,string argumentoFecha)
        {
            List<Empleado> Lista = new List<Empleado>();

            using (SqlConnection conexion = BDPrincipal.obtenerConexion())
            {
                string query = "SELECT * FROM EMPLEADO EMP JOIN CHECADA CHE ON EMP.ID_EMPLEADO_TE = CHE.ID_EMPLEADO_TC WHERE EMP.ID_EMPLEADO_TE = " + argumentoId+" AND CHE.FECHA = '"+argumentoFecha+"'";

                SqlCommand comando = new SqlCommand(query, conexion);

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    Empleado empleado = new Empleado();
                

                    empleado.id = reader.GetInt32(0);
                    empleado.nombre = reader.GetString(1);
                    empleado.apellidoPaterno = reader.GetString(2);
                    empleado.apellidoMaterno = reader.GetString(3);
                    empleado.edad = reader.GetInt32(4);
                    empleado.sexo = reader.GetString(5);
                    empleado.puesto = reader.GetString(6);
                    Lista.Add(empleado);
                }

                conexion.Close();
                return Lista;

            }
        }//FIN DE LA FUNCION MOSTRAR REGISTRO PARTICULAR

        //ELIMINAR EMPLEADO 

        //ELIMINAR EMPLEADO 
        public static int eliminarEmpleado(int parametroid)
        {
            int retorno = 0;

            using (SqlConnection conexion = BDPrincipal.obtenerConexion())
            {
                string query = "DELETE FROM EMPLEADO WHERE ID_EMPLEADO_TE = " + parametroid + "";

                SqlCommand comando = new SqlCommand(query, conexion);

                retorno = comando.ExecuteNonQuery();

            }

            return retorno;

        }// END ELIMANR EMPLEADO


        //MODIFICAR EMPLEADO 

        public static Empleado ModificarEmpleado(int idEmpleado)
        {
            string query = "SELECT NOMBRE, APELLIDO_PATERNO, APELLIDO_MATERNO, EDAD, SEXO, PUESTO FROM EMPLEADO WHERE ID_EMPLEADO_TE = @id";
            Empleado empleado = null;

            using (SqlConnection conexion = BDPrincipal.obtenerConexionAlternativa())
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.AddWithValue("@id", idEmpleado);

                    using (SqlDataReader reader = comando.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            empleado = new Empleado
                            {
                                nombre = reader["NOMBRE"].ToString(),
                                apellidoPaterno = reader["APELLIDO_PATERNO"].ToString(),
                                apellidoMaterno = reader["APELLIDO_MATERNO"].ToString(),
                                edad = Convert.ToInt32(reader["EDAD"]),
                                sexo = reader["SEXO"].ToString(),
                                puesto = reader["PUESTO"].ToString()
                            };
                        }
                    }
                }
            }

            return empleado;
        }//FIN DE MI FUNCION 


        //REGISTRA LOS EMPLEADOS 
        public static int ModificarEmpleadoCambios(int id, String nombre, String apellidoP, String apellidoM, int edad, String sexo, String puesto)
        {
            int retorno = 0;

            using (SqlConnection conexion = BDPrincipal.obtenerConexion())
            {
                string query = "update EMPLEADO set NOMBRE = '" + nombre + "', APELLIDO_PATERNO = '" + apellidoP + "', APELLIDO_MATERNO = '" + apellidoM + "', EDAD = " + edad + ", SEXO = '" + sexo + "',PUESTO = '" + puesto + "' where ID_EMPLEADO_TE = " + id + "";
                SqlCommand comando = new SqlCommand(query, conexion);

                retorno = comando.ExecuteNonQuery();

            }

            return retorno;

        }//FIN DE MI FUNCION 

        





























    }//END CLASS
}

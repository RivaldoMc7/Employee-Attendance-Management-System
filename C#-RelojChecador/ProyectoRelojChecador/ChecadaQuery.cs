using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoRelojChecador
{
    public class ChecadaQuery
    {
        //REGISTRAR CHECADA 
        public static int AgregarChecada(Checada checada) 
        {
            int retorno = 0;



            using (SqlConnection conexion = BDPrincipal.obtenerConexion()) 
            {

                string query = "INSERT INTO CHECADA (ID_EMPLEADO_TC,HORA,FECHA) VALUES("
                    + checada.id + ",'" + checada.hora + "','" + checada.fecha + "');";

                SqlCommand comando = new SqlCommand(query, conexion);

                retorno = comando.ExecuteNonQuery();

            }

            return retorno;
        
        }//FIN DE AGREGAR CHACADAS


        public static int AgregarChecada2(Checada checada)
        {
            int retorno = 0;


                using (SqlConnection conexion = BDPrincipal.obtenerConexion())
            {

                string query = "INSERT INTO CHECADA (ID_EMPLEADO_TC,HORA,FECHA) VALUES("
                    + checada.id + ",'" + checada.hora + "','" + checada.fecha + "');";

                SqlCommand comando = new SqlCommand(query, conexion);

                retorno = comando.ExecuteNonQuery();

            }

            return retorno;

        }//FIN DE AGREGAR CHACADAS


        //ELIMINAR EMPLEADO 
        public static int eliminarChecadaEmpleado(int parametroid) 
        {
            int retorno = 0;

            using (SqlConnection conexion = BDPrincipal.obtenerConexion()) 
            {
                string query = "DELETE FROM CHECADA WHERE ID_EMPLEADO_TC = "+parametroid+"";

                SqlCommand comando = new SqlCommand(query, conexion);

                retorno = comando.ExecuteNonQuery();

            }

            return retorno;

        }// END ELIMANR EMPLADO

        //PRUEBAS /////////////////////////////////////////////////////////////////////////////////

        public static int eliminarChecadaBonoEmpleado(int parametroid)
        {
            int retorno = 0;

            using (SqlConnection conexion = BDPrincipal.obtenerConexion())
            {
                string query = "DELETE FROM CHECADABONO WHERE ID_EMPLEADO_TB = " + parametroid + "";

                SqlCommand comando = new SqlCommand(query, conexion);

                retorno = comando.ExecuteNonQuery();

            }

            return retorno;

        }// END ELIMANR EMPLADO



        public static int ContarChecadas(int id)
        {
            int retorno = 0;

            using (SqlConnection conexion = BDPrincipal.obtenerConexion())
            {
                string fechaActual = DateTime.Now.ToString("yyyy-MM-dd");

                string query = @"SELECT COUNT(*) 
                         FROM CHECADA 
                         WHERE ID_EMPLEADO_TC = @id
                         AND FECHA = @fecha";

                SqlCommand comando = new SqlCommand(query, conexion);

                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@fecha", fechaActual);

                retorno = Convert.ToInt32(comando.ExecuteScalar());
            }

            return retorno;
        }//fin

        public static int AgregarChecadaBono(int id,String fecha,int indicador)
        {
            int retorno = 0;

            using (SqlConnection conexion = BDPrincipal.obtenerConexion())
            {
                string query = "INSERT INTO CHECADABONO (ID_EMPLEADO_TB,FECHA,BONO) VALUES(" + id + ",'" + fecha + "'," + indicador + ");";

                SqlCommand comando = new SqlCommand(query, conexion);

                retorno = comando.ExecuteNonQuery();

            }

            return retorno;

        }//FIN DE AGREGAR CHACADAS






    }//FIN DE MI CLASE
}

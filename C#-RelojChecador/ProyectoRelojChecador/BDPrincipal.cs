using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoRelojChecador
{
    public class BDPrincipal
    {

        public static SqlConnection obtenerConexion()
        {
            SqlConnection conexion = new SqlConnection(
                "Data Source=localhost;Initial Catalog=BD_RELOJ_C;Integrated Security=True;TrustServerCertificate=True"
            );

            conexion.Open();
            return conexion;
        }

        public static SqlConnection obtenerConexionAlternativa()
        {
            return new SqlConnection(
            "Data Source=localhost;Initial Catalog=BD_RELOJ_C;Integrated Security=True;TrustServerCertificate=True"
            );
        }



    }
}

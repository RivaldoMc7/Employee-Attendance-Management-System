
package app;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

public class BDPrincipal 
{
    public static Connection obtenerConexion()
    {
        String conexionUrl = "jdbc:sqlserver://localhost:1433;"
            + "databaseName=BD_RELOJ_C;"
            + "user=reloj_user;"
            + "password=Reloj12345!;"
            + "trustServerCertificate=true;"
            + "loginTimeout=30;";
        try
        {
            Connection con = DriverManager.getConnection(conexionUrl);
            return con;
        }catch(SQLException ex)
            {
                System.out.println(ex.toString());
                return null;
                
            }  
        
    }//FIN DE LA FUNCION CONEXION 
    
}//FIN DE MI CLASE

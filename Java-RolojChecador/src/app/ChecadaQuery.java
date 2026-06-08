
package app;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import javax.swing.JOptionPane;

public class ChecadaQuery 
{
    public void AgregarChecada(Checada checada)
    {
            
        try
        {
            Connection con = BDPrincipal.obtenerConexion();
            PreparedStatement pa = con.prepareStatement(
            "INSERT INTO CHECADA (ID_EMPLEADO_TC, HORA, FECHA) VALUES (?, ?, ?)"
            );
            
            pa.setInt(1, checada.getId());        
            pa.setString(2, checada.getHora());      
            pa.setString(3, checada.getFecha());        
            pa.executeUpdate();
            JOptionPane.showMessageDialog(null, "Haz Checado");
        
        }catch(SQLException e)
              {
                  JOptionPane.showMessageDialog(null, e.toString());
              }
        
    }//FIN DE MI AGREGAR CHECADA
    
    //ELIMINAR CHECADA 
    
    public void EliminarChecada(int parametroid)
     {
         ResultSet resultado = null;
        

    try {
        // Preparar conexión y consulta
        Connection conexion = BDPrincipal.obtenerConexion();
        String consulta = "DELETE FROM CHECADA WHERE ID_EMPLEADO_TC = ?";
        PreparedStatement sql = conexion.prepareStatement(consulta);

        // Asignar valor al parámetro
        sql.setInt(1, parametroid);

        // Ejecutar la consulta
        resultado = sql.executeQuery();

    } catch (SQLException ex) {
       // JOptionPane.showMessageDialog(null, ex.toString());
    }
     
     }//FIN DE MI FUNCION 
    
    /////PRUEBA
    
    public void EliminarChecadaBono(int parametroid)
     {
         ResultSet resultado = null;
        

    try {
        // Preparar conexión y consulta
        Connection conexion = BDPrincipal.obtenerConexion();
        String consulta = "DELETE FROM CHECADABONO WHERE ID_EMPLEADO_TB = ?";
        PreparedStatement sql = conexion.prepareStatement(consulta);

        // Asignar valor al parámetro
        sql.setInt(1, parametroid);

        // Ejecutar la consulta
        resultado = sql.executeQuery();

    } catch (SQLException ex) {
       // JOptionPane.showMessageDialog(null, ex.toString());
    }
     
     }//FIN DE MI FUNCION 
    
    public void AgregarChecadaBono(int id,String fecha,int bono)
    {
            
        try
        {
            Connection con = BDPrincipal.obtenerConexion();
            PreparedStatement pa = con.prepareStatement(
            "INSERT INTO CHECADABONO (ID_EMPLEADO_TB,FECHA,BONO) VALUES (?, ?, ?)"
            );
            
            pa.setInt(1, id);        
            pa.setString(2, fecha);      
            pa.setInt(3, bono);        
            pa.executeUpdate();
            //JOptionPane.showMessageDialog(null, "Haz Checado");
        
        }catch(SQLException e)
              {
                  JOptionPane.showMessageDialog(null, e.toString());
              }
        
    }//FIN DE MI AGREGAR CHECADA BONO 
    
    /////////////////////
    
     public int ContarChecadas(int id) {
        int retorno = 0;
        Connection conexion = null;
        PreparedStatement comando = null;
        ResultSet resultado = null;

        try {
            // Obtener conexión
            conexion = BDPrincipal.obtenerConexion(); // Asegúrate de implementar este método
            String query = "SELECT COUNT(*) FROM CHECADA WHERE ID_EMPLEADO_TC = ?";
            comando = conexion.prepareStatement(query);
            comando.setInt(1, id); // Configurar el parámetro

            // Ejecutar la consulta
            resultado = comando.executeQuery();
            if (resultado.next()) {
                retorno = resultado.getInt(1); // Obtener el primer valor de la primera fila
            }
        } catch (SQLException e) {
            e.printStackTrace(); // Manejo de excepciones
        } finally {
            // Cerrar recursos
            try {
                if (resultado != null) resultado.close();
                if (comando != null) comando.close();
                if (conexion != null) conexion.close();
            } catch (SQLException e) {
                e.printStackTrace();
            }
        }

        return retorno;
    }
    
    
    
    
    
}//FIN DE MI CLASE 



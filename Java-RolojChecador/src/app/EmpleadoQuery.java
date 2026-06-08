
package app;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.SQLException;
import javax.swing.JOptionPane;
import java.sql.*;
import java.util.ArrayList;
import java.util.List;
import javax.swing.JTable;
import javax.swing.table.DefaultTableModel;


public class EmpleadoQuery 
{
    
    public void AgregarEmpleado(Empleado empleado)
    {
            
        try
        {
            Connection con = BDPrincipal.obtenerConexion();
            PreparedStatement pa = con.prepareStatement(
            "INSERT INTO EMPLEADO (NOMBRE, APELLIDO_PATERNO, APELLIDO_MATERNO, EDAD, SEXO, PUESTO) VALUES (?, ?, ?, ?, ?, ?)"
            );
            
            pa.setString(1, empleado.getNombre());        
            pa.setString(2, empleado.getApellidoPaterno());      
            pa.setString(3, empleado.getApellidoMaterno());       
            pa.setInt(4, empleado.getEdad());                 
            pa.setString(5, empleado.getSexo());   
            pa.setString(6, empleado.getPuesto());  
            pa.executeUpdate();
            JOptionPane.showMessageDialog(null, "Resgistro Guardado");
        
        }catch(SQLException e)
              {
                  JOptionPane.showMessageDialog(null, e.toString());
              }
        
    }//FIN DE MI AGREGAR EMPLEADO 
    
    /////
    
    public void mostrarEmpleado(JTable paramTableEmpleado)
    {
        BDPrincipal objetoConexion = new BDPrincipal();
        
        DefaultTableModel modelo = new DefaultTableModel();
        
        String sql = "";
        
        modelo.addColumn("Id");
        modelo.addColumn("Nombre");
        modelo.addColumn("Apellido Paterno");
        modelo.addColumn("Apellido Materno");
        modelo.addColumn("Edad");
        modelo.addColumn("Sexo");
        modelo.addColumn("Puesto");
        
        paramTableEmpleado.setModel(modelo);
        
        sql= "select * from EMPLEADO;";
        
        String [] datos = new String[7];
        
        Statement st;
        
       
        
        try
        {
            st = objetoConexion.obtenerConexion().createStatement();
            ResultSet rs = st.executeQuery(sql);
            
            while(rs.next())
            {
                datos[0]=rs.getString(1);
                datos[1]=rs.getString(2);
                datos[2]=rs.getString(3);
                datos[3]=rs.getString(4);
                datos[4]=rs.getString(5);
                datos[5]=rs.getString(6);
                datos[6]=rs.getString(7);
                modelo.addRow(datos);
                
            }
            paramTableEmpleado.setModel(modelo);
            
            
        }catch(Exception e)
            {
                JOptionPane.showMessageDialog(null, e.toString());
            
            }
        
        
    
    }//FIN DE MI METODO 
    
     public ResultSet BuscarEmpleado(int parametroid)
     {
         ResultSet resultado = null;
        //int parametroid = 1; // Valor del parámetro a buscar

    try {
        // Preparar conexión y consulta
        Connection conexion = BDPrincipal.obtenerConexion();
        String consulta = "SELECT * FROM EMPLEADO WHERE ID_EMPLEADO_TE = ?";
        PreparedStatement sql = conexion.prepareStatement(consulta);

        // Asignar valor al parámetro
        sql.setInt(1, parametroid);

        // Ejecutar la consulta
        resultado = sql.executeQuery();

    } catch (SQLException ex) {
        JOptionPane.showMessageDialog(null, ex.toString());
    }
    
    return resultado;
     
     }//FIN DE MI FUNCION 
     
     ///////////////////////////////////////////////////////////////// 
     
     public void mostrarEmpleadoParticula(JTable paramTableEmpleado, int parametroId) {
    BDPrincipal objetoConexion = new BDPrincipal();
    DefaultTableModel modelo = new DefaultTableModel();

    // Definir columnas del modelo
    modelo.addColumn("Id");
    modelo.addColumn("Nombre");
    modelo.addColumn("Apellido Paterno");
    modelo.addColumn("Apellido Materno");
    modelo.addColumn("Edad");
    modelo.addColumn("Sexo");
    modelo.addColumn("Puesto");

    paramTableEmpleado.setModel(modelo);

    // Consulta SQL
    String consulta = "SELECT * FROM EMPLEADO WHERE ID_EMPLEADO_TE = ?";

    try (Connection conexion = objetoConexion.obtenerConexion();
         PreparedStatement pst = conexion.prepareStatement(consulta)) {

        // Asignar valor al parámetro
        pst.setInt(1, parametroId);

        // Ejecutar la consulta
        ResultSet rs = pst.executeQuery();

        // Array para almacenar los datos de cada fila
        String[] datos = new String[7];

        // Rellenar el modelo con los datos
        while (rs.next()) {
            datos[0] = rs.getString(1); // ID
            datos[1] = rs.getString(2); // Nombre
            datos[2] = rs.getString(3); // Apellido Paterno
            datos[3] = rs.getString(4); // Apellido Materno
            datos[4] = rs.getString(5); // Edad
            datos[5] = rs.getString(6); // Sexo
            datos[6] = rs.getString(7); // Puesto

            modelo.addRow(datos);
        }

        // Establecer el modelo final en la tabla
        paramTableEmpleado.setModel(modelo);

    } catch (SQLException e) {
        JOptionPane.showMessageDialog(null, "Error al mostrar los datos: " + e.toString());
    }
}// MOSTRAR EMPLEADO PARTICULAR 
     
public void mostrarEmpleadoJoin(JTable paramTableEmpleado, int parametroId, String parámetroFecha) {
    BDPrincipal objetoConexion = new BDPrincipal();
    DefaultTableModel modelo = new DefaultTableModel();

    // Definir columnas del modelo
    modelo.addColumn("Id");
    modelo.addColumn("Nombre");
    modelo.addColumn("Apellido Paterno");
    modelo.addColumn("Apellido Materno");
    modelo.addColumn("Hora");
    modelo.addColumn("Fecha");
    
    paramTableEmpleado.setModel(modelo);

    // Consulta SQL
    String consulta = "SELECT EMP.ID_EMPLEADO_TE, EMP.NOMBRE, EMP.APELLIDO_PATERNO, EMP.APELLIDO_MATERNO, CHE.HORA, CHE.FECHA FROM EMPLEADO EMP JOIN CHECADA CHE ON EMP.ID_EMPLEADO_TE = CHE.ID_EMPLEADO_TC WHERE EMP.ID_EMPLEADO_TE = ? AND CHE.FECHA = ?";

    try (Connection conexion = objetoConexion.obtenerConexion();
         PreparedStatement pst = conexion.prepareStatement(consulta)) {

        // Asignar valor al parámetro
        pst.setInt(1, parametroId);
	pst.setString(2, parámetroFecha);

        // Ejecutar la consulta
        ResultSet rs = pst.executeQuery();

        // Array para almacenar los datos de cada fila
        String[] datos = new String[6];

        // Rellenar el modelo con los datos
        while (rs.next()) {
            datos[0] = rs.getString(1); // ID
            datos[1] = rs.getString(2); // Nombre
            datos[2] = rs.getString(3); // Apellido Paterno
            datos[3] = rs.getString(4); // Apellido Materno
            datos[4] = rs.getString(5); // Hora
            datos[5] = rs.getString(6); // Fecha

            modelo.addRow(datos);
        }

        // Establecer el modelo final en la tabla
        paramTableEmpleado.setModel(modelo);

    } catch (SQLException e) {
        JOptionPane.showMessageDialog(null, "Error al mostrar los datos: " + e.toString());
    }
}// MOSTRAR EMPLEADO JOIN

public void EliminarEmpleado(int parametroid)
     {
         ResultSet resultado = null;
        

    try {
        // Preparar conexión y consulta
        Connection conexion = BDPrincipal.obtenerConexion();
        String consulta = "DELETE FROM EMPLEADO WHERE ID_EMPLEADO_TE = ?";
        PreparedStatement sql = conexion.prepareStatement(consulta);

        // Asignar valor al parámetro
        sql.setInt(1, parametroid);

        // Ejecutar la consulta
        resultado = sql.executeQuery();

    } catch (SQLException ex) {
        //JOptionPane.showMessageDialog(null, ex.toString());
    }
    
    //return resultado;
     
     }//FIN DE MI FUNCION 

    //////////////////////

    public void modificarEmpleado(String nombreP,String apellidoPP,String apellidoMP,int edadP,String sexoP,String puestoP,int idParametro)
    {
            
        try
        {
            Connection con = BDPrincipal.obtenerConexion();
            PreparedStatement pa = con.prepareStatement(
            "UPDATE EMPLEADO SET NOMBRE = ?, APELLIDO_PATERNO = ?, APELLIDO_MATERNO = ?, EDAD = ?, SEXO = ?, PUESTO = ? WHERE ID_EMPLEADO_TE = ?"
            );
            
            pa.setString(1, nombreP);        
            pa.setString(2, apellidoPP);      
            pa.setString(3, apellidoMP);       
            pa.setInt(4, edadP);                 
            pa.setString(5, sexoP);   
            pa.setString(6, puestoP);  
            pa.setInt(7, idParametro);
            pa.executeUpdate();
            JOptionPane.showMessageDialog(null, "Cambios Agregados");
        
        }catch(SQLException e)
              {
                  JOptionPane.showMessageDialog(null,"AAAAA"+ e.toString());
              }
        
    }//FIN DE MI AGREGAR EMPLEADO 
     
     

     
     
    
    
    
    
    
    
    
    
    
    
}//FIN DE MI CLASE 


package app;

import java.sql.ResultSet;
import java.sql.SQLException;
import javax.swing.JOptionPane;


public class FrmBuscarEmpleado extends javax.swing.JFrame {
    //VARIABLE BUSCAR GLOBAL
    int variableGlobalId;

    
    public FrmBuscarEmpleado() {
        initComponents();
        EmpleadoQuery empleadoquery = new EmpleadoQuery();
        empleadoquery.mostrarEmpleadoParticula(tableBuscarEmpleado, variableGlobalId);
        
        
        
    }

    
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jPanel1 = new javax.swing.JPanel();
        jLabel1 = new javax.swing.JLabel();
        txtBoxBuscarEmpleado = new javax.swing.JTextField();
        btnBuscarEmpleado = new javax.swing.JButton();
        btnRegresar = new javax.swing.JButton();
        jScrollPane1 = new javax.swing.JScrollPane();
        tableBuscarEmpleado = new javax.swing.JTable();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        jLabel1.setText("Id Empleado:");

        btnBuscarEmpleado.setText("Buscar");
        btnBuscarEmpleado.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnBuscarEmpleadoActionPerformed(evt);
            }
        });

        btnRegresar.setText("Regresar");
        btnRegresar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnRegresarActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout jPanel1Layout = new javax.swing.GroupLayout(jPanel1);
        jPanel1.setLayout(jPanel1Layout);
        jPanel1Layout.setHorizontalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addContainerGap(53, Short.MAX_VALUE)
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel1Layout.createSequentialGroup()
                        .addComponent(jLabel1)
                        .addGap(18, 18, 18)
                        .addComponent(txtBoxBuscarEmpleado, javax.swing.GroupLayout.PREFERRED_SIZE, 336, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(29, 29, 29))
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel1Layout.createSequentialGroup()
                        .addComponent(btnBuscarEmpleado)
                        .addGap(150, 150, 150))
                    .addComponent(btnRegresar, javax.swing.GroupLayout.Alignment.TRAILING)))
        );
        jPanel1Layout.setVerticalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addComponent(btnRegresar)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 32, Short.MAX_VALUE)
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(txtBoxBuscarEmpleado, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel1))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(btnBuscarEmpleado)
                .addGap(8, 8, 8))
        );

        tableBuscarEmpleado.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {
                {},
                {},
                {},
                {}
            },
            new String [] {

            }
        ));
        jScrollPane1.setViewportView(tableBuscarEmpleado);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addComponent(jPanel1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(0, 0, Short.MAX_VALUE))
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jScrollPane1)
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addComponent(jPanel1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(18, 18, 18)
                .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 108, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(46, Short.MAX_VALUE))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

//FUNCION BUCAR 
    private void btnBuscarEmpleadoActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnBuscarEmpleadoActionPerformed
        
        String verificaciones = txtBoxBuscarEmpleado.getText().trim();
        int bandera = 0;
        
        
        if (verificaciones.isEmpty()) 
            {
                JOptionPane.showMessageDialog(null, "EL campo id esta vacio");
                
            }else
                {
                   try {
                        Integer.parseInt(verificaciones); // Intentar convertir a entero
                           variableGlobalId = Integer.parseInt(txtBoxBuscarEmpleado.getText());// Si no lanza excepción, es un entero válido
                           bandera = 1;
                        } catch (NumberFormatException e) 
                            {
                          JOptionPane.showMessageDialog(null, "El campo tiene una letra");                                  // No es un entero válido
                            }
                }
        
        EmpleadoQuery empleadoquery = new EmpleadoQuery(); 
        
        
        
        //SEGUNDA VERIFICACION
        if (bandera == 1)
        {
            ResultSet resultado = empleadoquery.BuscarEmpleado(variableGlobalId);
            empleadoquery.mostrarEmpleadoParticula(tableBuscarEmpleado, variableGlobalId);
            
            try {
                    if (resultado != null && resultado.next()) 
                        {
            
                            JOptionPane.showMessageDialog(null, "id encontrado");
                            txtBoxBuscarEmpleado.setText("");
            
                        } else {
                                    // No hay resultados
                                    JOptionPane.showMessageDialog(null, "El id empleado no es valido");
                                    txtBoxBuscarEmpleado.setText("");
                               }
                } catch (SQLException e) {
                                            JOptionPane.showMessageDialog(null,  e.toString());
                                         }
            
        }
        
          
        
    }//GEN-LAST:event_btnBuscarEmpleadoActionPerformed

    private void btnRegresarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnRegresarActionPerformed
        ChecadorPrincipal c = new ChecadorPrincipal();
             this.dispose();
            c.setVisible(true); 
    }//GEN-LAST:event_btnRegresarActionPerformed
 // FIN DE MI FUNCION
    
    public static void main(String args[]) {
        
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new FrmBuscarEmpleado().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnBuscarEmpleado;
    private javax.swing.JButton btnRegresar;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JTable tableBuscarEmpleado;
    private javax.swing.JTextField txtBoxBuscarEmpleado;
    // End of variables declaration//GEN-END:variables
}

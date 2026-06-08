
package app;

import java.sql.ResultSet;
import java.sql.SQLException;
import javax.swing.JOptionPane;


public class FrmEliminarEmpleado extends javax.swing.JFrame {

    public FrmEliminarEmpleado() {
        initComponents();
    }

    
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jPanel1 = new javax.swing.JPanel();
        jLabel1 = new javax.swing.JLabel();
        txtBoxId = new javax.swing.JTextField();
        btnElimnar = new javax.swing.JButton();
        jScrollPane1 = new javax.swing.JScrollPane();
        tableEliminarEmpleado = new javax.swing.JTable();
        btnRegresar = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        jLabel1.setText("Id Empleado:");

        btnElimnar.setText("ELIMINAR");
        btnElimnar.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                btnElimnarActionPerformed(evt);
            }
        });

        tableEliminarEmpleado.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {
                {},
                {},
                {},
                {}
            },
            new String [] {

            }
        ));
        jScrollPane1.setViewportView(tableEliminarEmpleado);

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
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addComponent(btnRegresar)
                    .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                        .addGroup(jPanel1Layout.createSequentialGroup()
                            .addGap(29, 29, 29)
                            .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                        .addGroup(jPanel1Layout.createSequentialGroup()
                            .addGap(23, 23, 23)
                            .addComponent(jLabel1, javax.swing.GroupLayout.PREFERRED_SIZE, 119, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                            .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                .addComponent(txtBoxId, javax.swing.GroupLayout.PREFERRED_SIZE, 297, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addComponent(btnElimnar)))))
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );
        jPanel1Layout.setVerticalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(btnRegresar)
                .addGap(37, 37, 37)
                .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(txtBoxId, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel1))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 28, Short.MAX_VALUE)
                .addComponent(btnElimnar)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 144, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(28, 28, 28))
        );

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addComponent(jPanel1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(0, 8, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(jPanel1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void btnElimnarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnElimnarActionPerformed
        ChecadaQuery checadaquery = new ChecadaQuery();
        EmpleadoQuery empleadoquery = new EmpleadoQuery();
        
        int idLocal = 0;
        
        
        
         String verificaciones = txtBoxId.getText().trim();
        int bandera = 0;
        
        
        if (verificaciones.isEmpty()) 
            {
                JOptionPane.showMessageDialog(null, "EL campo id esta vacio");
                
            }else
                {
                   try {
                        Integer.parseInt(verificaciones); // Intentar convertir a entero
                           idLocal = Integer.parseInt(txtBoxId.getText());// Si no lanza excepción, es un entero válido
                           bandera = 1; 
                        } catch (NumberFormatException e) 
                            {
                          JOptionPane.showMessageDialog(null, "El campo tiene una letra");                                  // No es un entero válido
                            }
                }
        
        
        
        
        //SEGUNDA VERIFICACION
        if (bandera == 1)
        {
            ResultSet resultado = empleadoquery.BuscarEmpleado(idLocal);
            empleadoquery.mostrarEmpleadoParticula(tableEliminarEmpleado, idLocal);
            
            try {
                    if (resultado != null && resultado.next()) 
                        {
                            checadaquery.EliminarChecada(idLocal);
                            checadaquery.EliminarChecadaBono(idLocal);
                            empleadoquery.EliminarEmpleado(idLocal);
                            JOptionPane.showMessageDialog(null, "Empleado Eliminado");
                            empleadoquery.mostrarEmpleadoParticula(tableEliminarEmpleado, idLocal);
                            txtBoxId.setText("");
            
                        } else {
                                    // No hay resultados
                                    JOptionPane.showMessageDialog(null, "El id empleado no es valido");
                                    txtBoxId.setText("");
                               }
                } catch (SQLException e) {
                                            JOptionPane.showMessageDialog(null,  e.toString());
                                         }
            
        }
        
        
        
        
        
        
    }//GEN-LAST:event_btnElimnarActionPerformed

    private void btnRegresarActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_btnRegresarActionPerformed
        ChecadorPrincipal c = new ChecadorPrincipal();
        this.dispose();
        c.setVisible(true);
    }//GEN-LAST:event_btnRegresarActionPerformed

   
    public static void main(String args[]) {
        
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new FrmEliminarEmpleado().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton btnElimnar;
    private javax.swing.JButton btnRegresar;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JTable tableEliminarEmpleado;
    private javax.swing.JTextField txtBoxId;
    // End of variables declaration//GEN-END:variables
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoRelojChecador
{
    public partial class FrmAgregarEmpleado : Form
    {
        public FrmAgregarEmpleado()
        {
            InitializeComponent();
        }

        private void FrmAgregarEmpleado_Load(object sender, EventArgs e)
        {
            dataGridViewAgregarEmp.DataSource = EmpleadoQuery.MostrarRegistro();
        }


        //REGISTRAR NUEVO EMPLEADO
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Empleado empleado = new Empleado();

            if (!string.IsNullOrEmpty(txtBoxName.Text) && !string.IsNullOrEmpty(txtBoxLastNameP.Text) && !string.IsNullOrEmpty(txtBoxLastNameM.Text) && !string.IsNullOrEmpty(txtBoxAge.Text) && int.TryParse(txtBoxAge.Text, out int idBtnOk) && !string.IsNullOrEmpty(txtBoxSex.Text) && !string.IsNullOrEmpty(txtBoxOcupation.Text))
            {
                empleado.nombre = txtBoxName.Text;
                empleado.apellidoPaterno = txtBoxLastNameP.Text;
                empleado.apellidoMaterno = txtBoxLastNameM.Text;
                empleado.edad = Convert.ToInt32(txtBoxAge.Text);
                empleado.sexo = txtBoxSex.Text;
                empleado.puesto = txtBoxOcupation.Text;

                int result = EmpleadoQuery.AgregarEmpleado(empleado);

                if (result != 0)
                {
                    MessageBox.Show("El empleado se a registrado correctamente! ");

                    dataGridViewAgregarEmp.DataSource = EmpleadoQuery.MostrarRegistro();

                    txtBoxName.Text = "";
                    txtBoxLastNameP.Text = "";
                    txtBoxLastNameM.Text = "";
                    txtBoxAge.Text = "";
                    txtBoxSex.Text = "";
                    txtBoxOcupation.Text = "";

                }
                else
                {

                    MessageBox.Show("No se realizo el registro");
                }


            }
            else 
            {
                MessageBox.Show("LLene todos los campos porfavor o Digite un valor numerico en el campo Edad");

            }

           

        }//FIN DE LA FUNCION 

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}

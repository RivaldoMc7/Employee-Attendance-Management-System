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
    public partial class FrmModificarEmpleado : Form
    {



        public FrmModificarEmpleado()
        {
            InitializeComponent();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {


            if (!string.IsNullOrEmpty(textBoxId.Text) && int.TryParse(textBoxId.Text, out int idBtnOk))
            {

                int variableLocalid = int.Parse(textBoxId.Text);
                string nombreLocal = "";
                string apellidoPLocal = "";
                string apelldoMLocal = "";
                int edadLocal = 0;
                string sexoLocal = "";
                string puestoLocal = "";


                if (EmpleadoQuery.buscarEmpleado(variableLocalid) != 0)
                {
                    dataGridViewModificarEmpleado.DataSource = EmpleadoQuery.MostrarRegistroParticular(variableLocalid);
                    Empleado empleado = EmpleadoQuery.ModificarEmpleado(variableLocalid);


                    //ASINAMOS A LA VARIABLES LOCALES LOS VALORES DEL OBJETO empleado

                    nombreLocal = empleado.nombre;
                    apellidoPLocal = empleado.apellidoPaterno;
                    apelldoMLocal = empleado.apellidoMaterno;
                    edadLocal = empleado.edad;
                    sexoLocal = empleado.sexo;
                    puestoLocal = empleado.puesto;

                    //ASIGNAMOS A LOS TEXBOX LAS VARIABLES QUE SEVOLVEMOS DEL OBJETO PERSONA 
                    txtBoxName.Text = nombreLocal;
                    txtBoxLastNameP.Text = apellidoPLocal;
                    txtBoxLastNameM.Text = apelldoMLocal;
                    txtBoxAge.Text = edadLocal.ToString();
                    txtBoxSex.Text = sexoLocal;
                    txtBoxOcupation.Text = puestoLocal;

                    MessageBox.Show("Agregar los cambios en los campos requeridos");



                }
                else
                {
                    MessageBox.Show("El id no se encuentra en la base de datos ");

                }

            }
            else 
            {
                MessageBox.Show("Digita un numero en el campo id o digita al menos un valor");

            }


              


            //empleado = EmpleadoQuery.ModificarEmpleado(1);
            //MessageBox.Show("1" + empleado.nombre);
        }//FIN METODO 

        private void btnModificarTrue_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtBoxName.Text) && !string.IsNullOrEmpty(txtBoxLastNameP.Text) && !string.IsNullOrEmpty(txtBoxLastNameM.Text) && !string.IsNullOrEmpty(txtBoxAge.Text) && int.TryParse(txtBoxAge.Text, out int idBtnOk) && !string.IsNullOrEmpty(txtBoxSex.Text) && !string.IsNullOrEmpty(txtBoxOcupation.Text))
            {
                int variableLocalid = int.Parse(textBoxId.Text);
                string nombreLocal = txtBoxName.Text;
                string apellidoPLocal = txtBoxLastNameP.Text;
                string apelldoMLocal = txtBoxLastNameM.Text;
                int edadLocal = int.Parse(txtBoxAge.Text);
                string sexoLocal = txtBoxSex.Text;
                string puestoLocal = txtBoxOcupation.Text;


                EmpleadoQuery.ModificarEmpleadoCambios(variableLocalid, nombreLocal, apellidoPLocal, apelldoMLocal, edadLocal, sexoLocal, puestoLocal);



                MessageBox.Show("Los datos se han Modificado correctamente");

                textBoxId.Text = "";
                txtBoxName.Text = "";
                txtBoxLastNameM.Text = "";
                txtBoxLastNameP.Text = "";
                txtBoxAge.Text = "";
                txtBoxSex.Text = "";
                txtBoxOcupation.Text = "";

                dataGridViewModificarEmpleado.DataSource = EmpleadoQuery.MostrarRegistroParticular(variableLocalid);

            }
            else
            {
                MessageBox.Show("LLene todos los campos porfavor o Digite un valor numerico en el campo Edad");

            }





        }
    }//FIN DE MI CLASE 
}



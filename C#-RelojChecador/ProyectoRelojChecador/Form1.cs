using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoRelojChecador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //BOTONES

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void btnCero_Click(object sender, EventArgs e)
        {
            etiquetaIntroducir.Text += 0;
        }

        private void btnUno_Click(object sender, EventArgs e)
        {
            etiquetaIntroducir.Text += 1;
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            etiquetaIntroducir.Text += 2;
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            etiquetaIntroducir.Text += 3;
        }

        private void btnCuatro_Click(object sender, EventArgs e)
        {
            etiquetaIntroducir.Text += 4;
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            etiquetaIntroducir.Text += 5;
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            etiquetaIntroducir.Text += 6;
        }

        private void btnSiete_Click(object sender, EventArgs e)
        {
            etiquetaIntroducir.Text += 7;
        }

        private void btnOcho_Click(object sender, EventArgs e)
        {
            etiquetaIntroducir.Text += 8;
        }

        private void btnNueve_Click(object sender, EventArgs e)
        {
            etiquetaIntroducir.Text += 9;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(etiquetaIntroducir.Text))
            {
                // Get the length of the text
                int CADENA = etiquetaIntroducir.Text.Length;

                // Remove the last character using Substring
                etiquetaIntroducir.Text = etiquetaIntroducir.Text.Substring(0, CADENA - 1);
            }
        }


        //REGISTRO CHECADAS
        private void btnOk_Click(object sender, EventArgs e)
        {

            int comida = 0;

            // VERIFICA QUE EL TRABAJADOR PONGA SU ID A LA HORA DE CHECAR 
            if (!string.IsNullOrEmpty(etiquetaIntroducir.Text))
            {
                int idBtnOk = int.Parse(etiquetaIntroducir.Text);
                string horaBtnOk = DateTime.Now.ToString("HH:mm:ss");
                string fechaBtnOk = DateTime.Now.ToString("yyyy-MM-dd");

                Checada checada = new Checada();

                checada.id = idBtnOk;
                checada.hora = horaBtnOk;
                checada.fecha = fechaBtnOk;

                int registroExito = 0;

                if (EmpleadoQuery.buscarEmpleado(idBtnOk) != 0)
                {
                    registroExito = ChecadaQuery.AgregarChecada(checada);

                    if (registroExito != 0)
                    {
                        comida = ChecadaQuery.ContarChecadas(idBtnOk);

                        switch (comida)
                        {
                            case 1:
                                MessageBox.Show("Has entrado al trabajo");
                                break;

                            case 2:
                                MessageBox.Show("Has salido a comer");
                                break;

                            case 3:
                                MessageBox.Show("Has entrado de la comida");
                                break;

                            case 4:
                                MessageBox.Show("Estás saliendo del trabajo");

                                // BONO
                                ChecadaQuery.eliminarChecadaEmpleado(idBtnOk);
                                ChecadaQuery.AgregarChecadaBono(idBtnOk, fechaBtnOk, 1);
                                break;

                            default:
                                MessageBox.Show("Ya realizaste todas tus checadas del día");
                                break;
                        }

                        etiquetaIntroducir.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("No has checado");
                    }
                }
                else
                {
                    MessageBox.Show("Digita nuevamente el ID");
                    etiquetaIntroducir.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Introduce tu ID por favor");
            }

        }//END OK 

        private void TimerHoraFecha_Tick(object sender, EventArgs e)
        {
            etiquetaHora.Text = DateTime.Now.ToString("HH:mm:ss");
            etiquetaFecha.Text = DateTime.Now.ToShortDateString();
        }

        //BONTONES QUE TE LLEVANA OTRO WINDOWS FORM

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            FrmAgregarEmpleado frmAgregarEmpleado = new FrmAgregarEmpleado();
            frmAgregarEmpleado.ShowDialog();
        }

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            FrmBuscarEmpleado frmBuscarEmpleado = new FrmBuscarEmpleado();
            frmBuscarEmpleado.ShowDialog();
        }

        private void btnRegistroChecadas_Click(object sender, EventArgs e)
        {
            FrmRegistroChecada frmRegistroChecada = new FrmRegistroChecada();
            frmRegistroChecada.ShowDialog();
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            FrmEliminarEmpleado frmEliminarEmpleado = new FrmEliminarEmpleado();
            frmEliminarEmpleado.ShowDialog();
        }

        private void btnModificarEmpleado_Click(object sender, EventArgs e)
        {
            FrmModificarEmpleado frmModificarEmpleado = new FrmModificarEmpleado();
            frmModificarEmpleado.ShowDialog();
        }
    }
}

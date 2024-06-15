using ProyClinicOdonto_BE;
using ProyClinicOdonto_BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyClinicOdonto_GUI
{
    public partial class PacienteMan3 : Form
    {
        PacienteBL objPacienteBL = new PacienteBL();
        PacienteBE objPacienteBE = new PacienteBE();
        DistritoBL objDistritoBL = new DistritoBL();
        public PacienteMan3()
        {
            InitializeComponent();

        }
        public String Codigo { get; set; }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
        }

        private void PacienteMan3_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGrabar_Click_1(object sender, EventArgs e)
        {
            try
            {
                String Genero = "";
                if (rbMascu.Checked == true)
                {
                    Genero = "Masculino";
                }
                else
                {
                    Genero = "Femenino";
                }
                //Pasamos valores alas propiedades de la instancia...

                objPacienteBE.Nombres = txtNomPaci.Text;
                objPacienteBE.Apellidos = txtApePaci.Text;
                objPacienteBE.Genero = Genero;
                objPacienteBE.email = txtEmail.Text;
                //objPacienteBE.direccion = txtDirec.Text;
                objPacienteBE.IdDist = cboDistrito.SelectedValue.ToString();
                objPacienteBE.telefono = mskTelefono.Text;
                objPacienteBE.alergias = txtAlergias.Text;
                //objPacienteBE.Estado = activo;

                //objprofesorBE.FecIng = fechaIng;
                //objprofesorBE.Id_Ubi = cboDep.SelectedValue.ToString() + cboProvincia.SelectedValue.ToString() +
                //    cboDistrito.SelectedValue.ToString();
                if (objPacienteBL.ActualizarPaciente(objPacienteBE) == true)
                {
                    this.Close();
                }
                else
                {
                    throw new Exception("No se inserto ");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void PacienteMan3_Load_1(object sender, EventArgs e)
        {

            try

            {
                int idDistritoSeleccionado = Convert.ToInt32(cboDistrito.SelectedValue);
                DataTable dt = objDistritoBL.ListarDistrito();
                DataRow dr;
                dr = dt.NewRow();
                dr["IdDist"] = 0;
                dr["Nombre"] = "--Selecionar--";
                dt.Rows.InsertAt(dr, 0);
                cboDistrito.DataSource = dt;
                cboDistrito.DisplayMember = "Nombre";
                cboDistrito.ValueMember = "IdDist";

                foreach (DataRowView item in cboDistrito.Items)
                {
                    if (Convert.ToInt32(item["IdDist"]) == idDistritoSeleccionado)
                    {
                        // Establece el elemento como la selección actual
                        cboDistrito.SelectedItem = item;
                        break;
                    }
                }
            }

            catch (Exception)
            {

                throw;
            }




            try
            {
                objPacienteBE = objPacienteBL.ConsultarPacientes(this.Codigo);


                lblDni.Text = Codigo;
                txtNomPaci.Text = objPacienteBE.Nombres;
                txtApePaci.Text = objPacienteBE.Apellidos;
                txtEmail.Text = objPacienteBE.email;
                //txtDirec.Text = objPacienteBE.direccion;
                objPacienteBE.IdDist = cboDistrito.SelectedValue.ToString();
                mskTelefono.Text = objPacienteBE.telefono;
                txtAlergias.Text = objPacienteBE.alergias;
                //if (objPacienteBE.Estado == true)
                //{
                //optActivo.Checked = true;
                //}
                // else
                //{
                //optInactivo.Checked = true;
                //}

            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grpDatos_Enter(object sender, EventArgs e)
        {

        }
    }
}



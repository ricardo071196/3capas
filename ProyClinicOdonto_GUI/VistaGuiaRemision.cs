using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyClinicOdonto_BL;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyClinicOdonto_GUI
{
    public partial class VistaGuiaRemision : Form
    {

        GuiaRemisionBL objGuiaRemisionBL = new GuiaRemisionBL();
        DataView dtv;
        public VistaGuiaRemision()
        {
            InitializeComponent();
        }

        private void CargarDatos(String strFiltro)
        {

            // Construimos  el objeto Dataview dtv  en base al DataTable devuelto por el metodo ListarProducto
            // Y lo filtramos de acuerdo al parametro strFiltro
            dtv = new DataView(objGuiaRemisionBL.ListarGuia());
            dtv.RowFilter = " Nombre like '%" + strFiltro + "%'";
            dtgGuia.DataSource = dtv;
            lblRegistros.Text = dtgGuia.Rows.Count.ToString();

        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Pasaremos al metodo CargarDatos el texto que se va escribiendo
                // en la caja de texto 
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void dtgGuia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VistaGuiaRemision_Load(object sender, EventArgs e)
        {
            CargarDatos("");
        }
    }
}

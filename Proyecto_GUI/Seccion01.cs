using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_BE;
using Proyecto_BL;

namespace Proyecto_GUI
{
    public partial class Servicio01 : Form
    {
        SeccionBL objSeccionBL= new SeccionBL();
        DataView dtv;
        public Servicio01()
        {
            InitializeComponent();
        }

        private void Servicio01_Load(object sender, EventArgs e)
        {
            CargarDatos("");

        }

        private void CargarDatos(String strFiltro) { 

            dtv = new DataView(objSeccionBL.ListarSeccion());
            dtv.RowFilter = "grupo like '%" + strFiltro + "%'";
            dtgDatosSec.DataSource = dtv;
            lblRegistrosSec.Text = dtgDatosSec.Rows.Count.ToString();
        }

        private void txtFiltroSec_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CargarDatos(txtFiltroSec.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnAgregarSec_Click(object sender, EventArgs e)
        {
            try
            {
                Seccion02 objServicio02 = new Seccion02();
                objServicio02.ShowDialog();

                CargarDatos(txtFiltroSec.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnActualizarSec_Click(object sender, EventArgs e)
        {
            try
            {
                Seccion03 objSeccion03 = new Seccion03();
                objSeccion03.Codigo = Convert.ToInt16(dtgDatosSec.CurrentRow.Cells[0].Value);
                objSeccion03.ShowDialog();

                CargarDatos(txtFiltroSec.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnEliminarSec_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult vrpta = MessageBox.Show("Seguro de eliminar el registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (vrpta == DialogResult.Yes) {
                    if (objSeccionBL.EliminarSeccion(Convert.ToInt16(dtgDatosSec.CurrentRow.Cells[0].Value.ToString())) == true)
                    {
                        CargarDatos(txtFiltroSec.Text.Trim());
                    }
                    else {
                        throw new Exception("La sección no se pudo eliminar. Contacte con TI");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnCerrarSec_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data; // Para los objetos DataTable, DataRow y DataView
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Agregar...
using ProyMatricula_BL;

namespace ProyMatricula_GUI
{
    public partial class ApoderadoMan01 : Form
    {
        // Instancias
        Apoderado_BL objApoderadoBL = new Apoderado_BL();
        DataView dtv;
        
        public ApoderadoMan01()
        {
            InitializeComponent();
        }

        private void ProductoMan01_Load(object sender, EventArgs e)
        {
            //Que no se generen columnas automaticamente
            dtgDatos.AutoGenerateColumns = false;

            CargarDatos("");

        }

        private void CargarDatos(String strFiltro)
        {

            // Construimos  el objeto Dataview dtv  en base al DataTable devuelto por el metodo ListarApoderado
            //  e invocamos al metodo CargarDatos pasandole una cadena vacia ,
            //  lo cual hara que se muestren todos los Apoderados por defecto al momento de cargar el formulario

            dtv = new DataView(objApoderadoBL.ListarApoderado());
            dtv.RowFilter = "apePaterno like '%" + strFiltro + "%'";
            dtgDatos.DataSource = dtv;
            lblRegistros.Text = dtgDatos.Rows.Count.ToString();

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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                ApoderadoMan02 objMan02 = new ApoderadoMan02();
                objMan02.ShowDialog();//MODAL

                //refrescar el grid
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                // Codifique
                ApoderadoMan03 objMan03 = new ApoderadoMan03();
                //Asignar la propiedad codigo desde la celda 0 de la fila seleccionada en el grid
                objMan03.Codigo = Convert.ToInt16(dtgDatos.CurrentRow.Cells[0].Value.ToString());
                objMan03.ShowDialog();

                //Refrescar la grilla
                CargarDatos(txtFiltro.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult vrpta = MessageBox.Show("Seguro de eliminar el registro?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (vrpta == DialogResult.Yes)
            {
                if (objApoderadoBL.EliminarApoderado(dtgDatos.CurrentRow.Cells[0].Value.ToString()))
                {
                    CargarDatos(txtFiltro.Text.Trim());
                }
                else
                {
                    throw new Exception("Registro no se pudo eliminar. Contacte con TI");
                }
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


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
using ProyAlumnosBL;




namespace ProyVentas_GUI
{
    public partial class AlumnoMan01 : Form
    {
        // Instancias
        AlumnoBL objAlumnoBL = new AlumnoBL();
        DataView dtv;

        public AlumnoMan01()
        {
            InitializeComponent();
        }

        private void ProductoMan01_Load(object sender, EventArgs e)
        {
			
			CargarDatos("");

        }

        private void CargarDatos(String strFiltro)
        {

            // Construimos  el objeto Dataview dtv  en base al DataTable devuelto por el metodo ListarProducto
            //  e invocamos al metodo CargarDatos pasandole una cadena vacia ,
            //  lo cual hara que se muestren todos los proveedores por defecto al momento de cargar el formulario

            dtv = new DataView(objAlumnoBL.ListarAlumno());
            dtv.RowFilter = "nombres like '%" + strFiltro + "%'";
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
				AlumnosMan02 objMan02 = new AlumnosMan02();
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
				
				AlumnosMan03 objMan03 = new AlumnosMan03();
				//Asignar la propiedad codigo desde la celda 0 de la fila seleccionada en el grid

				objMan03.Codigo =Convert.ToInt16(dtgDatos.CurrentRow.Cells[0].Value);
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
				if (objAlumnoBL.EliminarAlumno(dtgDatos.CurrentRow.Cells[0].Value.ToString()))
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

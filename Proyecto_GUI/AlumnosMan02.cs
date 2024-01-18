using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
// Agregar...
using ProyAlumnosBL;
using ProyAlumnos_BE;
namespace ProyVentas_GUI
{
    public partial class AlumnosMan02 : Form
    {
        
        AlumnoBL objAlumnoBL = new AlumnoBL();
        AlumnoBE objAlumnoBE = new AlumnoBE();
            

        public AlumnosMan02()
        {
            InitializeComponent();
        }

        private void ProveedorMan02_Load(object sender, EventArgs e)
        {
            try
            {   
                //llenamos el combo Cod usuario, cod apo y cod distrito

                DataTable dt =objAlumnoBL.ListarDistritos();
                DataRow dr;
                dr = dt.NewRow();
                dr["codDistrito"] = 0;
				dr["nomDistrito"] = "--seleccione--";
				dt.Rows.InsertAt(dr,0);
                cboDistrito.DataSource= dt;
				cboDistrito.DisplayMember = "nomDistrito";
				cboDistrito.ValueMember = "codDistrito";

				//
				dt = objAlumnoBL.ListarApoderado();
				dr = dt.NewRow();
				dr["codApoderado"] = 0;
				dr["nombres"] = "--seleccione--";
				dt.Rows.InsertAt(dr,0);
				cboApo.DataSource = dt;
				cboApo.DisplayMember = "nomApoderado";
				cboApo.ValueMember = "codApoderado";
				//
				dt = objAlumnoBL.ListarUsuario();
				dr = dt.NewRow();
				dr["codUsuario"] = 0;				
				dt.Rows.InsertAt(dr, 0);
				cboUsuario.DataSource = dt;
				cboUsuario.DisplayMember = "codUsuario";
				cboUsuario.ValueMember = "codUsuario";

				//
				dtpFN.MaxDate = DateTime.Now;
				
				//validamos

			}

            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
            
            }
        }

        
        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
				//validacion
				if (txtNombres.Text.Trim() == String.Empty)
				{
					throw new Exception("Los Nombres son Obligatorios");
				}
				if (txtPaterno.Text.Trim() == String.Empty)
				{
					throw new Exception("El apellido paterno es Obligatorio");
				}
				if (txtMaterno.Text.Trim() == String.Empty)
				{
					throw new Exception("El apellido materno es Obligatorio");
				}

				if(cboApo.SelectedIndex==0 || cboDistrito.SelectedIndex==0 || cboUsuario.SelectedIndex == 0)
				{
					throw new Exception("el codigo del apoderado, distrito y usuario son obligatorios");
				}

				if (txtDNI.MaskFull == false)
				{
					throw new Exception("El dni es obligatorio");
				}
				if (txtDNI.MaskFull == false)
				{
					throw new Exception("El dni tiene que tener 8 caracteres");
				}

				//Si todo esta ok cargamos la entidad de negocio objAlumnoBE

				objAlumnoBE.nombres = txtNombres.Text.Trim();
				objAlumnoBE.apePaterno = txtPaterno.Text.Trim();
				objAlumnoBE.apeMaterno = txtMaterno.Text.Trim();
				objAlumnoBE.dni = txtDNI.Text;
				objAlumnoBE.fechaNacimiento = dtpFN.Value.Date;
				objAlumnoBE.direccionAlum = txtDirecc.Text.Trim();
				objAlumnoBE.telefono = txtTel.Text.Trim();
				objAlumnoBE.estado = Convert.ToInt16(chkEstado.Checked);
				objAlumnoBE.codApoderado = Convert.ToInt16(cboApo.SelectedValue);
				objAlumnoBE.codUsuario = Convert.ToInt16(cboUsuario.SelectedValue);
				objAlumnoBE.codDistrito = Convert.ToInt16(cboDistrito.SelectedValue);
				objAlumnoBE.usu_registro = "kevin";				
				objAlumnoBE.fecha_registro = DateTime.Now;

				if (pcbFot.Image != null)
				{
					objAlumnoBE.foto = File.ReadAllBytes(openFileDialog1.FileName);
				}
				else
				{
					objAlumnoBE.foto = null;
				}
				
				System.Diagnostics.Debug.WriteLine(objAlumnoBE.foto);
				System.Diagnostics.Debug.WriteLine(objAlumnoBE.nombres);

				//Invocamos el metodo insertar
				if (objAlumnoBL.InsertarAlumno(objAlumnoBE) == true)
				{
					this.Close();
				}
				else
				{
					throw new Exception("No se hizo el registro, contacte con TI");
				}

			}
            catch (Exception ex)
            {
                MessageBox.Show("Se ha producido el error: " + ex.Message);
            }


        }
               

      
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		private void btnCargar_Click(object sender, EventArgs e)
		{
			try
			{
				openFileDialog1.FileName = String.Empty;
				openFileDialog1.Multiselect = false;
				openFileDialog1.ShowDialog();

				// Si se escogio una foto se carga en el picture Box
				if (openFileDialog1.FileName != String.Empty)
				{
					pcbFot.Image = Image.FromFile(openFileDialog1.FileName);
				}
			}
			catch (Exception)
			{

				throw;
			}
		}
	}
}

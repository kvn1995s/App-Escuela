using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
// Agregar...
using ProyAlumnosBL;
using ProyAlumnos_BE;
namespace ProyVentas_GUI
{
	public partial class AlumnosMan03 : Form
	{

		AlumnoBL objAlumnoBL = new AlumnoBL();
		AlumnoBE objAlumnoBE = new AlumnoBE();
		// Variable para determinar si se a cambiado de foto o no.
		Boolean blnCambio;
		// Array de Bytes para conservar la foto original , por si no se desea cambiarla.
		Byte[] FotoOriginal;


		public AlumnosMan03()
		{
			InitializeComponent();
		}

		// IMPORTANTE: Creamos la propiedad Codigo ,que recepcionara el valor del codigo del alumno
		// a actualizar enviado desde el formulario AlumnosMan01


		public Int16 Codigo { get; set; }

		private void ProveedorMan03_Load(object sender, EventArgs e)
		{
			try
			{   //llenamos el combo Cod usuario, cod apo y cod distrito

				DataTable dt = objAlumnoBL.ListarDistritos();
				DataRow dr;
				dr = dt.NewRow();
				dr["codDistrito"] = 0;
				dr["nomDistrito"] = "--seleccione--";
				dt.Rows.InsertAt(dr, 0);
				cboDistrito.DataSource = dt;
				cboDistrito.DisplayMember = "nomDistrito";
				cboDistrito.ValueMember = "codDistrito";

				//
				dt = objAlumnoBL.ListarApoderado();
				dr = dt.NewRow();
				dr["codApoderado"] = 0;
				dr["nombres"] = "--seleccione--";
				dt.Rows.InsertAt(dr, 0);
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
				dtpFN.MinDate = DateTimePicker.MinimumDateTime;
				objAlumnoBE = objAlumnoBL.ConsultarAlumno(this.Codigo);

				//Mostramos los datos del alumno actualizar...

				lblCodAlum.Text = objAlumnoBE.codAlumno.ToString();
				txtNombres.Text = objAlumnoBE.nombres;
				txtPaterno.Text = objAlumnoBE.apePaterno;
				txtMaterno.Text = objAlumnoBE.apeMaterno;
				txtDNI.Text = objAlumnoBE.dni;
				txtDirecc.Text = objAlumnoBE.direccionAlum;
				txtTel.Text = objAlumnoBE.telefono;
				cboDistrito.SelectedValue = objAlumnoBE.codDistrito.ToString();
				cboApo.SelectedValue = objAlumnoBE.codApoderado.ToString();
				cboUsuario.SelectedValue = objAlumnoBE.codUsuario.ToString();
				chkEstado.Checked = Convert.ToBoolean(objAlumnoBE.estado);

				// Si no tiene foto....
				if (objAlumnoBE.foto.Length == 0)
				{
					pcbFot.Image = null;

				}
				else // Pero si tiene foto
				{
					MemoryStream fotoStream = new MemoryStream(objAlumnoBE.foto);
					pcbFot.Image = Image.FromStream(fotoStream);
					// Guardamos la foto original , por si no se hace cambios...
					FotoOriginal = objAlumnoBE.foto;
				}
				dtpFN.Value = objAlumnoBE.fechaNacimiento;
				objAlumnoBE.usu_ult_mod = "admin";
				objAlumnoBE.fecha_ult_mod = DateTime.Now;



			}
			catch (Exception ex)
			{
				MessageBox.Show("Error : " + ex.Message);
			}
		}


		

		
		private void btnCancelar_Click_1(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnCargar_Click(object sender, EventArgs e)
		{
			openFileDialog1.FileName = String.Empty;
			openFileDialog1.Multiselect = false;
			openFileDialog1.ShowDialog();

			// Si se escogio una foto se carga en el picture Box
			if (openFileDialog1.FileName != String.Empty)
			{
				pcbFot.Image = Image.FromFile(openFileDialog1.FileName);
				blnCambio = true;
			}
			else // de lo contrario la variable blnCambio se mantiene en falso
			{
				blnCambio = false;
			}
		}

		private void btnGrabar_Click_1(object sender, EventArgs e)
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

				if (cboApo.SelectedIndex == 0 || cboDistrito.SelectedIndex == 0 || cboUsuario.SelectedIndex == 0)
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

				objAlumnoBE.codAlumno = Convert.ToInt16(lblCodAlum.Text);
                objAlumnoBE.nombres = txtNombres.Text.Trim();
                objAlumnoBE.apePaterno = txtPaterno.Text.Trim();
                objAlumnoBE.apeMaterno = txtMaterno.Text.Trim();
                objAlumnoBE.dni = txtDNI.Text;
                objAlumnoBE.fechaNacimiento = Convert.ToDateTime(dtpFN.Value.Date);
                objAlumnoBE.direccionAlum = txtDirecc.Text.Trim();
                objAlumnoBE.telefono = txtTel.Text.Trim();
                objAlumnoBE.estado = Convert.ToInt16(chkEstado.Checked);
                objAlumnoBE.codApoderado = Convert.ToInt16(cboApo.SelectedValue);
                objAlumnoBE.codUsuario = Convert.ToInt16(cboUsuario.SelectedValue);
                objAlumnoBE.codDistrito = Convert.ToInt16(cboDistrito.SelectedValue);
                objAlumnoBE.usu_ult_mod = "admin";
                objAlumnoBE.fecha_ult_mod = DateTime.Now;
                <
                // Si cambio la foto...
                if (blnCambio == true)
                {
                   objAlumnoBE.foto = File.ReadAllBytes(openFileDialog1.FileName);
                }
                else  //Mantenemos la foto original
                {
                    objAlumnoBE.foto = FotoOriginal;
                }


                //Invocamos el metodo actualizar
                if (objAlumnoBL.ActualizarAlumno(objAlumnoBE) == true)
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
	}
}


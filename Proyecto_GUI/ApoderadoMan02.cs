using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Agregar...
using ProyMatricula_BE;
using ProyMatricula_BL;
using System.IO;// para la clase File

namespace ProyMatricula_GUI
{
    public partial class ApoderadoMan02 : Form
    {
        // Instancias...
        Apoderado_BL objApoderado_BL = new Apoderado_BL();
        Apoderado_BE objApoderadoBE = new Apoderado_BE();
        
        

        public ApoderadoMan02()
        {
            InitializeComponent();
        }

        private void ProductoMan02_Load(object sender, EventArgs e)
        {
            try
            {
                dtpFN.MaxDate = DateTime.Now;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {

                objApoderadoBE.nombres = txtNombres.Text.Trim();
                objApoderadoBE.apePaterno = txtPaterno.Text.Trim();
                objApoderadoBE.apeMaterno = txtMaterno.Text.Trim();
                objApoderadoBE.dni = txtDNI.Text.Trim();
                objApoderadoBE.fechaNac = dtpFN.Value.Date;
                objApoderadoBE.direccionApod = txtDirecc.Text.Trim();
                objApoderadoBE.telefono = txtTel.Text.Trim();
                objApoderadoBE.Usu_Registro = "Ivan";
                objApoderadoBE.Fec_Registro = DateTime.Now;
                // Convertimos la foto en un arreglo de Bytes y lo almacenamos en su respectiva propiedad
                //erros openfiledialog
                if (picbFoto.Image != null)
                {
                    objApoderadoBE.Foto_Apo = File.ReadAllBytes(openFileDialog1.FileName);
                }
                else
                {
                    objApoderadoBE.Foto_Apo = null;
                }

                System.Diagnostics.Debug.WriteLine(objApoderadoBE.Foto_Apo);
                System.Diagnostics.Debug.WriteLine(objApoderadoBE.nombres);



                //Invocamos el metodo insertar
                if (objApoderado_BL.InsertarApoderado(objApoderadoBE) == true)
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
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       






        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar)
                    || e.KeyChar == (char)Keys.Back);
        }

       

        private void txtNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 33 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                e.Handled = true;
                return;
            }
        }

        
        private void btnCargarFoto_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.FileName = String.Empty;
                openFileDialog1.Multiselect = false;
                openFileDialog1.ShowDialog();

                // Si se escogio una foto se carga en el picture Box
                if (openFileDialog1.FileName != String.Empty)
                {
                    picbFoto.Image = Image.FromFile(openFileDialog1.FileName);
                }


            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}

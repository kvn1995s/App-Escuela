using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Agregamos
using ProyMatricula_BE;
using ProyMatricula_BL;
using System.IO; // para el MemoryStream de la foto
namespace ProyMatricula_GUI

{
    public partial class ApoderadoMan03 : Form
    {
        // Instancias...
        Apoderado_BL objApoderado_BL = new Apoderado_BL();
        Apoderado_BE objApoderadoBE = new Apoderado_BE();

        // Variable para determinar si se a cambiado de foto o no.
        Boolean blnCambio;
        // Array de Bytes para conservar la foto original , por si no se desea cambiarla.
        Byte[] FotoOriginal;


        public ApoderadoMan03()
        {
            InitializeComponent();
        }

        // Propiedad que recibe el codigo del Apoderado que se actualizara, enviado
        // desde el ApoderadoMan01

        public Int16 Codigo { get; set; }

        private void ProductoMan03_Load(object sender, EventArgs e)
        {
            try
            {
                

                dtpFN.MaxDate = DateTime.Now;
                dtpFN.MinDate = DateTimePicker.MinimumDateTime;
                // Codifique
                objApoderadoBE = objApoderado_BL.ConsultarApoderado(this.Codigo);

                //Mostramos los datos del apoderado actualizar...
                lblCodigo.Text = objApoderadoBE.codApoderado.ToString();
                txtNombres.Text = objApoderadoBE.nombres;
                txtPaterno.Text = objApoderadoBE.apePaterno.ToString();
                txtMaterno.Text = objApoderadoBE.apeMaterno.ToString();
                txtDNI.Text = objApoderadoBE.dni.ToString();
                txtDirecc.Text = objApoderadoBE.direccionApod;
                txtTel.Text = objApoderadoBE.telefono;

                // Si no tiene foto....
                if (objApoderadoBE.Foto_Apo.Length == 0)
                {
                    pcbFot.Image = null;

                }
                else // Pero si tiene foto
                {
                    MemoryStream fotoStream = new MemoryStream(objApoderadoBE.Foto_Apo);
                    pcbFot.Image = Image.FromStream(fotoStream);
                    // Guardamos la foto original , por si no se hace cambios...
                    FotoOriginal = objApoderadoBE.Foto_Apo;
                }

                //Usuarios !! Tener Usuarios entre los integrantes del grupo
                dtpFN.Value = objApoderadoBE.fechaNac;
                objApoderadoBE.Usu_Ult_Mod = "admin";
                objApoderadoBE.Fec_Ult_Mod = DateTime.Now;
               
               
                
                

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
                //Condición

                if (txtDNI.Text.Trim() == "")
                {
                    throw new Exception("El DNI es obligatorio");
                }
                if (txtPaterno.Text.Trim() == "" && txtMaterno.Text.Trim() == "")
                {
                    throw new Exception("Los apellidos paterno es obligatorio");
                }

                //Si todo está OK cargamos entidad de negocios...

                objApoderadoBE.nombres = txtNombres.Text.Trim();
                objApoderadoBE.apePaterno = txtPaterno.Text.Trim();
                objApoderadoBE.apeMaterno = txtMaterno.Text.Trim();
                objApoderadoBE.dni = txtDNI.Text.Trim();
                objApoderadoBE.fechaNac = dtpFN.Value;
                objApoderadoBE.direccionApod = txtDirecc.Text.Trim();
                objApoderadoBE.telefono = txtTel.Text.Trim();

                // Si cambio la foto...
                if (blnCambio == true)
                {
                    objApoderadoBE.Foto_Apo = File.ReadAllBytes(openFileDialog1.FileName);
                }
                else  //Mantenemos la foto original
                {
                    objApoderadoBE.Foto_Apo = FotoOriginal;
                    
                }


                    if (objApoderado_BL.ActualizarApoderado(objApoderadoBE) == true)
                    {
                        this.Close();
                    }
                    else
                    {
                        throw new Exception("No se actualizó el registro, contacte con TI");
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

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            CultureInfo cc = System.Threading.Thread.CurrentThread.CurrentCulture;

            e.Handled = !(char.IsDigit(e.KeyChar)
                    || e.KeyChar == (char)Keys.Back
                    || e.KeyChar.ToString() == cc.NumberFormat.NumberDecimalSeparator);
        }

        private void txtStkAct_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsDigit(e.KeyChar)
                    || e.KeyChar == (char)Keys.Back);
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.FileName = String.Empty;
                openFileDialog1.Multiselect = false;
                openFileDialog1.ShowDialog();

                // Si se escogio una foto se carga en el picture Box y la variable blnCambio se pone en true
                // Esta variable permitira saber si se cambio la foto en el apoderado.
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
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}

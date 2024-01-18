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
    public partial class Seccion02 : Form
    {
        SeccionBL objSeccionBL = new SeccionBL();
        SeccionBE objSeccionBE = new SeccionBE();
        PersonalBL objPersonalBL = new PersonalBL();

        public Seccion02()
        {
            InitializeComponent();
        }

        private void Servicio02_Load(object sender, EventArgs e)
        {
            String[] Grados =
            {
                "1er",
                "2do",
                "3ro",
                "4to",
                "5to",
                "6to"
            };

            cboGradoSeccion.DataSource = Grados;
            try
            {
                DataTable dt = objPersonalBL.listarPersonal();
                DataRow dr;
                dr = dt.NewRow();
                dr["codPersonal"] = 0;
                dr["nombres"] = "--SELECCIONE--";
                dt.Rows.InsertAt(dr,0);
                cboPersonal.DataSource = dt;
                cboPersonal.DisplayMember = "nombres";
                cboPersonal.ValueMember = "codPersonal";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnGrabarSeccion_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboPersonal.SelectedIndex == 0) {
                    throw new Exception("El personal es obligatorio");
                }

                objSeccionBE.codPersonal = Convert.ToInt16(cboPersonal.SelectedValue);
                objSeccionBE.grupo = txtGradoSeccion.Text.Trim();
                if (rbtnManana.Checked)
                {
                    objSeccionBE.turno = "M";
                }
                else if (rbtnTarde.Checked) {
                    objSeccionBE.turno = "T";
                } 
                objSeccionBE.numSalon = mskNumSalon.Text.Trim();
                objSeccionBE.numGrado = cboGradoSeccion.Text.Trim();

                if (objSeccionBL.InsertarSeccion(objSeccionBE) == true)
                {
                    this.Close();
                }
                else {
                    throw new Exception("No se hizo el registro, contacte con TI");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8) //Si no es Backspace
            {
                e.Handled = true;
            }
        }

        private void mskNumSalon_Validating(object sender, CancelEventArgs e)
        {
            if (mskNumSalon.Text.Trim().Length == 0)
            {
                e.Cancel = true;
                MessageBox.Show("El número de Salon es obligatorio", "Error");
            }
            else {
                Int16 intNumSalon = Convert.ToInt16(mskNumSalon.Text.Trim());
                if (intNumSalon > 10) { 
                    e.Cancel=true;
                    MessageBox.Show("El número máximo de salon es el 10", "Error");
                }
            }
        }
    }
}

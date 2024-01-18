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
    public partial class Seccion03 : Form
    {
        SeccionBL objSeccionBL = new SeccionBL();
        SeccionBE objSeccionBE = new SeccionBE();
        PersonalBL objPersonalBL = new PersonalBL();
        public Seccion03()
        {
            InitializeComponent();
        }

        public Int16 Codigo { get; set; }

        private void Seccion03_Load(object sender, EventArgs e)
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
                dt.Rows.InsertAt(dr, 0);
                cboPersonal.DataSource = dt;
                cboPersonal.DisplayMember = "nombres";
                cboPersonal.ValueMember = "codPersonal";


                objSeccionBE = objSeccionBL.ConsultarSeccion(this.Codigo);

                lblCodSeccion.Text =objSeccionBE.codSeccion.ToString();
                cboPersonal.SelectedValue = objSeccionBE.codPersonal.ToString();
                txtGrupoSeccion.Text = objSeccionBE.grupo;
                mskNumSalon.Text = objSeccionBE.numSalon.ToString();
                cboGradoSeccion.Text = objSeccionBE.numGrado;
                if (objSeccionBE.turno == "M")
                {
                    rbtnManana.Checked = true;
                }
                else if (objSeccionBE.turno == "T") {
                    rbtnTarde.Checked = true;
                }

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
                if (cboPersonal.SelectedIndex == 0)
                {
                    throw new Exception("El personal es obligatorio");
                }

                objSeccionBE.codSeccion = Convert.ToInt16(lblCodSeccion.Text);
                objSeccionBE.codPersonal = Convert.ToInt16(cboPersonal.SelectedValue);
                objSeccionBE.grupo = txtGrupoSeccion.Text.Trim();
                if (rbtnManana.Checked)
                {
                    objSeccionBE.turno = "M";
                }
                else if (rbtnTarde.Checked)
                {
                    objSeccionBE.turno = "T";
                }
                objSeccionBE.numSalon = mskNumSalon.Text.Trim();
                objSeccionBE.numGrado = cboGradoSeccion.Text.Trim();

                if (objSeccionBL.ActualizarSeccion(objSeccionBE) == true)
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
    }
}

using Proyecto_GUI;
using ProyVentas_GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyMatricula_GUI
{
    public partial class MDIPrincipal : Form
    {
        public MDIPrincipal()
        {
            InitializeComponent();
        }

       

        private void MDIPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void MDIPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult vrpta;
            vrpta = MessageBox.Show("Seguro de salir del aplicativo?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (vrpta == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        private void MDIPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void apoderadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ApoderadoMan01 apo01 = new ApoderadoMan01();
            apo01.MdiParent = this;
            apo01.Show();
        }

        private void seccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Servicio01 seccion01 = new Servicio01();
            seccion01.MdiParent = this;
            seccion01.Show();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AlumnoMan01 alumnoMan01 = new AlumnoMan01();
            alumnoMan01.MdiParent = this;
            alumnoMan01.Show();
        }
    }
}

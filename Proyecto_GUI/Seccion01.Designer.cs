namespace Proyecto_GUI
{
    partial class Servicio01
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiltroSec = new System.Windows.Forms.TextBox();
            this.dtgDatosSec = new System.Windows.Forms.DataGridView();
            this.codSeccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codPersonal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numSalon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numGrado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRegistrosSec = new System.Windows.Forms.Label();
            this.btnCerrarSec = new System.Windows.Forms.Button();
            this.btnEliminarSec = new System.Windows.Forms.Button();
            this.btnActualizarSec = new System.Windows.Forms.Button();
            this.btnAgregarSec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatosSec)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese filtro por Seccion:";
            // 
            // txtFiltroSec
            // 
            this.txtFiltroSec.Location = new System.Drawing.Point(188, 36);
            this.txtFiltroSec.Name = "txtFiltroSec";
            this.txtFiltroSec.Size = new System.Drawing.Size(293, 23);
            this.txtFiltroSec.TabIndex = 1;
            this.txtFiltroSec.TextChanged += new System.EventHandler(this.txtFiltroSec_TextChanged);
            // 
            // dtgDatosSec
            // 
            this.dtgDatosSec.AllowUserToAddRows = false;
            this.dtgDatosSec.AllowUserToDeleteRows = false;
            this.dtgDatosSec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgDatosSec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgDatosSec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codSeccion,
            this.codPersonal,
            this.grupo,
            this.turno,
            this.numSalon,
            this.numGrado});
            this.dtgDatosSec.Location = new System.Drawing.Point(29, 91);
            this.dtgDatosSec.Name = "dtgDatosSec";
            this.dtgDatosSec.ReadOnly = true;
            this.dtgDatosSec.RowHeadersVisible = false;
            this.dtgDatosSec.RowTemplate.Height = 25;
            this.dtgDatosSec.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgDatosSec.Size = new System.Drawing.Size(918, 317);
            this.dtgDatosSec.TabIndex = 2;
            // 
            // codSeccion
            // 
            this.codSeccion.DataPropertyName = "codSeccion";
            this.codSeccion.HeaderText = "Codigo";
            this.codSeccion.Name = "codSeccion";
            this.codSeccion.ReadOnly = true;
            // 
            // codPersonal
            // 
            this.codPersonal.DataPropertyName = "codPersonal";
            this.codPersonal.HeaderText = "Codigo de Personal";
            this.codPersonal.Name = "codPersonal";
            this.codPersonal.ReadOnly = true;
            // 
            // grupo
            // 
            this.grupo.DataPropertyName = "grupo";
            this.grupo.HeaderText = "Grupo";
            this.grupo.Name = "grupo";
            this.grupo.ReadOnly = true;
            // 
            // turno
            // 
            this.turno.DataPropertyName = "turno";
            this.turno.HeaderText = "Turno";
            this.turno.Name = "turno";
            this.turno.ReadOnly = true;
            // 
            // numSalon
            // 
            this.numSalon.DataPropertyName = "numSalon";
            this.numSalon.HeaderText = "Numero de Salon";
            this.numSalon.Name = "numSalon";
            this.numSalon.ReadOnly = true;
            // 
            // numGrado
            // 
            this.numGrado.DataPropertyName = "numGrado";
            this.numGrado.HeaderText = "Numero de Grado";
            this.numGrado.Name = "numGrado";
            this.numGrado.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(810, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Registros:";
            // 
            // lblRegistrosSec
            // 
            this.lblRegistrosSec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRegistrosSec.Location = new System.Drawing.Point(874, 424);
            this.lblRegistrosSec.Name = "lblRegistrosSec";
            this.lblRegistrosSec.Size = new System.Drawing.Size(73, 23);
            this.lblRegistrosSec.TabIndex = 2;
            this.lblRegistrosSec.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCerrarSec
            // 
            this.btnCerrarSec.Location = new System.Drawing.Point(850, 457);
            this.btnCerrarSec.Name = "btnCerrarSec";
            this.btnCerrarSec.Size = new System.Drawing.Size(97, 32);
            this.btnCerrarSec.TabIndex = 4;
            this.btnCerrarSec.Text = "Cerrar";
            this.btnCerrarSec.UseVisualStyleBackColor = true;
            this.btnCerrarSec.Click += new System.EventHandler(this.btnCerrarSec_Click);
            // 
            // btnEliminarSec
            // 
            this.btnEliminarSec.Location = new System.Drawing.Point(703, 457);
            this.btnEliminarSec.Name = "btnEliminarSec";
            this.btnEliminarSec.Size = new System.Drawing.Size(97, 32);
            this.btnEliminarSec.TabIndex = 4;
            this.btnEliminarSec.Text = "Eliminar";
            this.btnEliminarSec.UseVisualStyleBackColor = true;
            this.btnEliminarSec.Click += new System.EventHandler(this.btnEliminarSec_Click);
            // 
            // btnActualizarSec
            // 
            this.btnActualizarSec.Location = new System.Drawing.Point(590, 457);
            this.btnActualizarSec.Name = "btnActualizarSec";
            this.btnActualizarSec.Size = new System.Drawing.Size(97, 32);
            this.btnActualizarSec.TabIndex = 4;
            this.btnActualizarSec.Text = "Actualizar";
            this.btnActualizarSec.UseVisualStyleBackColor = true;
            this.btnActualizarSec.Click += new System.EventHandler(this.btnActualizarSec_Click);
            // 
            // btnAgregarSec
            // 
            this.btnAgregarSec.Location = new System.Drawing.Point(474, 457);
            this.btnAgregarSec.Name = "btnAgregarSec";
            this.btnAgregarSec.Size = new System.Drawing.Size(97, 32);
            this.btnAgregarSec.TabIndex = 4;
            this.btnAgregarSec.Text = "Agregar";
            this.btnAgregarSec.UseVisualStyleBackColor = true;
            this.btnAgregarSec.Click += new System.EventHandler(this.btnAgregarSec_Click);
            // 
            // Servicio01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 510);
            this.Controls.Add(this.btnAgregarSec);
            this.Controls.Add(this.btnActualizarSec);
            this.Controls.Add(this.btnEliminarSec);
            this.Controls.Add(this.btnCerrarSec);
            this.Controls.Add(this.lblRegistrosSec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgDatosSec);
            this.Controls.Add(this.txtFiltroSec);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Servicio01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento de Secciones";
            this.Load += new System.EventHandler(this.Servicio01_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgDatosSec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtFiltroSec;
        private DataGridView dtgDatosSec;
        private Label label2;
        private Label lblRegistrosSec;
        private Button btnCerrarSec;
        private Button btnEliminarSec;
        private Button btnActualizarSec;
        private Button btnAgregarSec;
        private DataGridViewTextBoxColumn codSeccion;
        private DataGridViewTextBoxColumn codPersonal;
        private DataGridViewTextBoxColumn grupo;
        private DataGridViewTextBoxColumn turno;
        private DataGridViewTextBoxColumn numSalon;
        private DataGridViewTextBoxColumn numGrado;
    }
}
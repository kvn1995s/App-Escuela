namespace ProyVentas_GUI
{
    partial class AlumnosMan02
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
			this.Label3 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txtRepVentas = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.Label2 = new System.Windows.Forms.Label();
			this.btnGrabar = new System.Windows.Forms.Button();
			this.btnCancelar = new System.Windows.Forms.Button();
			this.chkEstado = new System.Windows.Forms.CheckBox();
			this.grpDatos = new System.Windows.Forms.GroupBox();
			this.cboApo = new System.Windows.Forms.ComboBox();
			this.cboUsuario = new System.Windows.Forms.ComboBox();
			this.cboDistrito = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.pcbFot = new System.Windows.Forms.PictureBox();
			this.btnCargar = new System.Windows.Forms.Button();
			this.txtTel = new System.Windows.Forms.TextBox();
			this.txtDirecc = new System.Windows.Forms.TextBox();
			this.dtpFN = new System.Windows.Forms.DateTimePicker();
			this.txtDNI = new System.Windows.Forms.MaskedTextBox();
			this.txtMaterno = new System.Windows.Forms.TextBox();
			this.txtPaterno = new System.Windows.Forms.TextBox();
			this.txtNombres = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.grpDatos.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pcbFot)).BeginInit();
			this.SuspendLayout();
			// 
			// Label3
			// 
			this.Label3.Location = new System.Drawing.Point(7, 228);
			this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(75, 18);
			this.Label3.TabIndex = 3;
			this.Label3.Text = "Telefono:";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(9, 126);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(75, 18);
			this.label7.TabIndex = 3;
			this.label7.Text = "DNI:";
			// 
			// txtRepVentas
			// 
			this.txtRepVentas.Location = new System.Drawing.Point(8, 30);
			this.txtRepVentas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.txtRepVentas.Name = "txtRepVentas";
			this.txtRepVentas.Size = new System.Drawing.Size(93, 21);
			this.txtRepVentas.TabIndex = 3;
			this.txtRepVentas.Text = "Nombres:";
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(306, 331);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(93, 21);
			this.label8.TabIndex = 3;
			this.label8.Text = "Estado:";
			// 
			// Label2
			// 
			this.Label2.Location = new System.Drawing.Point(6, 193);
			this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(75, 18);
			this.Label2.TabIndex = 3;
			this.Label2.Text = "Direccion";
			// 
			// btnGrabar
			// 
			this.btnGrabar.Location = new System.Drawing.Point(537, 321);
			this.btnGrabar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnGrabar.Name = "btnGrabar";
			this.btnGrabar.Size = new System.Drawing.Size(84, 28);
			this.btnGrabar.TabIndex = 9;
			this.btnGrabar.Text = "Grabar";
			this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
			// 
			// btnCancelar
			// 
			this.btnCancelar.Location = new System.Drawing.Point(636, 321);
			this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.btnCancelar.Name = "btnCancelar";
			this.btnCancelar.Size = new System.Drawing.Size(84, 28);
			this.btnCancelar.TabIndex = 10;
			this.btnCancelar.Text = "Cancelar";
			this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
			// 
			// chkEstado
			// 
			this.chkEstado.AutoSize = true;
			this.chkEstado.Location = new System.Drawing.Point(385, 330);
			this.chkEstado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.chkEstado.Name = "chkEstado";
			this.chkEstado.Size = new System.Drawing.Size(65, 19);
			this.chkEstado.TabIndex = 8;
			this.chkEstado.Text = "Activo?";
			this.chkEstado.UseVisualStyleBackColor = true;
			// 
			// grpDatos
			// 
			this.grpDatos.Controls.Add(this.cboApo);
			this.grpDatos.Controls.Add(this.cboUsuario);
			this.grpDatos.Controls.Add(this.cboDistrito);
			this.grpDatos.Controls.Add(this.label10);
			this.grpDatos.Controls.Add(this.label5);
			this.grpDatos.Controls.Add(this.pcbFot);
			this.grpDatos.Controls.Add(this.btnCargar);
			this.grpDatos.Controls.Add(this.txtTel);
			this.grpDatos.Controls.Add(this.txtDirecc);
			this.grpDatos.Controls.Add(this.dtpFN);
			this.grpDatos.Controls.Add(this.txtDNI);
			this.grpDatos.Controls.Add(this.txtMaterno);
			this.grpDatos.Controls.Add(this.txtPaterno);
			this.grpDatos.Controls.Add(this.txtNombres);
			this.grpDatos.Controls.Add(this.label4);
			this.grpDatos.Controls.Add(this.label9);
			this.grpDatos.Controls.Add(this.label6);
			this.grpDatos.Controls.Add(this.label1);
			this.grpDatos.Controls.Add(this.chkEstado);
			this.grpDatos.Controls.Add(this.btnCancelar);
			this.grpDatos.Controls.Add(this.btnGrabar);
			this.grpDatos.Controls.Add(this.Label2);
			this.grpDatos.Controls.Add(this.label8);
			this.grpDatos.Controls.Add(this.txtRepVentas);
			this.grpDatos.Controls.Add(this.label7);
			this.grpDatos.Controls.Add(this.Label3);
			this.grpDatos.Location = new System.Drawing.Point(13, 12);
			this.grpDatos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.grpDatos.Name = "grpDatos";
			this.grpDatos.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.grpDatos.Size = new System.Drawing.Size(729, 363);
			this.grpDatos.TabIndex = 0;
			this.grpDatos.TabStop = false;
			this.grpDatos.Text = "Datos";
			// 
			// cboApo
			// 
			this.cboApo.FormattingEnabled = true;
			this.cboApo.Location = new System.Drawing.Point(111, 331);
			this.cboApo.Name = "cboApo";
			this.cboApo.Size = new System.Drawing.Size(121, 23);
			this.cboApo.TabIndex = 50;
			// 
			// cboUsuario
			// 
			this.cboUsuario.FormattingEnabled = true;
			this.cboUsuario.Location = new System.Drawing.Point(111, 296);
			this.cboUsuario.Name = "cboUsuario";
			this.cboUsuario.Size = new System.Drawing.Size(121, 23);
			this.cboUsuario.TabIndex = 49;
			// 
			// cboDistrito
			// 
			this.cboDistrito.FormattingEnabled = true;
			this.cboDistrito.Location = new System.Drawing.Point(111, 261);
			this.cboDistrito.Name = "cboDistrito";
			this.cboDistrito.Size = new System.Drawing.Size(121, 23);
			this.cboDistrito.TabIndex = 48;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(7, 264);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(76, 15);
			this.label10.TabIndex = 47;
			this.label10.Text = "Cod. Distrito:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(4, 334);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(97, 15);
			this.label5.TabIndex = 45;
			this.label5.Text = "Cod. Apoderado:";
			// 
			// pcbFot
			// 
			this.pcbFot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pcbFot.Location = new System.Drawing.Point(525, 66);
			this.pcbFot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pcbFot.Name = "pcbFot";
			this.pcbFot.Size = new System.Drawing.Size(184, 147);
			this.pcbFot.TabIndex = 44;
			this.pcbFot.TabStop = false;
			// 
			// btnCargar
			// 
			this.btnCargar.Location = new System.Drawing.Point(428, 123);
			this.btnCargar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.btnCargar.Name = "btnCargar";
			this.btnCargar.Size = new System.Drawing.Size(91, 26);
			this.btnCargar.TabIndex = 43;
			this.btnCargar.Text = "Cargar Foto:";
			this.btnCargar.UseVisualStyleBackColor = true;
			this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
			// 
			// txtTel
			// 
			this.txtTel.Location = new System.Drawing.Point(111, 225);
			this.txtTel.MaxLength = 9;
			this.txtTel.Name = "txtTel";
			this.txtTel.Size = new System.Drawing.Size(93, 23);
			this.txtTel.TabIndex = 41;
			this.txtTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// txtDirecc
			// 
			this.txtDirecc.Location = new System.Drawing.Point(111, 190);
			this.txtDirecc.MaxLength = 70;
			this.txtDirecc.Name = "txtDirecc";
			this.txtDirecc.Size = new System.Drawing.Size(227, 23);
			this.txtDirecc.TabIndex = 40;
			// 
			// dtpFN
			// 
			this.dtpFN.Location = new System.Drawing.Point(111, 154);
			this.dtpFN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.dtpFN.Name = "dtpFN";
			this.dtpFN.Size = new System.Drawing.Size(267, 23);
			this.dtpFN.TabIndex = 39;
			// 
			// txtDNI
			// 
			this.txtDNI.Location = new System.Drawing.Point(111, 123);
			this.txtDNI.Mask = "99999999";
			this.txtDNI.Name = "txtDNI";
			this.txtDNI.Size = new System.Drawing.Size(100, 23);
			this.txtDNI.TabIndex = 38;
			// 
			// txtMaterno
			// 
			this.txtMaterno.Location = new System.Drawing.Point(111, 91);
			this.txtMaterno.MaxLength = 40;
			this.txtMaterno.Name = "txtMaterno";
			this.txtMaterno.Size = new System.Drawing.Size(170, 23);
			this.txtMaterno.TabIndex = 37;
			// 
			// txtPaterno
			// 
			this.txtPaterno.Location = new System.Drawing.Point(111, 62);
			this.txtPaterno.MaxLength = 40;
			this.txtPaterno.Name = "txtPaterno";
			this.txtPaterno.Size = new System.Drawing.Size(170, 23);
			this.txtPaterno.TabIndex = 36;
			// 
			// txtNombres
			// 
			this.txtNombres.Location = new System.Drawing.Point(111, 27);
			this.txtNombres.MaxLength = 50;
			this.txtNombres.Name = "txtNombres";
			this.txtNombres.Size = new System.Drawing.Size(170, 23);
			this.txtNombres.TabIndex = 35;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(4, 301);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(78, 15);
			this.label4.TabIndex = 34;
			this.label4.Text = "Cod. Usuario:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(6, 160);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(81, 15);
			this.label9.TabIndex = 21;
			this.label9.Text = "Fecha de Nac:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(7, 94);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(102, 15);
			this.label6.TabIndex = 19;
			this.label6.Text = "Apellido Materno:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 62);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 15);
			this.label1.TabIndex = 20;
			this.label1.Text = "Apellido Paterno:";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// AlumnosMan02
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(747, 389);
			this.Controls.Add(this.grpDatos);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AlumnosMan02";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Insertar Alumno";
			this.Load += new System.EventHandler(this.ProveedorMan02_Load);
			this.grpDatos.ResumeLayout(false);
			this.grpDatos.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pcbFot)).EndInit();
			this.ResumeLayout(false);

        }

		#endregion
		internal Label Label3;
		internal Label label7;
		internal Label txtRepVentas;
		internal Label label8;
		internal Label Label2;
		internal Button btnGrabar;
		internal Button btnCancelar;
		private CheckBox chkEstado;
		internal GroupBox grpDatos;
		private Label label1;
		private Label label6;
		private Label label9;
		private Label label4;
		private TextBox txtNombres;
		private TextBox txtPaterno;
		private TextBox txtMaterno;
		private MaskedTextBox txtDNI;
		private DateTimePicker dtpFN;
		private TextBox txtDirecc;
		private TextBox txtTel;
		private Button btnCargar;
		private PictureBox pcbFot;
		private Label label5;
		private ComboBox cboApo;
		private ComboBox cboUsuario;
		private ComboBox cboDistrito;
		private Label label10;
		private OpenFileDialog openFileDialog1;
	}
}
namespace Proyecto_GUI
{
    partial class Seccion02
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
            this.cboPersonal = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboGradoSeccion = new System.Windows.Forms.ComboBox();
            this.btnGrabarSeccion = new System.Windows.Forms.Button();
            this.btnCancelarSeccion = new System.Windows.Forms.Button();
            this.txtGradoSeccion = new System.Windows.Forms.TextBox();
            this.grpTurno = new System.Windows.Forms.GroupBox();
            this.rbtnTarde = new System.Windows.Forms.RadioButton();
            this.rbtnManana = new System.Windows.Forms.RadioButton();
            this.mskNumSalon = new System.Windows.Forms.MaskedTextBox();
            this.grpTurno.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personal:";
            // 
            // cboPersonal
            // 
            this.cboPersonal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPersonal.FormattingEnabled = true;
            this.cboPersonal.Location = new System.Drawing.Point(189, 54);
            this.cboPersonal.Name = "cboPersonal";
            this.cboPersonal.Size = new System.Drawing.Size(184, 23);
            this.cboPersonal.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Grupo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Turno:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 15);
            this.label4.TabIndex = 2;
            this.label4.Text = "Número de salón:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(79, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Grado:";
            // 
            // cboGradoSeccion
            // 
            this.cboGradoSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGradoSeccion.FormattingEnabled = true;
            this.cboGradoSeccion.Location = new System.Drawing.Point(184, 218);
            this.cboGradoSeccion.Name = "cboGradoSeccion";
            this.cboGradoSeccion.Size = new System.Drawing.Size(184, 23);
            this.cboGradoSeccion.TabIndex = 1;
            // 
            // btnGrabarSeccion
            // 
            this.btnGrabarSeccion.Location = new System.Drawing.Point(105, 346);
            this.btnGrabarSeccion.Name = "btnGrabarSeccion";
            this.btnGrabarSeccion.Size = new System.Drawing.Size(97, 32);
            this.btnGrabarSeccion.TabIndex = 4;
            this.btnGrabarSeccion.Text = "Grabar";
            this.btnGrabarSeccion.UseVisualStyleBackColor = true;
            this.btnGrabarSeccion.Click += new System.EventHandler(this.btnGrabarSeccion_Click);
            // 
            // btnCancelarSeccion
            // 
            this.btnCancelarSeccion.Location = new System.Drawing.Point(246, 346);
            this.btnCancelarSeccion.Name = "btnCancelarSeccion";
            this.btnCancelarSeccion.Size = new System.Drawing.Size(97, 32);
            this.btnCancelarSeccion.TabIndex = 4;
            this.btnCancelarSeccion.Text = "Cancelar";
            this.btnCancelarSeccion.UseVisualStyleBackColor = true;
            // 
            // txtGradoSeccion
            // 
            this.txtGradoSeccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGradoSeccion.Location = new System.Drawing.Point(189, 113);
            this.txtGradoSeccion.MaxLength = 1;
            this.txtGradoSeccion.Name = "txtGradoSeccion";
            this.txtGradoSeccion.Size = new System.Drawing.Size(36, 23);
            this.txtGradoSeccion.TabIndex = 1;
            this.txtGradoSeccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpTurno
            // 
            this.grpTurno.Controls.Add(this.rbtnTarde);
            this.grpTurno.Controls.Add(this.rbtnManana);
            this.grpTurno.Location = new System.Drawing.Point(174, 267);
            this.grpTurno.Name = "grpTurno";
            this.grpTurno.Size = new System.Drawing.Size(214, 50);
            this.grpTurno.TabIndex = 5;
            this.grpTurno.TabStop = false;
            // 
            // rbtnTarde
            // 
            this.rbtnTarde.AutoSize = true;
            this.rbtnTarde.Location = new System.Drawing.Point(131, 23);
            this.rbtnTarde.Name = "rbtnTarde";
            this.rbtnTarde.Size = new System.Drawing.Size(53, 19);
            this.rbtnTarde.TabIndex = 0;
            this.rbtnTarde.TabStop = true;
            this.rbtnTarde.Text = "Tarde";
            this.rbtnTarde.UseVisualStyleBackColor = true;
            // 
            // rbtnManana
            // 
            this.rbtnManana.AutoSize = true;
            this.rbtnManana.Location = new System.Drawing.Point(10, 23);
            this.rbtnManana.Name = "rbtnManana";
            this.rbtnManana.Size = new System.Drawing.Size(68, 19);
            this.rbtnManana.TabIndex = 0;
            this.rbtnManana.TabStop = true;
            this.rbtnManana.Text = "Mañana";
            this.rbtnManana.UseVisualStyleBackColor = true;
            // 
            // mskNumSalon
            // 
            this.mskNumSalon.Location = new System.Drawing.Point(189, 165);
            this.mskNumSalon.Mask = "99";
            this.mskNumSalon.Name = "mskNumSalon";
            this.mskNumSalon.Size = new System.Drawing.Size(24, 23);
            this.mskNumSalon.TabIndex = 6;
            this.mskNumSalon.Validating += new System.ComponentModel.CancelEventHandler(this.mskNumSalon_Validating);
            // 
            // Servicio02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 411);
            this.Controls.Add(this.mskNumSalon);
            this.Controls.Add(this.grpTurno);
            this.Controls.Add(this.txtGradoSeccion);
            this.Controls.Add(this.btnCancelarSeccion);
            this.Controls.Add(this.btnGrabarSeccion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboGradoSeccion);
            this.Controls.Add(this.cboPersonal);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Servicio02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Servicio";
            this.Load += new System.EventHandler(this.Servicio02_Load);
            this.grpTurno.ResumeLayout(false);
            this.grpTurno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox cboPersonal;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private ComboBox cboGradoSeccion;
        private Button btnGrabarSeccion;
        private Button btnCancelarSeccion;
        private TextBox txtGradoSeccion;
        private GroupBox grpTurno;
        private RadioButton rbtnTarde;
        private RadioButton rbtnManana;
        private MaskedTextBox mskNumSalon;
    }
}
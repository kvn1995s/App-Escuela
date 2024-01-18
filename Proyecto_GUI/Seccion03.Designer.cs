namespace Proyecto_GUI
{
    partial class Seccion03
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
            this.mskNumSalon = new System.Windows.Forms.MaskedTextBox();
            this.grpTurno = new System.Windows.Forms.GroupBox();
            this.rbtnTarde = new System.Windows.Forms.RadioButton();
            this.rbtnManana = new System.Windows.Forms.RadioButton();
            this.txtGrupoSeccion = new System.Windows.Forms.TextBox();
            this.btnCancelarSeccion = new System.Windows.Forms.Button();
            this.btnGrabarSeccion = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboGradoSeccion = new System.Windows.Forms.ComboBox();
            this.cboPersonal = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCodSeccion = new System.Windows.Forms.Label();
            this.grpTurno.SuspendLayout();
            this.SuspendLayout();
            // 
            // mskNumSalon
            // 
            this.mskNumSalon.Location = new System.Drawing.Point(203, 205);
            this.mskNumSalon.Mask = "99";
            this.mskNumSalon.Name = "mskNumSalon";
            this.mskNumSalon.Size = new System.Drawing.Size(24, 23);
            this.mskNumSalon.TabIndex = 18;
            // 
            // grpTurno
            // 
            this.grpTurno.Controls.Add(this.rbtnTarde);
            this.grpTurno.Controls.Add(this.rbtnManana);
            this.grpTurno.Location = new System.Drawing.Point(188, 307);
            this.grpTurno.Name = "grpTurno";
            this.grpTurno.Size = new System.Drawing.Size(214, 50);
            this.grpTurno.TabIndex = 17;
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
            // txtGrupoSeccion
            // 
            this.txtGrupoSeccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGrupoSeccion.Location = new System.Drawing.Point(203, 153);
            this.txtGrupoSeccion.MaxLength = 1;
            this.txtGrupoSeccion.Name = "txtGrupoSeccion";
            this.txtGrupoSeccion.Size = new System.Drawing.Size(36, 23);
            this.txtGrupoSeccion.TabIndex = 8;
            this.txtGrupoSeccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCancelarSeccion
            // 
            this.btnCancelarSeccion.Location = new System.Drawing.Point(260, 386);
            this.btnCancelarSeccion.Name = "btnCancelarSeccion";
            this.btnCancelarSeccion.Size = new System.Drawing.Size(97, 32);
            this.btnCancelarSeccion.TabIndex = 15;
            this.btnCancelarSeccion.Text = "Cancelar";
            this.btnCancelarSeccion.UseVisualStyleBackColor = true;
            // 
            // btnGrabarSeccion
            // 
            this.btnGrabarSeccion.Location = new System.Drawing.Point(119, 386);
            this.btnGrabarSeccion.Name = "btnGrabarSeccion";
            this.btnGrabarSeccion.Size = new System.Drawing.Size(97, 32);
            this.btnGrabarSeccion.TabIndex = 16;
            this.btnGrabarSeccion.Text = "Grabar";
            this.btnGrabarSeccion.UseVisualStyleBackColor = true;
            this.btnGrabarSeccion.Click += new System.EventHandler(this.btnGrabarSeccion_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Grado:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Número de salón:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Turno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Grupo:";
            // 
            // cboGradoSeccion
            // 
            this.cboGradoSeccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGradoSeccion.FormattingEnabled = true;
            this.cboGradoSeccion.Location = new System.Drawing.Point(198, 258);
            this.cboGradoSeccion.Name = "cboGradoSeccion";
            this.cboGradoSeccion.Size = new System.Drawing.Size(184, 23);
            this.cboGradoSeccion.TabIndex = 9;
            // 
            // cboPersonal
            // 
            this.cboPersonal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPersonal.FormattingEnabled = true;
            this.cboPersonal.Location = new System.Drawing.Point(203, 94);
            this.cboPersonal.Name = "cboPersonal";
            this.cboPersonal.Size = new System.Drawing.Size(184, 23);
            this.cboPersonal.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Personal:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Personal:";
            // 
            // lblCodSeccion
            // 
            this.lblCodSeccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCodSeccion.Location = new System.Drawing.Point(198, 39);
            this.lblCodSeccion.Name = "lblCodSeccion";
            this.lblCodSeccion.Size = new System.Drawing.Size(70, 23);
            this.lblCodSeccion.TabIndex = 0;
            // 
            // Seccion03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 477);
            this.Controls.Add(this.lblCodSeccion);
            this.Controls.Add(this.mskNumSalon);
            this.Controls.Add(this.grpTurno);
            this.Controls.Add(this.txtGrupoSeccion);
            this.Controls.Add(this.btnCancelarSeccion);
            this.Controls.Add(this.btnGrabarSeccion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboGradoSeccion);
            this.Controls.Add(this.cboPersonal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Seccion03";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seccion03";
            this.Load += new System.EventHandler(this.Seccion03_Load);
            this.grpTurno.ResumeLayout(false);
            this.grpTurno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaskedTextBox mskNumSalon;
        private GroupBox grpTurno;
        private RadioButton rbtnTarde;
        private RadioButton rbtnManana;
        private TextBox txtGrupoSeccion;
        private Button btnCancelarSeccion;
        private Button btnGrabarSeccion;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cboGradoSeccion;
        private ComboBox cboPersonal;
        private Label label1;
        private Label label6;
        private Label lblCodSeccion;
    }
}
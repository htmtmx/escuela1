namespace escuela1.vista
{
    partial class frm_crud_alumno
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApaterno = new System.Windows.Forms.TextBox();
            this.txtAmaterno = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtFechaRegistro = new System.Windows.Forms.TextBox();
            this.btnAction = new System.Windows.Forms.Button();
            this.cboEstatus = new System.Windows.Forms.CheckBox();
            this.pickNacimiento = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(50, 42);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(129, 17);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "<Accion a realizar>";
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Location = new System.Drawing.Point(118, 272);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(61, 17);
            this.lblRegistro.TabIndex = 2;
            this.lblRegistro.Text = "Registro";
            this.lblRegistro.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha nacimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(128, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Correo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Segundo Apellido";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Primer Apellido";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(121, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Nombre";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(114, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Matricula";
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(218, 82);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(277, 22);
            this.txtMatricula.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(218, 114);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(277, 22);
            this.txtNombre.TabIndex = 10;
            // 
            // txtApaterno
            // 
            this.txtApaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApaterno.Location = new System.Drawing.Point(218, 147);
            this.txtApaterno.Name = "txtApaterno";
            this.txtApaterno.Size = new System.Drawing.Size(277, 22);
            this.txtApaterno.TabIndex = 11;
            // 
            // txtAmaterno
            // 
            this.txtAmaterno.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAmaterno.Location = new System.Drawing.Point(218, 178);
            this.txtAmaterno.Name = "txtAmaterno";
            this.txtAmaterno.Size = new System.Drawing.Size(277, 22);
            this.txtAmaterno.TabIndex = 12;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(218, 206);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(277, 22);
            this.txtCorreo.TabIndex = 13;
            // 
            // txtFechaRegistro
            // 
            this.txtFechaRegistro.Location = new System.Drawing.Point(218, 272);
            this.txtFechaRegistro.Name = "txtFechaRegistro";
            this.txtFechaRegistro.ReadOnly = true;
            this.txtFechaRegistro.Size = new System.Drawing.Size(277, 22);
            this.txtFechaRegistro.TabIndex = 15;
            this.txtFechaRegistro.Visible = false;
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(387, 372);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(108, 34);
            this.btnAction.TabIndex = 16;
            this.btnAction.Text = "<action>";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // cboEstatus
            // 
            this.cboEstatus.AutoSize = true;
            this.cboEstatus.Checked = true;
            this.cboEstatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cboEstatus.Location = new System.Drawing.Point(218, 314);
            this.cboEstatus.Name = "cboEstatus";
            this.cboEstatus.Size = new System.Drawing.Size(68, 21);
            this.cboEstatus.TabIndex = 17;
            this.cboEstatus.Text = "Activo";
            this.cboEstatus.UseVisualStyleBackColor = true;
            // 
            // pickNacimiento
            // 
            this.pickNacimiento.Location = new System.Drawing.Point(218, 241);
            this.pickNacimiento.Name = "pickNacimiento";
            this.pickNacimiento.Size = new System.Drawing.Size(277, 22);
            this.pickNacimiento.TabIndex = 18;
            // 
            // frm_crud_alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 588);
            this.Controls.Add(this.pickNacimiento);
            this.Controls.Add(this.cboEstatus);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.txtFechaRegistro);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtAmaterno);
            this.Controls.Add(this.txtApaterno);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frm_crud_alumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frm_crud_alumno";
            this.Load += new System.EventHandler(this.frm_crud_alumno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApaterno;
        private System.Windows.Forms.TextBox txtAmaterno;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtFechaRegistro;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.CheckBox cboEstatus;
        private System.Windows.Forms.DateTimePicker pickNacimiento;
    }
}